using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bug_intro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string fn;
                fn = "E:\\tuts\\Koala.jpg";
                //---------------------------
                if ( System.IO.File.Exists(fn)==true )
                {
                    System.IO.File.Delete(fn);
                }
               //----------------------------
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!"+" "+ex.ToString());
            }
            
        }
    }
}
