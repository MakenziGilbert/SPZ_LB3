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
    public partial class AddProgram : Form
    {
        public Classes.Program program { get; set; }
        public AddProgram()
        {
            InitializeComponent();
        }

        private void AddProgramDialogBtn_Click(object sender, EventArgs e)
        {
            program = new Classes.Program(NameTbx.Text, OsTypeCbx.SelectedItem.ToString(), ManufacturerTbx.Text, VersionTbx.Text);
            var programManagerEvent = new ProgramManagerEvent();
            programManagerEvent.programManagerEvent += ProgramManagerEvent.IncrementProgram;
            programManagerEvent.OnEvent();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
