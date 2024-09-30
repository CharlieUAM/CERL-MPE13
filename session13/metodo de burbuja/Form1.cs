using metodo_de_burbuja.modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metodo_de_burbuja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] numbers = new int[10];
        int i = 0;


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int Number = int.Parse(tbNumber.Text);
                numbers[i++] = Number;
                ShowNumbers();
                Clear();
            }
            catch (Exception ex)
            {
                tbNumber.Text = ex.Message;
            }
        }
        public void ShowNumbers()
        {
            if (lbarray.Items.Count > 0)
            {
                lbarray.Items.Clear();
            }
            foreach (int i in numbers)
            {
                lbarray.Items.Add(i);
            }
            
        }
        private void Clear()
        {
            tbNumber.Clear();
            tbNumber.Focus();
        }

        private void TBNsort_Click(object sender, EventArgs e)
        {
            Bubble bubble = new Bubble();
            bubble.Bsort(numbers);
            ShowNumbers();
        }
    }
}
