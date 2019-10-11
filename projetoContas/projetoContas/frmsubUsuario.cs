using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoContas
{
    public partial class frmsubUsuario : Form
    {
        public frmsubUsuario()
        {
            InitializeComponent();
        }

        private void Habilita()
        {
            textBoxnmNome.Enabled = true;
            textBoxsgNivel.Enabled = true;
            textBoxdsLogin.Enabled = true;
            textBoxdsSenha.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnAdicionar.Enabled = false;
            btnExcluir.Enabled = false;
            btnEditar.Enabled = false;

        }
        private void Desabilita()
        {
            textBoxnmNome.Enabled = false;
            textBoxsgNivel.Enabled = false;
            textBoxdsLogin.Enabled = false;
            textBoxdsSenha.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnAdicionar.Enabled = true;
            btnExcluir.Enabled = true;
            btnEditar.Enabled = true;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolbox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmsubUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contasDataSet1.tbUsuario' table. You can move, or remove it, as needed.
            this.tbUsuarioTableAdapter.Fill(this.contasDataSet1.tbUsuario);
            // TODO: This line of code loads data into the 'contasDataSet.tbUsuario' table. You can move, or remove it, as needed.
            this.tbUsuarioTableAdapter.Fill(this.contasDataSet.tbUsuario);
            textBoxcdUsuario.Enabled = false;
            Desabilita();
            

        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tbUsuarioBindingSource1.EndEdit();
            tbUsuarioTableAdapter.Update(contasDataSet.tbUsuario);
            Desabilita();

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            tbUsuarioBindingSource1.AddNew();
            Habilita();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbUsuarioBindingSource1.Count > 0)
            {
                tbUsuarioBindingSource1.RemoveCurrent();
                tbUsuarioTableAdapter.Update(contasDataSet.tbUsuario);
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tbUsuarioBindingSource1.MoveNext();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbUsuarioBindingSource1.MovePrevious();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tbUsuarioBindingSource1.Count > 0)
            {
                Habilita();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbUsuarioBindingSource1.CancelEdit();
            Desabilita();
        }
    }
}
