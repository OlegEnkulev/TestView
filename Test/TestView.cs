using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Test
{
    public class TestView
    {
        public string Color { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public string Manufacturer { get; set; }
        public string Cost { get; set; }
        public int Count { get; set; }

        public TestView(string name, string desc, string pic, string manufact, string cost, int count)
        {
            if (pic != null)
            {
                Picture = "/Images/" + pic;
            }
            else
            {
                Picture = "/Images/null.png";
            }

            Name = name;
            Description = desc;
            Manufacturer = manufact;
            Cost = cost;
            Count = count;

            if (count == 0)
            {
                Color = "Gray";
            }
            else
            {
                Color = "White";
            }
        }
    }
}
