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
using SPZLAB3;

namespace SPZLAB3.Forms
{
    public partial class AddUser : Form
    { 
        public Classes.User user { get; set; }
        public AddUser()
        {
            InitializeComponent();
        }
        public AddUser(ProgramManager programManager)
        {
            InitializeComponent();
            ProgramsCLbx.Items.AddRange(programManager.ProgramList.ToArray());
        }
        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            user = new User(UserNameTbx.Text, PasswordTbx.Text);
            foreach(var item in ProgramsCLbx.CheckedItems)
            {
                user.AddProgramToList((Classes.Program)item);
            }
            var programManagerEvent = new ProgramManagerEvent();
            programManagerEvent.programManagerEvent += ProgramManagerEvent.IncrementUser;
            programManagerEvent.OnEvent();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
