
namespace Kursa4
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			metka:
            Application.Run(new Form1());
			if(Form1.post == "��������") { Application.Run(new Form_for_manager()); }
            if(Form1.post == "������") { Application.Run(new Menu()); }
			if (Form1.exit_btn) { goto metka; }
			
			
		
        }
	}
}