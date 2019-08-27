using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarroOuCaminhao
{
    class Veiculo
    {
        private string mod, placa, km;
        private bool carro;
        public string Infmod {
            set { mod = value; }
            get { return  mod; }
        }
        public string Infplaca
        {
            set { placa = value; }
            get { return placa; }
        }
        public string Infkm
        {
            set { km = value; }
            get { return km; }
        }
        public bool Infcarro
        {
            set { carro = value; }
            get { return carro; }
        }
    }
}
