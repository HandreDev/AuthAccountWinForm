using AuthAccountWinForm.App_code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuthAccountWinForm
{
    public partial class Accounts : Form
    {
        private LinqToSQLDataContext _context = new LinqToSQLDataContext();

        public Accounts()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _context.SubmitChanges();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userBindingSource.DataSource = _context.Users;
        }
    }
}
