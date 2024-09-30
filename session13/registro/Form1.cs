using registro.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registro
{
    public partial class Form1 : Form
    {
        List<Persona> persons;
        public Form1()
        {
            InitializeComponent();
            persons = new List<Persona>();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Persona person = new Persona();
            person.name = tbprodct.Text;
            person.price = int.Parse(tbprice.Text);
            persons.Add(person);
        }

        private void ShowProducts()
        {
            DGVnumbers.DataSource = null;
            DGVnumbers.DataSource = persons;
        }
    }
}
