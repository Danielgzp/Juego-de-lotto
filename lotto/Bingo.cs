using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;


namespace lotto
{
	
	public partial class Bingo : Form
	{
		public Bingo()
		{
			
			InitializeComponent();
			
		}
		
		
		informacion info2 = new informacion();
		ListaNumeros cantados = new ListaNumeros();
		Int32 numerito;
		
		
		int contador = 1;
		
		
		void Button3Click(object sender, EventArgs e){
			
			menu menusito = new menu();
			menusito.Show();
			this.Close();
			
			//inicializando el evento de click para el metodo volver
			//aqui le estamos diciendo que cuando se presione el boton de volver
			//muestre el menu principal
			
		}
		
		public void Button1Click(object sender, EventArgs e)
		{
			info2.buscar_ganador("bingo");
			button3.Hide();
			
			if(contador == 21){
				
				button1.Hide();
				button2.Show();
			}
			
			// Si hay un ganador se desaparece el botón de generar número y aparece el de ganadores
			if (contador >= 6){
				if(informacion.bingo.Count >= 1){
					button1.Hide();
					button2.Show();
				}
			}
			
			//Generar número con letra y ponerlo rojo
			
			if(cantado.Text == Convert.ToString(0)){
				
				numerito = Convert.ToInt32(cantado.Text);
			}
			    
				numerito = info2.generar_numero("bingo");
				
				if(numerito >= 1 && numerito <= 9){
					
					cantado.Text = "B "+Convert.ToString(numerito);
					
				} else if(numerito >= 10 && numerito <= 18){
					
					cantado.Text = "I "+Convert.ToString(numerito);
					
				} else if(numerito >= 19 && numerito <= 26){
					
					cantado.Text = "N "+Convert.ToString(numerito);
					
				} else if(numerito >= 27 && numerito <= 34){
					
					cantado.Text = "G "+Convert.ToString(numerito);
					
				}else if(numerito >= 35 && numerito <= 42){
					
					cantado.Text = "O "+Convert.ToString(numerito);
				}
	
				CambiarColores(numerito);
			    cantados.VerLista(cantado.Text); 
				contador++; //este si importa
				
				
				if(Convert.ToInt32(ultimajugada2.Text) >= 0){
							
					ultimajugada4.Text = ultimajugada3.Text;
					
							
				} 
				
				if(Convert.ToInt32(ultimajugada2.Text) >= 0){
				
					ultimajugada3.Text = ultimajugada2.Text;
					
					
				} 
				
				if(Convert.ToInt32(ultimajugada2.Text) >= 0){
					
					ultimajugada2.Text = ultimajugada1.Text;
					
					                                	                                
				} 
				
				if(Convert.ToInt32(ultimajugada1.Text) >= 0){
					
					ultimajugada1.Text = Convert.ToString(numerito);
					
					
				}
				
				
					
		}
		
		 public void CambiarColores(int RN){
						
			switch(RN){
						
						
					case 1: num1.BackColor = System.Drawing.Color.Red; break;
					case 2: num2.BackColor = System.Drawing.Color.Red; break;
					case 3: num3.BackColor = System.Drawing.Color.Red; break;
					case 4: num4.BackColor = System.Drawing.Color.Red; break;
					case 5: num5.BackColor = System.Drawing.Color.Red; break;
					case 6: num6.BackColor = System.Drawing.Color.Red; break;
					case 7: num7.BackColor = System.Drawing.Color.Red; break;
					case 8: num8.BackColor = System.Drawing.Color.Red; break;
					case 9: num9.BackColor = System.Drawing.Color.Red; break;
					case 10: num10.BackColor = System.Drawing.Color.Red; break;
					case 11: num11.BackColor = System.Drawing.Color.Red; break;
					case 12: num12.BackColor = System.Drawing.Color.Red; break;
					case 13: num13.BackColor = System.Drawing.Color.Red; break;
					case 14: num14.BackColor = System.Drawing.Color.Red; break;
					case 15: num15.BackColor = System.Drawing.Color.Red; break;
					case 16: num16.BackColor = System.Drawing.Color.Red; break;
					case 17: num17.BackColor = System.Drawing.Color.Red; break;
					case 18: num18.BackColor = System.Drawing.Color.Red; break;
					case 19: num19.BackColor = System.Drawing.Color.Red; break;
					case 20: num20.BackColor = System.Drawing.Color.Red; break;
					case 21: num21.BackColor = System.Drawing.Color.Red; break;
					case 22: num22.BackColor = System.Drawing.Color.Red; break;
					case 23: num23.BackColor = System.Drawing.Color.Red; break;
					case 24: num.BackColor = System.Drawing.Color.Red; break;
					case 25: num25.BackColor = System.Drawing.Color.Red; break;
					case 26: num26.BackColor = System.Drawing.Color.Red; break;
					case 27: num27.BackColor = System.Drawing.Color.Red; break;
					case 28: num28.BackColor = System.Drawing.Color.Red; break;
					case 29: num29.BackColor = System.Drawing.Color.Red; break;
					case 30: num30.BackColor = System.Drawing.Color.Red; break;
					case 31: num31.BackColor = System.Drawing.Color.Red; break;
					case 32: num32.BackColor = System.Drawing.Color.Red; break;
					case 33: num33.BackColor = System.Drawing.Color.Red; break;
					case 34: num34.BackColor = System.Drawing.Color.Red; break;
					case 35: num35.BackColor = System.Drawing.Color.Red; break;
					case 36: num36.BackColor = System.Drawing.Color.Red; break;
					case 37: num37.BackColor = System.Drawing.Color.Red; break;
					case 38: num38.BackColor = System.Drawing.Color.Red; break;
					case 39: num39.BackColor = System.Drawing.Color.Red; break;
					case 40: num40.BackColor = System.Drawing.Color.Red; break;
					case 41: num41.BackColor = System.Drawing.Color.Red; break;
					case 42: num42.BackColor = System.Drawing.Color.Red; break;
				default: break;
			}
			   	
		}
		
			
			void Button8Click(object sender, EventArgs e)
			{
				//Mostrar las lista de los números cantados
				cantados.Show();
				
			}
		
			
			
			void BingoLoad(object sender, EventArgs e)
			{
				//Premios e información
				button2.Hide();
				dineroGanador.Text = "Ganador del bingo: " + Convert.ToString(info2.premios_bingo() + "$");
				cartones_registrados.Text = "Cartones registrados: " + info2.total_cartones();
				Int64 total = informacion.monto_total + informacion.pote_resto_bingo;
			    total_pote.Text = "Total del pote: " + total + "$";
			}
			
			void Button2Click(object sender, EventArgs e)
			{
				
				//mostrar ganador del bingo
				
				GanadorBingo bingoGanador = new GanadorBingo();
				bingoGanador.Show();
				this.Close();
				
			}
	}
}
