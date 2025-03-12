using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_codeFirstApproach.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Product> Products { get; set; } = new List<Product>();
    }
}
