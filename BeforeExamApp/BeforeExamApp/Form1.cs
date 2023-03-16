using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Entity;

namespace BeforeExamApp
{
    public partial class Form1 : Form
    {
        BeforeExamsEntities db = new BeforeExamsEntities();

        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// İlk hafta yaptığımız datadan veri alma ve listeleme kısa ve uzun yol
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnlist1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=SEREN;Initial Catalog=BeforeExams;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from Student",conn);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);  
            dataGridView1.DataSource = dt;
        }

        private void btnlist2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Student.ToList();
        }
        /// <summary>
        /// 2. hafta yaptığmız öğrenci listelme, eklme, silme 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnListStudents_Click(object sender, EventArgs e)
        {
            //dataGridView2.DataSource = db.Student.ToList();//listeliyor ama gereksı not kısmı da çıkıyor
            ///önlemek için aşağıdaki şekilde listeleme yapıyoruz
            var query = from x in db.Student
                        select new
                        {
                            x.id,
                            x.firstName,
                            x.lastName,
                            x.phoneNumber
                        };
            dataGridView2.DataSource = query.ToList();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.firstName = txtName.Text;
            student.lastName = txtLastname.Text;
            student.phoneNumber = txtPhone.Text;
            db.Student.Add(student);
            db.SaveChanges();

             
        }

        private void btnListStndtNotes_Click(object sender, EventArgs e)
        {
            //dataGridView2.DataSource = db.Courses.ToList();
            dataGridView2.DataSource = db.NotListesi();

        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            //int id = Convert.ToInt16(txtID.Text);
            //Student t = db.Student.Find(id);   
            //db.Student.Remove(t);
            //db.SaveChanges();

            string s = txtName.Text;
            Student t = db.Student.Find(s);
            db.Student.Remove(t);
            db.SaveChanges();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(txtID.Text);
            Student t = db.Student.Find(id);

            t.firstName = txtName.Text;
            t.lastName = txtLastname.Text;
            t.phoneNumber = txtPhone.Text;

            db.SaveChanges();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtLastname.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPhone.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        //****
        /// <summary>
        /// Radio Buttons for listing 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rBtnList_Click(object sender, EventArgs e)
        {
            if (rBtnAtoZ.Checked)
            {
                List<Student> list1 = db.Student.OrderBy(p => p.firstName).ToList();
                dataGridView3.DataSource=list1;
            }

            if (rBtnZtoA.Checked)
            {
                List<Student> list2 = db.Student.OrderByDescending(p => p.lastName).ToList();
                dataGridView3.DataSource = list2;
            }

            if (rBtnslctID.Checked)
            {
                int id = int.Parse(txtID.Text);
                List<Student> list3 = db.Student.Where(p => p.id == id).ToList();
                dataGridView3.DataSource = list3;

            }

            if (rBtnFrst.Checked)
            {
                List<Student> list4 = db.Student.Take(2).ToList();
                dataGridView3.DataSource = list4;

            }

            if (rBtnstrt.Checked)
            {
                List<Student> list5 = db.Student.Where(p => p.firstName.StartsWith(txtName.Text)).ToList();
                dataGridView3.DataSource = list5;
            }

            if (rBtnEnd.Checked)
            {
                List<Student> list6 = db.Student.Where(p => p.firstName.EndsWith(txtName.Text)).ToList();
                dataGridView3.DataSource = list6;

            }

            if (rBtnContain.Checked)
            {
                List<Student> list7 = db.Student.Where(p => p.firstName.Contains(txtName.Text)).ToList();
                dataGridView3.DataSource = list7;
            }

            if (rBtnCount.Checked)
            {
                int number = db.Student.Count();
                MessageBox.Show(number.ToString(), "Warn", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            if (rBtnSum.Checked)
            {
                var sum = db.Courses.Sum(p => p.exam1);
                MessageBox.Show(sum.ToString());
            }

            if (rBtnAvg.Checked)
            {
                var avg = db.Courses.Average(p => p.exam1);
                MessageBox.Show(avg.ToString());
            }

            if (rBtnMax.Checked)
            {
                var max = db.Courses.Max(p => p.exam1);
                MessageBox.Show(max.ToString());

            }
            if (rBtnMin.Checked)
            {
                var min = db.Courses.Min(p => p.exam1);
                MessageBox.Show(min.ToString());

            }

            if (rBtnAboveAvg.Checked)
            {
                var avg = db.Courses.Average(p => p.exam1);
                List<Courses> list = db.Courses.Where(p => (p.exam1 >= avg)).ToList();
                dataGridView3.DataSource = list;
            }
            
        }

        
    }
}
