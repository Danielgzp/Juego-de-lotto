﻿/*
 * Creado por SharpDevelop.
 * Usuario: Mariangel
 * Fecha: 24/01/2021
 * Hora: 03:57 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace lotto
{
	partial class registro_cartones
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registro_cartones));
			this.label2 = new System.Windows.Forms.Label();
			this.n_carton = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.numero1 = new System.Windows.Forms.TextBox();
			this.numero2 = new System.Windows.Forms.TextBox();
			this.numero3 = new System.Windows.Forms.TextBox();
			this.numero4 = new System.Windows.Forms.TextBox();
			this.numero5 = new System.Windows.Forms.TextBox();
			this.numero6 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.cartones_registrados = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.total_pote = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(192, 95);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(150, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Número de cartón: ";
			// 
			// n_carton
			// 
			this.n_carton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.n_carton.Location = new System.Drawing.Point(339, 92);
			this.n_carton.Name = "n_carton";
			this.n_carton.Size = new System.Drawing.Size(39, 24);
			this.n_carton.TabIndex = 2;
			this.n_carton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.n_carton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.N_cartonKeyPress);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(10, 125);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(584, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Ingresa la secuencia de 6 números diferentes entre 1 y 42:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// numero1
			// 
			this.numero1.Location = new System.Drawing.Point(169, 157);
			this.numero1.Name = "numero1";
			this.numero1.Size = new System.Drawing.Size(41, 24);
			this.numero1.TabIndex = 4;
			this.numero1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numero1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numero1KeyPress);
			// 
			// numero2
			// 
			this.numero2.Location = new System.Drawing.Point(216, 157);
			this.numero2.Name = "numero2";
			this.numero2.Size = new System.Drawing.Size(41, 24);
			this.numero2.TabIndex = 5;
			this.numero2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numero2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numero2KeyPress);
			// 
			// numero3
			// 
			this.numero3.Location = new System.Drawing.Point(263, 157);
			this.numero3.Name = "numero3";
			this.numero3.Size = new System.Drawing.Size(41, 24);
			this.numero3.TabIndex = 6;
			this.numero3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numero3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numero3KeyPress);
			// 
			// numero4
			// 
			this.numero4.Location = new System.Drawing.Point(310, 157);
			this.numero4.Name = "numero4";
			this.numero4.Size = new System.Drawing.Size(41, 24);
			this.numero4.TabIndex = 7;
			this.numero4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numero4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numero4KeyPress);
			// 
			// numero5
			// 
			this.numero5.Location = new System.Drawing.Point(357, 157);
			this.numero5.Name = "numero5";
			this.numero5.Size = new System.Drawing.Size(41, 24);
			this.numero5.TabIndex = 8;
			this.numero5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numero5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numero5KeyPress);
			// 
			// numero6
			// 
			this.numero6.Location = new System.Drawing.Point(404, 157);
			this.numero6.Name = "numero6";
			this.numero6.Size = new System.Drawing.Size(41, 24);
			this.numero6.TabIndex = 9;
			this.numero6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numero6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numero6KeyPress);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(114, 195);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(379, 23);
			this.label4.TabIndex = 10;
			this.label4.Text = "Total a pagar: 100$";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(164)))), ((int)(((byte)(216)))));
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(230, 221);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(145, 50);
			this.button1.TabIndex = 11;
			this.button1.Text = "Comprar cartón";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// cartones_registrados
			// 
			this.cartones_registrados.BackColor = System.Drawing.Color.Transparent;
			this.cartones_registrados.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cartones_registrados.ForeColor = System.Drawing.Color.Black;
			this.cartones_registrados.Location = new System.Drawing.Point(19, 299);
			this.cartones_registrados.Name = "cartones_registrados";
			this.cartones_registrados.Size = new System.Drawing.Size(184, 23);
			this.cartones_registrados.TabIndex = 12;
			this.cartones_registrados.Text = "Cartones registrados: 0";
			this.cartones_registrados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(161)))), ((int)(((byte)(216)))));
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(232, 284);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(139, 36);
			this.button2.TabIndex = 14;
			this.button2.Text = "Volver";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// total_pote
			// 
			this.total_pote.BackColor = System.Drawing.Color.Transparent;
			this.total_pote.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.total_pote.ForeColor = System.Drawing.Color.Black;
			this.total_pote.Location = new System.Drawing.Point(362, 299);
			this.total_pote.Name = "total_pote";
			this.total_pote.Size = new System.Drawing.Size(191, 23);
			this.total_pote.TabIndex = 15;
			this.total_pote.Text = "Total del pote: 0$";
			this.total_pote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.Location = new System.Drawing.Point(127, 36);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(352, 70);
			this.pictureBox1.TabIndex = 16;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
			this.pictureBox2.Location = new System.Drawing.Point(27, 189);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(176, 108);
			this.pictureBox2.TabIndex = 17;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
			this.pictureBox3.Location = new System.Drawing.Point(384, 189);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(163, 111);
			this.pictureBox3.TabIndex = 18;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
			this.pictureBox4.Location = new System.Drawing.Point(4, -2);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(483, 42);
			this.pictureBox4.TabIndex = 19;
			this.pictureBox4.TabStop = false;
			// 
			// registro_cartones
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(216)))));
			this.ClientSize = new System.Drawing.Size(584, 327);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.total_pote);
			this.Controls.Add(this.cartones_registrados);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.numero6);
			this.Controls.Add(this.numero5);
			this.Controls.Add(this.numero4);
			this.Controls.Add(this.numero3);
			this.Controls.Add(this.numero2);
			this.Controls.Add(this.numero1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.n_carton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox1);
			this.Font = new System.Drawing.Font("Libre Baskerville", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "registro_cartones";
			this.Text = "Registro de cartones";
			this.Load += new System.EventHandler(this.Registro_cartonesLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label total_pote;
		private System.Windows.Forms.Label cartones_registrados;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox numero6;
		private System.Windows.Forms.TextBox numero5;
		private System.Windows.Forms.TextBox numero4;
		private System.Windows.Forms.TextBox numero3;
		private System.Windows.Forms.TextBox numero2;
		private System.Windows.Forms.TextBox numero1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox n_carton;
		private System.Windows.Forms.Label label2;
	}
}
