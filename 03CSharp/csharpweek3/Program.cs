using System;
using System.Collections.Generic;

namespace csharpweek3
{
    /// <summary>
    /// Program class is the main entry point of this program
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // List<int> list = GenericCollection.List();
            // foreach(int n in list)
            // {
            //     Console.WriteLine(n);
            // }
            // Console.WriteLine(list.Count);
            //Covariant: child in place of parent
            IEnumerable<int> intList = new IList<int>();
            IEnumerable<object> objectList = intList; //List<int>

            Iinterface foo = new InterfaceImpl();

            //Contravariant: Parent in place of child
            Action<FirstGen> FirstGenAction = (target) => { Console.WriteLine(target.GetType().Name); };
            Action<SecondGen> SecondGenAction = FirstGenAction; //Action<FirstGen>
            SecondGenAction(new SecondGen());

            try
            {
                ExceptionHandling.ExceptionExample();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("we caught it here!! {0}", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("This catches all other exception {0}", ex);
            }
            finally 
            {
                Console.WriteLine("This block is executed regardless of exception");
            }
        }
    }
    interface Iinterface {
        public methodOne() {}
    }

    class InterfaceImpl : Iinterface {
        public methodOne()
        {
            Console.WriteLine("hello");
        }
    }
    /// <summary>
    /// XML documentation demo class
    /// </summary>
    class XMLDocumentation
    {
        /// <summary>
        /// It adds numbers
        /// </summary>
        /// <param name="n">an integer to add</param>
        /// <param name="m">another integer to add</param>
        /// <returns>an integer of n + m</returns>
        public static int Add(int n, int m)
        {
            return n + m;
        }
    }

    class TypeConversion
    {
        public static void Boxing()
        {
            int i = 5;
            //boxing this integer
            object o = i;
            object p = i;

            // Console.WriteLine(ReferenceEquals(o, p));

            //unboxing
            int n = (int)o;
            Console.WriteLine($"Unboxing: {n}");
        }

        /// <summary>
        /// Pass by reference example
        /// </summary>
        /// <param name="outParam">out integer param, must have value before function exits</param>
        /// <param name="inParam">in integer param, cannot be changed inside the method</param>
        /// <param name="refParam">ref integer param, must be initialized before call time</param>
        public static void ParamMod(out int outParam, in int inParam, ref int refParam)
        {
            outParam = 100;
            refParam = outParam * refParam;

            // inParam = 0; // It's not gon work
        }

        //pass by value
        public static void Foo(int var)
        {

        }
    }

    class TypeChecking
    {
        public static void TypeCheck()
        {
            // //typeof, GetType, Is, and As
            // Console.WriteLine(typeof(int));
            // int m = 100;
            // typeof(m);
            // m.GetType();at

            // int n = 10;
            // //program runs, stuff happens to n
            // Console.WriteLine($"N Get Type: {n.GetType()}");
            // Console.WriteLine($"Is n an integer? {n.GetType() == typeof(int)}");

            // //is operator
            // SecondGen two = new SecondGen();
            // Console.WriteLine($"Is two second gen {two is SecondGen}");
            // Console.WriteLine($"Is two first gen {two is FirstGen}");
            // Console.WriteLine($"Is two really first gen {two.GetType() == typeof(FirstGen)}");

            //as operator
            // IEnumerable<int> first = new int[] {1, 2, 3};
            // IList<int> second = first as IList<int>;
            // Object o = (Object)m;
            // object o = new object(m);

            // what is happening under the hood with as operator
            // if(m is object)
            // {
            //     o = (object)m;
            // }
            // else
            // {
            //     o = null;
            // }

        }
    }

    class FirstGen {}
    class SecondGen : FirstGen {}

    class GenericCollection {
        public static List<int> List() {
            //array of integer
            int[] arr = new int[5]{1, 2, 3, 4, 5};
            List<int> intList = new List<int>();
            // List<int> anotherList = new List<int>(){1, 2, 3, 4, 5};
            intList.Add(10);
            // intList.AddRange(anotherList);
            return intList;
        }
    }

    class ExceptionHandling {
        public static void ExceptionExample() {
            int[] arr = new int[4];

            try
            {
                //risky code. Gonna throw an exception
                Console.WriteLine(arr[10]);
            }
            catch(IndexOutOfRangeException ex)
            {
                // Console.WriteLine("handled exception {0}", ex);
                throw new CustomException("we're throwing a custom exception");
            }
        }
    }

    public class CustomException : Exception
    {
        public CustomException() { }
        public CustomException(string message) : base(message) { }
        public CustomException(string message, System.Exception inner) : base(message, inner) { }
        protected CustomException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
