using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class EstrategiaBombas : IAtacar
    {
        public void Conquistar()
        {
            Console.WriteLine("Tiro bombas");
        }
    }
}
