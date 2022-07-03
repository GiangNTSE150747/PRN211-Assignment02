using FStoreAppLibrary.Data_Layer.Repository;
using FStoreAppLibrary.Models;
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
    public partial class frmMemberDetail : Form
    {
        public frmMemberDetail()
        {
            InitializeComponent();
        }

        public IMemberRepository MemberRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Member MemberInfor { get; set; }

        private void frmMemberDetail_Load(object sender, EventArgs e)
        {
            txtMenberId.Enabled = !InsertOrUpdate;

            if(InsertOrUpdate == true)
            {
                txtMenberId.Text = MemberInfor.MemberId.ToString();
                txtEmail.Text = MemberInfor.Email;
                txtCompanyName.Text = MemberInfor.CompanyName;
                txtCity.Text = MemberInfor.City;
                txtCountry.Text = MemberInfor.Country;
                txtPassword.Text = MemberInfor.Password;
            }          
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var member = new Member
                {
                    MemberId = int.Parse(txtMenberId.Text),
                    Email = txtEmail.Text,
                    CompanyName = txtCompanyName.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Password = txtPassword.Text
                };

                if(InsertOrUpdate == false)
                {
                    MemberRepository.InsertMember(member);
                }
                else
                {
                    MemberRepository.UpdateMember(member);
                }

                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new member" : "Update member");
            }
        }
    }
}
