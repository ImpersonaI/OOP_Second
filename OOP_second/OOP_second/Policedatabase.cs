using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_second
{
    public class Policedatabase
    {

        static double[] baseofpunishment = new double[10];
        static string[] baseofcriminals = new string[10];
               
        //input the base of punishment 

        public Policedatabase() 
        {
            for (int i = 0; i < 10; i++)
            {
                baseofpunishment[i] = i * 100 + 100;       
            }
            baseofcriminals[8] = "x180ap09";
        }
        
        public static void Checkforcriminals(string fio, string number, int power)
        {

            bool flag = false;
            for (int i = 0; i < 10; i++)
            {                               

                if (number == baseofcriminals[i])
                {
                    flag = true;
                    Console.WriteLine(fio + ", your car`s power = " + power + " and you must pay " + baseofpunishment[i] + " rubles for the crime you have commited");
                }
                                
            }

            if (flag == false)
            {
                Console.WriteLine(fio + ", your car`s car = " + power + " and you must pay nothing");
            }
        }

    }
}
