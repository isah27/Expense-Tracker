using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Budget_App
{
    public partial class Form1 : KryptonForm
    {
        budgetClass budgetClass = new budgetClass();
        public static bool isUpdate = false;
        int num = 0;//use to check if input data is number in tryParse method
        public static long spid;
        public Form1()
        {
            InitializeComponent();
            Extra2();
            FillData();
            FillChart();
            //label5.Text = "WELCOME "+Login.myName.ToUpper();
            if (isUpdate == true)
            {
                inputExpenseBtn.Text = " Update ";
            }
           
        }
        void getBudget()
        {
            budgettxt.Text = "";
            panel2.Visible = true;
            panel1.Visible = false;
        }
        private void inputExpenseBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(costtxt.Text.Trim(), out num))
            {
                if (isUpdate == true)
                {
                    if (exptxt.Text != "" && costtxt.Text != "")
                    {
                        budgetClass.updateExpens(((int)spid), exptxt.Text.ToString().Trim(), Convert.ToInt32(costtxt.Text.Trim()));
                        Extra2();
                        FillData();
                        clear();
                        FillChart();
                        inputExpenseBtn.Text = "INPUT EXPENSE";
                        costError.Text = "";
                    }
                }
                else
                {
                    if (exptxt.Text != "" && costtxt.Text != "")
                    {
                        int cost = Convert.ToInt32(costtxt.Text.Trim());
                        budgetClass.insertExpense(exptxt.Text.Trim(), cost);
                        Extra2();
                        FillData();
                        clear();
                        FillChart();
                        costError.Text = "";
                    }
                }
            }
            else
            {
                costError.Text = "Enter a valid figure";
            }
               
        }
        void clear()
        {
            exptxt.Text = "";
            costtxt.Text = "";
        }
        SQLiteDataAdapter expenseadp;
        DataTable dtExpense;
        public void Extra2()
        {

            // if(exptxt.Text!="" && costtxt.Text != "")
            // { }
            using (SQLiteConnection con = new SQLiteConnection(connections.connectionStrings()))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string budgetQuery = "SELECT * FROM Budget WHERE userId=@id";
                string expenseQuery = "SELECT * FROM expense WHERE userId=@id";

                SQLiteCommand budgetcmd = new SQLiteCommand(budgetQuery, con);
                budgetcmd.Parameters.AddWithValue("@id", Login.session);
                budgetcmd.ExecuteNonQuery();

                SQLiteCommand expensecmd = new SQLiteCommand(expenseQuery, con);
                expensecmd.Parameters.AddWithValue("@id", Login.session);
                expensecmd.ExecuteNonQuery();

                SQLiteDataAdapter budgetadp = new SQLiteDataAdapter(budgetcmd);
                expenseadp = new SQLiteDataAdapter(expensecmd);

                DataTable dtBudget = new DataTable();
                dtExpense = new DataTable();

                budgetadp.Fill(dtBudget);
                expenseadp.Fill(dtExpense);

                object budgetAmount = null;
                object expDesct = null;
                object expCost = null;
                object budgetBalance = null;


                if (dtBudget.Rows.Count > 0)
                {
                    panel1.Visible = false;
                    panel2.Visible = true;
                    display();
                    //string budgetAmount = null;
                    foreach (DataRow dr in dtBudget.Rows)
                    {
                        budgetAmount = (object)dr["budgetAmount"];
                        budgetBalance = (object)dr["budgetBalance"];
                    }
                    budgetValue.Text = budgetAmount.ToString();
                    if (dtExpense.Rows.Count >= 0)
                    {
                        foreach (DataRow dr in dtExpense.Rows)
                        {
                            expDesct = (object)dr["expDesc"];
                            expCost = (object)dr["expCost"];
                        }

                        BALC.Text = budgetBalance.ToString();
                    }
                }
                FillData();
                con.Close();
            }
        }    
        public void FillChart()
        {
            using (SQLiteConnection sqlcon = new SQLiteConnection(connections.connectionStrings()))
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                object budgetAmount = null;
                object budgetBalance = null;
                object expCost = null;
                int totalCost = 0;
                //Budget
                string budgetQuery = "SELECT * FROM Budget WHERE userId=@id";
                SQLiteCommand budgetcmd = new SQLiteCommand(budgetQuery, sqlcon);
                budgetcmd.Parameters.AddWithValue("@id", Login.session);
                budgetcmd.ExecuteNonQuery();
                SQLiteDataAdapter budgetadp = new SQLiteDataAdapter(budgetcmd);
                DataTable dtBudget = new DataTable();
                budgetadp.Fill(dtBudget);
                if (dtBudget.Rows.Count > 0)
                {
                    foreach (DataRow dr in dtBudget.Rows)
                    {

                        budgetAmount = (object)dr["budgetAmount"];
                        budgetBalance = (object)dr["budgetBalance"];

                    }
                }
                //Expense
                string expenseQuery = "SELECT * FROM expense WHERE userId=@id";
                SQLiteCommand expensecmd = new SQLiteCommand(expenseQuery, sqlcon);
                expensecmd.Parameters.AddWithValue("@id", Login.session);
                expensecmd.ExecuteNonQuery();
                SQLiteDataAdapter expenseadp = new SQLiteDataAdapter(expensecmd);
                DataTable dtExpense = new DataTable();
                expenseadp.Fill(dtExpense);
                //totalCostInDays
                string totalCostInDaysquery = "SELECT * FROM totalCostInDays WHERE userId=@id";
                SQLiteCommand command = new SQLiteCommand(totalCostInDaysquery,sqlcon);
                command.Parameters.AddWithValue("@id", Login.session);
                command.ExecuteNonQuery();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count >= 0)
                {
                    //Spine Chart or Line Chart
                    spineChart.Series["s2"].Points.Clear();
                    spineChart.Series["s2"].IsValueShownAsLabel = true;
                    foreach (DataRow dr in dt.Rows)
                    {
                        string date = Convert.ToString(dr["dates"]);
                        int totalcost = Convert.ToInt32(dr["totalCost"]);
                        spineChart.Series["s2"].Points.AddXY(date.ToString(), totalcost.ToString());
                    }
                }
               
                if (dtExpense.Rows.Count >= 0)
                {
                   
                    foreach (DataRow dr in dtExpense.Rows)
                    {
                        expCost = (object)dr["expCost"];
                        totalCost += Convert.ToInt32(expCost);
                    }
                }
                else
                {
                    totalCost = 0;
                }
                    //This is a Pie Chart
                    if(Convert.ToInt32(budgetBalance)!=0)
                    {

                        PieChart.Series["s1"].Points.Clear();
                        //PieChart.Titles.Add("Representation of Balance and Expense against your Budget");
                        PieChart.Series["s1"].IsValueShownAsLabel = true;
                        PieChart.Series["s1"].Points.AddXY("BALANCE", budgetBalance.ToString());
                        PieChart.Series["s1"].Points.AddXY("Expensed", totalCost.ToString());
                    }
                sqlcon.Close();
            }
          
        }

        private void inputbtn_Click_1(object sender, EventArgs e)
        {
            if (budgettxt.Text != "")
            {
                if (int.TryParse(budgettxt.Text.Trim(), out num))
                {
                    if (budgetValue.Text == "")
                    {
                        budgetClass.insertBudget(budgettxt.Text.Trim());
                        getBudget();
                        display();
                        budgettxt.Text = "";
                        inputbtn.Text = "INPUT BUDGET";
                    }
                    else if (budgetValue.Text != "")
                    {
                        budgetClass.ModifyBudget(Convert.ToInt32(budgettxt.Text.Trim()));
                        Extra2();
                        budgettxt.Text = "";
                        inputbtn.Text = "INPUT BUDGET";
                    }
                    FillChart();
                }
                else
                {
                    budgetErrorLabel.Text = "Enter a valid figure";
                }
                    
            }
            else
            {
                budgetErrorLabel.Text = "Empty Budget!!!";
            }
        }
        public void FillData()
        {
            using (SQLiteConnection con = new SQLiteConnection(connections.connectionStrings()))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string query = "SELECT * FROM expense WHERE userId=@id";
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                cmd.Parameters.AddWithValue("@id", Login.session);
                cmd.ExecuteNonQuery();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
               
                con.Close();
                   
                
                DataGridView1.DataSource = dt;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            FillData();
        }
        private void exptxt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void costtxt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void budgettxt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        void display()
        {
           
            BALANCE.Visible = true;
            budget.Visible = true;
            BALC.Visible = true;
            budgetValue.Visible = true;
            DataGridView1.Visible = true;
           
        }
       
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
            inputbtn.Text = "Update Budget";
        }
        private void deleteAccountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure you want to Delete this Account?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                budgetClass.DeleteAccount();
                Login login = new Login();
                login.Show();
                this.Hide();
            }     
        }
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void createAccoutntoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to create new account", "New Account", MessageBoxButtons.OKCancel,MessageBoxIcon.Information) == DialogResult.OK)
            {
                SignUp signUp = new SignUp();
                signUp.Show();
                this.Hide();
            }
        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (DataGridView1.Columns[e.ColumnIndex].Name == "updateBtn")
            {
                isUpdate = true;
                inputExpenseBtn.Text = "Modify";
                spid = Convert.ToInt64((DataGridView1.CurrentRow.Cells["IDS"].Value));
                exptxt.Text = DataGridView1.CurrentRow.Cells["expDesc"].Value.ToString();
                costtxt.Text = DataGridView1.CurrentRow.Cells["cost"].Value.ToString();
            }
            else if (DataGridView1.Columns[e.ColumnIndex].Name == "deleteBtn")
            {
                clear();
                budgetClass.DeleteExpense(Convert.ToInt32(DataGridView1.CurrentRow.Cells["IDS"].Value));
                budgetClass.UpdateBalance(Login.session);
                Extra2();
                FillData();
                FillChart();
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clear();
            isUpdate = false;
            inputExpenseBtn.Text = "INPUT EXPENSE";
        }
    }
}
