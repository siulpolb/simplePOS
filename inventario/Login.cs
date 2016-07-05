using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventario
{
    public partial class Login : Form
    {

        public string Username { get; set; }
        public int UserId { get; set; }

        private DB db;

        public Login(DB db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!isValid())
                return;
            Username = tbUser.Text;
            UserId = db.login(Username,tbPassword.Text);
            if (UserId != -1)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }   
        }

        private bool isValid()
        {
            bool valid = false;
            if (tbUser.Text == "")
                tbUser.Focus();
            else if (tbPassword.Text == "")
                tbPassword.Focus();
            else
                valid = true;
            return valid;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }
    }
}
