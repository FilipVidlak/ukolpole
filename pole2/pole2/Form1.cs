using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pole2
{
	public partial class Form1 : Form
	{


		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			listBox1.Items.Clear();
			try
			{
				int[] pole;
				int n = int.Parse(textBox1.Text);
				pole = new int[n];
				for (int i = 0; i < n; i++)
				{
					pole[i] = rnd.Next(-1000, 1000);
					listBox1.Items.Add(pole[i]);
				}
				double average = pole.Average();
				double max = -1000;
				MessageBox.Show("Aritmetický průměr se rovná: " + average,"Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
				foreach (double number in pole)
				{
					if (number <= average && number > max) { max = number; }
				}
				MessageBox.Show("Maximum z prvků menších nebo rovných aritmetickýmu průměru: " + max, "Výsledek", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch
			{
				MessageBox.Show("Nezadal si číslo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
    }
}
	
