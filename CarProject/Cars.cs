using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject
{
     interface Cars
    {
        string Name { set; get; }
        int Id { set; get; }
        string Color { set; get; }
        double Price { set; get; }

        void Add_data();
        String[] Show_result();
        Enum Car_Color();
    }
}
