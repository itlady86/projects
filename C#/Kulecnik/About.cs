
using System;
using System.Windows.Forms;

namespace Kulecnik
{
	/// <summary>
	/// Description of About.
	/// </summary>
	public partial class About : Form
	{
		public About()
		{
			InitializeComponent();
		}
		
		public void Button1Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
	}
}
