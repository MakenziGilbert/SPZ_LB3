using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPZLAB3.Forms;
using SPZLAB3.Classes;

namespace SPZLAB3
{
    public partial class Form1 : Form
    {
        ProgramManager programManager = new ProgramManager();
        public Form1()
        {
            InitializeComponent();
            ConfigurationLabel.Text = programManager.PrintConfiguration();
        }
        private void AddProgramBtn_Click(object sender, EventArgs e)
        {
            var addProgramDialog = new AddProgram();
            addProgramDialog.StartPosition = FormStartPosition.CenterParent;
            if(addProgramDialog.ShowDialog() == DialogResult.OK)
            {
                ProgramsLbx.Items.Clear();
                programManager.AddProgram(addProgramDialog.program);
                ProgramsLbx.Items.AddRange(programManager.ProgramList.ToArray());
            }
        }
        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            var addUserDialog = new AddUser(programManager);
            addUserDialog.StartPosition = FormStartPosition.CenterParent;
            if(addUserDialog.ShowDialog() == DialogResult.OK)
            {
                UsersLbx.Items.Clear();
                programManager.AddUser(addUserDialog.user);
                UsersLbx.Items.AddRange(programManager.UserList.ToArray());
            }
        }

        private void DeleteProgramBtn_Click(object sender, EventArgs e)
        {
            programManager.DeleteProgram(ProgramsLbx.SelectedIndex);
            ProgramsLbx.Items.Clear();
            ProgramsLbx.Items.AddRange(programManager.ProgramList.ToArray());
            var programManagerEvent = new ProgramManagerEvent();
            programManagerEvent.programManagerEvent += ProgramManagerEvent.DecrementProgram;
            programManagerEvent.OnEvent();
        }

        private void DeleteUserBtn_Click(object sender, EventArgs e)
        {
            User someUser = (User)UsersLbx.SelectedItem;
            programManager.DeleteUser(someUser.Name);
            UsersLbx.Items.Clear();
            UsersLbx.Items.AddRange(programManager.UserList.ToArray());
            var programManagerEvent = new ProgramManagerEvent();
            programManagerEvent.programManagerEvent += ProgramManagerEvent.DecrementUser;
            programManagerEvent.OnEvent();
        }

        private void ConfigurationLabel_DoubleClick(object sender, EventArgs e) // Конфигурация ПК
        {
            var configDiaog = new EditConfiguration(programManager);
            configDiaog.StartPosition = FormStartPosition.CenterParent;
            if(configDiaog.ShowDialog() == DialogResult.OK)
            {
                programManager = configDiaog.newProgramManager;
                ConfigurationLabel.Text = programManager.PrintConfiguration();
            }
        }

        private void ProgramsLbx_DoubleClick(object sender, EventArgs e) // Редактировать программу
        {
            var updateProgram = new UpdateProgram((Classes.Program)ProgramsLbx.SelectedItem, programManager);
            updateProgram.StartPosition = FormStartPosition.CenterParent;
            if(updateProgram.ShowDialog() == DialogResult.OK)
            {
                Classes.Program someprogram = (Classes.Program)ProgramsLbx.SelectedItem;
                programManager.ProgramList[ProgramsLbx.SelectedIndex] = updateProgram.newProgram;
                programManager.DeleteProgram(ProgramsLbx.SelectedIndex);
                programManager.AddProgram(someprogram);
                ProgramsLbx.Items.Clear();
                ProgramsLbx.Items.AddRange(programManager.ProgramList.ToArray());
            }
        }

        private void UsersLbx_DoubleClick(object sender, EventArgs e) // Редактировать пользователя
        {
            var updateUser = new UpdateUser((User)UsersLbx.SelectedItem, programManager);
            User someuser = (User)UsersLbx.SelectedItem;
            string oldName = someuser.Name;
            var autorizationDialog = new Autorization(updateUser, (User)UsersLbx.SelectedItem);
            autorizationDialog.StartPosition = FormStartPosition.CenterParent;
            if(autorizationDialog.ShowDialog() == DialogResult.OK)
            {
                if (updateUser.ShowDialog() == DialogResult.OK)
                {
                    programManager.UserList[UsersLbx.SelectedIndex] = updateUser.newUser;
                    programManager.DeleteUser(oldName);
                    programManager.DeleteUser(someuser.Name);
                    programManager.AddUser(updateUser.newUser);
                    UsersLbx.Items.Clear();
                    UsersLbx.Items.AddRange(programManager.UserList.ToArray());
                }
            }
        }

        private void button5_Click(object sender, EventArgs e) // Обновить версию
        {
            programManager.UpdateThisProgram(ProgramsLbx.SelectedIndex);
            ProgramsLbx.Items.Clear();
            ProgramsLbx.Items.AddRange(programManager.ProgramList.ToArray());
        }
        private List<User> compareUsers = new List<User>();
        private void UsersComparisonBtn_Click(object sender, EventArgs e)
        {
            compareUsers.Add((User)UsersLbx.SelectedItem);
            if(compareUsers.Count == 2)
            {
                if(programManager.CompareTwousers(compareUsers[0], compareUsers[1]))
                {
                    MessageBox.Show($"Пользователи {compareUsers[0].Name} и {compareUsers[1].Name} равны. У каждого по {compareUsers[0].programList.Count} программ.",
                        "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
                else
                {
                    MessageBox.Show($"Пользователи {compareUsers[0].Name} и {compareUsers[1].Name} не равны. {compareUsers[0].programList.Count} и {compareUsers[1].programList.Count} программ.",
                                         "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
                compareUsers.Clear();
            }
        }
        private List<Classes.Program> comparePrograms = new List<Classes.Program>();
        private void ConpareprogramsBtn_Click(object sender, EventArgs e)
        {
            comparePrograms.Add((Classes.Program)ProgramsLbx.SelectedItem);
            if(comparePrograms.Count==2)
            {
                if(programManager.CompareTwoprograms(comparePrograms[0], comparePrograms[1]))
                {
                    MessageBox.Show($"Программа {comparePrograms[0].Name} требовательней программы {comparePrograms[1].Name}. {comparePrograms[0]._frequencyCP} GHz и {comparePrograms[1]._frequencyCP} GHz, " +
                        $"{comparePrograms[0]._necessaryRam} Mb и {comparePrograms[1]._necessaryRam} Mb, {comparePrograms[0]._spaceHDD} Gb и {comparePrograms[1]._spaceHDD} Gb соответственно.",
                    "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
                else
                {
                    MessageBox.Show($"Программа {comparePrograms[1].Name} требовательней программы {comparePrograms[0].Name}. {comparePrograms[1]._frequencyCP} GHz и {comparePrograms[0]._frequencyCP} GHz, " +
             $"{comparePrograms[1]._necessaryRam} Mb и {comparePrograms[0]._necessaryRam} Mb, {comparePrograms[1]._spaceHDD} Gb и {comparePrograms[0]._spaceHDD} Gb соответственно.",
         "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
            }
        }
    }
}
