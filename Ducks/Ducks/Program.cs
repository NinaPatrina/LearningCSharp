using System;

namespace Ducks
{
    public abstract class Duck
    {
        public IFlyBehavior flybehavior;
        public IQuackBehavior quakBehavior;
        public Duck()
        {

        }
        public abstract void Display();
        public void PerformFly()
        {
            flybehavior.Fly();
        }
        public void SetFlyBehavior(IFlyBehavior fb)
        {
            flybehavior = fb;
        }
          public void PerformQuack()
        {
            quakBehavior.Quack();
        }
        public void SetQuackBehavior(IQuackBehavior qb)
        {
            quakBehavior = qb;
        }
        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

    }
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quakBehavior = new QuackLowd();
            flybehavior = new FlyWithWings();
        }
        public override void Display() { Console.WriteLine("I'm a real Mallard Duck"); }

    }
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flybehavior = new FlyNoWay();
            quakBehavior = new QuackLowd();
        }
        public override void Display() { Console.WriteLine("I'm a model duck"); }

    }
    public interface IFlyBehavior
    {
        void Fly();
    }
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!!");

        }
    }
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly!");

        }
    }
    public class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a rocket!");

        }
    }
    public interface IQuackBehavior
    {
        void Quack();
    }
    public class QuackLowd : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack!!");

        }
    }
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("silence");

        }
    }
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squick");

        }
    }
    public class MiniDuckSimulator
    {
        public static void Main(string[] args)
        {
           /* Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();*/

            Duck model = new ModelDuck();
            model.PerformFly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();

        }
    }
}
