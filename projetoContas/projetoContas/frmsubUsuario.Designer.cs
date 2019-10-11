namespace projetoContas
{
    partial class frmsubUsuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsubUsuario));
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxnmNome = new System.Windows.Forms.TextBox();
            this.tbUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contasDataSet = new projetoContas.contasDataSet();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBoxdsSenha = new System.Windows.Forms.TextBox();
            this.textBoxdsLogin = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxsgNivel = new System.Windows.Forms.TextBox();
            this.textBoxcdUsuario = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.controlbox = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.toolbox = new System.Windows.Forms.Panel();
            this.tbUsuarioTableAdapter = new projetoContas.contasDataSetTableAdapters.tbUsuarioTableAdapter();
            this.contasDataSet1 = new projetoContas.contasDataSet();
            this.tbUsuarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasDataSet)).BeginInit();
            this.panel12.SuspendLayout();
            this.controlbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(12, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.btnProximo);
            this.panel1.Controls.Add(this.btnAnterior);
            this.panel1.Controls.Add(this.controlbox);
            this.panel1.Controls.Add(this.toolbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 445);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.textBoxnmNome);
            this.panel4.Controls.Add(this.panel14);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.textBoxdsSenha);
            this.panel4.Controls.Add(this.textBoxdsLogin);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.textBoxsgNivel);
            this.panel4.Controls.Add(this.textBoxcdUsuario);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 157);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(628, 288);
            this.panel4.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(87)))), ((int)(((byte)(120)))));
            this.label4.Location = new System.Drawing.Point(31, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nome";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(87)))), ((int)(((byte)(120)))));
            this.label12.Location = new System.Drawing.Point(31, 207);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(87)))), ((int)(((byte)(120)))));
            this.label5.Location = new System.Drawing.Point(31, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(87)))), ((int)(((byte)(120)))));
            this.label3.Location = new System.Drawing.Point(31, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nível";
            // 
            // textBoxnmNome
            // 
            this.textBoxnmNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.textBoxnmNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxnmNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource1, "nm_usuario", true));
            this.textBoxnmNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxnmNome.ForeColor = System.Drawing.Color.White;
            this.textBoxnmNome.Location = new System.Drawing.Point(34, 80);
            this.textBoxnmNome.Name = "textBoxnmNome";
            this.textBoxnmNome.Size = new System.Drawing.Size(251, 19);
            this.textBoxnmNome.TabIndex = 0;
            // 
            // tbUsuarioBindingSource
            // 
            this.tbUsuarioBindingSource.DataMember = "tbUsuario";
            this.tbUsuarioBindingSource.DataSource = this.contasDataSet;
            // 
            // contasDataSet
            // 
            this.contasDataSet.DataSetName = "contasDataSet";
            this.contasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(87)))), ((int)(((byte)(120)))));
            this.panel14.Location = new System.Drawing.Point(34, 248);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(253, 1);
            this.panel14.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(87)))), ((int)(((byte)(120)))));
            this.panel7.Location = new System.Drawing.Point(34, 201);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(253, 1);
            this.panel7.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(87)))), ((int)(((byte)(120)))));
            this.label2.Location = new System.Drawing.Point(31, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Código";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(87)))), ((int)(((byte)(120)))));
            this.panel6.Location = new System.Drawing.Point(34, 153);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(253, 1);
            this.panel6.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(87)))), ((int)(((byte)(120)))));
            this.panel5.Location = new System.Drawing.Point(34, 105);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(253, 1);
            this.panel5.TabIndex = 1;
            // 
            // textBoxdsSenha
            // 
            this.textBoxdsSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.textBoxdsSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxdsSenha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource1, "ds_senha", true));
            this.textBoxdsSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxdsSenha.ForeColor = System.Drawing.Color.White;
            this.textBoxdsSenha.Location = new System.Drawing.Point(34, 223);
            this.textBoxdsSenha.Name = "textBoxdsSenha";
            this.textBoxdsSenha.Size = new System.Drawing.Size(251, 19);
            this.textBoxdsSenha.TabIndex = 3;
            // 
            // textBoxdsLogin
            // 
            this.textBoxdsLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.textBoxdsLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxdsLogin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource1, "ds_login", true));
            this.textBoxdsLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxdsLogin.ForeColor = System.Drawing.Color.White;
            this.textBoxdsLogin.Location = new System.Drawing.Point(34, 176);
            this.textBoxdsLogin.Name = "textBoxdsLogin";
            this.textBoxdsLogin.Size = new System.Drawing.Size(251, 19);
            this.textBoxdsLogin.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(87)))), ((int)(((byte)(120)))));
            this.panel3.Location = new System.Drawing.Point(34, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 1);
            this.panel3.TabIndex = 4;
            // 
            // textBoxsgNivel
            // 
            this.textBoxsgNivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.textBoxsgNivel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxsgNivel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource1, "sg_nivel", true));
            this.textBoxsgNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxsgNivel.ForeColor = System.Drawing.Color.White;
            this.textBoxsgNivel.Location = new System.Drawing.Point(34, 128);
            this.textBoxsgNivel.Name = "textBoxsgNivel";
            this.textBoxsgNivel.Size = new System.Drawing.Size(251, 19);
            this.textBoxsgNivel.TabIndex = 3;
            // 
            // textBoxcdUsuario
            // 
            this.textBoxcdUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.textBoxcdUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxcdUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource1, "cd_usuario", true));
            this.textBoxcdUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcdUsuario.ForeColor = System.Drawing.Color.White;
            this.textBoxcdUsuario.Location = new System.Drawing.Point(34, 30);
            this.textBoxcdUsuario.Name = "textBoxcdUsuario";
            this.textBoxcdUsuario.Size = new System.Drawing.Size(251, 19);
            this.textBoxcdUsuario.TabIndex = 3;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label7);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 57);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(628, 100);
            this.panel12.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.CausesValidation = false;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(86)))));
            this.label7.Location = new System.Drawing.Point(26, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(252, 88);
            this.label7.TabIndex = 9;
            this.label7.Text = "Cadastro de \r\nUsuário";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProximo.FlatAppearance.BorderSize = 0;
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(86)))));
            this.btnProximo.Location = new System.Drawing.Point(643, 3);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(46, 46);
            this.btnProximo.TabIndex = 0;
            this.btnProximo.Text = "►";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(86)))));
            this.btnAnterior.Location = new System.Drawing.Point(326, 3);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(46, 46);
            this.btnAnterior.TabIndex = 0;
            this.btnAnterior.Text = "◄";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // controlbox
            // 
            this.controlbox.Controls.Add(this.btnSalvar);
            this.controlbox.Controls.Add(this.btnCancelar);
            this.controlbox.Controls.Add(this.btnExcluir);
            this.controlbox.Controls.Add(this.btnPesquisar);
            this.controlbox.Controls.Add(this.btnEditar);
            this.controlbox.Controls.Add(this.btnAdicionar);
            this.controlbox.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlbox.Location = new System.Drawing.Point(628, 57);
            this.controlbox.Name = "controlbox";
            this.controlbox.Size = new System.Drawing.Size(64, 388);
            this.controlbox.TabIndex = 11;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(6, 121);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(50, 50);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(6, 334);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(50, 50);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(6, 278);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(50, 50);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(6, 2);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(50, 50);
            this.btnPesquisar.TabIndex = 10;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(6, 226);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(50, 50);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.Location = new System.Drawing.Point(6, 173);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(50, 50);
            this.btnAdicionar.TabIndex = 10;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // toolbox
            // 
            this.toolbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbox.Location = new System.Drawing.Point(0, 0);
            this.toolbox.Name = "toolbox";
            this.toolbox.Size = new System.Drawing.Size(692, 57);
            this.toolbox.TabIndex = 12;
            this.toolbox.Paint += new System.Windows.Forms.PaintEventHandler(this.toolbox_Paint);
            // 
            // tbUsuarioTableAdapter
            // 
            this.tbUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // contasDataSet1
            // 
            this.contasDataSet1.DataSetName = "contasDataSet";
            this.contasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbUsuarioBindingSource1
            // 
            this.tbUsuarioBindingSource1.DataMember = "tbUsuario";
            this.tbUsuarioBindingSource1.DataSource = this.contasDataSet1;
            // 
            // frmsubUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(692, 445);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmsubUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmsubCliente";
            this.Load += new System.EventHandler(this.frmsubUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasDataSet)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.controlbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxcdUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel controlbox;
        private System.Windows.Forms.Panel toolbox;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxnmNome;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBoxdsLogin;
        private System.Windows.Forms.TextBox textBoxsgNivel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox textBoxdsSenha;
        private contasDataSet contasDataSet;
        private System.Windows.Forms.BindingSource tbUsuarioBindingSource;
        private contasDataSetTableAdapters.tbUsuarioTableAdapter tbUsuarioTableAdapter;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private contasDataSet contasDataSet1;
        private System.Windows.Forms.BindingSource tbUsuarioBindingSource1;
    }
}