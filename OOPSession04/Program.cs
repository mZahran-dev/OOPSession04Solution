
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


            #region Part2

            #region  Question 1:

            //What is the primary purpose of an interface in C#?
            //a) To provide a way to implement multiple inheritance
            //b) To define a blueprint for a class
            //c) To declare abstract methods and properties
            //d) To create instances of objects 

            // Answer : a)
            #endregion

            #region Question 2:
            //Which of the following is NOT a valid access modifier for interface members in C#?
            // a) private
            // b) protected
            // c) internal
            // d) public

            // Answer : b) , c)

            #endregion


            #region Question 3:
            //Can an interface contain fields in C#?
            //a) Yes
            //b) No
            //c) Only if they are static
            //d) Only if they are readonly

            //Answer : b)

            #endregion


            #region Question 4:

            //In C#, can an interface inherit from another interface?
            //    a) No, interfaces cannot inherit from each other
            //    b) Yes, interfaces can inherit from multiple interfaces
            //    c) Yes, but only if they have the same methods
            //    d) Only if the interfaces are in the same namespace 

            // Answer : b)
            #endregion

            #region Question 5:
            //Which keyword is used to implement an interface in a class in C#?
            //    a) inherit
            //    b) use
            //    c) extends
            //    d) implements

            //Answer : d) 

            #endregion


            #region Question 6:
            //Can an interface contain static methods in C#?
            //    a) Yes
            //    b) No
            //    c) Only if the interface is sealed
            //    d) Only if the methods are private


            //Answer : a) 
            #endregion


            #region Question 7:
            //In C#, can an interface have explicit access modifiers for its members?
            //    a) Yes, for all members
            //    b) No, all members are implicitly public
            //    c) Yes, but only for abstract members
            //    d) Only if the interface is sealed


            //Answer : b) 
            #endregion

            #region Question 8:
            //What is the purpose of an explicit interface implementation in C#?
            //a) To hide the interface members from outside access
            //b) To provide a clear separation between interface and class members
            //c) To allow multiple classes to implement the same interface
            //d) To speed up method resolution

            //Answer : b) 

            #endregion

            #region Question 9:
            //In C#, can an interface have a constructor?
            // a) Yes, but it must be private
            // b) No, interfaces cannot have constructors
            // c) Yes, but only if the interface is sealed
            // d) Only if the constructor is static


            //Answer : b) 
            #endregion

            #region Question 10:
            //How can a C# class implement multiple interfaces?
            //    a) By using the "implements" keyword
            //    b) By using the "extends" keyword
            //    c) By separating interface names with commas
            //    d) A class cannot implement multiple interfaces

            //Answer : c) 

            #endregion

            #endregion

            #region Part03

            #region Question 1 
            //ICircle circle = new Circle(5);
            //IRectangle rectangle = new Rectangle(4, 6);

            //// Display shape information
            //circle.DisplayShapeInfo();
            //rectangle.DisplayShapeInfo();
            #endregion

            #region Question 2 
            //IAuthenticationService authService = new BasicAuthenticationService();

            //string username = "user1";
            //string password = "password1";
            //string role = "admin";

            //// Authenticate the user
            //bool isAuthenticated = authService.AuthenticateUser(username, password);
            //Console.WriteLine($"Is {username} authenticated? {isAuthenticated}");

            //// Authorize the user
            //bool isAuthorized = authService.AuthorizeUser(username, role);
            //Console.WriteLine($"Is {username} authorized as {role}? {isAuthorized}");
            #endregion

            #region Question 3 
            //INotificationService emailService = new EmailNotificationService();
            //INotificationService smsService = new SmsNotificationService();
            //INotificationService pushService = new PushNotificationService();


            //string recipient = "example@domain.com";
            //string message = "Hello, this is a test notification.";

            //emailService.SendNotification(recipient, message);
            //smsService.SendNotification(recipient, message);
            //pushService.SendNotification(recipient, message);
            #endregion


            #endregion
        }
    }
}
