using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationDemo
{
    public class AnnotationClassTest
    {
        public void Display()
        {
            Console.WriteLine("Employee class validation");
            Console.WriteLine("------------");
            // variable initization
            Employee employee = new Employee();
            employee.Name ="Snehal";
            employee.Age =24;
            employee.PhoneNumber="9887887608";
            employee.Email ="snehalbansod@gmail.com";
            
            ////inbuil class for validation to pass objet service and dictionary,
            ////if serivce and dictionaries are not used we can make it as null.
            ValidationContext context = new ValidationContext(employee, null, null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(employee, context, results, true);
            ////foreach loop is used to transversal the date if error occurs prints the message in different colours.
            
            if (!valid)
            {
                foreach(ValidationResult totalResult in results)
                {
                    Console.WriteLine("Member Name : {0}",totalResult.MemberNames.First(),Environment.NewLine);
                    Console.WriteLine("Error msg :: {0}{1}",totalResult.ErrorMessage,Environment.NewLine);


                }
            }
            else
            {
                Console.WriteLine("Name : " +employee.Name+"\n "+"age :"+employee.Age+"\n "+"phone number :"+employee.PhoneNumber+" \n"+"Email :"+employee.Email);
            }
            //// toprint the console in our with colour
            Console.WriteLine("\n Press any key to exit");
            Console.ReadKey();
        }
    }
}
