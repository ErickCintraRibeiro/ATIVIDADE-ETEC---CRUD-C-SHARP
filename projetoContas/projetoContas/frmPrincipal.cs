using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace projetoContas
{
    public partial class frmPrincipal : Form
    {
        public const int WM_NCLBUTTONDOWN = 0XA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public frmPrincipal()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
            panelCadastroSubMenu.Visible = false;
            panelProcessarSubMenu.Visible = false;
            panelRelatoriosSubMenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelCadastroSubMenu.Visible == true)
                panelCadastroSubMenu.Visible = false;
            if (panelProcessarSubMenu.Visible == true)
                panelProcessarSubMenu.Visible = false;
            if (panelRelatoriosSubMenu.Visible == true)
                panelRelatoriosSubMenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        #region Cadastro
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCadastroSubMenu);
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            openChildForm(new frmsubUsuario());
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            openChildForm(new frmsubCliente());
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            openChildForm(new frmsubFornecedor());
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void btnContasReceber_Click(object sender, EventArgs e)
        {
            openChildForm(new frmsubContasReceber());
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void btnContasPagar_Click(object sender, EventArgs e)
        {
            openChildForm(new frmsubContasPagar());
            //..
            //Your codes
            //..
            hideSubMenu();
        }
#endregion
        #region Relatorios
        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            showSubMenu(panelRelatoriosSubMenu);
        }

        private void btnUsuarioRelatorio_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void btnClienteRelatorio_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void btnFornecedorRelatorio_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void btnContasReceberRelatorio_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void btnContasPagarRelatorio_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }
#endregion
        #region Processar
        private void btnProcessar_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProcessarSubMenu);
        }

        private void btnRemessa_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void btnRetorno_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }
        #endregion
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panelControlBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        private void bntClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panelControlBox_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
