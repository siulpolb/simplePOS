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
    public partial class Form1 : Form
    {
        private DB db;
        private string username;
        private int userId;

        public Form1()
        {
            InitializeComponent();
            db = new DB();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //login();
            loadAutocomplete();
        }

        private void login()
        {
            Login login = new Login(db);
            var result = login.ShowDialog();
            if (login.DialogResult != DialogResult.OK)
                this.Close();
            username = login.Username;
            userId = login.UserId;
        }

        private void loadAutocomplete()
        {
            var source = new AutoCompleteStringCollection();
            source.AddRange( 
                new string[]
                {
                    "Prueba",
                    "Otra Prueba", 
                    "Una Más",
                    "Coca Cola",
                    "Cocaina"
                });
            tbProductName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbProductName.AutoCompleteCustomSource = source;
            tbProductName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }
    }
}
