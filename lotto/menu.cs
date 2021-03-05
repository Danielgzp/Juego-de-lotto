using System;
using System.Drawing;
using System.Windows.Forms;

namespace lotto
{
	
	public partial class menu : Form
	{
		public menu()
		{
			
			InitializeComponent();
			
			
		}
		
		informacion info = new informacion();
		
		void Button1Click(object sender, EventArgs e)
		{
			//Instancio el formulario registro_cartones y luego utilizo show para mostrarlo.
			registro_cartones registro = new registro_cartones();
			registro.Show();
			//Este es para cerrar el primer formulario.
			this.Close();
		}
		
		void MenuLoad(object sender, EventArgs e)
		{
			//Mostrar información
			cartones_registrados.Text = "Cartones registrados: " + info.total_cartones();
			total_pote.Text = "Total del pote: " + info.total_acumulado() + "$";
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			//Abrir lotería
			if(info.total_cartones() > 0){
				loteria loteria_juego = new loteria();
				loteria_juego.Show();
				this.Close();
			}else{
				MessageBox.Show("Compra primero un cartón", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void Button3Click(object sender, EventArgs e){
			
			//Abrir bingo
			if(info.total_cartones() > 0){
				
				Bingo bingo = new Bingo();
			 	bingo.Show();
				this.Close();
			}else{
				MessageBox.Show("Compra primero un cartón", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}
		
		void Button4Click(object sender, EventArgs e)
		{	
			//Abrir información
			estadisticas infor = new estadisticas();
			infor.Show();
			this.Close();
		}
		
		
	}
}
