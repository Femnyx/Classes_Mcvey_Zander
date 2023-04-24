using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Mcvey_Zander
{
    class Greetings
    {
        /// <summary>
        /// It prints text that greets the user.
        /// </summary>
        public void Welcome()
        {
            Console.WriteLine("Hello Traveler!, welcome!");
        }

        /// <summary>
        /// It prints text that thanks the user.
        /// </summary>
        /// <param name="name"></param>
        public void Hello(string name)
        {
            Console.WriteLine($"{name}, thank you for joining us today!");
        }

    }
}
