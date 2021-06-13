using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Base;

namespace WindowsFormsApp1.Impl {

    public class Institute : Entity {
        public string InstituteName { get; set; }
        public int YearsInService { get; set; }


        public Institute(): base() {

        }
    }
}
