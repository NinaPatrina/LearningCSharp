using System;
using System.Collections.Generic;
using System.Text;

namespace SupernaturaLInheritance
{
    class Archmage: Mage
    {
        public Archmage(string title): base(title)
        {
            this.Title = title;
        }
        public Archmage(string title, string origin): base(title,origin)
        {
            this.Title = title;
            this.Origin = origin;
        }

        public override Storm CastRainStorm()
        {
            Storm st = new Storm("rain storm", true, this.Title);
            return st;
        }
        public Storm CastLightningStorm()
        {
            Storm st = new Storm ("lightning storm", true, this.Title);
            return st;
        }
    }
}
