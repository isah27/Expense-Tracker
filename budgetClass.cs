using System;
using System.Data;
using System.Data.SQLite;

namespace Budget_App
{
    class budgetClass
    {

        public void insertBudget(string amount)
        {
            string budgetAmount = amount;

            using (SQLiteConnection con = new SQLiteConnection(connections.connectionStrings()))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string querry = "INSERT INTO budget ( userId,budgetAmount,budgetBalance)VALUES( @userId,@budgetAmount, @budgetBalance)";
                SQLiteCommand cmd = new SQLiteCommand(querry, con);
                cmd.Parameters.AddWithValue("@userId", Login.session);
                cmd.Parameters.AddWithValue("@budgetAmount", budgetAmount);
                cmd.Parameters.AddWithValue("@budgetBalance", budgetAmount);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void DeleteExpense(int id)
        {
           
                using (SQLiteConnection sqlcon = new SQLiteConnection(connections.connectionStrings()))
                {
                    if (sqlcon.State == ConnectionState.Closed)
                        sqlcon.Open();
                    SQLiteCommand com = new SQLiteCommand("SELECT * FROM expense WHERE (Id,userId)=(@id,@userId)", sqlcon);
                    com.Parameters.AddWithValue("@id", id);
                    com.Parameters.AddWithValue("userId", Login.session);
                    com.ExecuteNonQuery();
                    SQLiteDataAdapter data = new SQLiteDataAdapter(com);
                    DataTable dt = new DataTable();
                    data.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            string date = Convert.ToString(dr["dates"]);
                            int expCost = Convert.ToInt32(dr["expCost"]);
                            string totalCostInDaysQuery = "SELECT * FROM totalCostInDays WHERE (userId,dates)=(@id ,@date) ";
                            SQLiteCommand command = new SQLiteCommand(totalCostInDaysQuery, sqlcon);
                            command.Parameters.AddWithValue("@id", Login.session);
                            command.Parameters.AddWithValue("@date", date);
                            command.ExecuteNonQuery();
                            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            if (dataTable.Rows.Count > 0)
                            {
                                int totalCost = 0;
                                foreach (DataRow dat in dataTable.Rows)
                                {
                                    totalCost = Convert.ToInt32(dat["totalCost"]) - expCost;
                                    string insertQuery = "UPDATE totalCostInDays SET totalCost= @totalcost WHERE (userId,dates)=(@id ,@date)";
                                    SQLiteCommand cmds = new SQLiteCommand(insertQuery, sqlcon);
                                    cmds.Parameters.AddWithValue("@totalCost", totalCost);
                                    cmds.Parameters.AddWithValue("@id", Login.session);
                                    cmds.Parameters.AddWithValue("@date", date);
                                    cmds.ExecuteNonQuery();
                                }
                            }
                        }
                        
                    }
                    SQLiteCommand sqlcmd = new SQLiteCommand("DELETE FROM expense WHERE Id=@Id", sqlcon);
                    sqlcmd.Parameters.AddWithValue("@Id", id);
                    sqlcmd.ExecuteNonQuery();
                    SQLiteCommand cmd = new SQLiteCommand("DELETE FROM totalCostInDays WHERE totalCost=@cost",sqlcon);
                    cmd.Parameters.AddWithValue("@cost", 0);
                    cmd.ExecuteNonQuery();
                }
                UpdateBalance(Login.session);  
            
        }

