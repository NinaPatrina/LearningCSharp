using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DatingSite
{
    class Profile
    {
        string name;
        int age;

        public Profile(string country = "unknown", string pronounce = "they/them")
        {
            if (string.IsNullOrWhiteSpace(country))
            {
                throw new ArgumentException(nameof(country));
            }

            this.City = "default city";
            this.Country = country;
            this.Pronounce = pronounce;
            this.Hobbies = null;
        }
        public string Name { get { return name; } set { name = value; } }
        public int Age
        {
            get { return age; }
            set { if (age < 18) age = value; else throw new ArgumentOutOfRangeException(); }
        }

        private string City { get; set; }
        private string Country { get; set; }
        private string Pronounce { get; set; }
        private string[] Hobbies { get; set; }
        public void SetHobbies(string[] hobbies)
        {
            this.Hobbies = hobbies;
        }
        public string ViewProfile()
        {
            string result = $"{this.Name}   { this.Age.ToString()}    {this.City}   {this.Country}    {this.Pronounce}";
            string hobby = "";
            if (Hobbies != null) hobby = string.Concat(Hobbies);
            return result + hobby;
        }

    }
}
