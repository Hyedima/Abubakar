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
    public partial class frmAttendance : Form
    {
        public frmAttendance()
        {
            InitializeComponent();
        }

        private void attendanceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
           // this.attendanceBindingSource.EndEdit();
           // this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void frmAttendance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.Attendance' table. You can move, or remove it, as needed.
            this.attendanceTableAdapter.Fill(this.dataSet2.Attendance);
            // TODO: This line of code loads data into the 'dataSet2.Attendance' table. You can move, or remove it, as needed.
            //this.attendanceTableAdapter.Fill(this.dataSet2.Attendance);
            // TODO: This line of code loads data into the 'dataSet1.attendance' table. You can move, or remove it, as needed.
            // this.attendanceTableAdapter.Fill(this.dataSet1.attendance);

        }

        private void attendanceBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            //this.attendanceBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.dataSet2);

        }

        private void attendanceBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.attendanceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet2);

        }
    }
}
