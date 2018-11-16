using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ScriptEase
{

	// **************************************************************************************************************************************
	// **																																   **		
	// **	THIS VERSION CONNECTS TO .TXT FILE AND USES IT AS A SOURCE FOR SCRIPTS TO COPY												   **
	// **																																   **
	// **************************************************************************************************************************************
	public partial class frmScriptEase : Form
	{
		public frmScriptEase()
		{
			InitializeComponent();
		}

		private void frmScriptEase_Load(object sender, EventArgs e)
		{
			DateTime dayCurrentDay = DateTime.Now;
			txtLEEP.Text = dayCurrentDay.ToString("MM.dd.yy") + "_LEEP_";
			txtIG.Text = dayCurrentDay.ToString("MM.dd.yy") + "_IG_";
			txtNICS.Text = dayCurrentDay.ToString("MM.dd.yy") + "_NICS_";
			txtUNET.Text = dayCurrentDay.ToString("MM.dd.yy") + "_UNET_";
			txtTDEX.Text = dayCurrentDay.ToString("MM.dd.yy") + "_TDEX_";
		}

		private void GetScript(string strStart, string strEnd)
		{
			string strHold;
			StreamReader streamTesting;
			StringBuilder builder = new StringBuilder();
			string filename = "sourcedata.txt";
			string path = Path.Combine(Environment.CurrentDirectory, @"Data\", filename);
			streamTesting = File.OpenText(path);
			strHold = streamTesting.ReadLine();
			while (!streamTesting.EndOfStream)
			{
				strHold = streamTesting.ReadLine();
				if (String.Equals(strHold, strStart))
				{
					do
					{
						strHold = streamTesting.ReadLine();
						builder.Append(strHold).AppendLine();
					}
					while (strHold != strEnd);
				}
			}
			Clipboard.SetText(builder.ToString());
		}

		private void btnYesResetLEEP_Click(object sender, EventArgs e)
		{
			// Call a variable that references our "script item" bookmark in txt file
			string strScriptTop = "01LEEPAssist";
			// Call a variable that references our "newline" bookmark in txt file
			string strScriptBottom = "no further questions, policies";

			GetScript(strScriptTop, strScriptBottom);
		}

		private void btnNoResetLEEP_Click(object sender, EventArgs e)
		{
			// Call a variable that references our "script item" bookmark in txt file
			string strScriptTop = "02LEEPNoAssist";
			// Call a variable that references our "newline" bookmark in txt file
			string strScriptBottom = "no further questions, policies";

			GetScript(strScriptTop, strScriptBottom);
		}

		private void btnYesResetIG_Click(object sender, EventArgs e)
		{
			// Call a variable that references our "script item" bookmark in txt file
			string strScriptTop = "03IGAssist";
			// Call a variable that references our "newline" bookmark in txt file
			string strScriptBottom = "no further questions, policies";

			GetScript(strScriptTop, strScriptBottom);
		}

		private void btnNoResetIG_Click(object sender, EventArgs e)
		{
			// Call a variable that references our "script item" bookmark in txt file
			string strScriptTop = "04IGNoAssist";
			// Call a variable that references our "newline" bookmark in txt file
			string strScriptBottom = "no further questions, policies";

			GetScript(strScriptTop, strScriptBottom);
		}

		private void btnOrientation_Click(object sender, EventArgs e)
		{
			// Call a variable that references our "script item" bookmark in txt file
			string strScriptTop = "05PortOrient";
			// Call a variable that references our "newline" bookmark in txt file
			string strScriptBottom = "no further questions, policies";

			GetScript(strScriptTop, strScriptBottom);
		}

		private void btnServices_Click(object sender, EventArgs e)
		{
			// Call a variable that references our "script item" bookmark in txt file
			string strScriptTop = "06ServOrient";
			// Call a variable that references our "newline" bookmark in txt file
			string strScriptBottom = "no further questions, policies";

			GetScript(strScriptTop, strScriptBottom);
		}

		private void btnSetup_Click(object sender, EventArgs e)
		{
			// Call a variable that references our "script item" bookmark in txt file
			string strScriptTop = "07IGSetup";
			// Call a variable that references our "newline" bookmark in txt file
			string strScriptBottom = "no further questions, policies";

			GetScript(strScriptTop, strScriptBottom);
		}
	}
}
