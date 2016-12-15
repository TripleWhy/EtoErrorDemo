using System;
using Eto.Forms;
using Eto.Drawing;

namespace EtoErrorDemo
{
	// Executed on windows 10 with WPF and display scaling set to 125%.
	public class MainForm : Form
	{
		public MainForm()
		{
			ClientSize = new Size(400, 350);

			Content = new TabControl
			{
				Pages =
				{
					new TabPage
					{
						Content = new Scrollable
						{
							Border = BorderType.None
						}
					}
				}
			};
		}
	}
}
