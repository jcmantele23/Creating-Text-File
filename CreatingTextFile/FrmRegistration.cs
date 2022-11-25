using CreatingTextFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizationProfile
{
    public partial class frmRegistration : Form
    {
       
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
           
        }
        /////return methods 
        
        private void btnRegister_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmFileName fn = new FrmFileName();
            fn.ShowDialog();

            String getStudentNo = textBox1.Text;
            String getProgram = cbProgram.Text;
            String getFirstName = textBox4.Text;
            String getLastName = textBox2.Text;
            String getMiddleInitial = textBox3.Text;
            String getAge = textBox3.Text;
            String getGender = comboBox2.Text;
            String getBirthday = dateTimePicker1.Text;
            String getContactNo = textBox6.Text;


            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,
            FrmFileName.SetFileName)))
            {
                outputFile.WriteLine("Student No: " + getStudentNo);
                outputFile.WriteLine("Full Name: " + getLastName + ", " + getFirstName + "," + getMiddleInitial);
                outputFile.WriteLine("Program: " + getProgram);
                outputFile.WriteLine("Gender: " + getGender);
                outputFile.WriteLine("Age: " + getAge);
                outputFile.WriteLine("Birthday: " + getBirthday);
                outputFile.WriteLine("Contact No: " + getContactNo);

                Console.WriteLine("Student No: " + getStudentNo);
                Console.WriteLine("Full Name: " + getLastName + ", " + getFirstName + "," + getMiddleInitial);
                Console.WriteLine("Program: " + getProgram);
                Console.WriteLine("Gender: " + getGender);
                Console.WriteLine("Age: " + getAge);
                Console.WriteLine("Birthday: " + getBirthday);
                Console.WriteLine("Contact No: " + getContactNo);

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmRegistration_Load_1(object sender, EventArgs e)
        {
            
        }
    }
}