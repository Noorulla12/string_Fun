using System;

namespace stringFun
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Noorulla";
            var lastName = "Rupanagudi";

             Console.WriteLine("My name is " + firstName + " " + lastName);

             Console.WriteLine(string.Format("{0} {1} ",firstName, lastName));

            var names = new string[] { "Noor", "Rahim", "Baari" };

            var formattedNames = string.Join(", ", names);

            Console.WriteLine(formattedNames);

            var text =@"Hi noor
look into the following paths
C:\projects\project1
C:\folder1\folder2";

            Console.WriteLine(text);






        }
    }

}