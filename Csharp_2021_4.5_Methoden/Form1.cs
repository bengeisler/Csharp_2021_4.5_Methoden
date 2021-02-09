using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_2021_4._5_Methoden
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnAnzeige1_Click(object sender, EventArgs e)
		{
			double a, b;
			a = 4.2;
			b = 7.5;
			ZeigeMaximum(a, b);
		}

		private void btnAnzeige2_Click(object sender, EventArgs e)
		{
			double c, d;
			c = 23.9;
			d = 5.6;
			ZeigeMaximum(c, d);
		}

		// Eigene Methode erstellen
		// - Rückgabetyp void = keine Rückgabe von Werten
		// - Parameter x und y vom Datentyp double
		private void ZeigeMaximum(double x, double y)
		{
			if (x > y) lblAusgabe.Text = "Maximum: " + x;
			else lblAusgabe.Text = "Maximum: " + y;

			// Alternativ: Kurzschreibweise (ternärer Operator)
			// lblAusgabe.Text = (x > y) ? "Maximum: " + x : "Maximum: " + y;
		}
	}
}
