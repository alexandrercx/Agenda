namespace WindowsForms
{
    partial class FrmNovo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNovo));
            this.panelContato = new System.Windows.Forms.Panel();
            this.Nome = new System.Windows.Forms.Label();
            this.txtNomeContato = new System.Windows.Forms.TextBox();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelTel = new System.Windows.Forms.Panel();
            this.txtTel2 = new System.Windows.Forms.MaskedTextBox();
            this.bindingTelefone2 = new System.Windows.Forms.BindingSource(this.components);
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.bindingTelefone1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnExcluiTel2 = new System.Windows.Forms.Button();
            this.btnAddTel2 = new System.Windows.Forms.Button();
            this.btnExcluiTel1 = new System.Windows.Forms.Button();
            this.cbTipoTel2 = new System.Windows.Forms.ComboBox();
            this.cbTipoTel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelEmail = new System.Windows.Forms.Panel();
            this.btnExcluiEmail2 = new System.Windows.Forms.Button();
            this.btnAddEmail2 = new System.Windows.Forms.Button();
            this.btnExcluiEmail = new System.Windows.Forms.Button();
            this.cbTipoEmail2 = new System.Windows.Forms.ComboBox();
            this.bindingEmail2 = new System.Windows.Forms.BindingSource(this.components);
            this.txtEmail2 = new System.Windows.Forms.TextBox();
            this.cbTipoEmail = new System.Windows.Forms.ComboBox();
            this.bindingEmail1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.telefoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelContato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panelTel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingTelefone2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingTelefone1)).BeginInit();
            this.panelEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingEmail2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingEmail1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telefoneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContato
            // 
            this.panelContato.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelContato.Controls.Add(this.Nome);
            this.panelContato.Controls.Add(this.txtNomeContato);
            this.panelContato.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContato.Location = new System.Drawing.Point(0, 0);
            this.panelContato.Name = "panelContato";
            this.panelContato.Size = new System.Drawing.Size(408, 76);
            this.panelContato.TabIndex = 2;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(18, 10);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(45, 16);
            this.Nome.TabIndex = 2;
            this.Nome.Text = "Nome";
            // 
            // txtNomeContato
            // 
            this.txtNomeContato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeContato.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Nome", true));
            this.txtNomeContato.Location = new System.Drawing.Point(21, 29);
            this.txtNomeContato.MaxLength = 40;
            this.txtNomeContato.Name = "txtNomeContato";
            this.txtNomeContato.Size = new System.Drawing.Size(320, 20);
            this.txtNomeContato.TabIndex = 1;
            // 
            // panelTel
            // 
            this.panelTel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelTel.Controls.Add(this.txtTel2);
            this.panelTel.Controls.Add(this.txtTelefone);
            this.panelTel.Controls.Add(this.btnExcluiTel2);
            this.panelTel.Controls.Add(this.btnAddTel2);
            this.panelTel.Controls.Add(this.btnExcluiTel1);
            this.panelTel.Controls.Add(this.cbTipoTel2);
            this.panelTel.Controls.Add(this.cbTipoTel);
            this.panelTel.Controls.Add(this.label1);
            this.panelTel.Location = new System.Drawing.Point(0, 84);
            this.panelTel.Name = "panelTel";
            this.panelTel.Size = new System.Drawing.Size(408, 111);
            this.panelTel.TabIndex = 3;
            // 
            // txtTel2
            // 
            this.txtTel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingTelefone2, "Numero", true));
            this.txtTel2.Location = new System.Drawing.Point(21, 67);
            this.txtTel2.Mask = "(00)00000-0000";
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.Size = new System.Drawing.Size(193, 20);
            this.txtTel2.TabIndex = 4;
            this.txtTel2.Visible = false;
            this.txtTel2.Enter += new System.EventHandler(this.txtTel2_Enter);
            this.txtTel2.Leave += new System.EventHandler(this.txtTel2_Leave);
            // 
            // txtTelefone
            // 
            this.txtTelefone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingTelefone1, "Numero", true));
            this.txtTelefone.Location = new System.Drawing.Point(21, 33);
            this.txtTelefone.Mask = "(00)00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(193, 20);
            this.txtTelefone.TabIndex = 2;
            this.txtTelefone.Enter += new System.EventHandler(this.txtTelefone_Enter);
            this.txtTelefone.Leave += new System.EventHandler(this.txtTelefone_Leave);
            // 
            // btnExcluiTel2
            // 
            this.btnExcluiTel2.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluiTel2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluiTel2.ForeColor = System.Drawing.SystemColors.Window;
            this.btnExcluiTel2.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluiTel2.Image")));
            this.btnExcluiTel2.Location = new System.Drawing.Point(376, 66);
            this.btnExcluiTel2.Name = "btnExcluiTel2";
            this.btnExcluiTel2.Size = new System.Drawing.Size(25, 25);
            this.btnExcluiTel2.TabIndex = 9;
            this.btnExcluiTel2.UseVisualStyleBackColor = false;
            this.btnExcluiTel2.Visible = false;
            this.btnExcluiTel2.Click += new System.EventHandler(this.btnExcluiTel2_Click);
            // 
            // btnAddTel2
            // 
            this.btnAddTel2.BackColor = System.Drawing.Color.Transparent;
            this.btnAddTel2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTel2.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAddTel2.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTel2.Image")));
            this.btnAddTel2.Location = new System.Drawing.Point(347, 32);
            this.btnAddTel2.Name = "btnAddTel2";
            this.btnAddTel2.Size = new System.Drawing.Size(25, 25);
            this.btnAddTel2.TabIndex = 8;
            this.btnAddTel2.UseVisualStyleBackColor = false;
            this.btnAddTel2.Click += new System.EventHandler(this.btnAddTel2_Click);
            // 
            // btnExcluiTel1
            // 
            this.btnExcluiTel1.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluiTel1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluiTel1.ForeColor = System.Drawing.SystemColors.Window;
            this.btnExcluiTel1.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluiTel1.Image")));
            this.btnExcluiTel1.Location = new System.Drawing.Point(376, 32);
            this.btnExcluiTel1.Name = "btnExcluiTel1";
            this.btnExcluiTel1.Size = new System.Drawing.Size(25, 25);
            this.btnExcluiTel1.TabIndex = 7;
            this.btnExcluiTel1.UseVisualStyleBackColor = false;
            this.btnExcluiTel1.Click += new System.EventHandler(this.btnExcluiTel1_Click);
            // 
            // cbTipoTel2
            // 
            this.cbTipoTel2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingTelefone2, "IdClassificacao", true));
            this.cbTipoTel2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoTel2.FormattingEnabled = true;
            this.cbTipoTel2.Location = new System.Drawing.Point(220, 67);
            this.cbTipoTel2.Name = "cbTipoTel2";
            this.cbTipoTel2.Size = new System.Drawing.Size(121, 21);
            this.cbTipoTel2.TabIndex = 5;
            this.cbTipoTel2.Visible = false;
            // 
            // cbTipoTel
            // 
            this.cbTipoTel.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingTelefone1, "IdClassificacao", true));
            this.cbTipoTel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoTel.FormattingEnabled = true;
            this.cbTipoTel.Location = new System.Drawing.Point(220, 33);
            this.cbTipoTel.Name = "cbTipoTel";
            this.cbTipoTel.Size = new System.Drawing.Size(121, 21);
            this.cbTipoTel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Telefone";
            // 
            // panelEmail
            // 
            this.panelEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEmail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelEmail.Controls.Add(this.btnExcluiEmail2);
            this.panelEmail.Controls.Add(this.btnAddEmail2);
            this.panelEmail.Controls.Add(this.btnExcluiEmail);
            this.panelEmail.Controls.Add(this.cbTipoEmail2);
            this.panelEmail.Controls.Add(this.txtEmail2);
            this.panelEmail.Controls.Add(this.cbTipoEmail);
            this.panelEmail.Controls.Add(this.label2);
            this.panelEmail.Controls.Add(this.txtEmail);
            this.panelEmail.Location = new System.Drawing.Point(0, 202);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Size = new System.Drawing.Size(408, 103);
            this.panelEmail.TabIndex = 4;
            // 
            // btnExcluiEmail2
            // 
            this.btnExcluiEmail2.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluiEmail2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluiEmail2.ForeColor = System.Drawing.SystemColors.Window;
            this.btnExcluiEmail2.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluiEmail2.Image")));
            this.btnExcluiEmail2.Location = new System.Drawing.Point(376, 64);
            this.btnExcluiEmail2.Name = "btnExcluiEmail2";
            this.btnExcluiEmail2.Size = new System.Drawing.Size(25, 25);
            this.btnExcluiEmail2.TabIndex = 12;
            this.btnExcluiEmail2.UseVisualStyleBackColor = false;
            this.btnExcluiEmail2.Visible = false;
            this.btnExcluiEmail2.Click += new System.EventHandler(this.btnExcluiEmail2_Click);
            // 
            // btnAddEmail2
            // 
            this.btnAddEmail2.BackColor = System.Drawing.Color.Transparent;
            this.btnAddEmail2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmail2.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAddEmail2.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEmail2.Image")));
            this.btnAddEmail2.Location = new System.Drawing.Point(347, 34);
            this.btnAddEmail2.Name = "btnAddEmail2";
            this.btnAddEmail2.Size = new System.Drawing.Size(25, 25);
            this.btnAddEmail2.TabIndex = 11;
            this.btnAddEmail2.UseVisualStyleBackColor = false;
            this.btnAddEmail2.Click += new System.EventHandler(this.btnAddEmail2_Click);
            // 
            // btnExcluiEmail
            // 
            this.btnExcluiEmail.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluiEmail.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluiEmail.ForeColor = System.Drawing.SystemColors.Window;
            this.btnExcluiEmail.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluiEmail.Image")));
            this.btnExcluiEmail.Location = new System.Drawing.Point(376, 34);
            this.btnExcluiEmail.Name = "btnExcluiEmail";
            this.btnExcluiEmail.Size = new System.Drawing.Size(25, 25);
            this.btnExcluiEmail.TabIndex = 10;
            this.btnExcluiEmail.UseVisualStyleBackColor = false;
            this.btnExcluiEmail.Click += new System.EventHandler(this.btnExcluiEmail_Click);
            // 
            // cbTipoEmail2
            // 
            this.cbTipoEmail2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingEmail2, "IdClassificacao", true));
            this.cbTipoEmail2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoEmail2.FormattingEnabled = true;
            this.cbTipoEmail2.Location = new System.Drawing.Point(220, 65);
            this.cbTipoEmail2.Name = "cbTipoEmail2";
            this.cbTipoEmail2.Size = new System.Drawing.Size(121, 21);
            this.cbTipoEmail2.TabIndex = 9;
            this.cbTipoEmail2.Visible = false;
            // 
            // txtEmail2
            // 
            this.txtEmail2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingEmail2, "EnderecoEmail", true));
            this.txtEmail2.Location = new System.Drawing.Point(21, 65);
            this.txtEmail2.Name = "txtEmail2";
            this.txtEmail2.Size = new System.Drawing.Size(193, 20);
            this.txtEmail2.TabIndex = 8;
            this.txtEmail2.Visible = false;
            this.txtEmail2.Leave += new System.EventHandler(this.txtEmail2_Leave);
            // 
            // cbTipoEmail
            // 
            this.cbTipoEmail.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingEmail1, "IdClassificacao", true));
            this.cbTipoEmail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoEmail.FormattingEnabled = true;
            this.cbTipoEmail.Location = new System.Drawing.Point(220, 34);
            this.cbTipoEmail.Name = "cbTipoEmail";
            this.cbTipoEmail.Size = new System.Drawing.Size(121, 21);
            this.cbTipoEmail.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingEmail1, "EnderecoEmail", true));
            this.txtEmail.Location = new System.Drawing.Point(21, 34);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(193, 20);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtEndereco);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtEmpresa);
            this.panel1.Location = new System.Drawing.Point(0, 313);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 123);
            this.panel1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Endereco", true));
            this.txtEndereco.Location = new System.Drawing.Point(21, 82);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(320, 20);
            this.txtEndereco.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Empresa";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmpresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Empresa", true));
            this.txtEmpresa.Location = new System.Drawing.Point(21, 34);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(320, 20);
            this.txtEmpresa.TabIndex = 10;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.Image")));
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmar.Location = new System.Drawing.Point(310, 454);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(91, 29);
            this.btnConfirmar.TabIndex = 9;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(4, 454);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 29);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 442);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 50);
            this.panel2.TabIndex = 10;
            // 
            // telefoneBindingSource
            // 
            this.telefoneBindingSource.DataSource = typeof(Dados.Entidades.Telefone);
            // 
            // FrmNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(408, 492);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelEmail);
            this.Controls.Add(this.panelTel);
            this.Controls.Add(this.panelContato);
            this.Name = "FrmNovo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Contato";
            this.panelContato.ResumeLayout(false);
            this.panelContato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panelTel.ResumeLayout(false);
            this.panelTel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingTelefone2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingTelefone1)).EndInit();
            this.panelEmail.ResumeLayout(false);
            this.panelEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingEmail2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingEmail1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telefoneBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContato;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox txtNomeContato;
        private System.Windows.Forms.Panel panelTel;
        private System.Windows.Forms.ComboBox cbTipoTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelEmail;
        private System.Windows.Forms.ComboBox cbTipoEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Button btnExcluiTel1;
        private System.Windows.Forms.ComboBox cbTipoTel2;
        private System.Windows.Forms.ComboBox cbTipoEmail2;
        private System.Windows.Forms.TextBox txtEmail2;
        private System.Windows.Forms.Button btnAddTel2;
        private System.Windows.Forms.Button btnExcluiTel2;
        private System.Windows.Forms.Button btnExcluiEmail2;
        private System.Windows.Forms.Button btnAddEmail2;
        private System.Windows.Forms.Button btnExcluiEmail;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.BindingSource bindingEmail1;
        private System.Windows.Forms.BindingSource bindingEmail2;
        private System.Windows.Forms.BindingSource bindingTelefone1;
        private System.Windows.Forms.BindingSource bindingTelefone2;
        private System.Windows.Forms.BindingSource telefoneBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtTel2;
    }
}