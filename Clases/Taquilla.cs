using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parque_TeamWork.Clases
{
    class Taquilla
    {
        private byte id;
        private byte nro_manillas_taquilla;

        //Constructor

        public Taquilla(byte id, byte nro_manillas_taquilla)
        {
            this.id = id;
            this.nro_manillas_taquilla = nro_manillas_taquilla;
        }
        public byte Id { get => id; set => id = value; }
        public byte Nro_manillas_taquilla { get => nro_manillas_taquilla; set => nro_manillas_taquilla = value; }
    }
}
