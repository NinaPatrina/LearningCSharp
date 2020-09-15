using System;
using System.Collections.Generic;
using System.Text;

namespace SupernaturaLInheritance
{
    class Storm: Spell
    {
        public Storm(string essence, bool isStrong, string caster)
        {
            this.Essence = essence;
            this.IsStrong = isStrong;
            this.Caster = caster;
        }
     
        public override string Announce()
        {
            string strong = (IsStrong) ? "strong" : "week";
            return $"{Caster} cast a {strong} {Essence}";
        }

    }
}
