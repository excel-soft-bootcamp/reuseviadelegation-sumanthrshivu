using System;
using System.Collections.Generic;
using System.Text;

namespace ResueViaDelegation
{
    public class Traveller
    {
        public void Hike(IGPS gps)
        {
            gps.Navigate();

        }
    }
}
