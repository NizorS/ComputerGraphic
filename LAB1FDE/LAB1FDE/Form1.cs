using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1FDE
{
	public partial class Form1 : Form
	{
		bool check1 = true;
		bool check2 = true;
		bool check3 = true;
		double radius = 1.0;
		int n = 1;
		double degree = 0.0;
		Pen pen_ax;
		Pen pen1;
		double x0, y0;
		Bitmap canvas;
		Bitmap axesImg;
		Bitmap whiteCanvas;
		Graphics user_Graphics;
		Graphics axes;
		Graphics whiteGraphics;
		Color user_color;
		int w, h;
		Font axFont;
		SolidBrush axBrush;
		Color white25;
		SolidBrush brushWhite25;
		int del;
		int number = 0;
		List<Color> colorsForGraphics;

		private void button2_Click(object sender, EventArgs e)
		{
			if (number == colorsForGraphics.Count) number = 0;
			pen1.Color = colorsForGraphics[number++];
			double x = (double)(x0);
			double y = (double)(y0);
			double x2 = x;
			double y2 = y;

			double newRadius = (double)del * radius;

			user_Graphics.DrawLine(pen1, (float)x0, (float)y0, (float)(x0 + newRadius), (float)(y0));

			/*double t = degree * Math.PI / 180.0;
			double r = t / 2.0;
			double anglef = 0.1;

			for (int i = 0; i < n; i++)
			{
				while (t <)
				{ 
					x2 = x0 + r * Math.Cos(t);
					y2 = y0 + r * Math.Sin(t);
					user_Graphics.DrawLine(pen1, (float)x, (float)y, (float)x2, (float)y2);
					x = x2;
					y = y2;
					t += anglef;
					r = t / 2.0; 
				}
			}*/

			pictureBox1.Image = canvas;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			pictureBox1.Image = null;
			canvas = null;
			canvas = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);
			user_Graphics = Graphics.FromImage(canvas);
			user_Graphics.FillRectangle(brushWhite25, 0, 0, ClientRectangle.Width, ClientRectangle.Height);
			number = 0;
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{
			try
			{
				degree = Convert.ToDouble(textBox3.Text);
			}
			catch (System.FormatException)
			{
				button2.Enabled = false;
				check3 = false;
				MessageBox.Show("Вы ввели символ! Пожалуйста, введите цифрy");
				return;
			}

			degree = Convert.ToDouble(textBox3.Text);
			check3 = true;
			if (check1 && check2 && check3) button2.Enabled = true;
		}

		public Form1()
		{
			InitializeComponent();

			white25 = Color.FromArgb(0, 255, 255, 255);
			brushWhite25 = new SolidBrush(white25);

			canvas = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);
			user_Graphics = Graphics.FromImage(canvas);
			user_Graphics.FillRectangle(brushWhite25, 0, 0, ClientRectangle.Width, ClientRectangle.Height);

			axesImg = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);
			axes = Graphics.FromImage(axesImg);
			axes.FillRectangle(Brushes.White, 0, 0, ClientRectangle.Width, ClientRectangle.Height);

			whiteCanvas = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);
			whiteGraphics = Graphics.FromImage(whiteCanvas);
			whiteGraphics.FillRectangle(Brushes.White, 0, 0, ClientRectangle.Width, ClientRectangle.Height);
			pictureBox1.BackgroundImage = whiteCanvas;

			axFont = new Font("Tahoma", 10);
			pen_ax = new Pen(Color.Gray, 1);
			axBrush = new SolidBrush(Color.Gray);
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				pictureBox1.BackgroundImage = axesImg;
			}
			else
			{
				pictureBox1.BackgroundImage = whiteCanvas;
			}
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			Form dlg1 = new Form();
			dlg1.StartPosition = FormStartPosition.CenterScreen;
			PictureBox pb1 = new PictureBox();
			pb1.Load("./1.png");
			pb1.Dock = DockStyle.Fill;

			dlg1.Controls.Add(pb1);
			dlg1.MaximizeBox = false;
			dlg1.MinimizeBox = false;
			dlg1.MaximumSize = new Size(510, 150);
			dlg1.MinimumSize = new Size(510, 150);

			dlg1.ShowDialog();

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			try
			{
				n = Convert.ToInt32(textBox1.Text);

				if (n < 0)
				{
					button2.Enabled = false;
					check1 = false;
					MessageBox.Show("Количество витков не может быть отрицательным числом");
					return;
				}
			}
			catch (System.FormatException)
			{
				button2.Enabled = false;
				check1 = false;
				MessageBox.Show("Вы ввели символ! Пожалуйста, введите цифрy");
				return;
			}

			n = Convert.ToInt32(textBox1.Text);
			check1 = true;
			if (check1 && check2 && check3) button2.Enabled = true;
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			try
			{
				radius = Convert.ToDouble(textBox2.Text);

				if (radius < 0)
				{
					button2.Enabled = false;
					check2 = false;
					MessageBox.Show("Радиус не может быть отрицательным числом");
					return;
				}
			}
			catch (System.FormatException)
			{
				button2.Enabled = false;
				check2 = false;
				MessageBox.Show("Вы ввели символ! Пожалуйста, введите цифрy");
				return;
			}

			radius = Convert.ToDouble(textBox2.Text);
			check2 = true;
			if (check1 && check2 && check3) button2.Enabled = true;
		}

		private void pictureBox1_Paint(object sender, PaintEventArgs e)
		{
			colorsForGraphics = new List<Color>();
			colorsForGraphics.AddRange(new List<Color>
			{
				Color.Red, Color.Green,
				Color.Blue, Color.Purple,
				Color.DarkSlateGray, Color.DarkCyan,
				Color.ForestGreen, Color.Brown,
				Color.Black, Color.Gold
			}) ;

			user_color = Color.Red;
			pen1 = new Pen(user_color, 3);
			w = pictureBox1.Width;
			h = pictureBox1.Height;
			x0 = w / 2;
			y0 = h / 2;

			axes.DrawString("x", axFont, axBrush, (float)(w - 15), (float)(y0 + 2));
			axes.DrawString("y", axFont, axBrush, (float)(x0 + 5), (float)(0));
			axes.DrawString("0", axFont, axBrush, (float)(w / 2 + 3), (float)(h / 2 + 3));
			axes.DrawLine(pen_ax, (float)x0, 0, (float)x0, h);
			axes.DrawLine(pen_ax, 0, (float)y0, w, (float)y0);
			axes.DrawLine(pen_ax, w - 10, (float)y0 + 5, w - 5, (float)y0);    // Стрелочки x
			axes.DrawLine(pen_ax, w - 10, (float)y0 - 5, w - 5, (float)y0);    // Стрелочки x
			axes.DrawLine(pen_ax, (float)x0 - 5, 5, (float)x0, 0);             // Стрелочки y
			axes.DrawLine(pen_ax, (float)x0 + 5, 5, (float)x0, 0);             // Стрелочки y

			del = h / 20 + 8;

			for (int i = (int)y0 + del, j = -1; i <= pictureBox1.Height; i += del, j--)
			{
				axes.DrawLine(pen_ax, (float)x0 - 5, i, (float)x0 + 5, i);
				axes.DrawString(j.ToString(), axFont, axBrush, (float)(x0 - 25), (float)(i - 8));
			}

			for (int i = (int)y0 - del, j = 1; i >= 0; i -= del, j++)
			{
				axes.DrawLine(pen_ax, (float)x0 - 5, i, (float)x0 + 5, i);
				axes.DrawString(j.ToString(), axFont, axBrush, (float)(x0 - 20), (float)(i - 8));
			}

			for (int i = (int)x0 + del, j = 1; i <= pictureBox1.Width; i += del, j++)
			{
				axes.DrawLine(pen_ax, i, (float)y0 - 5, i, (float)y0 + 5);
				axes.DrawString(j.ToString(), axFont, axBrush, (float)(i - 6), (float)(y0 - 20));
			}

			for (int i = (int)x0 - del, j = -1; i >= 0; i -= del, j--)
			{
				axes.DrawLine(pen_ax, i, (float)y0 - 5, i, (float)y0 + 5);
				axes.DrawString(j.ToString(), axFont, axBrush, (float)(i - 9), (float)(y0 - 20));
			}
		}
	}
}
