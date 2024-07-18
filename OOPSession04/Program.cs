using OOPSession04.IClonable;
using OOPSession04.Interface_Example02;
using OOPSession04.Interface_Example03;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace OOPSession04
{
    internal class Program
    {
        public static void print10NumbersFromSeries(ISeries seriesByTwo)
        {
            if (seriesByTwo == null)
                return;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{seriesByTwo.Current}\t");
                seriesByTwo.GetNext();
            }
            seriesByTwo.Reset();
            Console.WriteLine();
        }
        //public static void print10NumbersFromSeriesByThree(SeriesByThree seriesByThree)
        //{
        //    if (seriesByThree == null)
        //        return;
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine($"{seriesByThree.Current}\t");
        //        seriesByThree.GetNext();
        //    }
        //    seriesByThree.Reset();
        //    Console.WriteLine();
        //}



        static void Main(string[] args)
        {
            #region Example02
            //SeriesByTwo seriesByTwo = new SeriesByTwo();
            //print10NumbersFromSeries(seriesByTwo);

            //SeriesByThree seriesByThree = new SeriesByThree();
            //print10NumbersFromSeries(seriesByThree);
            #endregion

            #region Example03
            //Airplane airplane = new Airplane();
            //IMovable movable = new Airplane();
            //IFlyable flyable = new Airplane();
            //flyable.Forward();
            //airplane.Forward();

            #endregion

            #region Shallow Copy vs Deep Copy [Value type]

            int[] arr = { 1, 3, 4, 5 };
            int[] arr02 = { 1, 3, 4, 5 };

            //Console.WriteLine($"Hash Code arr = {arr.GetHashCode()}");
            //Console.WriteLine($"Hash Code arr = {arr02.GetHashCode()}");
            ////shallow copy
            //arr02 = arr;
            //Console.WriteLine("After shallow copy: ");
            //Console.WriteLine($"Hash Code arr = {arr.GetHashCode()}");
            //Console.WriteLine($"Hash Code arr = {arr02.GetHashCode()}");

            //arr02[0] = 10;

            //Console.WriteLine(arr02[0]);
            //Console.WriteLine(arr[0]);


            #region Deep Copy [value type]
            //arr02 = (int[]) arr.Clone(); // clone method will generate new object
            //                             // this object will have the same object state[data]
            //                             // of the caller object

            //Console.WriteLine($"Hash Code arr = {arr.GetHashCode()}");
            //Console.WriteLine($"Hash Code arr = {arr02.GetHashCode()}");
            //Console.WriteLine("After Deep copy: ");
            //Console.WriteLine($"Hash Code arr = {arr.GetHashCode()}");
            //Console.WriteLine($"Hash Code arr = {arr02.GetHashCode()}");

            //arr02[0] = 100;
            //Console.WriteLine(arr[0]);
            //Console.WriteLine(arr02[0]);

            #endregion

            #endregion
            #region Shallow Copy vs Deep Copy [Reference type]
            //string[] Name01 = new string[] { "omar" };
            //string[] Name02 = new string[1];
            //Console.WriteLine($"Hash Code Name02 = {Name01.GetHashCode()}");
            //Console.WriteLine($"Hash Code Name01 = {Name02.GetHashCode()}");

            ////shallow copy
            //Name02 = Name01;
            //Console.WriteLine("After Shallow copy: ");
            //Console.WriteLine($"Hash Code Name02 = {Name01.GetHashCode()}");
            //Console.WriteLine($"Hash Code Name01 = {Name02.GetHashCode()}");

            //Name02[0] = "Mohamed";
            //Console.WriteLine(Name02[0]);
            //Console.WriteLine(Name01[0]);


            #region Deep Copy [reference Type]

            //Name02 = (string[])Name01.Clone();

            //Console.WriteLine("Before Deep copy: ");
            //Console.WriteLine($"Hash Code Name02 = {Name01.GetHashCode()}");
            //Console.WriteLine($"Hash Code Name01 = {Name02.GetHashCode()}");
            //Console.WriteLine("After Deep copy: ");
            //Console.WriteLine($"Hash Code Name02 = {Name01.GetHashCode()}");
            //Console.WriteLine($"Hash Code Name01 = {Name02.GetHashCode()}");

            //Name02[0] = "Mohamed";
            //Console.WriteLine("After Deep Copy : ");
            //Console.WriteLine(Name02[0]);
            //Console.WriteLine(Name01[0]);


            #endregion







            #endregion

            #region Shallow Copy vs Deep Copy [Mutable Reference Type]
            //StringBuilder[] Name01 = new StringBuilder[1];
            //StringBuilder[] Name02 = new StringBuilder[1];
            //Name01[0] = new StringBuilder("omar"); // null ref exception

            //Console.WriteLine($"Hash Code Name02 = {Name01.GetHashCode()}");
            //Console.WriteLine($"Hash Code Name01 = {Name02.GetHashCode()}");

            //Console.WriteLine(Name02[0]);
            //Console.WriteLine(Name02[0]);


            //shallow copy
            //Name02 = Name01;
            //Console.WriteLine("After shallow copy: ");
            //Console.WriteLine($"Hash Code Name02 = {Name01.GetHashCode()}");
            //Console.WriteLine($"Hash Code Name01 = {Name02.GetHashCode()}");

            //Console.WriteLine(Name01[0]); 
            //Console.WriteLine(Name02[0]);
            //Name02[0].Append("Ahmed");
            //Console.WriteLine("After change: ");

            //Console.WriteLine(Name01[0]);
            //Console.WriteLine(Name02[0]);


            //Deep Copy
            //Name02 = (StringBuilder[])Name01.Clone();

            //Console.WriteLine("After Deep copy: ");
            //Console.WriteLine($"Hash Code Name02 = {Name01.GetHashCode()}");
            //Console.WriteLine($"Hash Code Name01 = {Name02.GetHashCode()}");

            //Console.WriteLine(Name01[0]);
            //Console.WriteLine(Name02[0]);

            //Name02[0].Append("Ahmed");
            //Console.WriteLine("After change: ");

            //Console.WriteLine(Name01[0]);
            //Console.WriteLine(Name02[0]);







            #endregion


            #region ICloneable

            //Employee emp01 = new Employee()
            //{
            //    Id = 1,
            //    Name = "Omar",
            //    Salary = 45000,
            //    department = new Department()
            //    {
            //        id = 100,
            //        name = "HR"
            //    }

            //};

            //Employee emp02 = new Employee()
            //{
            //    Id = 2,
            //    Name = "Ahmed",
            //    Salary = 30000
            //};

            //Console.WriteLine($"Hashcode of emp01 : {emp01.GetHashCode()}");
            //Console.WriteLine($"Hashcode of emp02 : {emp02.GetHashCode()}");

            ////Employee emp03 = emp01; //shallow copy

            //Employee emp03= (Employee) emp01.Clone();
            //Console.WriteLine("After Deep Copy : ");
            //Console.WriteLine($"Hashcode of emp01 : {emp01.GetHashCode()}");
            //Console.WriteLine($"Hashcode of emp03 : {emp03.GetHashCode()}");

            //emp03.department.name = "Sales";

            //Console.WriteLine(emp01);
            //Console.WriteLine(emp03);







            #endregion

            #region ICompareable
            //int[] Numbers = { 1, 3, 5, 20, 200 };
            //Array.Sort(arr);

            //Employee[] employees =
            //{
            //     new Employee(){Id = 10 ,Name = "omar", Salary = 1000 },
            //     new Employee(){Id = 20 ,Name = "ali", Salary = 5000 },
            //     new Employee(){Id = 30 ,Name = "aya", Salary = 7000 }

            //};
            //Array.Sort(employees);
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}


            //for (int i = 0; i < employees.Length; i++)
            //{
            //    for (int j = 0; j < employees.Length - j - 1; j++)
            //    {
            //        if (employees[j].CompareTo(employees[j + 1]) == 1)
            //        {
            //            swap(employees[j], employees[j + 1]);
            //        }
            //    }

            //}
            #endregion

        }
    }
}
