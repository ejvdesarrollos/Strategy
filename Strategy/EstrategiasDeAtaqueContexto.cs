using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class EstrategiasDeAtaqueContexto
    {
        //Creo una variable privada de tipo Inerface principal
        private IAtacar oAtacar;


        //Genero los métodos para que implementen esa interfaz de acuerdo a la estrategia.
        public void AtacarConOjitos()
        {
            this.oAtacar = new EstrategiaOjitos();
        }

        public void AtacarConBombas()
        {
            this.oAtacar = new EstrategiaBombas();
        }

        //Como ambos entiende IAtacar, tienen el mismo método.
        public void Atacar()
        {
            this.oAtacar.Conquistar();
        }

        public EstrategiasDeAtaqueContexto()
        {

        }

        public enum ATAQUE{
            Ojos = 1, Bombas
        }

        public EstrategiasDeAtaqueContexto(int tipo)
        {
            switch(tipo)
            {
                case (int)ATAQUE.Bombas: this.oAtacar = new EstrategiaBombas(); break;
                case (int)ATAQUE.Ojos: this.oAtacar = new EstrategiaOjitos(); break;
                default: this.oAtacar = null; break;
            }
        }
    }
}
