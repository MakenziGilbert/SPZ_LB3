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
    public partial class UpdateUser : Form
    {
        public User newUser { get; set; }
        public UpdateUser(User user, ProgramManager programManager)
        {
            InitializeComponent();
            user.CheckForBlocking(programManager.ProgramList);
            newUser = user;
            NameTbx.Text = user.Name;
            PasswordTbx.Text = user.Password;
            foreach (var item in programManager.ProgramList)
            {
                if(!item.blockedUsers.Contains(user.Name))
                {
                    if (user.programList.Contains(item))
                    {
                        ProgramsCLbx.Items.Add(item, true);
                    }
                    else
                        ProgramsCLbx.Items.Add(item, false);
                }

            }
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in ProgramsCLbx.Items)
                newUser.DeleteProgramFromlist((Classes.Program)item);
            foreach (var item in ProgramsCLbx.CheckedItems)
                newUser.AddProgramToList((Classes.Program)item);

            if(!string.IsNullOrEmpty(NameTbx.Text))
                newUser.Name = NameTbx.Text;
            if (!string.IsNullOrEmpty(PasswordTbx.Text))
                newUser.Password = PasswordTbx.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
