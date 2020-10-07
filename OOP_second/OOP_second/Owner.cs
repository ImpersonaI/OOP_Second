using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OOP_second
{
    public class Owner : Car
    {

        private string fio;
        
        public string Fio
        {

            get
            {
                return fio;
            }
            set
            {
                fio = value;
            }
        }
        
               
        
    }
}
