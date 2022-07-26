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
    public partial class AdminPanel : Form
    {
        List<Users> users = new List<Users>();
        public AdminPanel()
        {
            InitializeComponent();
            usersFoundListBox.DataSource = users;
            usersFoundListBox.DisplayMember = "FullInfo";
           

        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            users = db.GetUsers();
            usersFoundListBox.DataSource = users;
            usersFoundListBox.DisplayMember = "FullInfo";

        }

        private void GetListBoxSelectedValue(ListBox usersFoundListBox)
        {
            string selectedItem;
            selectedItem = usersFoundListBox.GetItemText(usersFoundListBox.SelectedItem);

            string[] temp = selectedItem.Split(' ');

            idtextBox.Text = temp[0];
            logintextBox.Text = temp[1];
            passwordtextBox.Text = temp[2];
            emailtextBox.Text = temp[3];
            roletextBox.Text = temp[4];

            
        }

        private void getuserbutton_Click(object sender, EventArgs e)
        {
            GetListBoxSelectedValue(usersFoundListBox);
        }

        private void modifybutton_Click(object sender, EventArgs e)
        {
            string prompt = "The data will be changed irretrievably, do you want to continue ? ";
            string caption = "Warning !";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            if (MessageBox.Show(prompt, caption, buttons) == DialogResult.Yes)
            {
                try
                {
                    DataAccess db = new DataAccess();
                    int id = Convert.ToInt32(idtextBox.Text);
                    string login = logintextBox.Text;
                    var password_hash = SecurePasswordHasher.Hash(passwordtextBox.Text);
                    SecurePasswordHasher.Verify(passwordtextBox.Text, password_hash);
                    var password = password_hash;
                    string email = emailtextBox.Text;
                    string role = roletextBox.Text;
                    db.UpdateUser(id, login, password, email, role);
                    this.Refresh();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Data cannot be modified, please restart the application and try again !");
                }
            }
            
            
           

        }
    }
}
