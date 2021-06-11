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

    public partial class MainForm : Form {
        public String message1;
        public String message2;
        public String message3;

        List<Student> Students = new List<Student>();


        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            label4.Text = message1;
            label2.Text = message2;
            label3.Text = message3;

            //MessageBox.Show("Hello World!");
        }

        private void button1_Click(object sender, EventArgs e) {
            //textBox1.Text = "Hello World!";

            //checkBox1.Checked = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

        }

        private void button4_Click(object sender, EventArgs e) {

            Student student = new Student();
            // TODO: 1. ΝΑ ΠΕΡΑΣΩ ΤΟ STUDENT ΟΒJECT ΣΤΗΝ ΦΟΡΜΑ!

            // TODO: OPEN FORM ...
            StudentForm form = new StudentForm();
            form.ShowDialog();


            //TODO: WHEN FORM THE CLOSES ADD THE STUDENT TO A STUDENT LIST
            Students.Add(student);
            
        }

        private void button2_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
