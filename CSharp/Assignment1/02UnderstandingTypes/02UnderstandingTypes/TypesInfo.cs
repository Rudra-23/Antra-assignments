using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _02UnderstandingTypes
{
    public class TypesInfo
    {
        public void GetInfo()
        {
            Console.WriteLine($"The size of sbytes in bytes: " + sizeof(sbyte) + ", min value: " + sbyte.MinValue + ", max value: " + sbyte.MaxValue);
            Console.WriteLine($"The size of byte in bytes: " + sizeof(byte) + ", min value: " + byte.MinValue + ", max value: " + byte.MaxValue);
            Console.WriteLine($"The size of short in bytes: " + sizeof(short) + ", min value: " + short.MinValue + ", max value: " + short.MaxValue);
            Console.WriteLine($"The size of ushort in bytes: " + sizeof(ushort) + ", min value: " + ushort.MinValue + ", max value: " + ushort.MaxValue);
            Console.WriteLine($"The size of int in bytes: " + sizeof(int) + ", min value: " + int.MinValue + ", max value: " + int.MaxValue);
            Console.WriteLine($"The size of uint in bytes: " + sizeof(uint) + ", min value: " + uint.MinValue + ", max value: " + uint.MaxValue);
            Console.WriteLine($"The size of float in bytes: " + sizeof(float) + ", min value: " + float.MinValue + ", max value: " + float.MaxValue);
            Console.WriteLine($"The size of long in bytes: " + sizeof(long) + ", min value: " + long.MinValue + ", max value: " + long.MaxValue);
            Console.WriteLine($"The size of ulong in bytes: " + sizeof(ulong) + ", min value: " + ulong.MinValue + ", max value: " + ulong.MaxValue);
            Console.WriteLine($"The size of double in bytes: " + sizeof(double) + ", min value: " + double.MinValue + ", max value: " + double.MaxValue);
            Console.WriteLine($"The size of decimal in bytes: " + sizeof(decimal) + ", min value: " + decimal.MinValue + ", max value: " + decimal.MaxValue);
        }

        public string ConvertCenturiesToTime(int century)
        {
            int years = century * 100;
            int days = years * 365 + (years / 100) *24 + years / 400;
            int hours = days * 24;
            long minutes = hours * 60;
            long seconds = minutes * 60;
            long milliseconds = seconds * 1000;
            ulong microseconds = (ulong) milliseconds * 1000;
            ulong nanoseconds = (ulong) microseconds * 1000;

            return $"{century} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds";
        }
    }
}
