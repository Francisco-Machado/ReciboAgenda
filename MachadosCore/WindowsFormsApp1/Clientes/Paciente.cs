using System;
using System.Collections.Generic;
using System.Text;

namespace MachadosCore.Clientes
{
    public class Paciente : Cliente
    {
      
        public string  DiaDaSemana  { get; set; }

        public DateTime Horario { get; set; }
        public string PlanoDeSaude { get; set; }
        public string DataDaPrimeiraConsulta { get; set; }

        public DateTime UltimoRecibo { get; set; }

        public int Indice { get; set; }

        public int MaiorMenor { get; set; }
    }
}

