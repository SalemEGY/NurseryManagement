using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace NurseryManagement
{
	public partial class Form1 : MaterialForm
	{
		public Form1()
		{
			InitializeComponent();
			LoadDashBoard();
		}

		public void LoadDashBoard()
		{
			Dashboard dsh = new Dashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
			this.panel5.Controls.Add(dsh);
			dsh.Show();
		}
		private void materialFlatButton1_Click_1(object sender, EventArgs e)
		{

			if (panel2.Width != 25)
			{
				panel2.Width = 25;
			}
			else
				panel2.Width = 157;

		}
		private void bunifuButton7_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void bunifuButton8_Click(object sender, EventArgs e)
		{
			if (WindowState != FormWindowState.Maximized)
			{
				WindowState = FormWindowState.Maximized;
			}
			else
			{
				WindowState = FormWindowState.Normal;
			}
		}

		private void bunifuButton3_Click(object sender, EventArgs e)
		{
			panel5.Controls.Clear();
			kids frmkids = new kids() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
			this.panel5.Controls.Add(frmkids);
			frmkids.Show();
			panel2.Width = 25;
		}

		private void panel5_Paint(object sender, PaintEventArgs e)
		{
			LoadDashBoard();
		}
	}
}
