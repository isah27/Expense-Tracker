using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;


namespace Budget_App
{
    public partial class Login : KryptonForm
    {
        public static int session = 0;
        public static string myName = "";
        public Login()
        {
            InitializeComponent();
        }
        public void login()
        {
            using(SQLiteConnection con= new SQLiteConnection(connections.connectionStrings()))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string name = nametxt.Text.Trim();
                string password = passwordtxt.Text.Trim();
                string query = "SELECT * FROM auth WHERE name=@name";
                SQLiteCommand command = new SQLiteCommand(query, con);
                command.Parameters.AddWithValue("@name", name);
                command.ExecuteNonQuery();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach(DataRow dr in dt.Rows)
                    {
                        string dbName = dr["name"].ToString();
                        string dbPassword = dr["password"].ToString();
                        int id = Convert.ToInt32(dr["id"]);
                        if (dbName == name && dbPassword == password)
                        {
                            session = id;
                            myName = dbName;
                            Form1 form = new Form1();
                            this.Hide();
                            form.Show();
                            
                        }
                        else
                        {
                            MessageBox.Show("Invalid Password", "Wrong Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                  
                }
                else
                {
                    if(MessageBox.Show("Username Not Found...\n\nDo you want to create a new account?", "Wrong Login Details",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SignUp signUp = new SignUp();
                        signUp.Show();
                        this.Hide();
                    }
                    
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click_1(object sender, EventArgs e)
        {
            if (nametxt.Text != "" && passwordtxt.Text != "")
            {
                login();
                nametxt.Text = "";
                passwordtxt.Text = "";
            }
            else
            {
                MessageBox.Show("Please fill all the forms", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clickLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();

        }

        private void forgetpasswordbtn_Click_1(object sender, EventArgs e)
        {
            PasswordRecovery recovery = new PasswordRecovery();
            recovery.Show();
            this.Hide();
        }
    }
}
