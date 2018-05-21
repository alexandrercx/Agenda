using Dados.Entidades;
using Dominio.DominioModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace WindowsForms
{
    public partial class FrmNovo : Form
    {

        private readonly ContatoDominio contatoDominio;
        private readonly TelefoneDominio telefoneDominio;
        private readonly EmailDominio emailDominio;
        private readonly ClassificacaoDominio classificacaoDominio;
        public FrmNovo()
        {
            contatoDominio = new ContatoDominio();
            telefoneDominio = new TelefoneDominio();
            emailDominio = new EmailDominio();
            classificacaoDominio = new ClassificacaoDominio();
            ConfiguracoesIniciais();

        }

        public FrmNovo(int contatoId, ContatoDominio contatoDominioRef)
        {
            contatoDominio = contatoDominioRef;
            telefoneDominio = new TelefoneDominio();
            emailDominio = new EmailDominio();
            classificacaoDominio = new ClassificacaoDominio();

            ConfiguracoesIniciais();

            var contato = contatoDominio.Obter(contatoId);
            bindingSource.DataSource = contato;

            var lstTelefone = telefoneDominio.ObterTelefoneContato(contato.Id);
            bindingTelefone1.DataSource = lstTelefone[0];
            bindingTelefone2.DataSource = lstTelefone.Count == 2 ? lstTelefone[1] : bindingTelefone2.Current;
            txtTel2.Visible = lstTelefone.Count == 2 ? true : false;
            cbTipoTel2.Visible = lstTelefone.Count == 2 ? true : false;
            btnExcluiTel2.Visible = lstTelefone.Count == 2 ? true : false;


            var lstEmail = emailDominio.ObterEmailContato(contato.Id);
            bindingEmail1.DataSource = lstEmail.Count >= 1 ? lstEmail[0] : bindingEmail1.Current;
            bindingEmail2.DataSource = lstEmail.Count == 2 ? lstEmail[1] : bindingEmail2.Current;
            txtEmail2.Visible = lstEmail.Count == 2 ? true : false;
            cbTipoEmail2.Visible = lstEmail.Count == 2 ? true : false;
            btnExcluiEmail2.Visible = lstTelefone.Count == 2 ? true : false;

        }

        public void ConfiguracoesIniciais()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            bindingSource.DataSource = new Contato();
            bindingEmail1.DataSource = new Email();
            bindingEmail2.DataSource = new Email();
            bindingTelefone1.DataSource = new Telefone();
            bindingTelefone2.DataSource = new Telefone();
            CarregarClassificacao();

        }

        private void btnAddTel2_Click(object sender, EventArgs e)
        {
            txtTel2.Visible = true;
            cbTipoTel2.Visible = true;
            btnExcluiTel2.Visible = true;
            txtTel2.Enabled = true;
            cbTipoTel2.Enabled = true;
            btnExcluiTel2.Enabled = true;
            btnAddTel2.Visible = false;
        }

        private void btnExcluiTel2_Click(object sender, EventArgs e)
        {
            var telefone = (Telefone)bindingTelefone2.Current;
            if (telefone.Id > 0)
            {
                telefoneDominio.Excluir(telefone);
                bindingTelefone2.DataSource = new Telefone();
                bindingTelefone2.EndEdit();
            }
            txtTel2.Visible = false;
            cbTipoTel2.Visible = false;
            btnExcluiTel2.Visible = false;
            txtTel2.Enabled = false;
            cbTipoTel2.Enabled = false;
            btnExcluiTel2.Enabled = false;
            txtTel2.Clear();
            cbTipoTel2.SelectedValue = 0;
            btnAddTel2.Visible = true;
            btnExcluiTel2.Visible = false;

        }

        private void btnExcluiTel1_Click(object sender, EventArgs e)
        {
            txtTelefone.Text = "";
            cbTipoTel.SelectedValue = 0;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.Default;
                bindingSource.EndEdit();
                var contato = (Contato)bindingSource.Current;
                var lstTelefone = new List<Telefone>();
                var lstEmail = new List<Email>();

                if (!txtTelefone.MaskFull)
                {
                    MessageBox.Show("Telefone inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtTelefone.Focus();
                    return;
                }
                if (cbTipoTel.SelectedValue == null || (int)cbTipoTel.SelectedValue == 0)
                {
                    MessageBox.Show("Classificação de telefone é informação obrigatória", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cbTipoTel.Focus();
                    return;
                }

                if (txtTel2.MaskFull)
                {
                    if (cbTipoTel2.SelectedValue == null || (int)cbTipoTel2.SelectedValue == 0)
                    {
                        MessageBox.Show("Classificação de telefone é informação obrigatória", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cbTipoTel.Focus();
                        return;
                    }
                    lstTelefone.Add((Telefone)bindingTelefone2.Current);
                }

                if (!string.IsNullOrEmpty(txtEmail.Text))
                {
                   

                    if (cbTipoEmail.SelectedValue == null || (int)cbTipoEmail.SelectedValue == 0)
                    {
                        MessageBox.Show("Classificação de e-mail é informação obrigatória", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cbTipoEmail.Focus();
                        return;
                    }
                    lstEmail.Add((Email)bindingEmail1.Current);
                }

                if (!string.IsNullOrEmpty(txtEmail2.Text))
                {
                    if (cbTipoEmail2.SelectedValue == null || (int)cbTipoEmail2.SelectedValue == 0)
                    {
                        MessageBox.Show("Classificação de e-mail é informação obrigatória", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cbTipoEmail2.Focus();
                        return;
                    }
                    lstEmail.Add((Email)bindingEmail2.Current);
                }


                lstTelefone.Add((Telefone)bindingTelefone1.Current);
                contatoDominio.Salvar(contato, lstTelefone, lstEmail);

                MessageBox.Show("Salvo com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch(FormatException fe)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show(fe.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Erro ao salvar", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluiEmail2_Click(object sender, EventArgs e)
        {
            var email = (Email)bindingEmail2.Current;
            if (email.Id > 0)
            {
                emailDominio.Excluir((Email)bindingEmail2.Current);
                bindingEmail2.DataSource = new Email();
                bindingEmail2.EndEdit();
            }

            txtEmail2.Visible = false;
            cbTipoEmail2.Visible = false;
            btnExcluiEmail2.Visible = false;
            txtEmail2.Enabled = false;
            cbTipoEmail2.Enabled = false;
            btnExcluiEmail2.Enabled = false;
            txtEmail2.Clear();
            cbTipoEmail2.SelectedValue = 0;
            btnAddEmail2.Visible = true;
            btnExcluiEmail2.Visible = false;
            cbTipoEmail2.SelectedValue = 0;


        }

        private void btnAddEmail2_Click(object sender, EventArgs e)
        {
            txtEmail2.Visible = true;
            cbTipoEmail2.Visible = true;
            btnExcluiEmail2.Visible = true;
            txtEmail2.Enabled = true;
            cbTipoEmail2.Enabled = true;
            btnExcluiEmail2.Enabled = true;
        }

        private void txtTelefone_Leave(object sender, EventArgs e)
        {
            if (txtTelefone.Text.Length == 14)
                txtTelefone.Mask = "(00)00000-0000";
            else
                txtTelefone.Mask = "(00)0000-0000";
        }

        private void txtTel2_Leave(object sender, EventArgs e)
        {
            if (txtTel2.Text.Length == 14)
                txtTel2.Mask = "(00)00000-0000";
            else
                txtTel2.Mask = "(00)0000-0000";
        }

        private void txtTelefone_Enter(object sender, EventArgs e)
        {
            txtTelefone.Mask = "(00)00000-0000";
        }

        private void txtTel2_Enter(object sender, EventArgs e)
        {
            txtTel2.Mask = "(00)00000-0000";
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtEmail2_Leave(object sender, EventArgs e)
        {
            
        }

        private void CarregarClassificacao()
        {

            cbTipoTel.DataSource = classificacaoDominio.Listar().ToList();
            cbTipoTel.DisplayMember = "Descricao";
            cbTipoTel.ValueMember = "Id";

            cbTipoTel2.DataSource = classificacaoDominio.Listar().ToList();
            cbTipoTel2.DisplayMember = "Descricao";
            cbTipoTel2.ValueMember = "Id";

            cbTipoEmail.DataSource = classificacaoDominio.Listar().ToList();
            cbTipoEmail.DisplayMember = "Descricao";
            cbTipoEmail.ValueMember = "Id";

            cbTipoEmail2.DataSource = classificacaoDominio.Listar().ToList();
            cbTipoEmail2.DisplayMember = "Descricao";
            cbTipoEmail2.ValueMember = "Id";

        }

        private void btnExcluiEmail_Click(object sender, EventArgs e)
        {
            var email = (Email)bindingEmail1.Current;
            if (email.Id > 0)
                emailDominio.Excluir((Email)bindingEmail1.Current);

            bindingEmail1.DataSource = new Email();
            bindingEmail1.EndEdit();
        }
    }
}
