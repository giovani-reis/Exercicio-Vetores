using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixaxaoVetores10._3
{
    internal class Cliente
    {
        public int NumeroQuarto { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public Cliente(int numeroQuarto, string nome, string email)
        {
            NumeroQuarto = numeroQuarto;
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return NumeroQuarto+": "+Nome+", "+Email;
        }
    }
}
