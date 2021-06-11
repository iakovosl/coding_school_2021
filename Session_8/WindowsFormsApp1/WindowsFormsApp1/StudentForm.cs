using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {

    public partial class StudentForm : Form {

        // PROPERTIES ????
        

        // CONSTRUCTOR
        public StudentForm() {
            InitializeComponent();
        }


        // METHODS
        private void StudentForm_Load(object sender, EventArgs e) {
           
        }

        private void button1_Click(object sender, EventArgs e) {

            // todo: MODIFY THE OBJECT STUDENT -- CLOSE THE FORM!
  
            MainForm mainForm = new MainForm();
            mainForm.message1 = textBox1.Text;
            mainForm.message2 = textBox2.Text;
            mainForm.message3 = textBox3.Text;
            mainForm.Show();

        }

        private void button2_Click(object sender, EventArgs e) {

            // todo: CANCEL EVERYTHING -- DO NOT MODIFY THE OBJECT!
            this.Close();
        }

    
    }
}
