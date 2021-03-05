using System;
using System.Drawing;
using System.Windows.Forms;

namespace lotto
{
	public partial class GanadorBingo : Form
	{
		public GanadorBingo()
		{
			InitializeComponent();
			
		}
		
		informacion info = new informacion();
		Int64 premio2; 
		
		void GanadorBingoLoad(object sender, EventArgs e)
		{
			Int64 premio;
			carton_Ganador.Text = Convert.ToString(info.lista_ganadoresBingo());
			//Si hay más de un cartón ganador se divide el premio por el número devuelto en la lista
			if(informacion.bingo.Count == 0){
				premio = info.premios_bingo();
				
			}else{
				premio = (info.premios_bingo() / informacion.bingo.Count);
				
			}
			
			monto_ganado.Text = "Premio para cada ganador: " + Convert.ToString(premio) + "$";
			
		
			if(info.lista_ganadoresBingo() != "No hay ganadores"){
				premio2 = info.premios_bingo();
				//Si hay un ganador o ganadores se resta el premio al monto total
				informacion.monto_total = informacion.monto_total - info.premios_bingo();
				
			}else{
				monto_ganado.Hide();
			}
			
			
		}
		
		
		void Button1Click(object sender, EventArgs e)
		{	
			//Información bingo
			informacion.juegos_bingo++;
			if(info.lista_ganadoresBingo() == "No hay ganadores"){
				//Si no hay ganadores el premio queda para el próximo juego
				informacion.pote_resto_bingo = informacion.pote_resto_bingo+informacion.monto_total;
				informacion.monto_total = 0;
				
			}else{
				//Si hay ganadores se guarda ganancias
				informacion.repartido_bingo = informacion.repartido_bingo + premio2;
				info.guardar_ganancias("bingo");
				
			}
			
			//Limpiar la lista de cartones y ganadores
			informacion.r_cartones.Clear();
			informacion.bingo.Clear();
			//Instancio el formulario registro_cartones y luego utilizo show para mostrarlo.
			menu menu_principal = new menu();
			menu_principal.Show();
			//Este es para cerrar el primer formulario.
			this.Close();
		}
		
		
	}
}
