﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Base;

namespace WindowsFormsApp1.Impl {

    public class Course : Entity {

        // PROPERTIES
        public string Subject { get; set; }
        public int Hours { get; set; }
        public CoursesCategoryEnum Category { get; set; }

        // CONSTRUCTOR
        public Course() 
            : base() {

        }

        // METHODS
    }
}
