using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject
{
     class Toyota : Cars
    {
        public string Name { set; get; }
        public int Id { set; get; }
        public string Color { set; get; }
        public double Price { set; get; }

        public void Add_data()
        {
            File.AppendAllText("Toyota.txt", this.Id + " " + this.Name + " " + this.Color + " " + this.Price + "*");
        }

        public string[] Show_result()
        {
            String Toyotaread = File.ReadAllText("Toyota.txt");
            return Toyotaread.Split('*');
        }
    }
}
