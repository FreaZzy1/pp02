using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP02_Cheremnykh.Models
{
    public class Drivers
    {
        public int Id {  get; set; }
        public string FIO { get; set; }
        public DateTime Birthday { get; set; }
        public int Pasport {  get; set; }
        public int Number {  get; set; }
        public string Organization {  get; set; }
        public Drivers(int Id, string FIO, DateTime Birthday, int Pasport, int Number, string Oraganization)
        {
            this.Id = Id;
            this.FIO = FIO;
            this.Birthday = Birthday;
            this.Pasport = Pasport;
            this.Number = Number;
            this.Organization = Organization;
        }
    }
}
