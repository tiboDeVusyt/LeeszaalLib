using LeeszaalLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUi
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ClassManger.Lanch();
            Reader reader = new Reader();
            foreach (var item in Reader.readers)
            {
                lstReaders.Items.Add(item.ToString());
            }
            foreach (var item in Hat.Hats())
            {
                cmbHat.Items.Add(item);
            }
            foreach (var item in MagazineColors.Colors())
            {
                cmbKleur.Items.Add(item);
            }
        }
        private void lstReaders_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbHat_SelectedIndexChanged(object sender, EventArgs e)
        {
            var result = (from r in Reader.readers where r.Hat == cmbHat.SelectedItem.ToString() select r).ToList();
            lblHatCount.Text = result.Count.ToString();

            if (cmbKleur.SelectedItem != null)
            {
                List<Reader> resultBoth = Reader.readers.Where(r => r.Hat == cmbHat.SelectedItem.ToString()).ToList().Where(d => d.magazine.ToString() == cmbKleur.SelectedItem.ToString()).ToList();
                lblBothCount.Text = resultBoth.Count.ToString();
            }
            //List<Employee> result = (from e in Employees
            //                         where e.DepartmentId == departmentId
            //                         select e).ToList();
            //return result;
        }

        private void cmbKleur_SelectedIndexChanged(object sender, EventArgs e)
        {
            var result = Reader.readers.Where(r => r.magazine.ToString() == cmbKleur.SelectedItem.ToString()).ToList();
            lblMagazineColorCount.Text = result.Count.ToString();
            //employees = Employees.Where(Employees => Employees.DepartmentId == departmentId).ToList;
            if (cmbHat.SelectedItem != null) 
            {
                List<Reader> resultBoth = Reader.readers.Where(r => r.Hat == cmbHat.SelectedItem.ToString()).ToList().Where(d => d.magazine.ToString() == cmbKleur.SelectedItem.ToString()).ToList();
                lblBothCount.Text = resultBoth.Count.ToString();
            }
        }

        private void btnAddLezers_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtAddCount.Text) <= 10)
            {
                ClassManger.Add(Convert.ToInt32(txtAddCount.Text));
                lstReaders.Items.Clear();
                foreach (var item in Reader.readers)
                {
                    lstReaders.Items.Add(item.ToString());
                }
            }
            else
            {
                MessageBox.Show("u can't add more than 10 readers at a time");
            }
        }
    }
}
