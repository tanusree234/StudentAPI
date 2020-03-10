using System.Dynamic;
using System;
namespace StudentApi.Models
{
    public class Student
    {   public string dob;
        public long Id { get; set; }
        public string Name { get; set; }
        public string Address{get;set;}
        public string DOB{get{return dob;} set{dob =Convert.ToString(Convert.ToDateTime(value));}}
    }
}