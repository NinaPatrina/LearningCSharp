using System;
using System.Collections.Generic;
using System.Text;

namespace SupernaturaLInheritance
{
    abstract class Spell
    {
        public string Essence { get; protected set; }
        public bool IsStrong { get; protected set; }
        public string Caster { get; protected set; }
        public abstract string Announce();
        
    }
}
