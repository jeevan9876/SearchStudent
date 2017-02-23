using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search
{
    public class student
    {
        public string firstname;
        public string lastname;
        public int id;
        public DateTime DOB;
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select any one of the option available below");
            Console.WriteLine("1.Registration");
            Console.WriteLine("2.Look up student");
            int option = Convert.ToInt32(Console.ReadLine());
            List<student> sd = new List<student>();
            

            do
            {
                if (option == 1)
                {
                    student s = new student();
                    Console.WriteLine("Please enter the firstname");
                    s.firstname = Console.ReadLine();
                    Console.WriteLine("Please enter the lastname");
                    s.lastname = Console.ReadLine();
                    Console.WriteLine("Please enter the student id");
                    s.id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the date of birth in the format MM/DD/YYYY");
                    s.DOB = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Student details are saved");
                    sd.Add(s);
                    Console.WriteLine("Please enter any key to exit or please enter 1 or 2 to continue");
                    option = Convert.ToInt32(Console.ReadLine());
                }

                else if (option == 2)
                {
                    Console.WriteLine("Please enter the lastname of the student");
                    string std = Console.ReadLine();
                    var result = (from i in sd
                                  where i.lastname.Equals(std)
                                  select i).FirstOrDefault();
                   
                    if (result != null)
                    {
                        Console.WriteLine("the student details are " + result.firstname + " " + result.lastname + "\n" + result.id + "\n" + result.DOB.ToString("d"));
                    }
                    else
                    {
                        Console.WriteLine("No students are available on that name");
                    }
                    Console.WriteLine("Please enter any other number to exit or please enter 1 or 2 to continue");
                    option = Convert.ToInt32(Console.ReadLine());
                }
            } while (option == 1 ||  option == 2);
                 
        }
    }
}
