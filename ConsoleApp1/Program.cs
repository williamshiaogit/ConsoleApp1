using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Mosh";
            bool isWorking = false;
            */

            /*
            //型別var可以自動偵測
            var number = 2; //但是數字會被視為int
            var count = 10;
            var totalPrice = 20.95f;
            var character = 'A';
            var firstName = "Mosh";
            var isWorking = false;
            //use "ctrl + alt + j" to call "object browser" search how to use the class or method.
            
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            */

            /*
            Console.WriteLine("{0}, {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0}, {1}", float.MinValue, float.MaxValue);
            */

            /*
            const float Pi = 3.14f;
            Pi = 1;
            */
            //const is safe if the value will not be changed.

            //implicit type conversion(隱含型別轉換)
            /*int i = 256;
            byte b = (byte) i;//如果硬要轉換要加上cast
            Console.WriteLine(i);
            */
            //Convert.To..()
            /*
            var number = "1234";
            int i = Convert.ToInt32(number);
            Console.WriteLine(i);
            */

            //例外狀況try catch就像python的try except
            /*
            try
            {
                var number  = "1234";
                byte by = Convert.ToByte(number);
                Console.WriteLine(by);
                
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
                
            }
            catch (Exception)
            {
                Console.WriteLine(" Exception:The number could not be convert to a byte.");
            }
            */
    
            /*
            //Oprator
            var a = 1;
            var b = 2;
            var c = 3;
            Console.WriteLine(a + b * c);
            */

            var random = new Random();
            // Generate and display 5 random byte (integer) values.
            /*
            var bytes = new byte[5];
            random.NextBytes(bytes);
            foreach (byte byteValue in bytes)
                Console.Write("{0, 5}", byteValue);
            Console.WriteLine();

            for (int ctr = 0; ctr <= 4; ctr++)
                Console.Write("{0,15:N0}", random.Next());
            Console.WriteLine();
            */
            /*
            for (int ctr = 0; ctr <= 4; ctr++)
                Console.Write("{0,10:N5}", random.NextDouble() * 10);//NextDouble會回傳0到1之間的數
            //{output的空格子數:N小數點後幾位}random.Next(50,101)->50到100的數
            Console.WriteLine();
            */
            Console.ReadKey();

        }

    }
}
