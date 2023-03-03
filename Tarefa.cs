using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRJAgenda
{
    internal class Tarefa
    {
        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public DateTime dataInicio { get; set; }

        public DateTime dataFinal { get; set; }
    }
}
