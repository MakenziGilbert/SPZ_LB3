
namespace SPZLAB3.Forms
{
    partial class AddProgram
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.OsTypeCbx = new System.Windows.Forms.ComboBox();
            this.NameTbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ManufacturerTbx = new System.Windows.Forms.TextBox();
            this.VersionTbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddProgramDialogBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(34, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // OsTypeCbx
            // 
            this.OsTypeCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OsTypeCbx.FormattingEnabled = true;
            this.OsTypeCbx.Items.AddRange(new object[] {
            "Windows",
            "Linux",
            "MacOS"});
            this.OsTypeCbx.Location = new System.Drawing.Point(161, 89);
            this.OsTypeCbx.Name = "OsTypeCbx";
            this.OsTypeCbx.Size = new System.Drawing.Size(100, 28);
            this.OsTypeCbx.TabIndex = 1;
            // 
            // NameTbx
            // 
            this.NameTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTbx.Location = new System.Drawing.Point(161, 44);
            this.NameTbx.Name = "NameTbx";
            this.NameTbx.Size = new System.Drawing.Size(177, 26);
            this.NameTbx.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(34, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Тип ОС";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(33, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Изготовитель";
            // 
            // ManufacturerTbx
            // 
            this.ManufacturerTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManufacturerTbx.Location = new System.Drawing.Point(161, 134);
            this.ManufacturerTbx.Name = "ManufacturerTbx";
            this.ManufacturerTbx.Size = new System.Drawing.Size(177, 26);
            this.ManufacturerTbx.TabIndex = 5;
            // 
            // VersionTbx
            // 
            this.VersionTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VersionTbx.Location = new System.Drawing.Point(161, 180);
            this.VersionTbx.Name = "VersionTbx";
            this.VersionTbx.Size = new System.Drawing.Size(100, 26);
            this.VersionTbx.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(34, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Версия";
            // 
            // AddProgramDialogBtn
            // 
            this.AddProgramDialogBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddProgramDialogBtn.Location = new System.Drawing.Point(114, 219);
            this.AddProgramDialogBtn.Name = "AddProgramDialogBtn";
            this.AddProgramDialogBtn.Size = new System.Drawing.Size(124, 33);
            this.AddProgramDialogBtn.TabIndex = 8;
            this.AddProgramDialogBtn.Text = "Инсталяция";
            this.AddProgramDialogBtn.UseVisualStyleBackColor = true;
            this.AddProgramDialogBtn.Click += new System.EventHandler(this.AddProgramDialogBtn_Click);
            // 
            // AddProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 264);
            this.Controls.Add(this.AddProgramDialogBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VersionTbx);
            this.Controls.Add(this.ManufacturerTbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTbx);
            this.Controls.Add(this.OsTypeCbx);
            this.Controls.Add(this.label1);
            this.Name = "AddProgram";
            this.Text = "AddProgram";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox OsTypeCbx;
        private System.Windows.Forms.TextBox NameTbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ManufacturerTbx;
        private System.Windows.Forms.TextBox VersionTbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddProgramDialogBtn;
    }
}