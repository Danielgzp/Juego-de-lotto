using System;
using System.Windows.Forms;

namespace lotto
{
	
	internal sealed class Program
	{
		
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			//Instancio el formulario principal fuera de Aplication.Run().
			//Esto es para que no se cierre el programa al usar this.Close() en el formulario principal.			
			MainForm main = new MainForm();
			//Llamo a la función FormClosed.
			main.FormClosed += new FormClosedEventHandler(FormClosed);
			//Se muestra el formulario.
    		main.Show();
    		Application.Run(); 
		}
		
		/*Debido a los pasos de arriba, al cerrar una ventana la aplicación seguirá ejecutanse a pesar de no verse.
		 * Esta función es para cerrarla automáticamente cuando no haya una ventana abierta*/
		
		static void FormClosed(object sender, FormClosedEventArgs e) 
		{
        	((Form)sender).FormClosed -= FormClosed;
        	if (Application.OpenForms.Count == 0) Application.ExitThread();
        	else Application.OpenForms[0].FormClosed += FormClosed;
    	}
		
	}
}
