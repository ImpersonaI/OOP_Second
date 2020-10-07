using System;

namespace OOP_second
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Policedatabase punishment = new Policedatabase();

            Owner owner = new Owner();
                        
            Console.WriteLine("Input your fio");
            owner.Fio = Convert.ToString(Console.ReadLine());
            //x180ap09 - a criminal must pay 900
            Console.WriteLine("Input your car`s number");
            owner.Carnumber = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Input your car`s power");
            owner.Power = Convert.ToInt32(Console.ReadLine());

            Policedatabase.Checkforcriminals(owner.Fio, owner.Carnumber, owner.Power);

            Console.ReadKey();

        }
    }
}
