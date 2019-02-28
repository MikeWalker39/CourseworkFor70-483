using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UdemyWinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception)
            {

                throw;
            }
        }
                
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                InitialSetup();
            }
            catch (Exception)
            {

                throw;
            }

        }

        #region prevCode
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SayHello();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void SayHello()
        {
            try
            {
                MessageBox.Show("Hello");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void InitialSetup()
        {
            try
            {
                arcScaleComponent1.Value = 0;
                panGaugeHolder.Visible = false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (arcScaleComponent1.Value == 0) arcScaleComponent1.Value = 1;

                arcScaleComponent1.Value = (int)(arcScaleComponent1.Value * 2);
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void trackBarControl1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                arcScaleComponent1.Value = trackBarControl1.Value * 10;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                Employee e1 = new Employee();
                e1.FirstName = "Mark";
                e1.LastName = "Long";
                e1.Seniority = 5;

                string p = e1.Promote();

                Employee e2 = new Employee();
                e1.FirstName = "Alice";
                e1.LastName = "Jones";
                e1.Seniority = 5;

                string p2 = e2.AnnualReview();

                MessageBox.Show(p);
                MessageBox.Show(p2);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public class Employee
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Seniority { get; set; }

            public string Promote()
            {
                return FirstName + " " + LastName + " has been promoted.";
            }

            public string AnnualReview()
            {
                return "Annual Review completed.";
            }
        }
        #endregion

    }
}
