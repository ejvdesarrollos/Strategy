using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            //creo el contexto de la estrategia
            EstrategiasDeAtaqueContexto contexto = new EstrategiasDeAtaqueContexto();

            //defino cómo voy a ejecutar. Aquí es intercambiable.
            //en tiempo de ejecución cambia el tipo de objeto, pero internamente implementan la misma interfaz
            contexto.AtacarConBombas();

            //actúo
            contexto.Atacar();

            contexto.AtacarConOjitos();

            contexto.Atacar();

            EstrategiasDeAtaqueContexto contexto2 = new EstrategiasDeAtaqueContexto((int)EstrategiasDeAtaqueContexto.ATAQUE.Bombas);

            contexto2.Atacar();
        }
    }
}
