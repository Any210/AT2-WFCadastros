namespace AT2_WFCadastroPessoa
{
    partial class FormCadastrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastrar));
            mkdCodigo = new MaskedTextBox();
            lblCodigo = new Label();
            lblCPF = new Label();
            lblNome = new Label();
            lblEmail = new Label();
            lblCelular = new Label();
            mkdCPF = new MaskedTextBox();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            mkdCelular = new MaskedTextBox();
            gbxTTelefone = new GroupBox();
            rdbRecado = new RadioButton();
            rdbComercial = new RadioButton();
            rdbPessoal = new RadioButton();
            chkPossuiFilhos = new CheckBox();
            btnVoltar = new Button();
            btnSalvar = new Button();
            gbxTTelefone.SuspendLayout();
            SuspendLayout();
            // 
            // mkdCodigo
            // 
            mkdCodigo.Location = new Point(33, 50);
            mkdCodigo.Mask = "0000";
            mkdCodigo.Name = "mkdCodigo";
            mkdCodigo.Size = new Size(100, 23);
            mkdCodigo.TabIndex = 0;
            mkdCodigo.ValidatingType = typeof(int);
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(33, 23);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Codigo";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(172, 23);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(28, 15);
            lblCPF.TabIndex = 2;
            lblCPF.Text = "CPF";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(33, 94);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(96, 15);
            lblNome.TabIndex = 3;
            lblNome.Text = "Nome Completo";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(33, 164);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "E-mail";
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(33, 232);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(73, 15);
            lblCelular.TabIndex = 5;
            lblCelular.Text = "DDD/Celular";
            // 
            // mkdCPF
            // 
            mkdCPF.Location = new Point(172, 50);
            mkdCPF.Mask = "000.000.000-00";
            mkdCPF.Name = "mkdCPF";
            mkdCPF.Size = new Size(100, 23);
            mkdCPF.TabIndex = 6;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(33, 124);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(239, 23);
            txtNome.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(33, 192);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(239, 23);
            txtEmail.TabIndex = 8;
            // 
            // mkdCelular
            // 
            mkdCelular.Location = new Point(33, 260);
            mkdCelular.Mask = "(00) 00000-0000";
            mkdCelular.Name = "mkdCelular";
            mkdCelular.Size = new Size(100, 23);
            mkdCelular.TabIndex = 9;
            // 
            // gbxTTelefone
            // 
            gbxTTelefone.Controls.Add(rdbRecado);
            gbxTTelefone.Controls.Add(rdbComercial);
            gbxTTelefone.Controls.Add(rdbPessoal);
            gbxTTelefone.Location = new Point(172, 232);
            gbxTTelefone.Name = "gbxTTelefone";
            gbxTTelefone.Size = new Size(100, 94);
            gbxTTelefone.TabIndex = 10;
            gbxTTelefone.TabStop = false;
            gbxTTelefone.Text = "Tipo Telefone";
            // 
            // rdbRecado
            // 
            rdbRecado.AutoSize = true;
            rdbRecado.Location = new Point(3, 69);
            rdbRecado.Name = "rdbRecado";
            rdbRecado.Size = new Size(64, 19);
            rdbRecado.TabIndex = 2;
            rdbRecado.TabStop = true;
            rdbRecado.Text = "Recado";
            rdbRecado.UseVisualStyleBackColor = true;
            // 
            // rdbComercial
            // 
            rdbComercial.AutoSize = true;
            rdbComercial.Location = new Point(4, 46);
            rdbComercial.Name = "rdbComercial";
            rdbComercial.Size = new Size(79, 19);
            rdbComercial.TabIndex = 1;
            rdbComercial.TabStop = true;
            rdbComercial.Text = "Comercial";
            rdbComercial.UseVisualStyleBackColor = true;
            // 
            // rdbPessoal
            // 
            rdbPessoal.AutoSize = true;
            rdbPessoal.Location = new Point(6, 24);
            rdbPessoal.Name = "rdbPessoal";
            rdbPessoal.Size = new Size(64, 19);
            rdbPessoal.TabIndex = 0;
            rdbPessoal.TabStop = true;
            rdbPessoal.Text = "Pessoal";
            rdbPessoal.UseVisualStyleBackColor = true;
            // 
            // chkPossuiFilhos
            // 
            chkPossuiFilhos.AutoSize = true;
            chkPossuiFilhos.Location = new Point(33, 307);
            chkPossuiFilhos.Name = "chkPossuiFilhos";
            chkPossuiFilhos.Size = new Size(99, 19);
            chkPossuiFilhos.TabIndex = 11;
            chkPossuiFilhos.Text = "Possui Filhos?";
            chkPossuiFilhos.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVoltar.Location = new Point(84, 364);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(79, 32);
            btnVoltar.TabIndex = 12;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextAlign = ContentAlignment.MiddleRight;
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(185, 364);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(76, 32);
            btnSalvar.TabIndex = 13;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FormCadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 438);
            Controls.Add(btnSalvar);
            Controls.Add(btnVoltar);
            Controls.Add(chkPossuiFilhos);
            Controls.Add(gbxTTelefone);
            Controls.Add(mkdCelular);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(mkdCPF);
            Controls.Add(lblCelular);
            Controls.Add(lblEmail);
            Controls.Add(lblNome);
            Controls.Add(lblCPF);
            Controls.Add(lblCodigo);
            Controls.Add(mkdCodigo);
            Name = "FormCadastrar";
            Text = "FormCadastrar";
            gbxTTelefone.ResumeLayout(false);
            gbxTTelefone.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mkdCodigo;
        private Label lblCodigo;
        private Label lblCPF;
        private Label lblNome;
        private Label lblEmail;
        private Label lblCelular;
        private MaskedTextBox mkdCPF;
        private TextBox txtNome;
        private TextBox txtEmail;
        private MaskedTextBox mkdCelular;
        private GroupBox gbxTTelefone;
        private CheckBox chkPossuiFilhos;
        private Button btnVoltar;
        private Button btnSalvar;
        private RadioButton rdbRecado;
        private RadioButton rdbComercial;
        private RadioButton rdbPessoal;
    }
}