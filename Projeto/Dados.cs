using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    class Dados
    {
        public string Id { get; set; }
        public string Genero { get; set; }
        public string Nome { get; set; }
        public string Data { get; set; }
        public float Segurança { get; set; }


        public override string ToString()
        {
            return "Id:" + Id + " Genero:" + Genero + " Nome:" + Nome + " Data:" + Data + " Numero de segurança:" + Segurança;
        }





    }
}
