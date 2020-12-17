using System;

namespace ExceptionsBestPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            // best Practices for excepton Handling!
            //exceptions give us a chagce to inform  up above in  the hierarchy caller that there is a problem
            // methods can throw an exceptions!
            // stack OverFlowException- > hapens when we have endless recusrion, the momory is full -> outOfMemoryException !
            // or we dont we have memory enough !
            // Exceptions are objects !!, exceptions are Objects !, Exceptions are Objects !, Exceptions are Objects !
            // Exception Class represent error  that occur during application execution !

            //Exceptions are use to inform that error occured, 
            // Dont use the exceptions to controll the way our program works !
            // by passwoerd validation dont Use Exceptions !!!!, the password is false !
            //We have to throw the right way of exceptions !the right type of exceptions !
            //awalys put the descriptive erro message !
            // avoid empty cathch blocks !


            while (true)
            {

                string s = Console.ReadLine();
                try
                {
                    Int32.Parse(s);
                    Console.WriteLine("You have entered valid int.32 number{0}", s);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid integer Number!");
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("The numebr is too big to fit to int.32! ");
                    continue;
                }

                break;
                // Exceptions are used for data Validation!
                // Error Handling Techniques
                // throw an Exception
                // -> returna neutrtal value , 
                // return an error code !

                // OOP languages use exceptions 
                // exceptions are anouncement for about error condition, or unusual event., 
                //exception can be caught and the application can continue wirking !
                ///
                // Assertions are fatal errors, asertions always indicate bugs in the code .
                // Assertions can not be caufght and processed, application can not continue incase of failed assertions.
                // Assertions only for private methods and debug mode !
                //public methods --validate the data
                // private methods assume the data is safe!
                // defensive programing, --> many checks , validations, too much defence programming is not good!


            }
        }
    }
}
