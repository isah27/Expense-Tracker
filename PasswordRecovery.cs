using System;
using System.Data;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SQLite;
using ComponentFactory.Krypton.Toolkit;

namespace Budget_App
{
    public partial class PasswordRecovery : KryptonForm
    {
        
        public PasswordRecovery()
        {
            InitializeComponent();
        }
        public void forgetPassword(string username)
        {
            string dbEmail = "";
            string dbPassword = "";
            string dbName = "";
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connections.connectionStrings()))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    string name = textBoxName.Text.Trim();
                    string query = "SELECT * FROM auth WHERE name=@name";
                    SQLiteCommand command = new SQLiteCommand(query, con);
                    command.Parameters.AddWithValue("@name", name);
                    command.ExecuteNonQuery();
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            dbEmail = dr["email"].ToString();
                            dbPassword = dr["password"].ToString();
                            dbName = dr["name"].ToString();
                            int id = Convert.ToInt32(dr["id"]);
                            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                            client.EnableSsl = true;
                            client.Timeout = 10;
                            client.DeliveryMethod = SmtpDeliveryMethod.Network;
                            client.UseDefaultCredentials = false;
                            client.Credentials = new NetworkCredential("isahusmanneziru27@gmail.com", "@gmail2.cim");
                            MailMessage message = new MailMessage();
                            message.From = new MailAddress("isahusmanneziru27@gmail.com");
                            message.To.Add(dbEmail);
                            message.Subject = "Password Recovery";
                            message.Body = "Dear " + name + "\nYour password is " + dbPassword;
                            client.Send(message);
                            MessageBox.Show("Password sent to your Email");
                            Login login = new Login();
                            login.Show();
                            this.Hide();
                        }

                    }
                    else
                    {
                        if (MessageBox.Show("Username '"+username+
                            "'  Not Found...\n\nDo you want to return to Login?", "Wrong Username", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Login login=new Login();
                            login.Show();
                            this.Hide();
                            
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonRecoverPassword_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text!="")
            {
                errorLabel.Text = "";
                forgetPassword(textBoxName.Text.Trim());
            }
            else
            {
                errorLabel.Text = "Fill in the form";   
            }
            
        }

        private void kryptonLinkLabel1_LinkClicked(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
