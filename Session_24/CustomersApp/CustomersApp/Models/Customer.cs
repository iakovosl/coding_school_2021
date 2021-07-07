using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomersApp.Models {
    public class Customer {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string AFM { get; set; }
        public Boolean Active { get; set; }
        public DateTime EnrollmentDate { get; set; }

       // public ICollection<Enrollment> Enrollments { get; set; }
    }
}
