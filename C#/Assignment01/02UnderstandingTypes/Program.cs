using System;

namespace _02UnderstandingTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type: {0,-10} Size: {1,2} bytes  Min: {2,30}  Max: {3,30}", "sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine("Type: {0,-10} Size: {1,2} bytes  Min: {2,30}  Max: {3,30}", "byte", sizeof(byte), byte.MinValue, byte.MaxValue);
            Console.WriteLine("Type: {0,-10} Size: {1,2} bytes  Min: {2,30}  Max: {3,30}", "short", sizeof(short), short.MinValue, short.MaxValue);
            Console.WriteLine("Type: {0,-10} Size: {1,2} bytes  Min: {2,30}  Max: {3,30}", "ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
            Console.WriteLine("Type: {0,-10} Size: {1,2} bytes  Min: {2,30}  Max: {3,30}", "int", sizeof(int), int.MinValue, int.MaxValue);
            Console.WriteLine("Type: {0,-10} Size: {1,2} bytes  Min: {2,30}  Max: {3,30}", "uint", sizeof(uint), uint.MinValue, uint.MaxValue);
            Console.WriteLine("Type: {0,-10} Size: {1,2} bytes  Min: {2,30}  Max: {3,30}", "long", sizeof(long), long.MinValue, long.MaxValue);
            Console.WriteLine("Type: {0,-10} Size: {1,2} bytes  Min: {2,30}  Max: {3,30}", "ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
            Console.WriteLine("Type: {0,-10} Size: {1,2} bytes  Min: {2,30}  Max: {3,30}", "float", sizeof(float), float.MinValue, float.MaxValue);
            Console.WriteLine("Type: {0,-10} Size: {1,2} bytes  Min: {2,30}  Max: {3,30}", "double", sizeof(double), double.MinValue, double.MaxValue);
            Console.WriteLine("Type: {0,-10} Size: {1,2} bytes  Min: {2,30}  Max: {3,30}", "decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);

        }
    }
}