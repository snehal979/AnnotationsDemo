using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationDemo
{
    public class Employee
    {/// <summary>
    /// name
    /// </summary>
        [Required(ErrorMessage ="Employee{0} is required")]
        [StringLength(100,MinimumLength =3,ErrorMessage ="Name Should be minimum 3 charactor and a maximum of 100 charactor")]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        /// <summary>
        /// age
        /// </summary>
        [Range(18,99,ErrorMessage ="Age should be above 18")]
        public int Age { get; set; }
        /// <summary>
        /// phone number
        /// </summary>

        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string PhoneNumber { get; set; }
        /// <summary>
        /// email
        /// </summary>
       
        [DataType(DataType.EmailAddress)]

        [EmailAddress]
        public string Email { get; set; }
    }
}
