using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper1
{
    class Program
    {
      
        static void Main(string[] args)
        {
            //Dog objDog = new Dog();
            //objDog.Eat();
            //objDog.Feature();
            //objDog.Noise();
            //Console.ReadLine();
            //
            //Cat objCat = new Cat();
            //objCat.Meo();
            //objCat.DoSomething();
            //Console.ReadLine();
            //
            Cat objcat = new Cat();
            objcat.Food = "Mouse";
            objcat.Activity = "laze around";
            Console.WriteLine("The Cat loves to eat " + objcat.Food + ".");
            Console.WriteLine("The Cat loves to " + objcat.Activity + ".");
            Console.ReadLine();
        }
    }
}
