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
	public partial class kids : MaterialForm
	{
		public kids()
		{
			InitializeComponent();
		}

		private void bunifuButton2_Click(object sender, EventArgs e)
		{
			this.Close();
			Dashboard dsh = new Dashboard();
			dsh.panel5.Controls.Clear();
			dsh.LoadDashBoard();
		}
	}
}
