using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlankPlanet
{
    class typewriter
    {
        public void Typewrite(string message, int speed)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(speed);
            }
        }
    }
}
