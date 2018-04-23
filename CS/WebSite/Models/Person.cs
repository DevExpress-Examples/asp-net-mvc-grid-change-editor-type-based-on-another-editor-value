using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DXWebApplication1.Models {
    public class Person {
        public Person() {
            PersonID = 0;
            FirstName = string.Empty;
            MiddleName = string.Empty;
            LastName = string.Empty;
        }

        public Person(int id, String firstName, string middleName, String lastName) {
            this.PersonID = id;
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
        }

       
        public int PersonID { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }


    }
}