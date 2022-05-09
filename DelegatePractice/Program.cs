using System;

namespace DelegatePractice
{
    delegate bool Condition(int value);
    class Program
    {
        int[] testArray;

        static void Main(string[] args)
        {
            
        }

        //public int GetValue(Condition condition)
        //{
            
        //}
    }

    class Hero
    {
        private int _health;

        public void TakeDamage(int amount)
        {
            _health -= amount;
        }
    }
}
