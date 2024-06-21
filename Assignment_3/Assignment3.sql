USE Northwind
GO

/*
1.      List all cities that have both Employees and Customers.
*/

SELECT DISTINCT City
FROM Customers
WHERE City IN (SELECT DISTINCT City FROM Employees)


/*
2.      List all cities that have Customers but no Employee.
a.      Use sub-query
b.      Do not use sub-query
*/

SELECT DISTINCT City
FROM Customers
WHERE City NOT IN (SELECT DISTINCT City FROM Employees)

SELECT DISTINCT C.CITY
FROM Customers C
LEFT JOIN Employees E
ON C.CITY = E.CITY
WHERE E.CITY IS NULL


/*
3.      List all products and their total order quantities throughout all orders.
*/


SELECT P.ProductID, SUM(ISNULL(OD.Quantity, 0)) AS 'TotalOrderQuantities'
FROM Products P
LEFT JOIN [Order Details] OD
ON P.ProductID = OD.ProductID
GROUP BY P.ProductID


/*
4.      List all Customer Cities and total products ordered by that city.
*/

SELECT C.City, COUNT(ISNULL(OD.OrderID, 0)) AS 'TotalProducts'
FROM Customers C
JOIN Orders O
ON C.CustomerID = O.CustomerID
JOIN [Order Details] OD
ON OD.OrderID = O.OrderID
GROUP BY C.City


/*
5.      List all Customer Cities that have at least two customers.
a.      Use union
b.      Use sub-query and no union
*/

SELECT DISTINCT City
FROM Customers
WHERE City NOT IN (
SELECT DISTINCT City
FROM Customers
GROUP BY City
HAVING COUNT(CustomerID) <= 1)


/*
6.      List all Customer Cities that have ordered at least two different kinds of products.
*/

SELECT C.City
FROM Customers C
JOIN Orders O
ON C.CustomerID = O.CustomerID
JOIN [Order Details] OD
ON OD.OrderID = O.OrderID
GROUP BY C.City
HAVING COUNT(DISTINCT OD.ProductID) >= 2


/*
7.      List all Customers who have ordered products, but have the ‘ship city’ on the order different from their own customer cities.
*/

SELECT DISTINCT C.CustomerID, C.City, O.ShipCity
FROM Customers C
JOIN Orders O ON C.CustomerID = O.CustomerID
WHERE C.City != O.ShipCity

/*
8.      List 5 most popular products, their average price, and the customer city that ordered most quantity of it.
*/


SELECT TOP 5 P.ProductID, AVG(OD.UnitPrice)
FROM Orders O
JOIN [Order Details] OD
ON O.OrderID = OD.OrderID
JOIN Products P
ON P.ProductID = OD.ProductID
GROUP BY P.ProductID
ORDER BY SUM(OD.Quantity) DESC


/*
9.      List all cities that have never ordered something but we have employees there.
a.      Use sub-query
b.      Do not use sub-query
*/

SELECT DISTINCT E.City
FROM Employees E
WHERE E.City NOT IN (
    SELECT DISTINCT O.ShipCity
    FROM Orders O
)

SELECT DISTINCT E.City
FROM Employees E
LEFT JOIN Orders O ON E.City = O.ShipCity
WHERE O.ShipCity IS NULL;

/*
10.  List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, and also the city of most total quantity of products ordered from. (tip: join  sub-query)
*/

WITH MostOrdersSoldByCity AS (
    SELECT E.City, COUNT(O.OrderID) AS OrdersSold
    FROM Employees E
    JOIN Orders O ON E.EmployeeID = O.EmployeeID
    GROUP BY E.City
), -- city in which emp has sold most orders.
MostQuantityOrderedByCity AS (
    SELECT C.City, SUM(OD.Quantity) AS TotalQuantityOrdered
    FROM Customers C
    JOIN Orders O ON c.CustomerID = O.CustomerID
    JOIN [Order Details] OD ON O.OrderID = OD.OrderID
    GROUP BY C.City
), -- city with max total quantity ordered
MaxOrders AS (
    SELECT City, OrdersSold
    FROM MostOrdersSoldByCity
    WHERE OrdersSold = (SELECT MAX(OrdersSold) FROM MostOrdersSoldByCity)
), -- getting max orders's city
MaxQuantity AS (
    SELECT City, TotalQuantityOrdered
    FROM MostQuantityOrderedByCity
    WHERE TotalQuantityOrdered = (SELECT MAX(TotalQuantityOrdered) FROM MostQuantityOrderedByCity)
) -- getting max quantity city
SELECT TOP 1 MO.City
FROM MaxOrders MO
JOIN MaxQuantity MQ ON MO.City = MQ.City -- inner join and getting top.


/*
11. How do you remove the duplicates record of a table?

Ans. Suppose, a table "duplicate_table" has 3 cols with first as a primary key. 
Intuition: Partition will group by all the duplicate columns [col1, col2, col3] and assign rownum in increments. Thus, rownum > 1 are duplicate rows.

WITH RankedRecords AS (
    SELECT *,
           ROW_NUMBER() OVER (PARTITION BY COL1,COL2, COL3 ORDER BY COL1) AS ROWNUM
    FROM duplicate_table
)
DELETE FROM RankedRecords
WHERE ROWNUM > 1;
*/
