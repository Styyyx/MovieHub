using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MovieHub
{
    public partial class loginForm : Form
    {
        private string connStr = "Data Source=.;Initial Catalog=MovieHub;Integrated Security=True";
        private int sessionClientId;
        //SqlDataAdapter watchedTableDA;

        public loginForm()
        {
            InitializeComponent();
        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT client_id FROM login WHERE username = @username AND password = @password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", txt_usernameLogin.Text);
                cmd.Parameters.AddWithValue("@password", txt_passwordLogin.Text);
                try
                {
                    conn.Open();
                    SqlDataReader sqlDR = cmd.ExecuteReader();
                    if (sqlDR.HasRows)
                    {
                        sqlDR.Read();
                        sessionClientId = sqlDR.GetInt32(0);
                        sqlDR.Close();
                        panel_login.Visible = false;
                        panel_home.Visible = true;
                        loadHomePanel();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username or Password");
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void loadHomePanel()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT * FROM movieLibrary";

                using (SqlDataAdapter sqlDA = new SqlDataAdapter(query, conn))
                {
                    DataTable t = new DataTable();
                    sqlDA.Fill(t);
                    dataGridView2.DataSource = t;
                }
                query = $"SELECT w.movie_id, m.name, w.favorite FROM watched as w INNER JOIN movieLibrary as m ON w.movie_id = m.movie_id WHERE w.client_id = {sessionClientId}";

                using (SqlDataAdapter sqlDA = new SqlDataAdapter(query, conn))
                {
                    DataTable table = new DataTable();
                    sqlDA.Fill(table);
                    dataGridView1.DataSource = table;
                    dataGridView1.Columns["movie_id"].ReadOnly = true;
                    dataGridView1.Columns["name"].ReadOnly = true;
                }
            }
        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel_login.Visible = false;
            panel_signup.Visible = true;
        }

        private void btn_createAccount_Click(object sender, EventArgs e)
        {
            int newClientId;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT COUNT(client_id) from client";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataReader sqlDR = cmd.ExecuteReader();
                    sqlDR.Read();
                    newClientId = 202100000 + sqlDR.GetInt32(0) + 1;
                    sessionClientId = newClientId;
                    conn.Close();
                }
            }
            string firstname, lastname, username, password, mobile, email, planName = "", payMethod = "";
            decimal planPrice = 0m;
            firstname = txt_firstName.Text;
            lastname = txt_lastName.Text;
            username = txt_usernameSignup.Text;
            password = txt_passwordSignup.Text;
            mobile = txt_mobileNum.Text;
            email = txt_email.Text;
            try
            {
                RadioButton rbPlan = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
                planName = rbPlan.Text;
                if (planName == "Basic") { planPrice = 169m; }
                else if (planName == "Standard") { planPrice = 369m; }
                else { planPrice = 469m; }
            }
            catch (Exception) { }

            try
            {
                RadioButton rbPayMethod = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
                payMethod = rbPayMethod.Text;
            }
            catch (Exception) { }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query;
                query = "INSERT INTO client VALUES(@client_id,@firstname,@lastname,@email,@mobile)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@client_id", newClientId);
                    cmd.Parameters.AddWithValue("@firstname", firstname);
                    cmd.Parameters.AddWithValue("@lastname", lastname);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@mobile", mobile);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                query = "INSERT INTO login VALUES(@client_id,@username,@password)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@client_id", newClientId);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                int newTransId;
                query = "SELECT COUNT(transaction_id) FROM transactions";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataReader sqlDR = cmd.ExecuteReader();
                    sqlDR.Read();
                    newTransId = 202100000 + sqlDR.GetInt32(0) + 1;
                    conn.Close();
                }

                query = "INSERT INTO transactions VALUES(@trans_id,@client_id,@planName,@planPrice,@subStart,@subEnd,@payMethod)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    DateTime subStart = DateTime.Today.Date;
                    DateTime subEnd = subStart.AddMonths(1).Date;

                    cmd.Parameters.AddWithValue("@trans_id", newTransId);
                    cmd.Parameters.AddWithValue("@client_id", newClientId);
                    cmd.Parameters.AddWithValue("@planName", planName);
                    cmd.Parameters.AddWithValue("@planPrice", planPrice);
                    cmd.Parameters.AddWithValue("@subStart", subStart);
                    cmd.Parameters.AddWithValue("@subEnd", subEnd);
                    cmd.Parameters.AddWithValue("@payMethod", payMethod);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            panel_home.Visible = true;
            panel_signup.Visible = false;
            loadHomePanel();
        }

        private void link_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel_login.Visible = true;
            panel_signup.Visible = false;
        }

        private void pictureBox_account_MouseClick(object sender, MouseEventArgs e)
        {
            panel_account.Visible = true;
            panel_home.Visible = false;
            loadAccountPanel();
        }

        private void loadAccountPanel()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query;
                query = "SELECT firstname, lastname, email, mobile FROM client WHERE client_id = @clientID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@clientID", sessionClientId);
                    try
                    {
                        conn.Open();
                        SqlDataReader sqlDR = cmd.ExecuteReader();
                        sqlDR.Read();
                        lbl_name.Text = $"Name: {sqlDR[0]} {sqlDR[1]}";
                        lbl_email.Text = $"Email: {sqlDR[2]}";
                        lbl_mobileNum.Text = $"Mobile Number: {sqlDR[3]}";
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        conn.Close();
                    }

                }
                query = "SELECT plan_name FROM transactions WHERE client_id = @clientID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@clientID", sessionClientId);
                    try
                    {
                        conn.Open();
                        SqlDataReader sqlDR = cmd.ExecuteReader();
                        sqlDR.Read();
                        lbl_plan.Text = $"Plan: {sqlDR.GetString(0)}";
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        conn.Close();
                    }
                }
            }
        }

        private void lbl_backAccount_Click(object sender, EventArgs e)
        {
            panel_home.Visible = true;
            panel_account.Visible = false;
            loadHomePanel();
        }

        private void link_signOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel_login.Visible = true;
            panel_home.Visible = false;
            txt_usernameLogin.Text = "";
            txt_passwordLogin.Text = "";
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string query = "UPDATE watched SET favorite=@value WHERE client_id=@clientId AND movie_id=@movieId";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    int rowIndex = e.RowIndex;
                    int movieId = (int)dataGridView1.Rows[rowIndex].Cells["movie_id"].Value;
                    Boolean value = (Boolean)dataGridView1.Rows[rowIndex].Cells["favorite"].Value;
                    cmd.Parameters.AddWithValue("@value", value);
                    cmd.Parameters.AddWithValue("@clientId", sessionClientId);
                    cmd.Parameters.AddWithValue("@movieId", movieId);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            panel_deleteAccount.Visible = true;
        }
        private void lbl_changePlan_Click(object sender, EventArgs e)
        {
            panel_changePlan.Visible = true;
        }
        private void lbl_changeMobileNum_Click(object sender, EventArgs e)
        {
            panel_changeMobile.Visible = true;
        }
        private void lbl_changePassword_Click(object sender, EventArgs e)
        {
            panel_changePassword.Visible = true;
        }

        private void btn_cancelDelete_Click(object sender, EventArgs e)
        {
            panel_deleteAccount.Visible = false;
        }

        private void btn_deleteAccount_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "DELETE FROM login WHERE client_id = @clientId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@clientId", sessionClientId);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                query = "DELETE FROM client WHERE client_id = @clientId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@clientId", sessionClientId);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            panel_deleteAccount.Visible = false;
            panel_account.Visible = false;
            panel_login.Visible = true;
        }

        private void btn_cancelPlan_Click(object sender, EventArgs e)
        {
            panel_changePlan.Visible = false;
        }

        private void btn_savePlan_Click(object sender, EventArgs e)
        {
            string newPlan = "";
            newPlan = groupBox2.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text;
            if (newPlan != "")
            {
                Decimal newPrice = 0m;
                if (newPlan == "Basic") { newPrice = 169m; }
                else if (newPlan == "Standard") { newPrice = 369m; }
                else { newPrice = 469m; }
                DateTime newStart = DateTime.Today.Date;
                DateTime newEnd = newStart.AddMonths(1).Date;
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string query = "UPDATE transactions SET plan_name = @newName, plan_price = @newPrice, sub_start = @newStart, sub_end = @newEnd WHERE client_id = @clientId";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@newName", newPlan);
                        cmd.Parameters.AddWithValue("@newPrice", newPrice);
                        cmd.Parameters.AddWithValue("@newStart", newStart);
                        cmd.Parameters.AddWithValue("@newEnd", newEnd);
                        cmd.Parameters.AddWithValue("@clientId", sessionClientId);
                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            panel_changePlan.Visible = false;
                            loadAccountPanel();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select plan before saving");
            }
        }

        private void btn_saveMobile_Click(object sender, EventArgs e)
        {
            string newMobile = "";
            newMobile = txt_newMobile.Text;
            if (newMobile != "")
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string query = "UPDATE client SET mobile = @newMobile WHERE client_id = @clientId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@newMobile", newMobile);
                        cmd.Parameters.AddWithValue("clientId", sessionClientId);

                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            panel_changeMobile.Visible = false;
                            loadAccountPanel();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Input");
                panel_changeMobile.Visible = false;
            }
        }

        private void btn_cancelMobile_Click(object sender, EventArgs e)
        {
            panel_changeMobile.Visible = false;
        }

        private void btn_savePassword_Click(object sender, EventArgs e)
        {
            string newPW = "";
            newPW = txt_newPassword.Text;
            if (newPW != "")
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string query = "UPDATE login SET password = @newPW WHERE client_id = @clientId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@newPW", newPW);
                        cmd.Parameters.AddWithValue("clientId", sessionClientId);

                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            panel_changePassword.Visible = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Input");
                panel_changePassword.Visible = false;
            }
        }

        private void btn_cancelPassword_Click(object sender, EventArgs e)
        {
            panel_changePassword.Visible = false;
        }
    }
}
