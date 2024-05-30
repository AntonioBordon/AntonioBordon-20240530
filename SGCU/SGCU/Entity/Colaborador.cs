using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGCU.Class
{
    public class Colaborador
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public Unidade UnidadeAssociada { get; set; }
        public  Usuario UsuarioAssociado { get; set; }
    }
}
