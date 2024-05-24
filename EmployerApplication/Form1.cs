using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EmployerApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void computesalarybtn_Click(object sender, EventArgs e)
        {
            ParttimeEmployee partime = new ParttimeEmployee(firstnametxtbox.Text, lastNametxtbox.Text, departmenttxtbox.Text, jobTitletxtbox.Text);
            partime.computeSalary(Convert.ToInt32(tothoursworktxtbox.Text), Convert.ToDouble(ratePerhourtxtbox.Text));


            basicsalresult.Text = Convert.ToString(partime.getSalary());
            lnameresult.Text = partime.L_name;
            fnameresult.Text = partime.F_name;
        }
    }
}
