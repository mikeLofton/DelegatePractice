using System;

namespace DelegatePractice
{
    delegate bool Condition(int value);
    delegate void Event(params object[] args);
    class Program
    {
        int[] testArray;

        static void Main(string[] args)
        {
            Hero hero = new Hero();
            hero.OnTakeDamage += args => Console.WriteLine(args[0]);
        }

        //public int GetValue(Condition condition)
        //{
            
        //}
    }

    class Hero
    {
        private int _health;
        public Event OnTakeDamage;

        public void TakeDamage(int amount)
        {
            _health -= amount;
            OnTakeDamage.Invoke(_health, amount);
        }
    }
}
