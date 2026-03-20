using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAgency
{
    public interface IFly
    {
        double FlightSpeed { get; set; }
        double MaxHeight { get; set; }

        void Fly(string alias);
    }
}
