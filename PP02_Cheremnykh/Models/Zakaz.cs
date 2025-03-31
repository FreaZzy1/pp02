using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP02_Cheremnykh.Models
{
    public class Zakaz
    {
        public int Id {  get; set; }
        public string Object { get; set; }
        public string Time {  get; set; }
        public int Price {  get; set; }
        public int Voditel_Id { get; set; }
        public int Car_Id {  get; set; }   
        public Zakaz():base()
        {
            this.Id = Id;
            this.Object = Object;
            this.Time = Time;
            this.Price = Price;
            this.Voditel_Id = Voditel_Id;
            this.Car_Id = Car_Id;
        }
    }
}
