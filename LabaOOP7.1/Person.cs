using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace LabaOOP5
{
    public class Person: IComparable<Person>, ICloneable
    {
        const string pattern = @"^[\p{L}ʼ'’\-]+$";
        const string datepattern = @"^\d{4},\d{2},\d{2}$";
        private string name;
        private string lastName;
        private DateTime birthdate;
        public Person()
        {
            this.name = "NoName";
            this.lastName = "NoLastName";
            this.birthdate = DateTime.Now;
        }
        public Person(string name, string lastName, DateTime birthdate)
        {
            this.name = Regex.IsMatch(name, pattern) ? name : "No name";
            this.lastName = Regex.IsMatch(lastName, pattern) ? lastName : "No last name";

           
            this.birthdate = birthdate;
        }
        public string Name
        {
            get { return this.name; }
            set {if (value != String.Empty&&Regex.IsMatch(value,pattern)) this.name = value;
                else throw new Exception("Wrong name format string");
            }

        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value != String.Empty && Regex.IsMatch(value, pattern)) this.lastName = value;
                else throw new Exception("Empty string");
            }
        }
        public DateTime Birthdate
        {
            get { return this.birthdate; }
            set {
                if (Regex.IsMatch(value.ToString("yyyy-MM-dd"), datepattern))
                {
                    this.birthdate = value;
                }
                else
                {
                    throw new Exception("Invalid birthdate format.");
                }
            }
        }
        public int BirthYear
        {
            get { return this.birthdate.Year; }
            set { this.birthdate = new DateTime(value, this.birthdate.Month, this.birthdate.Day); }
        }
        public  override string ToString()
        {
            return Name + " " + LastName +" "+ "Date of birth:" + birthdate;
        }
        public int CompareTo(Person other)
        {
            if (other == null) return 1;
            return (this.name == other.name && this.lastName == other.lastName && this.birthdate == other.birthdate) ? 0 : -1;
        }
        public object Clone()
        {
            return new Person(this.name, this.lastName, this.birthdate);
        }
        public virtual string ToShortString()
        {
            return $"{Name} {lastName}";
        }
        }
}
