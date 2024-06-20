/* Adv Works 2019 */

USE AdventureWorks2019
GO

/*1. How many products can you find in the Production.Product table? */
SELECT COUNT(ProductID) AS 'COUNT'
FROM Production.Product

/*2.      Write a query that retrieves the number of products in the Production.Product table that are included in a subcategory. The rows that have NULL in column ProductSubcategoryID are considered to not be a part of any subcategory.*/
SELECT COUNT(ProductID) AS 'COUNT'
FROM Production.Product 
WHERE ProductSubcategoryID IS NOT NULL

/*3.      How many Products reside in each SubCategory? Write a query to display the results with the following titles.

ProductSubcategoryID CountedProducts

-------------------- ---------------*/
SELECT ProductSubcategoryID AS 'ProductSubcategoryID', COUNT(ProductID) AS 'CountedProducts'
FROM Production.Product
GROUP BY ProductSubcategoryID

/*4.      How many products that do not have a product subcategory.*/

SELECT COUNT(ProductID) AS 'COUNT'
FROM Production.Product 
WHERE ProductSubcategoryID IS NULL

/*5.      Write a query to list the sum of products quantity in the Production.ProductInventory table.
*/

SELECT SUM(Quantity) AS 'SumOfQuantity'
FROM Production.ProductInventory


/*
6.    Write a query to list the sum of products in the Production.ProductInventory table and LocationID set to 40 and limit the result to include just summarized quantities less than 100.

              ProductID    TheSum

              -----------        ----------
			  */
SELECT ProductID, SUM(Quantity) AS 'TheSum'
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY ProductID
HAVING SUM(Quantity) < 100

/*
7.    Write a query to list the sum of products with the shelf information in the Production.ProductInventory table and LocationID set to 40 and limit the result to include just summarized quantities less than 100

    Shelf      ProductID    TheSum

    ----------   -----------        -----------
*/

SELECT Shelf, ProductID, SUM(Quantity) AS 'TheSum'
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY Shelf, ProductID
HAVING SUM(Quantity) < 100

/*
8. Write the query to list the average quantity for products where column LocationID has the value of 10 from the table Production.ProductInventory table.
*/

SELECT AVG(Quantity) AS 'TheAvg'
FROM Production.ProductInventory
WHERE LocationID = 10


/*
9.    Write query  to see the average quantity  of  products by shelf  from the table Production.ProductInventory

    ProductID   Shelf      TheAvg

    ----------- ---------- -----------

*/
SELECT ProductID ,Shelf, AVG(Quantity) AS 'TheAvg'
FROM Production.ProductInventory
GROUP BY ProductID, Shelf

/*
10.  Write query  to see the average quantity  of  products by shelf excluding rows that has the value of N/A in the column Shelf from the table Production.ProductInventory

    ProductID   Shelf      TheAvg

    ----------- ---------- -----------

*/

SELECT ProductID ,Shelf, AVG(Quantity) AS 'TheAvg'
FROM Production.ProductInventory
WHERE Shelf != 'N/A'
GROUP BY ProductID, Shelf



/*
11.  List the members (rows) and average list price in the Production.Product table. This should be grouped independently over the Color and the Class column. Exclude the rows where Color or Class are null.

    Color                        Class              TheCount          AvgPrice

    -------------- - -----    -----------            ---------------------

*/

SELECT Color, Class, COUNT(ProductID) AS 'TheCount', AVG(ListPrice) AS 'AvgPrice'
FROM Production.Product
GROUP BY Color, Class
HAVING Color IS NOT NULL AND Class IS NOT NULL

/* JOINS */

/*

12.   Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables. Join them and produce a result set similar to the following.

    Country                        Province

    ---------                          ----------------------
*/

SELECT PC.NAME AS 'Country', PS.Name AS 'Province'
FROM Person.CountryRegion PC JOIN Person.StateProvince PS ON PC.CountryRegionCode = PS.CountryRegionCode 


/*
13.  Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables and list the countries filter them by Germany and Canada. Join them and produce a result set similar to the following.
    Country                        Province

    ---------                          ----------------------
*/
SELECT PC.NAME AS 'Country', PS.Name AS 'Province'
FROM Person.CountryRegion PC JOIN Person.StateProvince PS ON PC.CountryRegionCode = PS.CountryRegionCode 
WHERE PC.NAME IN ('Germany', 'Canada')


/* Northwind database */


USE Northwind
GO

/*
14.  List all Products that has been sold at least once in last 27 years.
*/

