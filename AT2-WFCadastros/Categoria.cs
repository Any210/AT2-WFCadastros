using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT2_WFCadastros
{
    public class Categoria
    {

        public Categoria(string codigo, string? nome, string? descricao, bool status, DateTime dataCadastro)
        {
            Codigo = codigo;
            Nome = nome;
            Descricao = descricao;
            Status = status;
            DataCadastro = dataCadastro;
        }
        public Categoria() { }

        public static List<Categoria> ListaCategorias = new List<Categoria>();

        public string Codigo { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public bool Status { get; set; }
        public DateTime DataCadastro { get; set; }


       

        
    }

}
