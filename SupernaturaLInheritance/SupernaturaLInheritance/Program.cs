using System;

namespace SupernaturaLInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Storm[] array = new Storm[5];
            array[0] = new Storm("storm", false, "Zul'rajas");
            Pupil p = new Pupil("Mezil-kree");
            array[1] = p.CastWindStorm();
            Mage m = new Mage("Gul’dan");
            array[2] = m.CastWindStorm();
            Archmage a = new Archmage("Nielas Aran");
            array[3] = a.CastRainStorm();
            array[4] = a.CastLightningStorm();
            foreach (Storm s in array)
            {
                Console.WriteLine(s.Announce());
            }




        }
    }
}
