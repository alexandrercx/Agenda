using Dados.Views;
using Dominio.DominioModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class FrmConsulta : Form
    {
        private readonly ContatoDominio contatoDominio;
        List<ContatoView> colecaoContatos;

        public FrmConsulta()
        {
            InitializeComponent();
            contatoDominio = new ContatoDominio();
            colecaoContatos = new List<ContatoView>();
            ObterTodosContatos();
        }



        private void btnAddTel2_Click(object sender, EventArgs e)
        {
            FrmNovo frmNovo = new FrmNovo();
            frmNovo.ShowDialog();
            ObterTodosContatos();
        }


        public void ObterTodosContatos()
        {
            txtPesquisa.Text = "";
            colecaoContatos = contatoDominio.Listar(txtPesquisa.Text);
            dgvContatos.DataSource = colecaoContatos.OrderBy(c => c.NomeContato).ToList();
        }

        public void ObterContatos()
        {
            txtPesquisa.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (string.IsNullOrEmpty(txtPesquisa.Text))
            {
                dgvContatos.DataSource = colecaoContatos.OrderBy(c => c.NomeContato).ToList();
            }
            else
            {
                if (rbNome.Checked)
                    dgvContatos.DataSource = colecaoContatos.Where(c => c.NomeContato.StartsWith(txtPesquisa.Text)).ToList();
                else if (rbEmail.Checked)
                {
                    List<ContatoView> lstAux = new List<ContatoView>();
                    foreach (var item in colecaoContatos)
                    {
                        foreach (var email in item.Emails)
                        {
                            if (email.StartsWith(txtPesquisa.Text))
                            {
                                lstAux.Add(item);
                            }
                        }
                    }
                    dgvContatos.DataSource = lstAux.ToList();
                }
                else
                {

                    List<ContatoView> lstAux = new List<ContatoView>();
                    foreach (var item in colecaoContatos)
                    {
                        foreach (var tel in item.Numeros)
                        {
                            if (tel.StartsWith(txtPesquisa.Text))
                            {
                                lstAux.Add(item);
                            }
                        }
                    }
                    dgvContatos.DataSource = lstAux.Distinct().ToList();

                }
            }
        }

        public ContatoView ObterContatoSelecionado()
        {
            return (dgvContatos.SelectedRows.Cast<DataGridViewRow>().Select(linha => (ContatoView)linha.DataBoundItem)).FirstOrDefault();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                var contatoView = ObterContatoSelecionado();
                DialogResult result = MessageBox.Show("Deseja excluir este contato?", "Warning",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                Cursor.Current = Cursors.WaitCursor;

                if (result == DialogResult.Yes)
                {
                    contatoDominio.Excluir(contatoView.IdContato);
                }
                Cursor.Current = Cursors.Default;

                ObterTodosContatos();
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Erro ao excluir", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtNomeContato_TextChanged(object sender, EventArgs e)
        {
            txtPesquisa.Text = txtPesquisa.Text.ToUpper();
            txtPesquisa.SelectionStart = txtPesquisa.Text.Length;
            txtPesquisa.Focus();
            ObterContatos();
        }

        private void rbNome_Click(object sender, EventArgs e)
        {
            if (rbNome.Checked)
                txtPesquisa.Mask = null;

        }

        private void rbTelefone_Click(object sender, EventArgs e)
        {
            if (rbTelefone.Checked)
                txtPesquisa.Mask = "(00)00000-0000";

        }

        private void rbEmail_Click(object sender, EventArgs e)
        {
            if (rbEmail.Checked)
                txtPesquisa.Mask = null;
        }

        private void dgvContatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var contatoView = ObterContatoSelecionado();
            FrmNovo frmNovo = new FrmNovo(contatoView.IdContato, contatoDominio);
            frmNovo.ShowDialog();
        }
    }
}
