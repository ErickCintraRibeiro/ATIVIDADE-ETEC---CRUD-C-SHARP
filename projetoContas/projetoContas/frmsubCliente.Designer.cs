namespace projetoContas
{
    partial class frmsubCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsubCliente));
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCNPJ = new System.Windows.Forms.TextBox();
            this.tbClienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contasDataSet = new projetoContas.contasDataSet();
            this.panel13 = new System.Windows.Forms.Panel();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCPF = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.textBoxEstado = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.textBoxBairro = new System.Windows.Forms.TextBox();
            this.textBoxTEL = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.textBoxRG = new System.Windows.Forms.TextBox();
            this.textBoxnmNome = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.btnProximo = new System.Windows.Forms.Button();
            this.controlbox = new System.Windows.Forms.Panel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.toolbox = new System.Windows.Forms.Panel();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.tbClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbClienteTableAdapter = new projetoContas.contasDataSetTableAdapters.tbClienteTableAdapter();
            this.contasDataSet1 = new projetoContas.contasDataSet();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasDataSet)).BeginInit();
            this.panel12.SuspendLayout();
            this.controlbox.SuspendLayout();
            this.toolbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasDataSet1)).BeginInit();
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
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.btnProximo);
            this.panel1.Controls.Add(this.controlbox);
            this.panel1.Controls.Add(this.toolbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 445);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.textBoxCNPJ);
            this.panel4.Controls.Add(this.panel13);
            this.panel4.Controls.Add(this.textBoxEmail);
            this.panel4.Controls.Add(this.panel14);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel11);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.textBoxCPF);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Controls.Add(this.textBoxEstado);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.textBoxCidade);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.textBoxBairro);
            this.panel4.Controls.Add(this.textBoxTEL);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.textBoxEndereco);
            this.panel4.Controls.Add(this.textBoxRG);
            this.panel4.Controls.Add(this.textBoxnmNome);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 157);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(628, 288);
            this.panel4.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(87)))), ((int)(((byte)(120)))));
            this.label11.Location = new System.Drawing.Point(323, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "CNPJ";
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
            this.label4.Text = "E-mail";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(87)))), ((int)(((byte)(120)))));
            this.label10.Location = new System.Drawing.Point(323, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Estado";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(87)))), ((int)(((byte)(120)))));
            this.label12.Location = new System.Drawing.Point(31, 207);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Cidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(87)))), ((int)(((byte)(120)))));
            this.label5.Location = new System.Drawing.Point(31, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Bairro";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(87)))), ((int)(((byte)(120)))));
            this.label9.Location = new System.Drawing.Point(323, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(87)))), ((int)(((byte)(120)))));
            this.label3.Location = new System.Drawing.Point(31, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Endereço";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(87)))), ((int)(((byte)(120)))));
            this.label8.Location = new System.Drawing.Point(323, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "CPF";
            // 
            // textBoxCNPJ
            // 
            this.textBoxCNPJ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCNPJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.textBoxCNPJ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCNPJ.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource1, "cnpj_cliente", true));
            this.textBoxCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCNPJ.ForeColor = System.Drawing.Color.White;
            this.textBoxCNPJ.Location = new System.Drawing.Point(326, 127);
            this.textBoxCNPJ.Name = "textBoxCNPJ";
            this.textBoxCNPJ.Size = new System.Drawing.Size(251, 19);
            this.textBoxCNPJ.TabIndex = 8;
            // 
            // tbClienteBindingSource1
            // 
            this.tbClienteBindingSource1.DataMember = "tbCliente";
            this.tbClienteBindingSource1.DataSource = this.contasDataSet;
            // 
            // contasDataSet
            // 
            this.contasDataSet.DataSetName = "contasDataSet";
            this.contasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel13
            // 
            this.panel13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(87)))), ((int)(((byte)(120)))));
            this.panel13.Location = new System.Drawing.Point(326, 248);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(253, 1);
            this.panel13.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource1, "email_cliente", true));
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.Color.White;
            this.textBoxEmail.Location = new System.Drawing.Point(34, 80);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(251, 19);
            this.textBoxEmail.TabIndex = 2;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(87)))), ((int)(((byte)(120)))));
            this.panel14.Location = new System.Drawing.Point(34, 248);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(253, 1);
            this.panel14.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(87)))), ((int)(((byte)(120)))));
            this.label6.Location = new System.Drawing.Point(323, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "RG";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(87)))), ((int)(((byte)(120)))));
            this.panel7.Location = new System.Drawing.Point(34, 201);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(253, 1);
            this.panel7.TabIndex = 4;
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(87)))), ((int)(((byte)(120)))));
            this.panel11.Location = new System.Drawing.Point(326, 200);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(253, 1);
            this.panel11.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(87)))), ((int)(((byte)(120)))));
            this.label2.Location = new System.Drawing.Point(31, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome";
            // 
            // textBoxCPF
            // 
            this.textBoxCPF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.textBoxCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCPF.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource1, "cpf_cliente", true));
            this.textBoxCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCPF.ForeColor = System.Drawing.Color.White;
            this.textBoxCPF.Location = new System.Drawing.Point(326, 29);
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.Size = new System.Drawing.Size(251, 19);
            this.textBoxCPF.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(87)))), ((int)(((byte)(120)))));
            this.panel6.Location = new System.Drawing.Point(34, 153);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(253, 1);
            this.panel6.TabIndex = 4;
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(87)))), ((int)(((byte)(120)))));
            this.panel10.Location = new System.Drawing.Point(326, 152);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(253, 1);
            this.panel10.TabIndex = 1;
            // 
            // textBoxEstado
            // 
            this.textBoxEstado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.textBoxEstado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEstado.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tbClienteBindingSource1, "ds_estado", true));
            this.textBoxEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEstado.ForeColor = System.Drawing.Color.White;
            this.textBoxEstado.Location = new System.Drawing.Point(326, 223);
            this.textBoxEstado.Name = "textBoxEstado";
            this.textBoxEstado.Size = new System.Drawing.Size(251, 19);
            this.textBoxEstado.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(87)))), ((int)(((byte)(120)))));
            this.panel5.Location = new System.Drawing.Point(34, 105);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(253, 1);
            this.panel5.TabIndex = 1;
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.textBoxCidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource1, "ds_cidade", true));
            this.textBoxCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCidade.ForeColor = System.Drawing.Color.White;
            this.textBoxCidade.Location = new System.Drawing.Point(34, 223);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(251, 19);
            this.textBoxCidade.TabIndex = 5;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(87)))), ((int)(((byte)(120)))));
            this.panel9.Location = new System.Drawing.Point(326, 102);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(253, 1);
            this.panel9.TabIndex = 4;
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.textBoxBairro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBairro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource1, "ds_bairro", true));
            this.textBoxBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBairro.ForeColor = System.Drawing.Color.White;
            this.textBoxBairro.Location = new System.Drawing.Point(34, 176);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(251, 19);
            this.textBoxBairro.TabIndex = 4;
            // 
            // textBoxTEL
            // 
            this.textBoxTEL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.textBoxTEL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTEL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource1, "tel_cliente", true));
            this.textBoxTEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTEL.ForeColor = System.Drawing.Color.White;
            this.textBoxTEL.Location = new System.Drawing.Point(326, 175);
            this.textBoxTEL.Name = "textBoxTEL";
            this.textBoxTEL.Size = new System.Drawing.Size(251, 19);
            this.textBoxTEL.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(87)))), ((int)(((byte)(120)))));
            this.panel3.Location = new System.Drawing.Point(34, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 1);
            this.panel3.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(87)))), ((int)(((byte)(120)))));
            this.panel8.Location = new System.Drawing.Point(326, 54);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(253, 1);
            this.panel8.TabIndex = 1;
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.textBoxEndereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEndereco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource1, "ds_endereco", true));
            this.textBoxEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEndereco.ForeColor = System.Drawing.Color.White;
            this.textBoxEndereco.Location = new System.Drawing.Point(34, 128);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(251, 19);
            this.textBoxEndereco.TabIndex = 3;
            // 
            // textBoxRG
            // 
            this.textBoxRG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.textBoxRG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRG.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource1, "rg_cliente", true));
            this.textBoxRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRG.ForeColor = System.Drawing.Color.White;
            this.textBoxRG.Location = new System.Drawing.Point(326, 77);
            this.textBoxRG.Name = "textBoxRG";
            this.textBoxRG.Size = new System.Drawing.Size(251, 19);
            this.textBoxRG.TabIndex = 7;
            // 
            // textBoxnmNome
            // 
            this.textBoxnmNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.textBoxnmNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxnmNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource1, "nm_cliente", true));
            this.textBoxnmNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxnmNome.ForeColor = System.Drawing.Color.White;
            this.textBoxnmNome.Location = new System.Drawing.Point(34, 30);
            this.textBoxnmNome.Name = "textBoxnmNome";
            this.textBoxnmNome.Size = new System.Drawing.Size(251, 19);
            this.textBoxnmNome.TabIndex = 1;
            this.textBoxnmNome.TextChanged += new System.EventHandler(this.textBoxnmNome_TextChanged);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label7);
            this.panel12.Controls.Add(this.label1);
            this.panel12.Controls.Add(this.textBoxCodigo);
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
            this.label7.Text = "Cadastro de \r\nCliente\r\n";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(87)))), ((int)(((byte)(120)))));
            this.label1.Location = new System.Drawing.Point(323, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código Cliente:";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.textBoxCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource1, "cd_cliente", true));
            this.textBoxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(86)))));
            this.textBoxCodigo.Location = new System.Drawing.Point(326, 37);
            this.textBoxCodigo.MaxLength = 999;
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(82, 42);
            this.textBoxCodigo.TabIndex = 11;
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
            this.btnProximo.TabStop = false;
            this.btnProximo.Text = "►";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // controlbox
            // 
            this.controlbox.Controls.Add(this.btnPesquisar);
            this.controlbox.Controls.Add(this.btnCancelar);
            this.controlbox.Controls.Add(this.btnSalvar);
            this.controlbox.Controls.Add(this.btnAdicionar);
            this.controlbox.Controls.Add(this.btnExcluir);
            this.controlbox.Controls.Add(this.btnEditar);
            this.controlbox.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlbox.Location = new System.Drawing.Point(628, 57);
            this.controlbox.Name = "controlbox";
            this.controlbox.Size = new System.Drawing.Size(64, 388);
            this.controlbox.TabIndex = 11;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(6, 2);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(50, 50);
            this.btnPesquisar.TabIndex = 12;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(6, 334);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(50, 50);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(6, 121);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(50, 50);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.Location = new System.Drawing.Point(6, 173);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(50, 50);
            this.btnAdicionar.TabIndex = 13;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(6, 278);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(50, 50);
            this.btnExcluir.TabIndex = 15;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(6, 226);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(50, 50);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // toolbox
            // 
            this.toolbox.Controls.Add(this.btnAnterior);
            this.toolbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbox.Location = new System.Drawing.Point(0, 0);
            this.toolbox.Name = "toolbox";
            this.toolbox.Size = new System.Drawing.Size(692, 57);
            this.toolbox.TabIndex = 12;
            this.toolbox.Paint += new System.Windows.Forms.PaintEventHandler(this.toolbox_Paint);
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
            this.btnAnterior.TabStop = false;
            this.btnAnterior.Text = "◄";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // tbClienteTableAdapter
            // 
            this.tbClienteTableAdapter.ClearBeforeFill = true;
            // 
            // contasDataSet1
            // 
            this.contasDataSet1.DataSetName = "contasDataSet";
            this.contasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmsubCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(692, 445);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmsubCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmsubCliente";
            this.Load += new System.EventHandler(this.frmsubCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasDataSet)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.controlbox.ResumeLayout(false);
            this.toolbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxnmNome;
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCNPJ;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox textBoxCPF;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox textBoxEstado;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox textBoxBairro;
        private System.Windows.Forms.TextBox textBoxTEL;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.TextBox textBoxRG;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox textBoxCidade;
        private contasDataSet contasDataSet;
        private System.Windows.Forms.BindingSource tbClienteBindingSource;
        private contasDataSetTableAdapters.tbClienteTableAdapter tbClienteTableAdapter;
        private contasDataSet contasDataSet1;
        private System.Windows.Forms.BindingSource tbClienteBindingSource1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
    }
}