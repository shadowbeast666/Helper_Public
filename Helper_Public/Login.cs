namespace Project_Windows
{
    public partial class Login : Form
    {
        public static string Username { get; set; }
        

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string username = inputLogin.Text;
            Username = username;
            string password = inputPassword.Text;

            
            

            DataAccess db = new DataAccess();

            var hash = SecurePasswordHasher.Hash(password);
            if (SecurePasswordHasher.Verify(password, hash)) 
            {
               // MessageBox.Show(hash);
               // this.Hide();
               // CSV_Generator.Show();
                //AdminPanel.Show();
            }

            try
            {
                if (db.LoginValidation(username, password))
                {
                    CSV_Generator CSV_Generator = new CSV_Generator();
                    AdminPanel AdminPanel = new AdminPanel();
                    Main Form1 = new Main();
                    this.Hide();
                    Form1.Show();
                    string date = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    db.UpdateTime(username, date);

                    //CSV_Generator.Show();


                }
                else
                {
                    MessageBox.Show("Invalid username or password !");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Connection coud not be established please check your internet connection !");
            }

            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void inputPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}