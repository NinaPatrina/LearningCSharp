using System;

namespace RoverControlCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            Rover[] rovers = new Rover[3];

            rovers[0]  = new MoonRover("Lunokhod 1", 1970);
            rovers[1]  = new MoonRover("Apollo 15", 1971);
            rovers[2]  = new MarsRover("Sojourner", 1997);
            Satellite sputnik = new Satellite("Sputnik", 1957);
            DirectAll(rovers);

             static void DirectAll(Rover[] rovers)
            {
                foreach (Rover r in rovers)
                {
                    string a = r.GetInfo();
                    string b = r.Explore();
                    string c = r.Collect();
                    Console.WriteLine($"{a}\n{b}\n{c}\n");

                }
            }
            object[] probes = new object[4];
            probes[0] = new MoonRover("Lunokhod 1", 1970);
            probes[1] = new MoonRover("Apollo 15", 1971);
            probes[2] = new MarsRover("Sojourner", 1997);
            probes[3] = new Satellite("Sputnik", 1957);

            foreach (object o in probes)
            {
                Console.WriteLine($"Tracking a {o.GetType()} of object\n");
            }
            IDirectable[] probe = new IDirectable[4];
            probe[0] = new MoonRover("Lunokhod 1", 1970);
            probe[1] = new MoonRover("Apollo 15", 1971);
            probe[2] = new MarsRover("Sojourner", 1997);
            probe[3] = new Satellite("Sputnik", 1957);
            
            DirectAll(probe);

            static  void  DirectAll(IDirectable[] probe)
            {
                foreach (var r in probe)
                {
                    string a = r.GetInfo();
                    string b = r.Explore();
                    string c = r.Collect();
                    Console.WriteLine($"{a}\n{b}\n{c}\n");

                }
            }
        }
    }
}
