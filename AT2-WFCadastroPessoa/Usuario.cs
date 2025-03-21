using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT2_WFCadastroPessoa
{
    public class Usuario
    {
        public Usuario() { }

        public static List<Usuario> ListaUsuarios = new List<Usuario>();

        public Usuario(string? codigo, string? login, string? senha)
        {
            Codigo = codigo;
            Login = login;
            Senha = senha;
        }

        public string? Codigo { get; set; }
        public string? Login { get; set; }
        public string? Senha { get; set; }
    }
}
