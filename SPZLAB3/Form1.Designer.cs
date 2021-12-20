
namespace SPZLAB3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProgramsLbx = new System.Windows.Forms.ListBox();
            this.UsersLbx = new System.Windows.Forms.ListBox();
            this.AddProgramBtn = new System.Windows.Forms.Button();
            this.DeleteProgramBtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.AddUserBtn = new System.Windows.Forms.Button();
            this.UsersComparisonBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DeleteUserBtn = new System.Windows.Forms.Button();
            this.ConfigurationLabel = new System.Windows.Forms.Label();
            this.ConpareprogramsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ПРОГРАММЫ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ПОЛЬЗОВАТЕЛИ";
            // 
            // ProgramsLbx
            // 
            this.ProgramsLbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProgramsLbx.FormattingEnabled = true;
            this.ProgramsLbx.ItemHeight = 20;
            this.ProgramsLbx.Location = new System.Drawing.Point(12, 45);
            this.ProgramsLbx.Name = "ProgramsLbx";
            this.ProgramsLbx.Size = new System.Drawing.Size(200, 284);
            this.ProgramsLbx.TabIndex = 2;
            this.ProgramsLbx.DoubleClick += new System.EventHandler(this.ProgramsLbx_DoubleClick);
            // 
            // UsersLbx
            // 
            this.UsersLbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersLbx.FormattingEnabled = true;
            this.UsersLbx.ItemHeight = 20;
            this.UsersLbx.Location = new System.Drawing.Point(289, 45);
            this.UsersLbx.Name = "UsersLbx";
            this.UsersLbx.Size = new System.Drawing.Size(200, 284);
            this.UsersLbx.TabIndex = 3;
            this.UsersLbx.DoubleClick += new System.EventHandler(this.UsersLbx_DoubleClick);
            // 
            // AddProgramBtn
            // 
            this.AddProgramBtn.Location = new System.Drawing.Point(15, 341);
            this.AddProgramBtn.Name = "AddProgramBtn";
            this.AddProgramBtn.Size = new System.Drawing.Size(95, 23);
            this.AddProgramBtn.TabIndex = 6;
            this.AddProgramBtn.Text = "ИНСТАЛЯЦИЯ";
            this.AddProgramBtn.UseVisualStyleBackColor = true;
            this.AddProgramBtn.Click += new System.EventHandler(this.AddProgramBtn_Click);
            // 
            // DeleteProgramBtn
            // 
            this.DeleteProgramBtn.Location = new System.Drawing.Point(15, 370);
            this.DeleteProgramBtn.Name = "DeleteProgramBtn";
            this.DeleteProgramBtn.Size = new System.Drawing.Size(117, 23);
            this.DeleteProgramBtn.TabIndex = 7;
            this.DeleteProgramBtn.Text = "ДЕИНСТАЛЯЦИЯ";
            this.DeleteProgramBtn.UseVisualStyleBackColor = true;
            this.DeleteProgramBtn.Click += new System.EventHandler(this.DeleteProgramBtn_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(125, 341);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "ОБНОВИТЬ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.Location = new System.Drawing.Point(306, 341);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(75, 23);
            this.AddUserBtn.TabIndex = 9;
            this.AddUserBtn.Text = "ДОБАВИТЬ";
            this.AddUserBtn.UseVisualStyleBackColor = true;
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // UsersComparisonBtn
            // 
            this.UsersComparisonBtn.Location = new System.Drawing.Point(400, 370);
            this.UsersComparisonBtn.Name = "UsersComparisonBtn";
            this.UsersComparisonBtn.Size = new System.Drawing.Size(75, 23);
            this.UsersComparisonBtn.TabIndex = 11;
            this.UsersComparisonBtn.Text = "СРАВНИТЬ";
            this.UsersComparisonBtn.UseVisualStyleBackColor = true;
            this.UsersComparisonBtn.Click += new System.EventHandler(this.UsersComparisonBtn_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(-6, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(510, 2);
            this.label3.TabIndex = 12;
            // 
            // DeleteUserBtn
            // 
            this.DeleteUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteUserBtn.Location = new System.Drawing.Point(306, 369);
            this.DeleteUserBtn.Name = "DeleteUserBtn";
            this.DeleteUserBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteUserBtn.TabIndex = 13;
            this.DeleteUserBtn.Text = "УДАЛИТЬ";
            this.DeleteUserBtn.UseVisualStyleBackColor = true;
            this.DeleteUserBtn.Click += new System.EventHandler(this.DeleteUserBtn_Click);
            // 
            // ConfigurationLabel
            // 
            this.ConfigurationLabel.AutoSize = true;
            this.ConfigurationLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfigurationLabel.Location = new System.Drawing.Point(15, 428);
            this.ConfigurationLabel.Name = "ConfigurationLabel";
            this.ConfigurationLabel.Size = new System.Drawing.Size(0, 13);
            this.ConfigurationLabel.TabIndex = 14;
            this.ConfigurationLabel.DoubleClick += new System.EventHandler(this.ConfigurationLabel_DoubleClick);
            // 
            // ConpareprogramsBtn
            // 
            this.ConpareprogramsBtn.Location = new System.Drawing.Point(138, 369);
            this.ConpareprogramsBtn.Name = "ConpareprogramsBtn";
            this.ConpareprogramsBtn.Size = new System.Drawing.Size(75, 23);
            this.ConpareprogramsBtn.TabIndex = 15;
            this.ConpareprogramsBtn.Text = "СРАВНИТЬ";
            this.ConpareprogramsBtn.UseVisualStyleBackColor = true;
            this.ConpareprogramsBtn.Click += new System.EventHandler(this.ConpareprogramsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 450);
            this.Controls.Add(this.ConpareprogramsBtn);
            this.Controls.Add(this.ConfigurationLabel);
            this.Controls.Add(this.DeleteUserBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UsersComparisonBtn);
            this.Controls.Add(this.AddUserBtn);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.DeleteProgramBtn);
            this.Controls.Add(this.AddProgramBtn);
            this.Controls.Add(this.UsersLbx);
            this.Controls.Add(this.ProgramsLbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ProgramsLbx;
        private System.Windows.Forms.ListBox UsersLbx;
        private System.Windows.Forms.Button AddProgramBtn;
        private System.Windows.Forms.Button DeleteProgramBtn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button AddUserBtn;
        private System.Windows.Forms.Button UsersComparisonBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DeleteUserBtn;
        private System.Windows.Forms.Label ConfigurationLabel;
        private System.Windows.Forms.Button ConpareprogramsBtn;
    }
}

