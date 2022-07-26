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
    public partial class CSV_Generator : Form
    {
        public const int n = 5;
        public int name_helper = 1;
        public CSV_Generator()
        {
            InitializeComponent();
        }

        private void CSV_Generator_Load(object sender, EventArgs e)
        {
            if(Login.Username == "mwojtczak")
            {
                this.BackColor = Color.Purple;
                this.pictureBox1.Visible = true;
            }
        }

       


        private void CreateFile_Click(object sender, EventArgs e)
        {

            List<string> names = new List<string>();

            foreach (TextBox textBox in this.Controls.OfType<TextBox>())
            {
                names.Add(textBox.Name);
            }

            

            List<String> shop = new List<String>();
            List<String> country = new List<String>();
            List<String> mac = new List<String>();
            List<String> ip = new List<String>();
            List<String> pos = new List<String>();
            List<String> final_list = new List<String>();
            final_list.Add(FirstRow);

            foreach (Control ctrl in this.Controls) // Read ipnut form user
            {
                if (ctrl is TextBox)
                {
                    if(ctrl.Name.Contains("inputShop"))
                        shop.Add(((TextBox)ctrl).Text);
                    else if(ctrl.Name.Contains("inputCountry"))
                        country.Add(((TextBox)ctrl).Text);
                    else if(ctrl.Name.Contains("inputMac"))
                        mac.Add(((TextBox)ctrl).Text);
                    else if(ctrl.Name.Contains("inputIp"))
                        ip.Add(((TextBox)ctrl).Text);
                    else if(ctrl.Name.Contains("inputPos"))
                        pos.Add(((TextBox)ctrl).Text);
                }
                    
            }

            for (int i = 0; i < mac.Count; i++) //handle mac address requirements
            {
                var mac_helper = Enumerable.Range(0, mac[i].Length/2).Select(j => mac[i].Substring(j * 2, 2));

                string temp = string.Join("-", mac_helper);

                mac[i] = temp.ToUpper();
            }

            for (var i = 0; i < name_helper; i++)
            {
              //
            }


            /*https://stackoverflow.com/questions/2660723/remove-characters-after-specific-character-in-string-then-remove-substring */



       
            
        }

        private void AddRowButton_Click_1(object sender, EventArgs e)
        {
            TextBox[] textBox = new TextBox[n];

            int PosY = 150;

            switch(name_helper)
            {
                case 2:
                    PosY = 200;
                    break;
                case 3:
                    PosY = 250;
                    break;
                case 4:
                    PosY = 300;
                    break;
                case 5:
                    PosY = 350;
                    break;
                case 6:
                    PosY = 400;
                    break;
                case 7:
                    PosY = 450;
                    break;
                case 8:
                    PosY = 500;
                    break;
                case 9:
                    PosY = 550;
                    break;
                case 10:
                    PosY = 600;
                    break;
            }

            if (name_helper < 10)
            {
                name_helper++;

                for (int i = 0; i < n; i++)
                {
                    textBox[i] = new TextBox();

                    if (i == 0)
                    {
                        textBox[i].Name = "inputShop" + name_helper;
                        textBox[i].Location = new Point(45, PosY);
                    }
                    else if (i == 1)
                    {
                        textBox[i].Name = "inputCountry" + name_helper;
                        textBox[i].Location = new Point(207, PosY);
                    }
                    else if (i == 2)
                    {
                        textBox[i].Name = "inputMac" + name_helper;
                        textBox[i].Location = new Point(365, PosY);
                    }
                    else if (i == 3)
                    {
                        textBox[i].Name = "inputIp" + name_helper;
                        textBox[i].Location = new Point(522, PosY);
                    }
                    else if (i == 4)
                    {
                        textBox[i].Name = "inputPos" + name_helper;
                        textBox[i].Location = new Point(689, PosY);
                    }

                    textBox[i].BackColor = Color.White;
                    textBox[i].Font = new Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                    textBox[i].Size = new Size(115, 23);
                    textBox[i].Text = "";
                    textBox[i].Tag = "txt";

                    this.Controls.Add(textBox[i]);

                }

                
            }
            else
            {
                MessageBox.Show("Can't add more than 10 rows !");
            }

            

            
            
        }

        private void delete1_Click(object sender, EventArgs e)
        {
           
            if (name_helper > 1)
            {
                List<String> deleted_names = new List<String>()
                {
                    "inputShop",
                    "inputCountry",
                    "inputMac",
                    "inputIp",
                    "inputPos",
                };

                for (int i = 0; i < 5; i++)
                {
                    string temp = deleted_names[i] + name_helper;
                    Control object_to_delete = this.Controls[temp];
                    object_to_delete.Dispose();

                }
                name_helper--;
            }
            
            
            
            
            
            /*

            foreach (Control item in this.Controls.OfType<TextBox>())
            {
                if (item.Tag == "btn")
                {
                    Controls.Remove(item);
                }
                    
            }
            */


        }
    }
}
