using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSGPLogic
{
    class Setup
    {
        private string Name { get; set; }

        private bool Public { get; set; }

        private List<Item> Items { get; set; }

        public Setup() { }

        public Setup(string name, bool _public, List<Item> items)
        {
            this.Name = name;
            this.Public = _public;
            this.Items = items;
        }
    }
}
