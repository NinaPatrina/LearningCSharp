using System;

namespace DevilAngel
{
    public class SwingObserverExample
    {
        public event EventHandler Go; // event
        public void StartProcess()
        {
            Console.WriteLine("Should I do it?");
            Go?.Invoke(this, EventArgs.Empty);
        }
    }
    class Test
    {
        public static void Main(string[] args)
        {
            SwingObserverExample example = new SwingObserverExample();
            example.Go += (sender, ea) => Console.WriteLine("Don't do it you might regret it");
            example.Go += devil_Go;
            example.StartProcess();
        }

        private static void devil_Go(object sender, EventArgs e)
        {
            Console.WriteLine("Come on, do it");
        }
        /*
        private static void angel_Go(object sender, EventArgs e)
        {
            Console.WriteLine("Don't do it you might regret it");
        }
        /**/
    }
}
//https://www.tutorialsteacher.com/csharp/csharp-event

