using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class EstrategiaOjitos : IAtacar
    {
        public void Conquistar()
        {
            Console.Write("Tiro ojos de fuego");
        }
    }
}
