using FStoreAppLibrary.Data_Layer.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{

    public partial class frmLogin
    {
        IMemberRepository memberRepository = new MemberRepository();
        public frmLogin()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {


            string email = txtEmail.Text;
            string password = txtPassword.Text;
            if (((MemberRepository)memberRepository).CheckExistAdmin(email, password))
            {
                this.Hide();
                frmMain frmMain = new frmMain();
                frmMain.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong username or password!");
            }
        }

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void btnExit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnExit.PerformClick();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.CancelButton = this.btnExit;
            this.AcceptButton = this.btnLogin;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
