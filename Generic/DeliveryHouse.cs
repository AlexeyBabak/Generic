using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class DeliveryHouse
    {

        public T GetBirth<T>(T warmBlooded) where T : WarmBlooded, new()
        {
            var newBorn = new T();
            newBorn.Age = 0;
            newBorn.Height = warmBlooded.Height / 10;

            return newBorn;

        }
    }

    public class Human : WarmBlooded
    {
        public bool IsWoman { get; set; }
        public override bool IsPregnant => true;
    }

    public class Animal : WarmBlooded
    {
        public override bool IsPregnant => true;
    }

    public abstract class WarmBlooded
    {
        public int Age { get; set; }
        public int Height { get; set; }
        public abstract bool IsPregnant { get; }
    }
}
