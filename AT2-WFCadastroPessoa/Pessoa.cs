using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT2_WFCadastroPessoa { 

    public enum ETipoTelefone
{
    Pessoal = 1,
    Comercial,
    Recado
}

    public class Pessoa
    {
        
        public static List<Pessoa> ListaPessoas = new List<Pessoa>();

        public Pessoa(string? Nome, string? codigo, string? cPF, string? email, ETipoTelefone tipoTelefone, string? ddd, string? telefone, bool possuiFilhos)
        {
            Nome = Nome;
            Codigo = codigo;
            CPF = cPF;
            Email = email;
            TipoTelefone = tipoTelefone;
            Ddd = ddd;
            Telefone = telefone;
            PossuiFilhos = possuiFilhos;
        }

        public Pessoa() { }

         public string? Nome { get; set; }
         public string? Codigo { get; set; }
        public string? CPF { get; set; }
        public string? Email { get; set; }
        public ETipoTelefone TipoTelefone { get; set; }
        public string? Ddd { get; set; }
        public string? Telefone { get; set; }
        public bool PossuiFilhos { get; set; }
    }
}
