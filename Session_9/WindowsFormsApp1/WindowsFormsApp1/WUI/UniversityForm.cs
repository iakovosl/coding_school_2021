using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Impl;

namespace WindowsFormsApp1.WUI {
    public partial class UniversityForm : Form {

        // PROPERTIES ????
        public University NewUniversity { get; set; }

        // CONSTRUCTOR
        public UniversityForm() {
            InitializeComponent();
        }


        // METHODS
        private void UniversityForm_Load(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {

            // todo: CANCEL EVERYTHING -- DO NOT MODIFY THE OBJECT!

            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button1_Click(object sender, EventArgs e) {

            if (ctrlnstituteName.EditValue.ToString().Length > 0) {

                // 1. MODIFY THE OBJECT STUDENT
                NewUniversity.InstituteName = Convert.ToString(ctrlnstituteName.EditValue);

                NewUniversity.YearsInService = Convert.ToInt32(ctrlYearsInService.EditValue);


                // 2. CLOSE THE FORM!

                DialogResult = DialogResult.OK;
                Close();
            }
            else {

                MessageBox.Show("Please insert Institute Name!");
            }
        }

        private void button2_Click_1(object sender, EventArgs e) {
            // todo: CANCEL EVERYTHING -- DO NOT MODIFY THE OBJECT!

            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e) {

        }

        private void ctrlnstituteName_EditValueChanged(object sender, EventArgs e) {
            // Example on Edit Value Changed -> triggering another event
            TextEdit textEdit = (sender as TextEdit);
            if (textEdit.EditValue.ToString().Length == 0) {
                ctrlnstituteName.EditValue = string.Empty;
            }

        }

        private void button4_Click(object sender, EventArgs e) {

        }
    }
}
