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

namespace Grafik
{
    public partial class Form1 : Form
    {
 //       SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Neva;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(300, 300);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (double x = 1; x < 11 ; x += 1)
            {
                if(x == 1)
                { 
            //    double y = Convert.ToInt32 (dataGridView1.Rows[0].Cells[1].Value.ToString());

              //      chart1.Series[0].Points.AddXY(x, y);
                   
                }

                if (x ==2)
                {
                    double y = 1; //Convert.ToInt32(dataGridView1.Rows[1].Cells[1].Value.ToString());

                    chart1.Series[0].Points.AddXY(x, y);
                }
                if (x == 3)
                {
                    double y = 2; //Convert.ToInt32(dataGridView1.Rows[2].Cells[1].Value.ToString());

                    chart1.Series[0].Points.AddXY(x, y);
                }
                if (x == 4)
                {
                    double y = 3; //Convert.ToInt32(dataGridView1.Rows[3].Cells[1].Value.ToString());

                    chart1.Series[0].Points.AddXY(x, y);
                }

                if (x == 5)
                {
                    double y = 4; //Convert.ToInt32(dataGridView1.Rows[4].Cells[1].Value.ToString());

                    chart1.Series[0].Points.AddXY(x, y);

                }
                if (x == 6)
                {
                    double y = 5; //Convert.ToInt32(dataGridView1.Rows[5].Cells[1].Value.ToString());

                    chart1.Series[0].Points.AddXY(x, y);
                }
                if (x == 7)
                {
                    double y = 6;//Convert.ToInt32(dataGridView1.Rows[6].Cells[1].Value.ToString());

                    chart1.Series[0].Points.AddXY(x, y);
                }
                if (x == 8)
                {
                    double y = 5; //Convert.ToInt32(dataGridView1.Rows[7].Cells[1].Value.ToString());

                    chart1.Series[0].Points.AddXY(x, y);
                }
                if (x == 9)
                {
                    double y = 8;//Convert.ToInt32(dataGridView1.Rows[8].Cells[1].Value.ToString());

                    chart1.Series[0].Points.AddXY(x, y);
                }
                if (x == 10)
                {
                    double y = 9; //Convert.ToInt32(dataGridView1.Rows[9].Cells[1].Value.ToString());

                    chart1.Series[0].Points.AddXY(x, y);
                }


            }
            //label3.Text = dataGridView1.Rows[0].Cells[1].Value.ToString(); кол-во договоров 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nevaDataSet1.Mes". При необходимости она может быть перемещена или удалена.
 //           this.mesTableAdapter.Fill(this.nevaDataSet1.Mes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nevaDataSet.Dogovori". При необходимости она может быть перемещена или удалена.
  //          this.dogovoriTableAdapter.Fill(this.nevaDataSet.Dogovori);
  //          connection.Open();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                label1.Text = "Май";
                if (label1.Text == "Май")
                {
                    chart2.Visible = true;
                    chart1.Visible = false;
                    chart3.Visible = false;
                    chart4.Visible = false;
                    chart5.Visible = false;
                    for (double x = 1; x < 11; x += 1)
                    {
                        if (x == 1)
                        {
                            double y = 3;//Convert.ToInt32(dataGridView2.Rows[0].Cells[2].Value.ToString());

                            chart2.Series[0].Points.AddXY(x, y);

                        }
                        if (x == 2)
                        {
                            double y = 3;// Convert.ToInt32(dataGridView2.Rows[1].Cells[2].Value.ToString());

                            chart2.Series[0].Points.AddXY(x, y);

                        }
                        if (x == 3)
                        {
                            double y = 3;// Convert.ToInt32(dataGridView2.Rows[2].Cells[2].Value.ToString());

                            chart2.Series[0].Points.AddXY(x, y);

                        }
                    }
                }
            }

            if (comboBox2.SelectedIndex == 1)
            {
                label1.Text = "Июнь";
                if (label1.Text == "Июнь")
                {
                    chart2.Visible = false;
                    chart1.Visible = false;
                    chart4.Visible = false;
                    chart3.Visible=true;
                    chart5.Visible = false;
                    for (double x = 1; x < 11; x += 1)
                    {
                        if (x == 1)
                        {
                            double y = 3;//Convert.ToInt32(dataGridView2.Rows[3].Cells[2].Value.ToString());

                            chart3.Series[0].Points.AddXY(x, y);

                        }
                        if (x == 2)
                        {
                            double y = Convert.ToInt32(dataGridView2.Rows[4].Cells[2].Value.ToString());

                            chart3.Series[0].Points.AddXY(x, y);

                        }
                        if (x == 3)
                        {
                            double y = Convert.ToInt32(dataGridView2.Rows[5].Cells[2].Value.ToString());

                            chart3.Series[0].Points.AddXY(x, y);

                        }
                    }
                }
            }


            if (comboBox2.SelectedIndex == 2)
            {
                label1.Text = "Июль";
                if (label1.Text == "Июль")
                {
                    chart2.Visible = false;
                    chart1.Visible = false;
                    chart3.Visible = false;
                    chart4.Visible = true;
                    chart5.Visible = false;
                    for (double x = 1; x < 11; x += 1)
                    {
                        if (x == 1)
                        {
                            double y = 3;//Convert.ToInt32(dataGridView2.Rows[6].Cells[2].Value.ToString());

                            chart4.Series[0].Points.AddXY(x, y);

                        }
                    }
                }
            }

            if (comboBox2.SelectedIndex == 3)
            {
                label1.Text = "Июль";
                if (label1.Text == "Июль")
                {
                    chart2.Visible = false;
                    chart1.Visible = false;
                    chart3.Visible = false;
                    chart4.Visible = false;
                    chart5.Visible = true;
                    for (double x = 1; x < 11; x += 1)
                    {
                        if (x == 1)
                        {
                            double y = 3;// Convert.ToInt32(dataGridView2.Rows[7].Cells[2].Value.ToString());

                            chart5.Series[0].Points.AddXY(x, y);

                        }
                    }
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Visible= true;
                chart1.Visible= true;
                chart2.Visible = false;
                chart3.Visible = false;
                chart4.Visible = false;
                chart5.Visible = false;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
   
}

