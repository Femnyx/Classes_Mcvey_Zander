using System;

namespace Classes_Mcvey_Zander
{
    class Program
    {
        static void Main(string[] args)
        {
           //This links both classes together to use them both into one program.
            Greetings greetings = new Greetings(); 
          
            //This command greets the user using the other class in this program.
            greetings.Welcome();

            //The user inserts their name into the command.
            Console.WriteLine("What is your name squire?");
                string userName = Console.ReadLine();

            //The command greats the user with userName. 
            greetings.Hello(userName);
        }
    }
}
