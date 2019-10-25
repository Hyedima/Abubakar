using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDS
{
    public partial class frmStudents : Form
    {
        public frmStudents()
        {
            InitializeComponent();
        }

        private void studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.studentsBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void studentsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
           // this.studentsBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void frmStudents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.dataSet2.Students);
            // TODO: This line of code loads data into the 'dataSet2.Students' table. You can move, or remove it, as needed.
            // this.studentsTableAdapter.Fill(this.dataSet2.Students);
            // TODO: This line of code loads data into the 'dataSet1.Students' table. You can move, or remove it, as needed.
            //this.studentsTableAdapter.Fill(this.dataSet1.Students);

        }

        private void studentsBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            //this.studentsBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.dataSet2);

        }

        private void studentsBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet2);

        }
    }
}