SELECT DISTINCT P.ProductName
FROM Products P
JOIN [Order Details] OD ON P.ProductID = OD.ProductID
JOIN Orders O ON OD.OrderID = O.OrderID
WHERE O.OrderDate >= DATEADD(year, -27, GETDATE())

/*
15.  List top 5 locations (Zip Code) where the products sold most.
*/

SELECT TOP 5 ShipPostalCode
FROM Orders
GROUP BY ShipPostalCode
HAVING ShipPostalCode IS NOT NULL
ORDER BY COUNT(OrderID) DESC

/*
16.  List top 5 locations (Zip Code) where the products sold most in last 27 years.
*/
SELECT TOP 5 O.ShipPostalCode
FROM Products P
JOIN [Order Details] OD ON P.ProductID = OD.ProductID
JOIN Orders O ON OD.OrderID = O.OrderID
WHERE O.OrderDate >= DATEADD(year, -27, GETDATE())
GROUP BY O.ShipPostalCode
HAVING O.ShipPostalCode IS NOT NULL
ORDER BY COUNT(O.OrderID) DESC

/*17.   List all city names and number of customers in that city.     */

SELECT City, COUNT(CustomerID) AS 'NUM_OF_CUSTOMERS'
FROM Customers
GROUP BY City

/*
18.  List city names which have more than 2 customers, and number of customers in that city
*/

SELECT City, COUNT(CustomerID) AS 'NUM_OF_CUSTOMERS'
FROM Customers
GROUP BY City
HAVING COUNT(CustomerID) > 2

/*
19.  List the names of customers who placed orders after 1/1/98 with order date.
*/

SELECT DISTINCT C.ContactName
FROM Customers C
JOIN ORDERS O
ON C.CustomerID = O.CustomerID
WHERE O.OrderDate >= '1998-01-01'

/*
20.  List the names of all customers with most recent order dates
*/

SELECT C.ContactName
FROM ORDERS O
JOIN Customers C
ON O.CustomerID = C.CustomerID
WHERE O.OrderDate = '1998-05-06'


/*
	21.  Display the names of all customers  along with the  count of products they bought
*/
SELECT C.ContactName, COUNT(*) AS 'COUNT'
FROM Customers C
JOIN Orders O
ON C.CustomerID = O.CustomerID
GROUP BY C.ContactName 


/*
22.  Display the customer ids who bought more than 100 Products with count of products.
*/

SELECT C.CustomerID, COUNT(*) AS 'COUNT'
FROM Customers C
JOIN Orders O
ON C.CustomerID = O.CustomerID
GROUP BY C.CustomerID 
HAVING COUNT(*) > 100

/*
23.  List all of the possible ways that suppliers can ship their products. Display the results as below

    Supplier Company Name                Shipping Company Name

    ---------------------------------            ----------------------------------
*/
SELECT DISTINCT S.CompanyName AS SupplierCompanyName, SH.CompanyName AS ShippingCompanyName
FROM Suppliers S
JOIN Products P ON S.SupplierID = P.SupplierID
JOIN [Order Details] OD ON P.ProductID = OD.ProductID
JOIN Orders O ON OD.OrderID = O.OrderID
JOIN Shippers SH ON O.ShipVia = SH.ShipperID


/*
24.  Display the products order each day. Show Order date and Product Name.

*/
SELECT O.OrderDate, P.ProductName
FROM Orders O
JOIN [Order Details] OD ON O.OrderID = OD.OrderID
JOIN Products P ON OD.ProductID = P.ProductID
ORDER BY O.OrderDate, P.ProductName;


/*
25.  Displays pairs of employees who have the same job title.
*/
SELECT E1.EmployeeID, E2.EmployeeID
FROM Employees E1
JOIN Employees E2
ON E1.Title = E2.Title
WHERE E1.EmployeeID != E2.EmployeeID


/*
26.  Display all the Managers who have more than 2 employees reporting to them.
*/
SELECT M.EmployeeID
FROM Employees E
JOIN Employees M
ON E.ReportsTo = M.EmployeeID
GROUP BY M.EmployeeID
HAVING COUNT(E.EmployeeID) > 2


/*
27.  Display the customers and suppliers by city. The results should have the following columns
City

Name

Contact Name,

Type (Customer or Supplier)
*/
SELECT C.City, C.CompanyName AS Name, C.ContactName, 'Customer' AS Type
FROM Customers C
UNION
SELECT S.City, S.CompanyName AS Name, S.ContactName, 'Supplier' AS Type
FROM Suppliers S