using System;
using System.Collections.Generic;
using System.Text;

namespace ResueViaDelegation
{
    public class PhotoGrapher
    {
        public void Capture(ICamera camera)
        {

            camera.Click();
        }

    }
}
