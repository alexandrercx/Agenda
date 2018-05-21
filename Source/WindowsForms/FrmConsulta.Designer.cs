namespace WindowsForms
{
    partial class FrmConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsulta));
            this.panelContato = new System.Windows.Forms.Panel();
            this.txtPesquisa = new System.Windows.Forms.MaskedTextBox();
            this.rbTelefone = new System.Windows.Forms.RadioButton();
            this.rbEmail = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.btnAddTel2 = new System.Windows.Forms.Button();
            this.dgvContatos = new System.Windows.Forms.DataGridView();
            this.IdContato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.panelContato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContato
            // 
            this.panelContato.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelContato.Controls.Add(this.txtPesquisa);
            this.panelContato.Controls.Add(this.rbTelefone);
            this.panelContato.Controls.Add(this.rbEmail);
            this.panelContato.Controls.Add(this.rbNome);
            this.panelContato.Controls.Add(this.btnAddTel2);
            this.panelContato.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContato.Location = new System.Drawing.Point(0, 0);
            this.panelContato.Name = "panelContato";
            this.panelContato.Size = new System.Drawing.Size(408, 84);
            this.panelContato.TabIndex = 3;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(13, 36);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(348, 20);
            this.txtPesquisa.TabIndex = 13;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtNomeContato_TextChanged);
            // 
            // rbTelefone
            // 
            this.rbTelefone.AutoSize = true;
            this.rbTelefone.Location = new System.Drawing.Point(165, 12);
            this.rbTelefone.Name = "rbTelefone";
            this.rbTelefone.Size = new System.Drawing.Size(67, 17);
            this.rbTelefone.TabIndex = 12;
            this.rbTelefone.TabStop = true;
            this.rbTelefone.Text = "Telefone";
            this.rbTelefone.UseVisualStyleBackColor = true;
            this.rbTelefone.Click += new System.EventHandler(this.rbTelefone_Click);
            // 
            // rbEmail
            // 
            this.rbEmail.AutoSize = true;
            this.rbEmail.Location = new System.Drawing.Point(89, 12);
            this.rbEmail.Name = "rbEmail";
            this.rbEmail.Size = new System.Drawing.Size(53, 17);
            this.rbEmail.TabIndex = 11;
            this.rbEmail.TabStop = true;
            this.rbEmail.Text = "E-mail";
            this.rbEmail.UseVisualStyleBackColor = true;
            this.rbEmail.Click += new System.EventHandler(this.rbEmail_Click);
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Checked = true;
            this.rbNome.Location = new System.Drawing.Point(13, 13);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(53, 17);
            this.rbNome.TabIndex = 10;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            this.rbNome.Click += new System.EventHandler(this.rbNome_Click);
            // 
            // btnAddTel2
            // 
            this.btnAddTel2.BackColor = System.Drawing.Color.Transparent;
            this.btnAddTel2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTel2.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAddTel2.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTel2.Image")));
            this.btnAddTel2.Location = new System.Drawing.Point(367, 29);
            this.btnAddTel2.Name = "btnAddTel2";
            this.btnAddTel2.Size = new System.Drawing.Size(35, 32);
            this.btnAddTel2.TabIndex = 9;
            this.btnAddTel2.UseVisualStyleBackColor = false;
            this.btnAddTel2.Click += new System.EventHandler(this.btnAddTel2_Click);
            // 
            // dgvContatos
            // 
            this.dgvContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContatos.ColumnHeadersVisible = false;
            this.dgvContatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdContato,
            this.Nome});
            this.dgvContatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContatos.Location = new System.Drawing.Point(0, 84);
            this.dgvContatos.MultiSelect = false;
            this.dgvContatos.Name = "dgvContatos";
            this.dgvContatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContatos.Size = new System.Drawing.Size(408, 408);
            this.dgvContatos.TabIndex = 4;
            this.dgvContatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContatos_CellDoubleClick);
            // 
            // IdContato
            // 
            this.IdContato.DataPropertyName = "IdContato";
            this.IdContato.HeaderText = "IdContato";
            this.IdContato.Name = "IdContato";
            this.IdContato.ReadOnly = true;
            this.IdContato.Visible = false;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "NomeContato";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 445);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 47);
            this.panel1.TabIndex = 5;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.Window;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(367, 8);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(35, 32);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(408, 492);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvContatos);
            this.Controls.Add(this.panelContato);
            this.Name = "FrmConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta";
            this.panelContato.ResumeLayout(false);
            this.panelContato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContato;
        private System.Windows.Forms.Button btnAddTel2;
        private System.Windows.Forms.DataGridView dgvContatos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdContato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.RadioButton rbTelefone;
        private System.Windows.Forms.RadioButton rbEmail;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.MaskedTextBox txtPesquisa;
    }
}