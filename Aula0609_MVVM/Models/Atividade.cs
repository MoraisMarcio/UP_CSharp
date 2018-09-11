using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0609_MVVM.Models
{
    public class Atividade
    {
        public int AtividadeID { get; set; }
        public string Titutlo { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
    }
}
