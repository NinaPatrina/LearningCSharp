using System;
using System.Collections.Generic;
using System.Text;

namespace AppInterfaces
{
    interface IDisplayable
    {
        string HeaderSymbol { get; }

        void Display();
        void Reset();
    }
}
