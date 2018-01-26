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
    public partial class Form2 : Form
    {
        private BindingSource bs;
        private BindingList<Person> blPersons;
        private DBPerson db;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            db = new DBPerson();
            string dbStatus;
            bs = new BindingSource();
            blPersons = new BindingList<Person>(db.GetPersonList(out dbStatus));
            bs.DataSource = blPersons;
            dgvPersons.DataSource = bs;

        }

        private void dgvPersons_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            int c = e.ColumnIndex;
            string v = dgvPersons.Rows[r].Cells[c].Value.ToString();
            BindingSource bs = (BindingSource)dgvPersons.DataSource;
            BindingList<Person> blPersons = (BindingList<Person>)bs.DataSource;
            switch (c)
            {
                case 0:
                    // blPersons[r].Name = v;
                    break;
                case 1:
                    blPersons[r].Age = int.Parse(v);
                    break;
                case 2:
                    //  blPersons[r].Gender = char.Parse(v);
                    break;
            }
            db.UpdateDB(blPersons.ToList());

        }

        private void dgvPersons_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }

        private void dgvPersons_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void dgvPersons_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

            if (dgvPersons.SelectedRows.Count > 0)
            {
                Person p = (Person)dgvPersons.SelectedRows[0].DataBoundItem;

                db.DeleteDB(p.Name);
            }
        }

        private void dgvPersons_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void dgvPersons_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }
    }
}
