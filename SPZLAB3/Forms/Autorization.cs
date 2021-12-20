using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPZLAB3.Classes;

namespace SPZLAB3.Forms
{
    public partial class Autorization : Form
    {
        public User newUser { get; set; }
        public UpdateUser newUpdateUser { get; set; }
        public Autorization(UpdateUser updateUser, User user)
        {
            InitializeComponent();
            NameLabel.Text = user.Name;
            newUser = user;
            newUpdateUser = updateUser;
        }

        private void AutorizBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PasswordInputTbx.Text))
            {
                if (newUser.Authentication(PasswordInputTbx.Text))
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    throw new ArgumentException($"Пароль введен неверно!");
                }
            }
        }
        public void OpenUpdateUser(UpdateUser updateUser, User user)
        {

        }
    }
}
