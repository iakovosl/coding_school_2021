
namespace WindowsFormsApp1.WUI {
    partial class UniversityForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlnstituteName = new DevExpress.XtraEditors.TextEdit();
            this.ctrlYearsInService = new DevExpress.XtraEditors.TextEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ctrlAddStudent = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlnstituteName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlYearsInService.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(73, 73);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Institute Name :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(73, 133);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(84, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Years In service :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(281, 31);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(192, 23);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Add new University ";
            // 
            // ctrlnstituteName
            // 
            this.ctrlnstituteName.EditValue = "";
            this.ctrlnstituteName.Location = new System.Drawing.Point(160, 70);
            this.ctrlnstituteName.Name = "ctrlnstituteName";
            this.ctrlnstituteName.Size = new System.Drawing.Size(100, 20);
            this.ctrlnstituteName.TabIndex = 11;
            this.ctrlnstituteName.EditValueChanged += new System.EventHandler(this.ctrlnstituteName_EditValueChanged);
            // 
            // ctrlYearsInService
            // 
            this.ctrlYearsInService.EditValue = "";
            this.ctrlYearsInService.Location = new System.Drawing.Point(160, 130);
            this.ctrlYearsInService.Name = "ctrlYearsInService";
            this.ctrlYearsInService.Size = new System.Drawing.Size(32, 20);
            this.ctrlYearsInService.TabIndex = 12;
            this.ctrlYearsInService.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(511, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 32);
            this.button1.TabIndex = 13;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(651, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 32);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(679, 73);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 89);
            this.button5.TabIndex = 17;
            this.button5.Text = "Add Professor...";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // ctrlAddStudent
            // 
            this.ctrlAddStudent.Location = new System.Drawing.Point(539, 73);
            this.ctrlAddStudent.Name = "ctrlAddStudent";
            this.ctrlAddStudent.Size = new System.Drawing.Size(113, 89);
            this.ctrlAddStudent.TabIndex = 16;
            this.ctrlAddStudent.Text = "Add Student...";
            this.ctrlAddStudent.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(407, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 89);
            this.button3.TabIndex = 15;
            this.button3.Text = "Add Course...";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // UniversityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.ctrlAddStudent);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ctrlYearsInService);
            this.Controls.Add(this.ctrlnstituteName);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "UniversityForm";
            this.Text = "UniversityForm";
            ((System.ComponentModel.ISupportInitialize)(this.ctrlnstituteName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlYearsInService.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit ctrlnstituteName;
        private DevExpress.XtraEditors.TextEdit ctrlYearsInService;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button ctrlAddStudent;
        private System.Windows.Forms.Button button3;
    }
}