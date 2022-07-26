using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using Npgsql;

namespace Project_Windows
{ 
    internal class DataAccess
    {
        public List<Users> GetUsers()
        {
            try
            {
                using (IDbConnection con = new NpgsqlConnection(Helper.CnnVal("epiz")))
                {
                    var output = con.Query<Users>($"SELECT * FROM Users LIMIT 5").ToList();
                    return output;
                }
            }
            catch
            {
                List<Users> users = new List<Users>();
                users.Add(new Users());
                MessageBox.Show("Connection Error !");
                return users;
            }
            
        }

        public List<Users> ShowUser(string Login)
        {
            try
            {
                using (IDbConnection con = new NpgsqlConnection(Helper.CnnVal("epiz")))
                {
                    var output = con.Query<Users>($"SELECT * FROM Users WHERE login = '{ Login }'").ToList();
                    return output;
                }
            }
            catch
            {
                List<Users> users = new List<Users>();
                users.Add(new Users());
                MessageBox.Show("Connection Error !");
                return users;
            }

        }

        public void AddUser(string Login, string Password, string Email, string Role)
        {
            try
            {
                using (IDbConnection con = new NpgsqlConnection(Helper.CnnVal("epiz")))
                {
                    List<Users> users = new List<Users>();

                    users.Add(new Users { Login = Login, Password = Password, Email = Email, Role = Role });

                    con.Execute($"INSERT INTO Users ( login, password, email, role) values ('{Login}','{Password}','{Email}','{Role}')");
                }
            }
            catch
            {
                MessageBox.Show("Connection Error !");
            }
            
        }

        public void UpdateUser(int Id ,string Login, string Password, string Email, string Role)
        {
            using (IDbConnection con = new NpgsqlConnection(Helper.CnnVal("epiz")))
            {
   
                con.Execute($"UPDATE Users SET login = '{ Login }', password = '{ Password }', email = '{ Email }', role = '{ Role }' WHERE id = '{ Id }'");
            }
        }


        public void UpdateTime(string Login, string Date)
        {
            using (IDbConnection con = new NpgsqlConnection(Helper.CnnVal("epiz")))
            {
                con.Execute($"UPDATE Users SET last_login = '{ Date }' WHERE login = '{ Login }'");
            }
        }

        public void ChangePassword(string Login, string Password)
        {
            using (IDbConnection con = new NpgsqlConnection(Helper.CnnVal("epiz")))
            {
                con.Execute($"UPDATE Users SET password = '{Password}' WHERE login = '{Login}'");
            }
        }


        public bool LoginValidation(string Login, string Password)
        {
            try
            {
                using (IDbConnection con = new NpgsqlConnection(Helper.CnnVal("epiz")))
                {
                    var output = con.Query($"SELECT * FROM USERS WHERE Login = '{Login}' AND Password = '{Password}'").Count();

                    if (output > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            catch
            {
                MessageBox.Show("Connection Error !");
                return false;
            }
            
            
            
        }

        public bool RoleVerification(string Login)
        {
            using (IDbConnection con = new NpgsqlConnection(Helper.CnnVal("epiz")))
            {
                var output = con.Query($"SELECT ROLE FROM USERS WHERE Login = '{Login}'").Count();
                

                if (output > 0)
                {
                    return true;
                }
                else
                {
                    return false;

                }
                
            }
            
        }

    }
}
