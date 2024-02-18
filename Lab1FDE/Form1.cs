using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1FDE
{
	public partial class Form1 : Form
	{
		Pen pen1, pen2, pen_ax;
		double x0, y0, x1, y1, x2, y2;
		Bitmap canvas;
		Graphics user_Graphics;
		Color user_color;
		int w, h;
		int x, y;

		private void button4_Click(object sender, EventArgs e)
		{
			if (Int32.TryParse(textBox_x.Text, out x) && Int32.TryParse(textBox_y.Text, out y))
			{
				x = (Int32)x0 + Int32.Parse(textBox_x.Text);
				y = (Int32)y0 - Int32.Parse(textBox_y.Text);
				//n++;
			}
			else
				MessageBox.Show("Ввод данных произведен неверно!",
				"Ошибка ввода",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error);

		}

		public Form1()
		{
			InitializeComponent();
			canvas = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);
			user_Graphics = Graphics.FromImage(canvas);
			user_Graphics.FillRectangle(Brushes.White, 0, 0, ClientRectangle.Width, ClientRectangle.Height);
			pictureBox1.Image = canvas;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			user_Graphics.DrawLine(pen_ax, (float)x0, 5, (float)x0, h);
			user_Graphics.DrawLine(pen_ax, 0, (float)y0, w - 5, (float)y0);
			user_Graphics.DrawLine(pen_ax, w - 10, (float)y0 + 5, w - 5, (float)y0);
			user_Graphics.DrawLine(pen_ax, w - 10, (float)y0 - 5, w - 5, (float)y0);
			user_Graphics.DrawLine(pen_ax, (float)x0 - 5, 10, (float)x0, 5);
			user_Graphics.DrawLine(pen_ax, (float)x0 + 5, 10, (float)x0, 5);
			//user_Graphics.DrawString("x", axFont, axBrush, (float)(pictureBox_2d.Width - 10), (float)(y0 + 3), drawFormat);
			//user_Graphics.DrawString("y", axFont, axBrush, (float)(x0 - 10), (float)(3.0), drawFormat);
			pictureBox1.Image = canvas;
		}

		private void pictureBox1_Paint_1(object sender, PaintEventArgs e)
		{
			user_color = Color.Red;
			pen_ax = new Pen(Color.Black, 1);
			pen1 = new Pen(user_color, 3);
			pen2 = new Pen(Color.Blue, 2);
			pen2.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			w = pictureBox1.Width;
			h = pictureBox1.Height;
			x0 = w / 5;
			y0 = h / 2;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			x1 = x0;
			y1 = y0;
			x2 = x1;
			y2 = y1;
			while (x2 < pictureBox1.Width - 5)
			{
				x2 = x1 + 3;
				y2 = y0 - Math.Sin((x1 - x0) * Math.PI / 180) * 100;
				user_Graphics.DrawLine(pen1, (float)x1,
				(float)y1, (float)x2, (float)y2);
				x1 = x2;
				y1 = y2;
			}
			pictureBox1.Image = canvas;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			x1 = x0;
			y1 = y0 - Math.Cos((x1 - x0) * Math.PI / 180) * 100; ;
			x2 = x1;
			y2 = y1;
			while (x2 < pictureBox1.Width - 5)
			{
				x2 = x1 + 7;
				y2 = y0 - Math.Cos((x1 - x0) * Math.PI / 180) * 100;
				user_Graphics.DrawLine(pen2, (float)x1,
				(float)y1, (float)x2, (float)y2);
				x1 = x2;
				y1 = y2;
			}
			pictureBox1.Image = canvas;
		}
	}
}
