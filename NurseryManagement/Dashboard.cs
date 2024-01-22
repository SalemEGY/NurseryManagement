using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NurseryManagement
{
	public partial class Dashboard : MaterialForm
	{
		public Dashboard()
		{
			InitializeComponent();
		}
		public void LoadDashBoard()
		{
			Dashboard dsh = new Dashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
			panel5.Controls.Add(dsh);
			dsh.Show();
		}
		private void Panel3_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel6_Paint(object sender, PaintEventArgs e)
		{

		}

		public void bunifuButton2_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
