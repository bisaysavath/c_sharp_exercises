﻿using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Packt.CS7
{
    public class Person
    {
        public Person(decimal initialSalary)
        {
            Salary = initialSalary;
        }

        public Person() { }

        [XmlAttribute("fname")]
        public string FirstName { get; set; }
        [XmlAttribute("lanem")]
        public string LastName { get; set; }
        [XmlAttribute("dob")]
        public DateTime DateOfBirth { get; set; }
        public HashSet<Person> Children { get; set; }
        protected decimal Salary { get; set; }
    }
}