using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var deliveryHouse = new DeliveryHouse();

            var animalMother = new Animal { Age = 33, Height = 180 };
            var humanMother = new Human { Age = 33, Height = 180 };

            deliveryHouse.GetBirth(animalMother);
            deliveryHouse.GetBirth(humanMother);

            var babyAnimal = deliveryHouse.GetBirth(animalMother);
            var humanAnimal = deliveryHouse.GetBirth(humanMother);
        }
    }
}
