using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p5
{
    public partial class Form1 : Form
    {
        private PersonCollection pc; //add this 

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            pc = new PersonCollection();
            lblStatus.Text = pc.DbStatus;
            lblAverage.Text = pc.AverageAge.ToString();//add this
            refreshForm();
        }

        private void refreshForm()
        {
            Person p = pc.getCurrentPerson(); //call method from PersonCollection class
            txtName.Text = p.Name;
            txtAge.Text = p.Age + ""; //convert to string
            txtGender.Text = p.Gender + ""; //convert to string for textbox 
            txtBirthYr.Text = p.getYearOfBirth() + "";
            grpPerson.Text = (pc.Current + 1) + " / " + //update the no in groupBox
                pc.getTotalNoOfPersons();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            pc.Current = pc.getTotalNoOfPersons() - 1;
            refreshForm();
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (pc.Current > 0) //if not the 1st record
                pc.Current = pc.Current - 1;

            refreshForm();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (pc.Current < pc.getTotalNoOfPersons() - 1)
                pc.Current = pc.Current + 1;

            refreshForm();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            pc.Current = 0;
            refreshForm();
        }
    }
}
