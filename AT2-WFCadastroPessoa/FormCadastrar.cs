using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT2_WFCadastroPessoa
{
    public partial class FormCadastrar : Form
    {
        public FormCadastrar()
        {
            InitializeComponent();
        }

        private void LimparFormulario()
        {
            txtNome.Clear();
            mkdCodigo.Clear();
            mkdCPF.Clear();
            mkdCelular.Clear();
            rdbPessoal.Checked = false;
            rdbComercial.Checked = false;
            rdbRecado.Checked = false;
            txtEmail.Clear();
            chkPossuiFilhos.CheckState = CheckState.Indeterminate;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string Nome = txtNome.Text;

            if (Nome == "")
            {
                MessageBox.Show("Informe o seu nome!!");
                return;
            }
            else
            {
                Nome = txtNome.Text;
            }
            string Codigo = mkdCodigo.Text;

            if (Codigo == "")
            {
                MessageBox.Show("Informe o Codigo!!");
                return;
            }
            else
            {
                Codigo = mkdCodigo.Text;
            }
            string CPF = mkdCPF.Text;

            if (CPF == "")
            {
                MessageBox.Show("Informe o seu CPF!!");
                return;
            }
            else
            {
                Codigo = mkdCPF.Text;
            }
            string DddCelular = mkdCelular.Text;

            if (DddCelular == "")
            {
                MessageBox.Show("Informe o seu telefone!!");
                return;
            }
            else
            {
                Nome = mkdCelular.Text;
            }
            ETipoTelefone tipoTelefone;

            if (rdbPessoal.Checked)
            {
                tipoTelefone = ETipoTelefone.Pessoal;
            }
            else if (rdbComercial.Checked)
            {
                tipoTelefone = ETipoTelefone.Comercial;
            }
            else if (rdbRecado.Checked)
            {
                tipoTelefone = ETipoTelefone.Recado;
            }
            else
            {
                MessageBox.Show("Informe o Tipo de telefone!!");
                return;

            }
            string Email = txtEmail.Text;

            if (Email == "")
            {
                MessageBox.Show("Informe o seu E-mail!!");
                return;
            }
            else
            {
                Email = txtEmail.Text;

            }
            if (chkPossuiFilhos.CheckState == CheckState.Checked)
            {
                bool Ativo = true;
            }
            else if (chkPossuiFilhos.CheckState == CheckState.Unchecked)
            {
                bool Ativo = false;
            }
            else
            {
                MessageBox.Show("Faltou marcar se tem Filhos!");
                return;
            }

            Pessoa p1 = new Pessoa();
            p1.Nome = txtNome.Text;
            p1.CPF = mkdCPF.Text;
            p1.Email = txtEmail.Text;
            p1.Codigo = mkdCodigo.Text;
            p1.TipoTelefone = tipoTelefone;
            p1.Ddd = mkdCelular.Text.Substring(0, 2);
            p1.Telefone = mkdCelular.Text.Substring(2);

            Pessoa.ListaPessoas.Add(p1);


            string mensagem = "Cadastro concluido!"!;
            
            MessageBox.Show(mensagem, "Cadastro Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimparFormulario();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormCadastrar form = new FormCadastrar();
            form.ShowDialog();
        }
    }
    }

