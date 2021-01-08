using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oop_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string career = comboBox1.SelectedItem.ToString();
            string date1 = dateTimePicker1.Value.ToString();
            string date2 = dateTimePicker2.Value.ToString();
            string salary = textBox2.Text;
            FileStream file = new FileStream("EmployeeData.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}",name, career, date1, date2, salary);
            //writer.WriteLine(name);
            //writer.WriteLine(career);
            //writer.WriteLine(date1);
            //writer.WriteLine(date2);
            //writer.WriteLine(salary);
            writer.Close();
            file.Close();

            DialogResult result = MessageBox.Show("Your data is saved successfully!", "Confirmation message.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                this.Close();
                new Form1().Show();
            }
        }
    }
}
