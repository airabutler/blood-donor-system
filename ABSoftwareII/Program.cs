using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABC969.Database;

namespace ABSoftwareII
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// 
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			dbConnection.startConnection();
			Application.Run(new logIn());
			dbConnection.closeConnection();
		}
	}
}