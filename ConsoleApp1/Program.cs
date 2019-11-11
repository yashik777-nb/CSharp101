using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Math;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // C# is a statically types language which means once you declare a variable you need to specify its type
            // and that type cannot chnage during the lifetime of that variable

            Console.WriteLine("Test Yash");

            // Variables and Constants
            // case sensitive
            // Identifiers -
            // 1. Cannot start with a number eg: 1Route; eg: oneRoute
            // 2. Cannot include a whitespace eg: first Name; eg: firstName
            // 3. Cannot be a reserve keyword eg: int; eg: @int
            // 4. Use meaning full names eg: fn; eg; firstName

            // data type can be replaced with var and .net complier with map the data type to c#
            // default type is integer for integral numbers

            // TO delete a line -> Ctrl + X

            var num1 = 3;
            var booleanTest = true;

            int number;
            int Number = 1;
            const float Pi = 3.14f;
            const double Pii = 3.14; // default data type for decimal numbers in c#
            const decimal Piii = 3.14m;
            char character = 'A';
            string name = "Yash";   
            bool isWorking = true;

            // Console.WriteLine() -> shortcut - type cw and two times tab button

            // Naming Conventions - Popular
            // 1. Camel Case = firstName -> mostly used
            // 2. Pascal Case = FirstName
            // 3. Hungaration Notation = strFirstName -> not used in c# mostly

            // For Local Variables -> Use Camel case eg: number
            // For Constants -> Use Pascal case eg: Pi

            // ************************************************************************************************ //
            // Primitive Types
            // byte, short, int, long, float, double, decimal, char, bool
            // They all are strucutres in .net framework

            // Non-Primitive Types
            // String, Array, Enum, Class
            // They all are classes in .net framework

            // **************************************** //
            //              OverFlowing                 //
            // **************************************** //

            byte num = 255;
            num++;
            Console.WriteLine(num);

            checked
            {
                byte num2 = 255;
                num1++;
                Console.WriteLine(num1);
            }

            // **************************************** //
            //                  Scope                   //
            // **************************************** //

            // Where a varaibale/constant has meaning or accessible
            {
                byte a = 1;
                {
                    byte b = 2;
                    {
                        byte c = 3;
                    }
                }
            }

            // a is accessible in the entire block and the child blocks b & c
            // b is accessible in the entire block and the child block c
            // c is accessible only in the block c

            // **************************************** //
            //            Variables & Constants         //
            // **************************************** //

            // Place Holders - String Format

            Console.WriteLine("Place Holders");
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            const float p = 3.14f;

            // **************************************** //
            //            Type Conersion                //
            // **************************************** //

            // 1. Implcit Type Coversion

            byte b1 = 8;
            int i = b1;
            float f = i;

            Console.WriteLine(Convert.ToString(b1, 2));
            Console.WriteLine(Convert.ToString(1, 2));
            Console.WriteLine(BitConverter.GetBytes(f)); // Explore how to generate float binary code        

            // byte b2 = i; this gives error


            // 2. Explicit Type Conversion (casting)

            float f1 = 1.0f;
            int i1 = (int)f1;

            // 3. Conversion between non-compatible types

            string s = "1";
            int i3 = Convert.ToInt32(s);
            int i4 = int.Parse(s);

            // Convert ->
            // 1. ToByte() 
            // 2. ToInt16() - short
            // 3. ToInt32() - int
            // 4. ToInt64() - long

            try
            {
                var num4 = "1234";
                byte b3 = Convert.ToByte(num4);
                Console.WriteLine(b3);
            }
            catch (Exception e)
            {
                Console.WriteLine("The number could not converted to a byte " + e.Message);
            }

            try
            {
                string str = "tru1e";
                bool bool1 = Convert.ToBoolean(str);
                Console.WriteLine(bool1);
            }
            catch (Exception)
            {
                Console.WriteLine("The string cannot be converted to a boolean");
            }

            // **************************************** //
            //            Operators                     //
            // **************************************** //

            // 5 types of operators
            // 1. Arithmatic (+, -, *, /, %, ++, --), Postfix and prefix
            // 2. Comparison (==, !=, >, >=, <, <=)
            // 3. Assignment ( =, +=, -=, *=, /=)
            // 4. Logical ( &&, ||, !)
            // 5. Bitwise (&, |)

            int a1 = 1;
            int b5 = ++a1;
            int b4 = a1++;
            Console.WriteLine("{0}, {1}, {2}", b5, b4, a1); // 2,2,3



            // **************************************** //
            //            Logical Operators             //
            // **************************************** //

            int a6 = 10;
            int b6 = 3;

            Console.WriteLine(a6 + b6);
            Console.WriteLine(a6 - b6);
            Console.WriteLine(a6 * b6);
            Console.WriteLine(a6 / b6);
            Console.WriteLine((float)a6 / (float)b6);
            Console.WriteLine(a6 % b6);

            Console.WriteLine(a6 == b6);
            Console.WriteLine(a6 != b6);
            Console.WriteLine(a6 > b6);
            Console.WriteLine(a6 < b6);

            int c6 = 4;
            Console.WriteLine(c6 > b6 && b6 < a6);

            // ************************************************************************************************ //
            // Non-Primitive Types
            // ************************************************************************************************ //

            // 1. Classes
            // 2. Structures
            // 3. Arrays
            // 4. Strings
            // 5. Enums

            // Reference types vs Value Types -> Memory management of different types in c#

            // Classes
            // An object is an instance of a class 

            // Access Modifier -> determines who can access the class
            // public -> class acceseble in anywhere in the application

            // static Modifier -> Method is declared as static, now the method can be accessed directly  
            // using the class name without creating an object. We cannot access static members from objects
            // Only one created in memory (same reference always - singleton)

            Person yash = new Person();
            yash.firstName = "Yashwanth";
            yash.lastName = "Iddibani";
            yash.Introduce();

            Calculator cal = new Calculator();
            int result = cal.Add(2, 3);
            Console.WriteLine("Sum of two Numbers: " + result);

            // Structs - Similar to classes, 

            // Arrays - A datastructure to store a collection of variables of the same type
            // it is an object
            // zero index based

            var numArray = new int[3]{ 4,5,6};
            numArray[0] = 1;
            numArray[1] = 2;
            numArray[2] = 3;

            var flags = new bool[3];
            flags[0] = true;
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var names = new String[3] { "Jack", "John", "Mary"};

            // Strings - A sequence of characters eg:- "Hello World"
            string str1 = "Yash";
            string str2 = "Yashwanth" + " " + "Iddibani";
            string str3 = string.Format("{0} {1}", "Yaswanth", "Iddibani");
            string list = string.Join(",", numArray);

            char firstChar = str1[0];

            Console.WriteLine(str3);
            Console.WriteLine(list);

            // strings are immutable - Once you create them, you cannot change them
            str1 = "Yaashwanth";
            // str1[0] = "A";

            // Escapre Characters -> {\n, \t, \\ (BackSlash), \*, \" }

            // Varbatim strings
            string path = "D:\\VisualStudioProjects\\CSharp";
            string path1 = @"D:\VisualStudioProjects\CSharp";

            var firstName1 = "Yash";
            string lastName1 = "Iddibani";

            // string vs String
            // c# data type and .net data type.. String needs to be imported







        }
    }

    public struct RgbColor
    {
        public int red;
        public int green;
        public int blue;
    }
}
