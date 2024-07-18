using OOPSession04.IAuthenticationServiceQ;
using OOPSession04.IShape;
using OOPSession04.NotificationService;


namespace OOPSession04
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
