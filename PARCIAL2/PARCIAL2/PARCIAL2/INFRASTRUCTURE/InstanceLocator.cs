using System;
using System.Collections.Generic;
using System.Text;

namespace PARCIAL2.INFRASTRUCTURE
{
    using PARCIAL2.VIEWMODELS;
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            Main = new MainViewModel();
        }
    }
}
