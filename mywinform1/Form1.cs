using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // SQL 연동을 위한 using

namespace mywinform1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            // Connect with MySql
            try
            {
                MySqlConnection connection = new MySqlConnection("Server=localhost; Database=yeodaewon; Uid=root; Pwd=dueodnjs1!");
                connection.Open();

                //로그인 상태변수 선언, 비로그인 상태는 0
                int login_status = 0;

                string loginid = id.Text;
                string loginpassword = password.Text;

                string selectQuery = "SELECT * FROM user WHERE User_id = \'" + loginid + "\' ";

                MySqlCommand Selectcommand = new MySqlCommand(selectQuery, connection);
                MySqlDataReader userAccount = Selectcommand.ExecuteReader();

                while (userAccount.Read())
                {
                    if (loginid == (string)userAccount["User_id"] && loginpassword == (string)userAccount["User_password"])
                    {
                        login_status = 1;
                    }
                }

                connection.Close();

                if (login_status == 1)
                {
                    MessageBox.Show("환영합니다.");
                }
                else
                {
                    MessageBox.Show("해커이신가요?");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            //string userId = id.Text;
            //string userPassword = password.Text;

            //if(userId.Equals("MyId") && userPassword.Equals("MyPassword"))
            //{
            //    MessageBox.Show("로그인에 성공했습니다.", "로그인");
            //}
            //else
            //{
            //    MessageBox.Show("로그인에 실패했습니다.", "로그인");
            //}

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            Form2 showform2 = new Form2();
            showform2.ShowDialog();            
        }
        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
