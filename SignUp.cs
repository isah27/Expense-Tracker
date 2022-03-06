using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Budget_App
{
    public partial class SignUp : KryptonForm
    {
        public SignUp()
        {
            InitializeComponent();
        }
        void signUp()
        {
            string name = nametxt.Text.Trim();
            string email = emailtxt.Text.Trim();
            string mobileNumber = mobiletxt.Text.Trim();
            string password = passwordtxt.Text.Trim();
            string dbName ="";
            int sign = 0;
            using (SQLiteConnection con = new SQLiteConnection(connections.connectionStrings()))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                //string authQuery = "SELECT * FROM auth";

                //SQLiteDataAdapter authadp = new SQLiteDataAdapter(authQuery, con);
                //DataTable dtauth = new DataTable();
                //authadp.Fill(dtauth);
                //if (dtauth.Rows.Count > 0)
                //{
                //    foreach(DataRow dr in dtauth.Rows)
                //    {
                //        dbName = (string) dr["name"];
                //        if (name ==dbName)
                //        {
                //            sign = 1;
                //        }
                //    }
                //}

                //if (sign != 1)
                //{
                try
                {
                    string querry = "INSERT INTO auth ( name,email,mobileNumber,profilePicture, password)VALUES( @name, @email, @mobileNumber, @profilePicture, @password)";
                    SQLiteCommand cmd = new SQLiteCommand(querry, con);

                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@mobileNumber", mobileNumber);
                    cmd.Parameters.AddWithValue("@profilePicture", "profilePicture");
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Login form = new Login();
                    this.Hide();
                    form.Show();
                    dbNameLabel.Text = "";
                }
                catch (Exception ex)
                {
                    dbNameLabel.Text = "Username already used";
                }
                    
                //}
                //else
                //{
                //    dbNameLabel.Text = "Username already used";
                //}

            }

        }

        private void submitbtn_Click_1(object sender, EventArgs e)
        {
            if (nametxt.Text != "" && emailtxt.Text != "" && mobiletxt.Text != "")
            {
                signUp();
            }
            else
            {
                MessageBox.Show("All field must be filled");
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void clickLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

       
    }
}
