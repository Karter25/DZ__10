using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{

    class Time
    {
        private int hours = 0;
        private int minutes = 0;
        private int seconds = 0;

        public void GetInfo()
        {
            Console.WriteLine($"Час:{hours} , Минута:{minutes}, Секунда:{seconds}");
        }
        public Time() { }
        public int Hours
        {
            get { return hours; }

            set
            {
                if (value > 59)
                {
                    hours = 0;
                }

                else hours = value;
            }
        }
        public int Minutes
        {
            get { return minutes; }

            set
            {
                if (value > 59)
                {
                    minutes = 0;
                }

                else minutes = value;
            }
        }
        public int Seconds
        {
            get { return seconds; }
            set
            {
                if (value > 59)
                {
                    seconds = 0;
                }

                else seconds = value;
            }
        }

        public void Info()
        {
            Console.WriteLine($"Час:{hours} , Минута:{minutes}, Секунда:{seconds}");
        }


        class Program
        {
            static void Main(string[] args)
            {
                Time fg = new Time();
                fg.GetInfo();
                fg.Hours = 1;
                fg.Minutes = 2;
                fg.Minutes = 3;

                Console.ReadKey();
            }
        }
    }
}
