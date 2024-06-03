using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsControlMVVM.Models
{
    public class ProductViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public ProductViewModel(string n, string d, double p)
        {
            Name = n;
            Description = d;
            Price = p;
        }
    }
}
