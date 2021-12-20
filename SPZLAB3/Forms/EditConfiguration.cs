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
    public partial class EditConfiguration : Form
    {
        public ProgramManager newProgramManager { get; set; }
        public EditConfiguration(ProgramManager programManager)
        {
            InitializeComponent();
            newProgramManager = programManager;
            textBox1.Text = programManager.FrequencyCP;
            textBox2.Text = programManager.Ram;
            textBox3.Text = programManager.SpaceHDD;
            textBox4.Text = programManager.OsType;
            UserAmountLabel.Text = ProgramManager.AmountOfUsers.ToString();
            ProgramAmountLabel.Text = ProgramManager.AmountOfPrograms.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
                newProgramManager.FrequencyCP = textBox1.Text;
            if (!string.IsNullOrEmpty(textBox2.Text))
                newProgramManager.Ram = textBox2.Text;
            if (!string.IsNullOrEmpty(textBox3.Text))
                newProgramManager.SpaceHDD = textBox3.Text;
            if (!string.IsNullOrEmpty(textBox4.Text))
                newProgramManager.OsType = textBox4.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

    }
}
