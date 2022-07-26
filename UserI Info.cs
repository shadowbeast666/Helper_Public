using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Windows
{
    public partial class UserInfo : Form
    {
        List<Users> users = new List<Users>();
        public UserInfo()
        {
            InitializeComponent();
            DataAccess db = new DataAccess();
            users = db.ShowUser(Login.Username);

            loginlabel.Text = users[0].Login;
            emaillabel.Text = users[0].Email;
            rolelabel.Text = users[0].Role;
            lastloginlabel.Text = users[0].Last_Login;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
