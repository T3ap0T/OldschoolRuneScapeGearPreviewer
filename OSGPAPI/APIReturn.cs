using System;
using System.Collections.Generic;

namespace OSGPAPI
{
    public class APIReturn
    {
        public string Icon { get; set; }

        public string Icon_large { get; set; }

        public int Id { get; set; }

        public string Type { get; set; }

        public string TypeIcon { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Current current { get; set; }

        public bool Members { get; set; }

    }
}