        public void updateExpens(int id, string exp, int cost)
        {
            using (SQLiteConnection sqlcon = new SQLiteConnection(connections.connectionStrings()))
            {
                sqlcon.Open();
               
                SQLiteCommand com = new SQLiteCommand("SELECT * FROM expense WHERE (Id,userId)=(@id,@userId)", sqlcon);
                com.Parameters.AddWithValue("@id", id);
                com.Parameters.AddWithValue("userId", Login.session);
                com.ExecuteNonQuery();
                SQLiteDataAdapter data = new SQLiteDataAdapter(com);
                DataTable dt = new DataTable();
                data.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        string date = Convert.ToString(dr["dates"]);
                        int expCost = Convert.ToInt32(dr["expCost"]);
                        string totalCostInDaysQuery = "SELECT * FROM totalCostInDays WHERE (userId,dates)=(@id ,@date) ";
                        SQLiteCommand command = new SQLiteCommand(totalCostInDaysQuery, sqlcon);
                        command.Parameters.AddWithValue("@id", Login.session);
                        command.Parameters.AddWithValue("@date", date);
                        command.ExecuteNonQuery();
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        if (dataTable.Rows.Count > 0)
                        {
                            int totalCost = 0;
                            foreach (DataRow dat in dataTable.Rows)
                            {

                                totalCost = Convert.ToInt32(dat["totalCost"]) - expCost+cost;
                                string insertQuery = "UPDATE totalCostInDays SET totalCost= @totalcost WHERE (userId,dates)=(@id ,@date)";
                                SQLiteCommand cmds = new SQLiteCommand(insertQuery, sqlcon);
                                cmds.Parameters.AddWithValue("@totalCost", totalCost);
                                cmds.Parameters.AddWithValue("@id", Login.session);
                                cmds.Parameters.AddWithValue("@date", date);
                                cmds.ExecuteNonQuery();
                            }
                        }
                    }


                    SQLiteCommand cmd = new SQLiteCommand("UPDATE expense SET (expDesc,expCost)=(@desc,@cost) WHERE (userId,id)=(@userId,@id)", sqlcon);
                    cmd.Parameters.AddWithValue("@desc", exp);
                    cmd.Parameters.AddWithValue("@cost", cost);
                    cmd.Parameters.AddWithValue("@userId", Login.session);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();
                    Form1 form1 = new Form1();
                    form1.FillData();
                    form1.FillChart();
                    UpdateBalance(Login.session);
                }
            }
        }      
        
        public void insertExpense(string desc, int cost)
        {
            //string budgetAmount = budgettxt.Text.Trim();
            using (SQLiteConnection con = new SQLiteConnection(connections.connectionStrings()))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string querry = "INSERT INTO expense (userId, expDesc, expCost, dates)VALUES(@userId, @expDesc, @expCost,@dates)";
                SQLiteCommand cmd = new SQLiteCommand(querry, con);
                cmd.Parameters.AddWithValue("@userId", Login.session);
                cmd.Parameters.AddWithValue("@expDesc", desc);
                cmd.Parameters.AddWithValue("@expCost", cost);
                cmd.Parameters.AddWithValue("@dates", DateTime.Now.ToShortDateString());
                cmd.ExecuteNonQuery();
                /*
                 check if totalCostInDays table contain today date
                if exist add cost to totalCost
                else create new entry
                 */
                string totalCostInDaysQuery = "SELECT * FROM totalCostInDays WHERE (userId,dates)=(@id ,@date) ";
                SQLiteCommand command = new SQLiteCommand(totalCostInDaysQuery, con);
                command.Parameters.AddWithValue("@id", Login.session);
                command.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());
                command.ExecuteNonQuery();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    int totalCost = 0;
                    foreach(DataRow dr in dataTable.Rows)
                    {
                        totalCost = Convert.ToInt32(dr["totalCost"])+cost;
                    }
                    string insertQuery = "UPDATE totalCostInDays SET totalCost= @totalcost WHERE (userId,dates)=(@id ,@date)";
                    SQLiteCommand cmds = new SQLiteCommand(insertQuery, con);
                    cmds.Parameters.AddWithValue("@totalCost", totalCost);
                    cmds.Parameters.AddWithValue("@id", Login.session);
                    cmds.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());
                    cmds.ExecuteNonQuery();
                    //MessageBox.Show("data exist");
                }
                else
                {
                    string insertQuery = "INSERT INTO totalCostInDays(userId,totalCost,dates) VALUES(@id,@totalcost,@date)";
                    SQLiteCommand cmds = new SQLiteCommand(insertQuery, con);
                    cmds.Parameters.AddWithValue("@id", Login.session);
                    cmds.Parameters.AddWithValue("@totalCost", cost);
                    cmds.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());
                    cmds.ExecuteNonQuery();
                }

                UpdateBalance(Login.session);
                Form1 form = new Form1();
                form.Extra2();
                con.Close();
            }

        }
        public void UpdateBalance(int id)
        {

            using (SQLiteConnection sqlcon = new SQLiteConnection(connections.connectionStrings()))
            {
                sqlcon.Open();
                SQLiteCommand cmd = new SQLiteCommand("UPDATE budget SET budgetBalance=@budgetBalance WHERE userId=@Id", sqlcon);
                string budgetQuery = "SELECT * FROM Budget WHERE userId=@id";
                string expenseQuery = "SELECT * FROM expense WHERE userId=@id";
                SQLiteCommand totInDayscmd = new SQLiteCommand("UPDATE ");
                SQLiteCommand budgetcmd = new SQLiteCommand(budgetQuery, sqlcon);
                budgetcmd.Parameters.AddWithValue("@id", Login.session);
                budgetcmd.ExecuteNonQuery();
                SQLiteCommand expensecmd = new SQLiteCommand(expenseQuery, sqlcon);
                expensecmd.Parameters.AddWithValue("@id", Login.session);
                expensecmd.ExecuteNonQuery();
                SQLiteDataAdapter expenseadp = new SQLiteDataAdapter(expensecmd);
                SQLiteDataAdapter budgetadp = new SQLiteDataAdapter(budgetcmd);
                DataTable dtExpense = new DataTable();
                DataTable dtBudget = new DataTable();
                expenseadp.Fill(dtExpense);
                budgetadp.Fill(dtBudget);

                object budgetAmount = null;
                object expCost = null;
                int totalCost = 0;


                if (dtBudget.Rows.Count > 0)
                {
                    foreach (DataRow dr in dtBudget.Rows)
                    {

                        budgetAmount = (object)dr["budgetAmount"];

                    }
                }
                if (dtExpense.Rows.Count > 0)
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

                int balance = Convert.ToInt32(budgetAmount) - (totalCost);
                cmd.Parameters.AddWithValue("@budgetBalance", balance);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                sqlcon.Close();
                Form1 form1 = new Form1();
                form1.FillData();
                form1.FillChart();
            }

        }

        public void DeleteAccount()
        {
            using (SQLiteConnection sqlcon = new SQLiteConnection(connections.connectionStrings()))
            {
                sqlcon.Open();
                SQLiteCommand cmd = new SQLiteCommand("DELETE FROM auth WHERE id=@id", sqlcon);
                cmd.Parameters.AddWithValue("@id", Login.session);
                cmd.ExecuteNonQuery();
                string budgetQuery = "DELETE FROM Budget WHERE userId=@id";
                string expenseQuery = "DELETE FROM expense WHERE userId=@id";

                SQLiteCommand budgetcmd = new SQLiteCommand(budgetQuery, sqlcon);
                budgetcmd.Parameters.AddWithValue("@id", Login.session);
                budgetcmd.ExecuteNonQuery();
                SQLiteCommand expensecmd = new SQLiteCommand(expenseQuery, sqlcon);
                expensecmd.Parameters.AddWithValue("@id", Login.session);
                expensecmd.ExecuteNonQuery();
                SQLiteCommand cmdTotal = new SQLiteCommand("DELETE FROM totalCostInDays WHERE userId=@id", sqlcon);
                cmd.Parameters.AddWithValue("@id", Login.session);
                cmd.ExecuteNonQuery();

            }
        }

        public void ModifyBudget(int amount)
        {
            using (SQLiteConnection sqlcon = new SQLiteConnection(connections.connectionStrings()))
            {
                sqlcon.Open();
                SQLiteCommand cmd = new SQLiteCommand("UPDATE budget SET budgetAmount=@budgetAmount WHERE userId=@Id", sqlcon);
                cmd.Parameters.AddWithValue("@budgetAmount", amount);
                cmd.Parameters.AddWithValue("@Id", Login.session);
                cmd.ExecuteNonQuery();
                UpdateBalance(Login.session);
            }
        }
    }
}

