using System;
using System.Collections.Generic;
using System.Text;

namespace SupernaturaLInheritance
{
    class Pupil
    {
        public Pupil(string title)
        {
            this.Title = title;
        }
        public Pupil(string title, string origin)
        {
            this.Title = title;
            this.Origin = origin;
        }
        public string Origin { get; protected set; }
        public string Title { get; protected set; }

        public Storm CastWindStorm()
        {
            Storm st = new Storm("wind storm", false, this.Title);
            return st;
        }
    }
}
