using System;
using System.Collections.Generic;
using System.Text;

namespace ExCeptions_and_IndexER
{
    internal interface IPersonable
    {
        public string Name{ get; set; }
        public int  Age { get; set; }

    
        public string ShowInfo()
        {
            return Name + Age;
        }
    }
}
