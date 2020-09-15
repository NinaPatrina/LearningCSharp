using System;
using System.Collections.Generic;
using System.Text;

namespace SupernaturaLInheritance
{
    class Mage: Pupil
    {
        public Mage(string title): base (title)
        {
            this.Title = title;
        }
        public Mage(string title, string origin): base (title,origin)
        {
            this.Title = title;
            this.Origin = origin;
        }
        public virtual Storm CastRainStorm() 
        {
            Storm st = new Storm("rain storm", false, this.Title);
            return st;
        }

    }
}
