using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parque_TeamWork.Clases
{
    class Manilla
    {
        private byte id_interno;
        private ushort nro_puntos;
        private float dinero;


        //Constructor
        public Manilla(byte id_interno, ushort nro_puntos, float dinero)
        {
            Id_interno = id_interno;
            Nro_puntos = nro_puntos;
            Dinero = dinero;
        }

        //Accesor

        public byte Id_interno { get => id_interno; set => id_interno = value; }
        public ushort Nro_puntos { get => nro_puntos; set => nro_puntos = value; }
        public float Dinero { get => dinero; set => dinero = value; }
    }
}
