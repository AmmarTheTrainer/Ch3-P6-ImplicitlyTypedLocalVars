using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_P6_ImplicitlyTypedLocalVars
{
    class Program
    {
        static void Main(string[] args)
        {
            // Full Stack .NET Course Batch 1 < Lecture Unknown > 
            //DeclareImplicitVars();
            //RestrictionsOnVarKeyword();
            //ImplicitTypingIsStrongTyping();
            LinqQueryOverInts();

            Console.ReadLine();
        }

        private static void LinqQueryOverInts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
            // LINQ query!
            var subset = from i in numbers where i < 10 select i;

            Console.Write("Values in subset: ");
            foreach (var i in subset)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            // Hmm...what type is subset?
            Console.WriteLine("subset is a: {0}", subset.GetType().Name);
            Console.WriteLine("subset is defined in: {0}", subset.GetType().Namespace);
        }

        private static void ImplicitTypingIsStrongTyping()
        {
            // The compiler knows "s" is a System.String.
            var s = "This variable can only hold string data!";
            s = "This is fine...";
            // Can invoke any member of the underlying type.
            string upper = s.ToUpper();
            // Error! Can't assign numerical data to a string!
            //s = 44;
        }

        private static void RestrictionsOnVarKeyword()
        {
            // error
            //var mydata;

            // error
            //var number;
            //number = 3;

            // error
            //var mydata = null;

            // okay
            //var car = new Honda_e_le_saan();
            //car = null;

            // okay 
            //var number = 0;
            //var number2 = number;



            int number = GetAnInt();  // its okay

        }

        private static int GetAnInt()
        {
            var number = 0;

            return number;
        }

        private static void DeclareImplicitVars()
        {
            //int myint = 0;
            //bool mybool = true;


            // Implicitly typed local variables are declared as follows:
            // var variableName = initialValue;

            var myInt = 0;
            var myBool = true;
            var myString = "Time, marches on...";

            // Print out the underlying type.
            Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
            Console.WriteLine("myBool is a: {0}", myBool.GetType().Name);
            Console.WriteLine("myString is a: {0}", myString.GetType().Name);

            //var arr = new int[3];
            //for (int i = 0; i < arr.Length; i++)
            //{

            //}
        }
    }
}
