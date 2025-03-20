namespace AT2_WFCadastros
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        private void mnsCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastrar form = new FormCadastrar();
            form.ShowDialog();
        }

        

        private void mnsSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnsListar_Click_1(object sender, EventArgs e)
        {
            FormLista form = new FormLista();
            form.ShowDialog();
        }
    }
}
