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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            FileStream file = new FileStream("EmployeeData.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            int i = 0;
            while (reader.Peek() != -1)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells["name"].Value = reader.ReadLine();
                dataGridView1.Rows[i].Cells["career"].Value = reader.ReadLine();
                dataGridView1.Rows[i].Cells["checkin"].Value = reader.ReadLine();
                dataGridView1.Rows[i].Cells["checkout"].Value = reader.ReadLine();
                dataGridView1.Rows[i].Cells["salary"].Value = reader.ReadLine();
                i++;
            }
            reader.Close();
            file.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Show();
        }
    }
}
