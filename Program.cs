using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.IO;

namespace Json2
{
    class Program
    {
        static void Main()
        {
            Convert_json_to_cs();
            Convert_cs_to_json();
        }

        static Information Convert_json_to_cs()
        {
            string Filename = @"C:\New folder\information.json";

            if (System.IO.File.Exists(Filename))
            {
                string justText = File.ReadAllText(Filename);

                Information c = Newtonsoft.Json.JsonConvert.DeserializeObject<Information>(justText);

                return (c);
            }
            return (null);
        }


        static void Convert_cs_to_json()
        {
            var info = CreateInformation();

            var jsonFormattedContent = Newtonsoft.Json.JsonConvert.SerializeObject(info);

            string FileName = @"C:\New folder\Newinformation.json";

            if (System.IO.File.Exists(FileName) == false)
            {
                System.IO.File.WriteAllText(FileName, jsonFormattedContent);
            }
            else
            {
                System.IO.File.Delete(FileName);
                System.IO.File.WriteAllText(FileName, jsonFormattedContent);
            }
        }

        static Information CreateInformation()
        {
            var x = new Information();
            x.ApplicantID = "10";
            x.employees = new List<Employee>();

            var c = new Employee();
            c.EmployeeName = "Xyra Shenne A. Gordora";
            c.Address = "Brgy. Villa Nava Gumaca, Queszon";
            c.Phone = "093726482617";
            c.Email = "xyragordora@gmail.com";
            c.School = "Polytechnic University of the Philippines";
            c.Degree = "Bachelor of Science in Computer Engineering";
            c.GPA = 1.10;
            c.YourSkill = "Communication skills, Creativity, Flexible, Leadership, Multitasking, Strategic Thinking, Time Management";
            c.Languages = "English, Filipino";
            x.employees.Add(c);

            c = new Employee();
            c.EmployeeName = "Acetact";
            c.Address = "Brgy. Villa Nava Gumaca, Queszon";
            c.Phone = "092736482932";
            c.Email = "acetacy@gmail.com";
            c.School = "Adamson University";
            c.Degree = "Bachelor of Science in Nursing";
            c.GPA = 1.43;
            c.YourSkill = "Communication skills, Creativity, Flexible, Leadership, Multitasking, Strategic Thinking, Time Management";
            c.Languages = "English, Filipino";
            x.employees.Add(c);


            c = new Employee();
            c.EmployeeName = "Kylie";
            c.Address = "Brgy. Villa Nava Gumaca, Queszon";
            c.Phone = "0973849204";
            c.Email = "kylie@gmail.com";
            c.School = "Adamson University";
            c.Degree = "Bachelor of Science in Information Technology";
            c.GPA = 1.43;
            c.YourSkill = "Creativity, Flexible, Multitasking, Strategic Thinking, Time Management";
            c.Languages = "English, Filipino";
            x.employees.Add(c);




            return x;
        }
    }
}

                
   
