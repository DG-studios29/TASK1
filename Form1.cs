using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dhillan_Gopal_19017017_GADE6112_TASK1A
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			GameEnginClass Gm = new GameEnginClass();
			lblDisplay.Text = Gm.ToString();
			
		}

		private void btnUp_Click(object sender, EventArgs e)
		{

		}

		private void btnLeft_Click(object sender, EventArgs e)
		{
			
		}

		private void btnDown_Click(object sender, EventArgs e)
		{

		}

		private void btnRight_Click(object sender, EventArgs e)
		{

		}
	}
}
