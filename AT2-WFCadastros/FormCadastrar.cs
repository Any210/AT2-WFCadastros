using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AT2_WFCadastros
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
            rtbDescricao.Clear();
            dtpDataCadastro.Value = DateTime.Now;
            chkAtivo.CheckState = CheckState.Indeterminate;
        }

        public void Alerta(string mensagem = "")
        {
            MessageBox.Show(mensagem, "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void Erro(string mensagem = "")
        {
            MessageBox.Show(mensagem, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void Sucesso(string mensagem = "")
        {
            MessageBox.Show(mensagem, "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Info(string mensagem)
        {
            MessageBox.Show(mensagem, "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(mkdCodigo.Text))
            {
                Erro("Campo Vazio");
                return;
            }
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                Erro("Campo Vazio");
                return;
            }
            if (string.IsNullOrEmpty(rtbDescricao.Text))
            {
                Erro("Campo Vazio");
                return;
            }
            if (string.IsNullOrEmpty(dtpDataCadastro.Text))
            {
                Erro("Campo Vazio");
                return;
            }


            if (chkAtivo.CheckState == CheckState.Checked)
            {
                bool Ativo = true;
            }
            else if (chkAtivo.CheckState == CheckState.Unchecked)
            {
                bool Ativo = false;
            }
            else
            {
                MessageBox.Show("Faltou marcar se está ativo!");
                return;
            }
            Categoria Ca = new Categoria();
            Ca.Codigo = mkdCodigo.Text;
            Ca.Nome = txtNome.Text;
            Ca.Descricao = rtbDescricao.Text;
            Ca.DataCadastro = dtpDataCadastro.Value;

            Categoria.ListaCategorias.Add(Ca);

            MessageBox.Show("Cadastro realizado com sucesso!", "Info1", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimparFormulario();
        }



        
    }
}
