using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using Microsoft.Win32;


namespace Project_Windows
{
    public partial class IMEI_Sender : Form
    {

        public IMEI_Sender()
        {
            InitializeComponent();
            

        }
        private void IMEI_Sender_Load(object sender, EventArgs e)
        {
            ReadAllFiles();
        }

        private void ReadAllFiles()
        {
            string configfileName = "config.json";
            string path = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, @"py\", configfileName);
            string jsonString = File.ReadAllText(path);
            JObject jObject = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonString) as JObject;
            JToken username = jObject.SelectToken("share_point.user");
            JToken password = jObject.SelectToken("share_point.password");
            emailtextBox.Text = username.ToString();
            passwordtextBox.Text = password.ToString();
            //Read data from config.json


            string makefilePath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, @"py\", "MakeFile.py");
            string[] makefileArr = File.ReadAllLines(makefilePath);
            for (int i = 0; i < makefileArr.Length; i++)
            {
                string line = makefileArr[i];

                if (line.Contains("first ="))
                {
                    string firstrowvalue = new String(makefileArr[i].Where(Char.IsDigit).ToArray());
                    firsttextBox.Text = firstrowvalue;
                }
                if (line.Contains("second ="))
                {
                    string secoundrowvalue = new String(makefileArr[i].Where(Char.IsDigit).ToArray());
                    secondtextBox.Text = secoundrowvalue;
                }
                if (line.Contains("third ="))
                {
                    string thirdrowvalue = new String(makefileArr[i].Where(Char.IsDigit).ToArray());
                    thirdtextBox.Text = thirdrowvalue;
                }

            }

            string emailsenderPath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, @"py\", "EmailSender.py");
            string[] emailsenderArr = File.ReadAllLines(emailsenderPath);

            for (int i = 0; i < emailsenderArr.Length; i++)
            {
               string line = emailsenderArr[i];
               char [] toTrim = {'\''};

               if(line.Contains("mail.To"))
               {
                    string result = line.Trim(toTrim);
                    reciveremailtextBox.Text = result.Remove(0, 10);
               }    
               if(line.Contains("mail.Subject"))
               {
                    string result = line.Trim(toTrim);
                    subjecttextBox.Text = result.Remove(0, 16);
               }
               if (line.Contains("mail.Body"))
               {
                    string result = line.Trim(toTrim);
                    bodytextBox.Text = result.Remove(0, 12);
               }

            }


        }
        private void ChangeConfigFiles()
        {
            var Email = emailtextBox.Text;
            var Password = passwordtextBox.Text;
            string path = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, @"py\", "config.json");
            string jsonString = File.ReadAllText(path);
            // Convert the JSON string to a JObject:
            JObject jObject = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonString) as JObject;
            // Select a nested property using a single string:
            JToken username = jObject.SelectToken("share_point.user");
            JToken password = jObject.SelectToken("share_point.password");
            // Update the value of the property: 
            username.Replace(Email);
            password.Replace(Password);
            // Convert the JObject back to a string:
            string updatedJsonString = jObject.ToString();
            File.WriteAllText(path, updatedJsonString);

            try
            {
                
                string makefilepath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, @"py\", "MakeFile.py"); 
                string[] makefilearr = File.ReadAllLines(makefilepath);
                var makefilewriter = new StreamWriter(makefilepath);
                var first = firsttextBox.Text;
                var second = secondtextBox.Text;
                var third = thirdtextBox.Text;
               
                for (int i = 0; i < makefilearr.Length; i++)
                {
                    string line = makefilearr[i];

                    if (line.Contains("first ="))
                    {
                        line = String.Concat("first =", first);
                    }
                    if (line.Contains("second ="))
                    {
                        line = String.Concat("second =", second);
                    }
                    if (line.Contains("third ="))
                    {
                        line = String.Concat("third =", third);
                    }
                    makefilewriter.WriteLine(line);
                }
                makefilewriter.Close();

                string emailsenderPath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, @"py\", "EmailSender.py");
                string[] emailsenderearr = File.ReadAllLines(emailsenderPath);
                var emailsenderwriter = new StreamWriter(emailsenderPath);
                var subject = subjecttextBox.Text;
                var body = bodytextBox.Text;
                var email = emailtextBox.Text;
                var reciver = reciveremailtextBox.Text;

                for (int i = 0; i < emailsenderearr.Length; i++)
                {
                    string line = emailsenderearr[i];

                    if (line.Contains("mail.To"))
                    {
                        line = String.Concat("mail.To ='", reciver, "'");
                    }
                    if (line.Contains("mail.Subject"))
                    {
                        line = String.Concat("mail.Subject ='", subject, "'");
                    }
                    if (line.Contains("mail.Body"))
                    {
                        line = String.Concat("mail.Body ='", body, "'");
                    }
                    emailsenderwriter.WriteLine(line);
                }

                emailsenderwriter.Close();
            }
            catch (Exception ex)  
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void runButton_Click(object sender, EventArgs e)
        {
            string runpath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, @"py\", "Run.bat");
            string helppath = Path.Combine("cd ",Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, @"py\");
            ChangeConfigFiles();
            
            MessageBox.Show(runpath);
            Process Process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.UseShellExecute = true;
           // startInfo.Verb = "runas";
            //startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = @"C:\Windows\System32\cmd.exe";
            startInfo.WorkingDirectory = helppath;
            startInfo.Arguments = "/c "+ runpath;
            Process.Start(startInfo);
             
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            ChangeConfigFiles();
        }

        
    }
}

/*
 * Get path to python installation form registry
 * 
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Python\PythonCore\3.9\InstallPath"))
                {
                    if (key != null)
                    {
                        Object o = key.GetValue("ExecutablePath");
                        if (o != null)
                        {
                            var xd = o as string;
                            MessageBox.Show(xd);
                                                                         
                        }
                    }
                }
*/

/*
 * Run cmd without showing it to user
               System.Diagnostics.Process.Start("CMD.exe", path);


               System.Diagnostics.Process process = new System.Diagnostics.Process();
               System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
               startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
               startInfo.FileName = "cmd.exe";
               startInfo.Arguments = path;
               process.StartInfo = startInfo;
               process.Start();
*/