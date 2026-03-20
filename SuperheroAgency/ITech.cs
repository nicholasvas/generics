using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAgency
{
    internal interface ITech
    {
        public string Gadget { get; set; }

        void Hack(string alias);
    }
}
