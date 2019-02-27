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

        #region gaugeTest
        private void InitialSetup()
        {
            try
            {
                arcScaleComponent1.Value = 0;
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
        #endregion
    }
}
