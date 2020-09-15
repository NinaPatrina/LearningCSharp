using System;

namespace Duck
{
    public abstract class Duck
    {
        public IFlyBehavior flybehavior;
        public IQuackBehavior quakBehavior;
        public Duck()
        {

        }
        public abstract void Display();
        public void performFly()
        {
            flybehavior.Fly();
        }
        public void performQuack()
        {
            quakBehavior.Quack();
        }
        public void swim()
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
        public override void Display() { Console.WriteLine("Im a real Mallard Duck"); }
        
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
        public static void main (string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.performQuack();
            mallard.performFly();
        }
    }
}
