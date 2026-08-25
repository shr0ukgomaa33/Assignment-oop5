using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_oop5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            // a) When you assign one object variable to another, both variables refer to the same object in memory.

            // b) No. Assigning one object variable to another does not create a new object. It only copies the reference to the existing object.

            // c) Copying the reference: Both variables point to the same object, so changes through one variable can affect the other.
            //       Copying the object: A new, separate object is created with its own data

            #endregion



            #region Q2


            // a) A Shallow Copy creates a new object and copies the values of the original object's fields. For reference-type fields, it copies the references, not the referenced object


            // B) 
            //  A Deep Copy creates a new object and also creates independent copies of the objects referenced by its reference-type members.


            // C) The references are copied, so the original and copied objects point to the same referenced objects. 

            // d) New copies of the referenced objects are created, so the original and copied objects have independent reference-type members.

            // e) Deep Copy is safer when modifying the copied object must not affect the original object, such as when copying a customer record that contains a list of addresses or orders.
            #endregion


            #region Q3 


            // a)    A static field belongs to the class itself and is shared by all objects of that class.
            //              An instance field belongs to a specific object, so every object has its own copy.


            // b) A static method belongs to the class rather than to a specific object 
            // No, a static method cannot directly access instance members because it does not have an instance of the class. 


            //c) A static constructor initializes static members of a class. It is executed automatically once, before the class is first used.

            //d) A static class is a class that contains only static members.
            //No, you cannot create an object from a static class. 

            #endregion

            #region Q4

            // a)  An Extension Method is a method that allows you to add new functionality to an existing type without modifying its original source code or creating a derived class.

            // b) The this keyword must be used with the first parameter. 

            //c) It must be declared inside a static class. 

            //d) No. An extension method does not have access to the private members of the class it extends. 

            #endregion

            #region Q5

            //a) A Partial Class allows the definition of one class to be split across multiple files. The parts are combined by the compiler into a single class.

            // b) To organize large classes, improve readability, and allow different developers or tools to work on different parts of the same class.

            //c) 
            // A Partial Method is a method that can be declared in one part of a partial class and implemented in another part.


            // d) 
            // If a partial method has no implementation and meets the rules for an optional partial method, the compiler removes its declaration and any calls to it.

            #endregion


            #region Practical
            Console.WriteLine("==========================================");
            Console.WriteLine("Smart Delivery Management System");
            Console.WriteLine("==========================================");



            Console.WriteLine("==========================================");
            Console.WriteLine("Creating Shipments...");
            Console.WriteLine("==========================================");

            StandardShipment standardShipment = new StandardShipment(
                "SH001",
                "Laptop",
                9,
                50,
                new DeliveryAddress("Cairo", "Tahrir Street", 10)
            );

            ExpressShipment expressShipment = new ExpressShipment(
                "SH002",
                "Phone",
                4,
                50,
                new DeliveryAddress("Giza", "Pyramids Street", 20),
                30
            );

            InternationalShipment internationalShipment = new InternationalShipment(
                "SH003",
                "Documents",
                12,
                50,
                new DeliveryAddress("Fayoum", "Main Street", 15),
                "Germany",
                150
            );

            Console.WriteLine("Standard Shipment Created");
            Console.WriteLine("Express Shipment Created");
            Console.WriteLine("International Shipment Created");

            Console.WriteLine(
                $"Total Shipments Created : {Shipment.GetTotalShipmentsCreated()}"
            );



            Console.WriteLine("==========================================");
            Console.WriteLine("Object Copying");
            Console.WriteLine("==========================================");

            Shipment shipment1 = standardShipment;
            Shipment shipment2 = shipment1;

            Console.WriteLine($"Original Shipment : {shipment1.TrackingCode}");
            Console.WriteLine($"Assigned Shipment : {shipment2.TrackingCode}");
            Console.WriteLine(
                $"Same Object : {ReferenceEquals(shipment1, shipment2)}"
            );


            

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Shallow Copy");
            Console.WriteLine("------------------------------------------");

            Shipment shallowCopy = shipment1.ShallowCopy();

            Console.WriteLine(
                $"Original Shipment Address : {shipment1.Destination.City}"
            );

            Console.WriteLine(
                $"Copied Shipment Address : {shallowCopy.Destination.City}"
            );

            Console.WriteLine("Changing copied shipment address...");

            shallowCopy.Destination.City = "Giza";

            Console.WriteLine(
                $"Original Shipment Address : {shipment1.Destination.City}"
            );

            Console.WriteLine(
                $"Copied Shipment Address : {shallowCopy.Destination.City}"
            );

            Console.WriteLine(
                $"Same DeliveryAddress Object : " +
                $"{ReferenceEquals(shipment1.Destination, shallowCopy.Destination)}"
            );

            shipment1.Destination.City = "Cairo";


            

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Deep Copy");
            Console.WriteLine("------------------------------------------");

            Shipment deepCopy = shipment1.DeepCopy();

            Console.WriteLine(
                $"Original Shipment Address : {shipment1.Destination.City}"
            );

            Console.WriteLine(
                $"Copied Shipment Address : {deepCopy.Destination.City}"
            );

            Console.WriteLine("Changing copied shipment address...");

            deepCopy.Destination.City = "Giza";

            Console.WriteLine(
                $"Original Shipment Address : {shipment1.Destination.City}"
            );

            Console.WriteLine(
                $"Copied Shipment Address : {deepCopy.Destination.City}"
            );

            Console.WriteLine(
                $"Same DeliveryAddress Object : " +
                $"{ReferenceEquals(shipment1.Destination, deepCopy.Destination)}"
            );



            Console.WriteLine("==========================================");
            Console.WriteLine("Extension Methods");
            Console.WriteLine("==========================================");

            Console.WriteLine(standardShipment.GetSummary());
            Console.WriteLine(expressShipment.GetSummary());
            Console.WriteLine(internationalShipment.GetSummary());

            Console.WriteLine();

            Console.WriteLine(
                $"SH001 Is Delivered : {standardShipment.IsDelivered()}"
            );

            Console.WriteLine(
                $"SH003 Is Delivered : {internationalShipment.IsDelivered()}"
            );


            

            Console.WriteLine("==========================================");
            Console.WriteLine("Tracking Status");
            Console.WriteLine("==========================================");

            standardShipment.UpdateTrackingStatus("Out For Delivery");


            

            Console.WriteLine("==========================================");
            Console.WriteLine("Static Utilities");
            Console.WriteLine("==========================================");

            DeliveryUtilities.PrintSeparator();

            DeliveryUtilities.PrintSystemTitle();

            Console.WriteLine(
                $"Total Shipments Created : " +
                $"{Shipment.GetTotalShipmentsCreated()}"
            );


            

            Console.WriteLine("==========================================");
            Console.WriteLine("Partial Method");
            Console.WriteLine("==========================================");

            standardShipment.UpdateTrackingStatus("Delivered");


            
            DeliveryCenter center = new DeliveryCenter();

            center.AddShipment(standardShipment);
            center.AddShipment(expressShipment);
            center.AddShipment(internationalShipment);

            center.PrintAllShipments();

            Console.WriteLine("==========================================");
            Console.WriteLine();
            Console.WriteLine("Tracking Status");
            Console.WriteLine();

            center.PrintTrackingStatuses();


            

            Console.WriteLine("==========================================");
            Console.WriteLine();
            Console.WriteLine("Insurance");
            Console.WriteLine();

            DeliveryReport report = new DeliveryReport();

            report.PrintInsurance(standardShipment);
            report.PrintInsurance(expressShipment);
            report.PrintInsurance(internationalShipment);


            

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine();

            ITrackable[] trackableShipments =
            {
    standardShipment,
    expressShipment,
    internationalShipment
};

            foreach (ITrackable shipment in trackableShipments)
            {
                report.PrintShipment(shipment);
            }

            Console.WriteLine();

            IInsurable[] insurableShipments =
            {
    standardShipment,
    expressShipment,
    internationalShipment
};

            foreach (IInsurable shipment in insurableShipments)
            {
                report.PrintInsurance(shipment);
            }

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine();
            Console.WriteLine("Interface Polymorphism Demonstrated Successfully.");

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("Assignment Completed");
            Console.WriteLine("==========================================");




            #endregion











        }
    }
}
