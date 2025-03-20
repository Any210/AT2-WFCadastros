namespace AT2_WFCadastros
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
            lblNome = new Label();
            lblDescricao = new Label();
            chkAtivo = new CheckBox();
            rtbDescricao = new RichTextBox();
            txtNome = new TextBox();
            dtpDataCadastro = new DateTimePicker();
            lblDataCadastro = new Label();
            lblStatus = new Label();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // mkdCodigo
            // 
            mkdCodigo.Location = new Point(52, 60);
            mkdCodigo.Mask = "0000";
            mkdCodigo.Name = "mkdCodigo";
            mkdCodigo.Size = new Size(69, 23);
            mkdCodigo.TabIndex = 0;
            mkdCodigo.ValidatingType = typeof(int);
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(52, 27);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(145, 27);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(48, 106);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(58, 15);
            lblDescricao.TabIndex = 3;
            lblDescricao.Text = "Descrição";
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(52, 354);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 4;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // rtbDescricao
            // 
            rtbDescricao.Location = new Point(52, 130);
            rtbDescricao.Name = "rtbDescricao";
            rtbDescricao.Size = new Size(230, 105);
            rtbDescricao.TabIndex = 5;
            rtbDescricao.Text = "";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(145, 60);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(137, 23);
            txtNome.TabIndex = 6;
            // 
            // dtpDataCadastro
            // 
            dtpDataCadastro.Location = new Point(52, 274);
            dtpDataCadastro.Name = "dtpDataCadastro";
            dtpDataCadastro.Size = new Size(230, 23);
            dtpDataCadastro.TabIndex = 7;
            // 
            // lblDataCadastro
            // 
            lblDataCadastro.AutoSize = true;
            lblDataCadastro.Location = new Point(52, 247);
            lblDataCadastro.Name = "lblDataCadastro";
            lblDataCadastro.Size = new Size(81, 15);
            lblDataCadastro.TabIndex = 8;
            lblDataCadastro.Text = "Data Cadastro";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(51, 326);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "Status";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Image = (Image)resources.GetObject("btnCadastrar.Image");
            btnCadastrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastrar.Location = new Point(228, 377);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(88, 38);
            btnCadastrar.TabIndex = 10;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.TextAlign = ContentAlignment.MiddleRight;
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // FormCadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 427);
            Controls.Add(btnCadastrar);
            Controls.Add(lblStatus);
            Controls.Add(lblDataCadastro);
            Controls.Add(dtpDataCadastro);
            Controls.Add(txtNome);
            Controls.Add(rtbDescricao);
            Controls.Add(chkAtivo);
            Controls.Add(lblDescricao);
            Controls.Add(lblNome);
            Controls.Add(lblCodigo);
            Controls.Add(mkdCodigo);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastrar";
            Text = "FormCadastrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mkdCodigo;
        private Label lblCodigo;
        private Label lblNome;
        private Label lblDescricao;
        private CheckBox chkAtivo;
        private RichTextBox rtbDescricao;
        private TextBox txtNome;
        private DateTimePicker dtpDataCadastro;
        private Label lblDataCadastro;
        private Label lblStatus;
        private Button btnCadastrar;
    }
}