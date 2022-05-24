using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject
{
     class Hyundai :Cars
    {
       public string Name { set; get; }
       public int Id { set; get; }
        public string Color { set; get; }
       public double Price { set; get; }

       public void Add_data()
        {
            File.AppendAllText("Hyundai.txt",this.Id+" "+this.Name+" "+this.Color+" "+this.Price+"*");
        }

        public string[] Show_result()
        {
            String Hyundairead = File.ReadAllText("Hyundai.txt");
            return Hyundairead.Split('*');
        }

    }
}
