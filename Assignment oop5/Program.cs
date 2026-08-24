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



        }
    }
}
