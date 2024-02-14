using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Human
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        public Human()
        {
        }

        public Human(string sor)
        {
            string[] splitSor = sor.Split(';');
            Name = splitSor[0];
            Gender = splitSor[1];
            Age = Convert.ToInt32(splitSor[2]);
        }

        public override string? ToString()
        {
            return "{" + Name + "(" + Gender + ")" + Age + "}";
        }
    }
}
