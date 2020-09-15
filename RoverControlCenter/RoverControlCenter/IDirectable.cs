using System;
using System.Collections.Generic;
using System.Text;

namespace RoverControlCenter
{
    interface IDirectable
    {
        string GetInfo();
        string Explore();
        string Collect();

    }
}
