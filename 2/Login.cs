using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Login : Form
    {
        private User user1;
        private User user2;
        private User user3;
        private List<User> users;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            users = new List<User>();
            user1 = new User();
            user1.UserId = 1;
            user1.Username = "isam";
            user1.FullName = "isam";
            user1.Password = "112233";
            users.Add(user1);

            user2 = new User();
            user2.UserId = 2;
            user2.Username = "mohammad";
            user2.FullName = "mohammad";
            user2.Password = "445566";
            users.Add(user2);

            user3 = new User();
            user3.UserId = 3;
            user3.Username = "ayman";
            user3.FullName = "ayman";
            user3.Password = "778899";
            users.Add(user3);
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            bool isUserFound = false;
            foreach (User user in users)
            {
                if (user.Username == txtusername.Text && user.Password == txtpassword.Text)
                {
                    isUserFound = true;
                    MessageBox.Show("Welcome " + user.FullName);
                    break;
                }
            }
            if (!isUserFound)
            {
                MessageBox.Show("User does not exist or wrong password");
            }
        }
    }
}
