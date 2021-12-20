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
    public partial class UpdateProgram : Form
    {
        public Classes.Program newProgram { get; set; }
        public UpdateProgram(Classes.Program program, ProgramManager programManager)
        {
            InitializeComponent();
            newProgram = program;
            NameTbx.Text = program.Name;
            ManufacturerTbx.Text = program.Manufacturer;
            OsTypeTbx.Text = program.OSType;
            VersionTbx.Text = program.Version;
            InstDateLabel.Text = program.InstalDate.ToString();
            NecesFreqCPLabel.Text = program._frequencyCP + " GHz";
            NecesHDDMemLabel.Text = program._spaceHDD + " Gb";
            NecesOPLabel.Text = program._necessaryRam + " Mb";
            foreach(var item in programManager.UserDictionary)
            {
                if (program.blockedUsers.Contains(item.Key))
                    UsersForProgramCLbx.Items.Add(item.Key, true);
                else
                    UsersForProgramCLbx.Items.Add(item.Key, false);
            }
        }

        private void SaveCongForProgramBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NameTbx.Text))
                newProgram.Name = NameTbx.Text;
            if (!string.IsNullOrEmpty(ManufacturerTbx.Text))
                newProgram.Manufacturer = ManufacturerTbx.Text;
            if (!string.IsNullOrEmpty(OsTypeTbx.Text))
                newProgram.OSType = OsTypeTbx.Text;
            if (!string.IsNullOrEmpty(VersionTbx.Text))
                newProgram.Version = VersionTbx.Text;
            foreach (var item in UsersForProgramCLbx.Items)
                newProgram.RemoveBlockedUser(item.ToString());
            foreach (var item in UsersForProgramCLbx.CheckedItems)
                newProgram.AddBlockedUser(item.ToString());
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
