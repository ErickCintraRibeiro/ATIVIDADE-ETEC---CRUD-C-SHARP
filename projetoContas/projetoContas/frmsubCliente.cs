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
    public partial class frmsubCliente : Form
    {
        public frmsubCliente()
        {
            InitializeComponent();
        }
        private void Habilita()
        {
            textBoxnmNome.Enabled = true;
            textBoxEmail.Enabled = true;
            textBoxEndereco.Enabled = true;
            textBoxBairro.Enabled = true;
            textBoxCidade.Enabled = true;
            textBoxCPF.Enabled = true;
            textBoxCNPJ.Enabled = true;
            textBoxRG.Enabled = true;
            textBoxTEL.Enabled = true;
            textBoxEstado.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnAdicionar.Enabled = false;
            btnExcluir.Enabled = false;
            btnEditar.Enabled = false;

        }
        private void Desabilita()
        {
            textBoxnmNome.Enabled = true;
            textBoxEmail.Enabled = true;
            textBoxEndereco.Enabled = true;
            textBoxBairro.Enabled = true;
            textBoxCidade.Enabled = true;
            textBoxCPF.Enabled = true;
            textBoxCNPJ.Enabled = true;
            textBoxRG.Enabled = true;
            textBoxTEL.Enabled = true;
            textBoxEstado.Enabled = true;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
        
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
        
        }

        private void button7_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void toolbox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmsubCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contasDataSet1.tbCliente' table. You can move, or remove it, as needed.
            this.tbClienteTableAdapter.Fill(this.contasDataSet1.tbCliente);
            // TODO: This line of code loads data into the 'contasDataSet.tbCliente' table. You can move, or remove it, as needed.
            this.tbClienteTableAdapter.Fill(this.contasDataSet.tbCliente);
            textBoxCodigo.Enabled = false;
            Desabilita();

        }

        private void textBoxnmNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tbClienteBindingSource1.EndEdit();
            tbClienteTableAdapter.Update(contasDataSet.tbCliente);
            Desabilita();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource1.AddNew();
            Habilita();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbClienteBindingSource1.Count > 0)
            {
                tbClienteBindingSource1.RemoveCurrent();
                tbClienteTableAdapter.Update(contasDataSet.tbCliente);
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource1.MoveNext();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource1.MovePrevious();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource1.CancelEdit();
            Desabilita();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tbClienteBindingSource1.Count > 0)
            {
                Habilita();
            }
        }
    }
}
