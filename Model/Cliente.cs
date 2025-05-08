using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA09.Model
{
    internal class Cliente
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }

        public override string ToString()
        {
            return "ID:" + Id + "Nome:" + Nome + "E-mail" + Email + "Idade" + Idade; 
        }

        
    }
}
