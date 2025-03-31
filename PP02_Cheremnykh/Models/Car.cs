using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP02_Cheremnykh.Models
{
    public class Car
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Marks { get; set; }
        public string Gos_Number {  get; set; }
        public string Voditel {  get; set; }
        public Car(int id, string name, string marks, string gos_Number, string voditel)
        {
            Id = id;
            Name = name;
            Marks = marks;
            Gos_Number = gos_Number;
            Voditel = voditel;
        }
    }
}
