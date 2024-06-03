using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2FDE
{
	public partial class Form1 : Form
	{
		List<Point> obj1 = new List<Point>();
		List<Point> obj2 = new List<Point>();
		List<Point> obj3 = new List<Point>();
		List<Point> obj4 = new List<Point>();
		List<Point> obj5 = new List<Point>();
		List<Point> obj6 = new List<Point>();
		List<Point> obj7 = new List<Point>();
		List<Point> obj8 = new List<Point>();
		List<Point> obj9 = new List<Point>();
		List<Point> Test = new List<Point>();
		double[,] m1, m2, m3, m4, m5, m6, m7, m8, m9;
		double[,] M;
		double[,] Rx = new double[4, 4];
		double[,] Ry = new double[4, 4];
		double[,] Rz = new double[4, 4];
		double[,] Px = new double[4, 4];
		double[,] Py = new double[4, 4];
		double[,] Pz = new double[4, 4];

		Pen pen1;
		Pen pen2;
		int x0, x, y0, y, n = 0, z0;
		Bitmap canvas;
		Color user_color;
		int alpha, beta, gamma;

		private void button1_Click(object sender, EventArgs e)
		{
			user_Graphics.FillRectangle(Brushes.White, 0, 0, ClientRectangle.Width, ClientRectangle.Height);

			user_Graphics.DrawLine(Pens.Gray, x0, 2, x0, ClientRectangle.Height - 2);
			user_Graphics.DrawLine(Pens.Gray, 2, y0, ClientRectangle.Width - 2, y0);

			pen1.Color = Color.Blue;

			obj1.Clear();
			obj2.Clear();
			obj3.Clear();
			obj4.Clear();
			obj5.Clear();
			obj6.Clear();
			obj7.Clear();
			obj8.Clear();
			obj9.Clear();

			obj1.Add(new Point((int)(x0 - del * 3.5), (int)(y0 - del * 4.0)));
			obj1.Add(new Point((int)(x0 + del * 3.5), (int)(y0 - del * 4.0)));
			obj1.Add(new Point((int)(x0 + del * 3.5), (int)(y0 + del * 4.0)));
			obj1.Add(new Point((int)(x0 - del * 3.5), (int)(y0 + del * 4.0)));

			user_Graphics.DrawPolygon(pen1, obj1.ToArray());

			obj2.Add(new Point((int)(x0 - del * 3.5 / 2.0), (int)(y0 - del * 2.5)));
			obj2.Add(new Point((int)(x0 + del * 3.5 / 2.0), (int)(y0 - del * 2.5)));
			obj2.Add(new Point((int)(x0 + del * 3.5 / 2.0), (int)(y0 - del * 2.8)));
			obj2.Add(new Point((int)(x0 - del * 3.5 / 2.0), (int)(y0 - del * 2.8)));

			user_Graphics.DrawPolygon(pen1, obj2.ToArray());

			obj3.Add(new Point((int)(x0 - del * 2.9), (int)(y0 - del * 2.0)));
			obj3.Add(new Point((int)(x0 - del * 2.5), (int)(y0 - del * 2.0)));
			obj3.Add(new Point((int)(x0 - del * 2.5), (int)(y0 + del * 1.0)));
			obj3.Add(new Point((int)(x0 - del * 2.9), (int)(y0 + del * 1.0)));

			user_Graphics.DrawPolygon(pen1, obj3.ToArray());

			obj4.Add(new Point((int)(x0 - del * 1.5), (int)(y0 - del * 2.0)));
			obj4.Add(new Point((int)(x0 + del * 1.5), (int)(y0 - del * 2.0)));
			obj4.Add(new Point((int)(x0 + del * 1.5), (int)(y0 + del * 4.0)));
			obj4.Add(new Point((int)(x0 - del * 1.5), (int)(y0 + del * 4.0)));

			user_Graphics.DrawPolygon(pen1, obj4.ToArray());

			obj9.Add(new Point((int)(x0 + del * 0.9), (int)(y0 + del * 4.0)));
			obj9.Add(new Point((int)(x0 + del * 0.9), (int)(y0 - del * 1.0)));
			obj9.Add(new Point((int)(x0 - del * 0.9), (int)(y0 - del * 1.0)));
			obj9.Add(new Point((int)(x0 - del * 0.9), (int)(y0 + del * 4.0)));

			user_Graphics.DrawPolygon(pen1, obj9.ToArray());


			obj5.Add(new Point((int)(x0 - del * 1.9), (int)(y0 + del * 4.0)));
			obj5.Add(new Point((int)(x0 + del * 4.2), (int)(y0 + del * 4.0)));
			obj5.Add(new Point((int)(x0 + del * 4.2), (int)(y0 + del * 4.5)));
			obj5.Add(new Point((int)(x0 - del * 1.9), (int)(y0 + del * 4.5)));

			user_Graphics.DrawPolygon(pen1, obj5.ToArray());

			obj6.Add(new Point((int)(x0 - del * 1.9), (int)(y0 + del * 4.5)));
			obj6.Add(new Point((int)(x0 + del * 5.2), (int)(y0 + del * 4.5)));
			obj6.Add(new Point((int)(x0 + del * 5.2), (int)(y0 + del * 5.0)));
			obj6.Add(new Point((int)(x0 - del * 1.9), (int)(y0 + del * 5.0)));

			user_Graphics.DrawPolygon(pen1, obj6.ToArray());

			obj7.Add(new Point((int)(x0 - del * 1.9), (int)(y0 + del * 5.0)));
			obj7.Add(new Point((int)(x0 + del * 6.5), (int)(y0 + del * 5.0)));
			obj7.Add(new Point((int)(x0 + del * 6.5), (int)(y0 + del * 5.5)));
			obj7.Add(new Point((int)(x0 - del * 1.9), (int)(y0 + del * 5.5)));

			user_Graphics.DrawPolygon(pen1, obj7.ToArray());

			obj8.Add(new Point((int)(x0 - del * 1.9), (int)(y0 + del * 5.5)));
			obj8.Add(new Point((int)(x0 - del * 4.2), (int)(y0 + del * 5.5)));
			obj8.Add(new Point((int)(x0 - del * 4.2), (int)(y0 + del * 2.5)));
			obj8.Add(new Point((int)(x0 - del * 1.9), (int)(y0 + del * 2.5)));

			user_Graphics.DrawPolygon(pen1, obj8.ToArray());

			pictureBox1.Image = canvas;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			user_Graphics.FillRectangle(Brushes.White, 0, 0, ClientRectangle.Width, ClientRectangle.Height);

			user_Graphics.DrawLine(Pens.Gray, x0, 2, x0, ClientRectangle.Height - 2);
			user_Graphics.DrawLine(Pens.Gray, 2, y0, ClientRectangle.Width - 2, y0);

			pen1.Color = Color.LightGreen;

			obj1.Clear();
			obj2.Clear();
			obj3.Clear();
			obj4.Clear();
			obj5.Clear();
			obj6.Clear();
			obj7.Clear();
			obj8.Clear();
			obj9.Clear();

			obj1.Add(new Point((int)(x0 - del * 3.5), (int)(y0)));
			obj1.Add(new Point((int)(x0 + del * 3.5), (int)(y0)));
			obj1.Add(new Point((int)(x0 + del * 3.5), (int)(y0 - del * 1.5)));
			obj1.Add(new Point((int)(x0 - del * 3.5), (int)(y0 - del * 1.5)));

			user_Graphics.DrawPolygon(pen1, obj1.ToArray());

			obj2.Add(new Point((int)(x0 - del * 3.5 / 2.0), (int)(y0)));
			obj2.Add(new Point((int)(x0 + del * 3.5 / 2.0), (int)(y0)));
			obj2.Add(new Point((int)(x0 + del * 3.5 / 2.0), (int)(y0 + del * 1.5)));
			obj2.Add(new Point((int)(x0 - del * 3.5 / 2.0), (int)(y0 + del * 1.5)));

			user_Graphics.DrawPolygon(pen1, obj2.ToArray());

			obj3.Add(new Point((int)(x0 - del * 2.9), (int)(y0)));
			obj3.Add(new Point((int)(x0 - del * 2.5), (int)(y0)));
			obj3.Add(new Point((int)(x0 - del * 2.5), (int)(y0 + del * 2.0)));
			obj3.Add(new Point((int)(x0 - del * 2.9), (int)(y0 + del * 2.0)));

			user_Graphics.DrawPolygon(pen1, obj3.ToArray());

			obj4.Add(new Point((int)(x0 - del * 1.5), (int)(y0)));
			obj4.Add(new Point((int)(x0 + del * 1.5), (int)(y0)));
			obj4.Add(new Point((int)(x0 + del * 1.5), (int)(y0 - del * 0.5)));
			obj4.Add(new Point((int)(x0 - del * 1.5), (int)(y0 - del * 0.5)));

			pen1.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;

			user_Graphics.DrawPolygon(pen1, obj4.ToArray());

			obj9.Add(new Point((int)(x0 - del * 0.9), (int)(y0 - del * 0.5)));
			obj9.Add(new Point((int)(x0 + del * 0.9), (int)(y0 - del * 0.5)));
			obj9.Add(new Point((int)(x0 + del * 0.9), (int)(y0 - del * 1.0)));
			obj9.Add(new Point((int)(x0 - del * 0.9), (int)(y0 - del * 1.0)));

			user_Graphics.DrawPolygon(pen1, obj9.ToArray());

			pen1.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;

			obj5.Add(new Point((int)(x0 - del * 1.9), (int)(y0 + del * 1.2)));
			obj5.Add(new Point((int)(x0 + del * 4.2), (int)(y0 + del * 1.2)));
			obj5.Add(new Point((int)(x0 + del * 4.2), (int)(y0 - del * 1.5)));
			obj5.Add(new Point((int)(x0 - del * 1.9), (int)(y0 - del * 1.5)));

			user_Graphics.DrawPolygon(pen1, obj5.ToArray());

			obj6.Add(new Point((int)(x0 - del * 1.9), (int)(y0 + del * 2.4)));
			obj6.Add(new Point((int)(x0 + del * 5.2), (int)(y0 + del * 2.4)));
			obj6.Add(new Point((int)(x0 + del * 5.2), (int)(y0 - del * 1.5)));
			obj6.Add(new Point((int)(x0 - del * 1.9), (int)(y0 - del * 1.5)));

			user_Graphics.DrawPolygon(pen1, obj6.ToArray());

			obj7.Add(new Point((int)(x0 - del * 1.9), (int)(y0 + del * 3.6)));
			obj7.Add(new Point((int)(x0 + del * 6.5), (int)(y0 + del * 3.6)));
			obj7.Add(new Point((int)(x0 + del * 6.5), (int)(y0 - del * 1.5)));
			obj7.Add(new Point((int)(x0 - del * 1.9), (int)(y0 - del * 1.5)));

			user_Graphics.DrawPolygon(pen1, obj7.ToArray());

			obj8.Add(new Point((int)(x0 - del * 1.9), (int)(y0 + del * 4.1)));
			obj8.Add(new Point((int)(x0 - del * 4.2), (int)(y0 + del * 4.1)));
			obj8.Add(new Point((int)(x0 - del * 4.2), (int)(y0 - del * 0.8)));
			obj8.Add(new Point((int)(x0 - del * 1.9), (int)(y0 - del * 0.8)));

			user_Graphics.DrawPolygon(pen1, obj8.ToArray());

			pictureBox1.Image = canvas;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			user_Graphics.FillRectangle(Brushes.White, 0, 0, ClientRectangle.Width, ClientRectangle.Height);

			user_Graphics.DrawLine(Pens.Gray, x0, 2, x0, ClientRectangle.Height - 2);
			user_Graphics.DrawLine(Pens.Gray, 2, y0, ClientRectangle.Width - 2, y0);

			pen1.Color = Color.Purple;

			double[,] T = new double[4, 4];

			for (int i = 0; i < 4; i++)
				for (int j = 0; j < 4; j++)
					T[i, j] = 0.0;

			//T[0, 0] = Math.Sqrt(3.0) / 2.0;
			//T[0, 1] = Math.Sqrt(2.0) / 4.0;
			//T[1, 1] = Math.Sqrt(2.0) / 2.0;
			//T[2, 0] = 1.0 / 2.0;
			//T[2, 1] = -Math.Sqrt(6.0) / 4.0;
			//T[3, 3] = 1.0;

			double f = Convert.ToDouble(textBox2.Text), Phi = Convert.ToDouble(textBox1.Text) * 0.17;

			T[0, 0] = 1.0;
			//T[1, 1] = 1.0;
			T[2, 2] = 1.0;
			T[2, 0] = f * Math.Cos(Phi);
			T[1, 2] = f * Math.Sin(Phi);
			T[3, 3] = 1.0;

			//drawProj(multiplicateMatrix(m1, T));
			drawСornice(multiplicateMatrix(m2, T));
			drawProj(multiplicateMatrix(m3, T));
			drawProj(multiplicateMatrix(m4, T));
			drawProj(multiplicateMatrix(m9, T));
			//drawStairs(multiplicateMatrix(m5, T));
			//drawStairs(multiplicateMatrix(m6, T));
			//drawStairs(multiplicateMatrix(m7, T));
			//drawProj(multiplicateMatrix(m8, T));
			drawFacade(multiplicateMatrix(M, T));

			pictureBox1.Image = canvas;
		}

		Graphics user_Graphics;
		double del;

		public Form1()
		{
			InitializeComponent();

			user_color = Color.Blue;
			pen1 = new Pen(user_color, 1);
			pen2 = new Pen(Color.LightGreen, 2);
			canvas = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);
			user_Graphics = Graphics.FromImage(canvas);
			del = ClientRectangle.Height / 20.0 + 2.0;
			x0 = (int)(ClientRectangle.Width / 2);
			y0 = (int)(ClientRectangle.Height / 2) - 60;
			z0 = (int)((+y0 - x0) / 4);// + y0) / 2);
			user_Graphics.FillRectangle(Brushes.White, 0, 0, ClientRectangle.Width, ClientRectangle.Height);
			user_Graphics.DrawLine(Pens.Gray, x0, 2, x0, ClientRectangle.Height - 2);
			user_Graphics.DrawLine(Pens.Gray, 2, y0, ClientRectangle.Width - 2, y0);
			pictureBox1.Image = canvas;
		}

		private void drawFacade(double[,] Pm1)
		{
			List<Point> facade = new List<Point>();

			for (int i = 16; i < 26; i++)
				facade.Add(new Point((int)Pm1[i, 0], (int)Pm1[i, 1]));

			user_Graphics.DrawPolygon(pen1, facade.ToArray());

			user_Graphics.DrawLine(pen1, (int)Pm1[0, 0], (int)Pm1[0, 1], (int)Pm1[16, 0], (int)Pm1[16, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[0, 0], (int)Pm1[0, 1], (int)Pm1[26, 0], (int)Pm1[26, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[1, 0], (int)Pm1[1, 1], (int)Pm1[17, 0], (int)Pm1[17, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[0, 0], (int)Pm1[0, 1], (int)Pm1[1, 0], (int)Pm1[1, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[1, 0], (int)Pm1[1, 1], (int)Pm1[2, 0], (int)Pm1[2, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[2, 0], (int)Pm1[2, 1], (int)Pm1[18, 0], (int)Pm1[18, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[2, 0], (int)Pm1[2, 1], (int)Pm1[3, 0], (int)Pm1[3, 1]);

			user_Graphics.DrawLine(pen1, (int)Pm1[19, 0], (int)Pm1[19, 1], (int)Pm1[5, 0], (int)Pm1[5, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[5, 0], (int)Pm1[5, 1], (int)Pm1[4, 0], (int)Pm1[4, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[4, 0], (int)Pm1[4, 1], (int)Pm1[3, 0], (int)Pm1[3, 1]);

			user_Graphics.DrawLine(pen1, (int)Pm1[20, 0], (int)Pm1[20, 1], (int)Pm1[6, 0], (int)Pm1[6, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[6, 0], (int)Pm1[6, 1], (int)Pm1[7, 0], (int)Pm1[7, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[7, 0], (int)Pm1[7, 1], (int)Pm1[4, 0], (int)Pm1[4, 1]);

			user_Graphics.DrawLine(pen1, (int)Pm1[6, 0], (int)Pm1[6, 1], (int)Pm1[5, 0], (int)Pm1[5, 1]);

			user_Graphics.DrawLine(pen1, (int)Pm1[21, 0], (int)Pm1[21, 1], (int)Pm1[9, 0], (int)Pm1[9, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[9, 0], (int)Pm1[9, 1], (int)Pm1[8, 0], (int)Pm1[8, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[8, 0], (int)Pm1[8, 1], (int)Pm1[7, 0], (int)Pm1[7, 1]);

			user_Graphics.DrawLine(pen1, (int)Pm1[22, 0], (int)Pm1[22, 1], (int)Pm1[10, 0], (int)Pm1[10, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[10, 0], (int)Pm1[10, 1], (int)Pm1[11, 0], (int)Pm1[11, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[11, 0], (int)Pm1[11, 1], (int)Pm1[8, 0], (int)Pm1[8, 1]);

			user_Graphics.DrawLine(pen1, (int)Pm1[10, 0], (int)Pm1[10, 1], (int)Pm1[9, 0], (int)Pm1[9, 1]);

			user_Graphics.DrawLine(pen1, (int)Pm1[23, 0], (int)Pm1[23, 1], (int)Pm1[13, 0], (int)Pm1[13, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[13, 0], (int)Pm1[13, 1], (int)Pm1[12, 0], (int)Pm1[12, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[12, 0], (int)Pm1[12, 1], (int)Pm1[11, 0], (int)Pm1[11, 1]);

			user_Graphics.DrawLine(pen1, (int)Pm1[24, 0], (int)Pm1[24, 1], (int)Pm1[14, 0], (int)Pm1[14, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[14, 0], (int)Pm1[14, 1], (int)Pm1[15, 0], (int)Pm1[15, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[15, 0], (int)Pm1[15, 1], (int)Pm1[12, 0], (int)Pm1[12, 1]);

			user_Graphics.DrawLine(pen1, (int)Pm1[14, 0], (int)Pm1[14, 1], (int)Pm1[13, 0], (int)Pm1[13, 1]);

			user_Graphics.DrawLine(pen1, (int)Pm1[26, 0], (int)Pm1[26, 1], (int)Pm1[27, 0], (int)Pm1[27, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[27, 0], (int)Pm1[27, 1], (int)Pm1[3, 0], (int)Pm1[3, 1]);

			user_Graphics.DrawLine(pen1, (int)Pm1[27, 0], (int)Pm1[27, 1], (int)Pm1[29, 0], (int)Pm1[29, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[29, 0], (int)Pm1[29, 1], (int)Pm1[30, 0], (int)Pm1[30, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[30, 0], (int)Pm1[30, 1], (int)Pm1[15, 0], (int)Pm1[15, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[30, 0], (int)Pm1[30, 1], (int)Pm1[31, 0], (int)Pm1[31, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[28, 0], (int)Pm1[28, 1], (int)Pm1[31, 0], (int)Pm1[31, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[28, 0], (int)Pm1[28, 1], (int)Pm1[29, 0], (int)Pm1[29, 1]);

			user_Graphics.DrawLine(pen1, (int)Pm1[31, 0], (int)Pm1[31, 1], (int)Pm1[33, 0], (int)Pm1[33, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[28, 0], (int)Pm1[28, 1], (int)Pm1[32, 0], (int)Pm1[32, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[32, 0], (int)Pm1[32, 1], (int)Pm1[33, 0], (int)Pm1[33, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[34, 0], (int)Pm1[34, 1], (int)Pm1[32, 0], (int)Pm1[32, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[34, 0], (int)Pm1[34, 1], (int)Pm1[26, 0], (int)Pm1[26, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[34, 0], (int)Pm1[34, 1], (int)Pm1[35, 0], (int)Pm1[35, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[33, 0], (int)Pm1[33, 1], (int)Pm1[35, 0], (int)Pm1[35, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[25, 0], (int)Pm1[25, 1], (int)Pm1[35, 0], (int)Pm1[35, 1]);
		}

		private void pictureBox1_Paint(object sender, PaintEventArgs e)
		{
			M = new double[36, 4]{
				{x0 - del * 3.5, y0 - del * 4.0, z0, 1.0},//p1 0
				{x0 + del * 3.5, y0 - del * 4.0, z0, 1.0},//p2 1
				{x0 + del * 3.5, y0 + del * 4.0, z0, 1.0},//p3 2
				{x0 - del * 1.9, y0 + del * 4.0, z0, 1.0},//p3 3
				{x0 - del * 1.9, y0 + del * 4.0, z0 + del * 1.2, 1.0},// 1stairs1 4
				{x0 + del * 4.2, y0 + del * 4.0, z0 + del * 1.2, 1.0},// 1stairs2 5
				{x0 + del * 4.2, y0 + del * 4.5, z0 + del * 1.2, 1.0},// 1stairs3 6 
				{x0 - del * 1.9, y0 + del * 4.5, z0 + del * 1.2, 1.0},// 1stairs4 7
				{x0 - del * 1.9, y0 + del * 4.5, z0 + del * 2.4, 1.0},// 2stairs1 8
				{x0 + del * 5.2, y0 + del * 4.5, z0 + del * 2.4, 1.0},// 2stairs2 9
				{x0 + del * 5.2, y0 + del * 5.0, z0 + del * 2.4, 1.0},// 2stairs3 10
				{x0 - del * 1.9, y0 + del * 5.0, z0 + del * 2.4, 1.0},// 2stairs4 11
				{x0 - del * 1.9, y0 + del * 5.0, z0 + del * 3.6, 1.0},// 3stairs1 12
				{x0 + del * 6.5, y0 + del * 5.0, z0 + del * 3.6, 1.0},// 3stairs2 13
				{x0 + del * 6.5, y0 + del * 5.5, z0 + del * 3.6, 1.0},// 3stairs3 14
				{x0 - del * 1.9, y0 + del * 5.5, z0 + del * 3.6, 1.0},// 3stairs4 15
				{x0 - del * 3.5, y0 - del * 4.0, z0 - del * 1.5, 1.0},//z1 16
				{x0 + del * 3.5, y0 - del * 4.0, z0 - del * 1.5, 1.0},//z2 17
				{x0 + del * 3.5, y0 + del * 4.0, z0 - del * 1.5, 1.0},//z3 18
				{x0 + del * 4.2, y0 + del * 4.0, z0 - del * 1.5, 1.0},//z4 19
				{x0 + del * 4.2, y0 + del * 4.5, z0 - del * 1.5, 1.0},//z5 20
				{x0 + del * 5.2, y0 + del * 4.5, z0 - del * 1.5, 1.0},//z6 21
				{x0 + del * 5.2, y0 + del * 5.0, z0 - del * 1.5, 1.0},//z7 22
				{x0 + del * 6.2, y0 + del * 5.0, z0 - del * 1.5, 1.0},//z8 23
				{x0 + del * 6.2, y0 + del * 5.5, z0 - del * 1.5, 1.0},//z9 24
				{x0 - del * 3.5, y0 + del * 5.5, z0 - del * 1.5, 1.0},//z10 25
				{x0 - del * 3.5, y0 + del * 2.5, z0, 1.0},//p4 26
				{x0 - del * 1.9, y0 + del * 2.5, z0, 1.0},//p5 27
				{x0 - del * 4.2, y0 + del * 2.5, z0 + del * 4.1, 1.0},//m8 28
				{x0 - del * 1.9, y0 + del * 2.5, z0 + del * 4.1, 1.0},//m8 29
			    {x0 - del * 1.9, y0 + del * 5.5, z0 + del * 4.1, 1.0},//m8 30
				{x0 - del * 4.2, y0 + del * 5.5, z0 + del * 4.1, 1.0},//m8 31
				{x0 - del * 4.2, y0 + del * 2.5, z0 - del * 0.8, 1.0},//m8 32
				{x0 - del * 4.2, y0 + del * 5.5, z0 - del * 0.8, 1.0},//m8 33
				{x0 - del * 3.5, y0 + del * 2.5, z0 - del * 0.8, 1.0},//m8 34
				{x0 - del * 3.5, y0 + del * 5.5, z0 - del * 0.8, 1.0},//m8 35
			};
			


			m1 = new double[8, 4]{ 
				   { x0 - del * 3.5, y0 - del * 4.0, z0, 1.0},	                // 0
				   { x0 + del * 3.5, y0 - del * 4.0, z0, 1.0},					// 1
				   { x0 + del * 3.5, y0 + del * 5.5, z0, 1.0},					// 2
				   { x0 - del * 3.5, y0 + del * 5.5, z0, 1.0},					// 3
				   { x0 - del * 3.5, y0 - del * 4.0, z0 - del * 1.5, 1.0},		// 4
				   { x0 + del * 3.5, y0 - del * 4.0, z0 - del * 1.5, 1.0},		// 5
				   { x0 + del * 3.5, y0 + del * 5.5, z0 - del * 1.5, 1.0},		// 6										
				   { x0 - del * 3.5, y0 + del * 5.5, z0 - del * 1.5, 1.0} };    // 7																						


			m2 = new double[8, 4]{ 
				   { x0 - del * 3.5 / 2.0, y0 - del * 2.5, z0, 1.0},	                // 0
				   { x0 + del * 3.5 / 2.0, y0 - del * 2.5, z0, 1.0},					// 1
				   { x0 + del * 3.5 / 2.0, y0 - del * 2.8, z0, 1.0},					// 2
				   { x0 - del * 3.5 / 2.0, y0 - del * 2.8, z0, 1.0},					// 3
				   { x0 - del * 3.5 / 2.0, y0 - del * 2.5, z0 + del * 1.5, 1.0},		// 4
				   { x0 + del * 3.5 / 2.0, y0 - del * 2.5, z0 + del * 1.5, 1.0},		// 5
				   { x0 + del * 3.5 / 2.0, y0 - del * 2.8, z0 + del * 1.5, 1.0},		// 6											
				   { x0 - del * 3.5 / 2.0, y0 - del * 2.8, z0 + del * 1.5, 1.0} };      // 7

			m3 = new double[8, 4]{ 
				   { x0 - del * 2.9, y0 - del * 2.0, z0, 1.0},	                // 0
				   { x0 - del * 2.5, y0 - del * 2.0, z0, 1.0},					// 1
				   { x0 - del * 2.5, y0 + del * 1.0, z0, 1.0},					// 2
				   { x0 - del * 2.9, y0 + del * 1.0, z0, 1.0},					// 3
				   { x0 - del * 2.9, y0 - del * 2.0, z0 + del * 2.0, 1.0},		// 4
				   { x0 - del * 2.5, y0 - del * 2.0, z0 + del * 2.0, 1.0},		// 5
				   { x0 - del * 2.5, y0 + del * 1.0, z0 + del * 2.0, 1.0},		// 6											
				   { x0 - del * 2.9, y0 + del * 1.0, z0 + del * 2.0, 1.0} };    // 7

			m4 = new double[8, 4]{ 
				   { x0 - del * 1.5, y0 - del * 2.0, z0, 1.0},	                // 0
				   { x0 + del * 1.5, y0 - del * 2.0, z0, 1.0},					// 1
				   { x0 + del * 1.5, y0 + del * 4.0, z0, 1.0},					// 2
				   { x0 - del * 1.5, y0 + del * 4.0, z0, 1.0},					// 3
				   { x0 - del * 1.5, y0 - del * 2.0, z0 - del * 0.5, 1.0},		// 4
				   { x0 + del * 1.5, y0 - del * 2.0, z0 - del * 0.5, 1.0},		// 5
				   { x0 + del * 1.5, y0 + del * 4.0, z0 - del * 0.5, 1.0},		// 6
				   { x0 - del * 1.5, y0 + del * 4.0, z0 - del * 0.5, 1.0} };    // 7

			m5 = new double[8, 4]{ 
				   { x0 - del * 1.9, y0 + del * 4.0, z0 + del * 1.2, 1.0},	    // 0
				   { x0 + del * 4.2, y0 + del * 4.0, z0 + del * 1.2, 1.0},	    // 1
				   { x0 + del * 4.2, y0 + del * 4.5, z0 + del * 1.2, 1.0},	    // 2
				   { x0 - del * 1.9, y0 + del * 4.5, z0 + del * 1.2, 1.0},	    // 3
				   { x0 - del * 1.9, y0 + del * 4.0, z0 - del * 1.5, 1.0},      // 4
				   { x0 + del * 4.2, y0 + del * 4.0, z0 - del * 1.5, 1.0},	    // 5
				   { x0 + del * 4.2, y0 + del * 4.5, z0 - del * 1.5, 1.0},      // 6
				   { x0 - del * 1.9, y0 + del * 4.5, z0 - del * 1.5, 1.0} };    // 7

			m6 = new double[8, 4]{ 
				   { x0 - del * 1.9, y0 + del * 4.5, z0 + del * 2.4, 1.0},	    // 0
				   { x0 + del * 5.2, y0 + del * 4.5, z0 + del * 2.4, 1.0},		// 1
				   { x0 + del * 5.2, y0 + del * 5.0, z0 + del * 2.4, 1.0},		// 2
				   { x0 - del * 1.9, y0 + del * 5.0, z0 + del * 2.4, 1.0},		// 3
				   { x0 - del * 1.9, y0 + del * 4.5, z0 - del * 1.5, 1.0},		// 4
				   { x0 + del * 5.2, y0 + del * 4.5, z0 - del * 1.5, 1.0},		// 5
				   { x0 + del * 5.2, y0 + del * 5.0, z0 - del * 1.5, 1.0},		// 6											
				   { x0 - del * 1.9, y0 + del * 5.0, z0 - del * 1.5, 1.0} };    // 7

			m7 = new double[8, 4]{ 
				   { x0 - del * 1.9, y0 + del * 5.0, z0 + del * 3.6, 1.0},	    // 0
				   { x0 + del * 6.5, y0 + del * 5.0, z0 + del * 3.6, 1.0},		// 1
				   { x0 + del * 6.5, y0 + del * 5.5, z0 + del * 3.6, 1.0},		// 2
				   { x0 - del * 1.9, y0 + del * 5.5, z0 + del * 3.6, 1.0},		// 3
				   { x0 - del * 1.9, y0 + del * 5.0, z0 - del * 1.5, 1.0},		// 4
				   { x0 + del * 6.5, y0 + del * 5.0, z0 - del * 1.5, 1.0},		// 5
				   { x0 + del * 6.5, y0 + del * 5.5, z0 - del * 1.5, 1.0},		// 6											
				   { x0 - del * 1.9, y0 + del * 5.5, z0 - del * 1.5, 1.0} };    // 7

			m8 = new double[8, 4]{ 
				   { x0 - del * 1.9, y0 + del * 5.5, z0 + del * 4.1, 1.0},	    // 0
				   { x0 - del * 4.2, y0 + del * 5.5, z0 + del * 4.1, 1.0},		// 1
				   { x0 - del * 4.2, y0 + del * 2.5, z0 + del * 4.1, 1.0},		// 2
				   { x0 - del * 1.9, y0 + del * 2.5, z0 + del * 4.1, 1.0},		// 3
				   { x0 - del * 1.9, y0 + del * 5.5, z0 - del * 0.8, 1.0},		// 4
				   { x0 - del * 4.2, y0 + del * 5.5, z0 - del * 0.8, 1.0},		// 5
				   { x0 - del * 4.2, y0 + del * 2.5, z0 - del * 0.8, 1.0},		// 6											
				   { x0 - del * 1.9, y0 + del * 2.5, z0 - del * 0.8, 1.0} };    // 7

			m9 = new double[8, 4]{ 
				   { x0 - del * 0.9, y0 - del * 1.0, z0 - del * 0.5, 1.0},	// 0
				   { x0 + del * 0.9, y0 - del * 1.0, z0 - del * 0.5, 1.0},	// 1
				   { x0 + del * 0.9, y0 + del * 4.0, z0 - del * 0.5, 1.0},  // 2
				   { x0 - del * 0.9, y0 + del * 4.0, z0 - del * 0.5, 1.0},  // 3
				   { x0 - del * 0.9, y0 - del * 1.0, z0 - del * 1.0, 1.0},  // 4
				   { x0 + del * 0.9, y0 - del * 1.0, z0 - del * 1.0, 1.0},  // 5
				   { x0 + del * 0.9, y0 + del * 4.0, z0 - del * 1.0, 1.0},  // 6											
				   { x0 - del * 0.9, y0 + del * 4.0, z0 - del * 1.0, 1.0} };// 7

			for (int i = 0; i < 4; i++)
				for (int j = 0; j < 4; j++)
				{
					Rx[i, j] = 0.0;
					Ry[i, j] = 0.0;
					Rz[i, j] = 0.0;
					Px[i, j] = 0.0;
					Py[i, j] = 0.0;
					Pz[i, j] = 0.0;
				}

			Pz[0, 0] = 1.0;
			Pz[1, 1] = 1.0;
			Pz[3, 3] = 1.0;

			Px[1, 1] = 1.0;
			Px[2, 2] = 1.0;
			Px[3, 3] = 1.0;

			Py[0, 0] = 1.0;
			Py[2, 2] = 1.0;
			Py[3, 3] = 1.0;
		}

		private double[,] multiplicateMatrix(double[,] first, double[,] other)
		{
			int N = first.Length / 4;
			double[,] third = new double[N, 4];

			for (int i = 0; i < N; i++)
			{
				for (int k = 0; k < 4; k++)
					third[i, k] = 0.0;
			}

			for (int i = 0; i < N; i++)
			{
				for (int k = 0; k < 4; k++)
				{
					for (int j = 0; j < 4; j++)
					{
						third[i, j] += first[i, k] * other[k, j];
					}
				}
			}

			return third;
		}

		private void drawProj(double[,] Pm1)
		{
			user_Graphics.DrawLine(pen1, (int)Pm1[0, 0], (int)Pm1[0, 1], (int)Pm1[1, 0], (int)Pm1[1, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[0, 0], (int)Pm1[0, 1], (int)Pm1[3, 0], (int)Pm1[3, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[0, 0], (int)Pm1[0, 1], (int)Pm1[4, 0], (int)Pm1[4, 1]);

			user_Graphics.DrawLine(pen1, (int)Pm1[2, 0], (int)Pm1[2, 1], (int)Pm1[1, 0], (int)Pm1[1, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[2, 0], (int)Pm1[2, 1], (int)Pm1[3, 0], (int)Pm1[3, 1]);

			user_Graphics.DrawLine(pen1, (int)Pm1[6, 0], (int)Pm1[6, 1], (int)Pm1[2, 0], (int)Pm1[2, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[6, 0], (int)Pm1[6, 1], (int)Pm1[5, 0], (int)Pm1[5, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[6, 0], (int)Pm1[6, 1], (int)Pm1[7, 0], (int)Pm1[7, 1]);

			user_Graphics.DrawLine(pen1, (int)Pm1[5, 0], (int)Pm1[5, 1], (int)Pm1[1, 0], (int)Pm1[1, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[5, 0], (int)Pm1[5, 1], (int)Pm1[4, 0], (int)Pm1[4, 1]);

			user_Graphics.DrawLine(pen1, (int)Pm1[7, 0], (int)Pm1[7, 1], (int)Pm1[4, 0], (int)Pm1[4, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[7, 0], (int)Pm1[7, 1], (int)Pm1[3, 0], (int)Pm1[3, 1]);
		}

		private void drawStairs(double[,] Pm1)
		{
			user_Graphics.DrawLine(pen1, (int)Pm1[0, 0], (int)Pm1[0, 1], (int)Pm1[1, 0], (int)Pm1[1, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[0, 0], (int)Pm1[0, 1], (int)Pm1[3, 0], (int)Pm1[3, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[0, 0], (int)Pm1[0, 1], (int)Pm1[4, 0], (int)Pm1[4, 1]);

			user_Graphics.DrawLine(pen1, (int)Pm1[2, 0], (int)Pm1[2, 1], (int)Pm1[1, 0], (int)Pm1[1, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[2, 0], (int)Pm1[2, 1], (int)Pm1[3, 0], (int)Pm1[3, 1]);

			user_Graphics.DrawLine(pen1, (int)Pm1[6, 0], (int)Pm1[6, 1], (int)Pm1[2, 0], (int)Pm1[2, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[6, 0], (int)Pm1[6, 1], (int)Pm1[5, 0], (int)Pm1[5, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[6, 0], (int)Pm1[6, 1], (int)Pm1[7, 0], (int)Pm1[7, 1]);

			user_Graphics.DrawLine(pen1, (int)Pm1[5, 0], (int)Pm1[5, 1], (int)Pm1[1, 0], (int)Pm1[1, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[5, 0], (int)Pm1[5, 1], (int)Pm1[4, 0], (int)Pm1[4, 1]);

			user_Graphics.DrawLine(pen1, (int)Pm1[7, 0], (int)Pm1[7, 1], (int)Pm1[4, 0], (int)Pm1[4, 1]);
			//user_Graphics.DrawLine(pen1, (int)Pm1[7, 0], (int)Pm1[7, 1], (int)Pm1[3, 0], (int)Pm1[3, 1]);
		}

		private void drawСornice(double[,] Pm1)
		{
			user_Graphics.DrawLine(pen1, (int)Pm1[0, 0], (int)Pm1[0, 1], (int)Pm1[1, 0], (int)Pm1[1, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[0, 0], (int)Pm1[0, 1], (int)Pm1[3, 0], (int)Pm1[3, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[0, 0], (int)Pm1[0, 1], (int)Pm1[4, 0], (int)Pm1[4, 1]);

			user_Graphics.DrawLine(pen1, (int)Pm1[2, 0], (int)Pm1[2, 1], (int)Pm1[1, 0], (int)Pm1[1, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[2, 0], (int)Pm1[2, 1], (int)Pm1[3, 0], (int)Pm1[3, 1]);

			user_Graphics.DrawLine(pen1, (int)Pm1[6, 0], (int)Pm1[6, 1], (int)Pm1[2, 0], (int)Pm1[2, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[6, 0], (int)Pm1[6, 1], (int)Pm1[5, 0], (int)Pm1[5, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[6, 0], (int)Pm1[6, 1], (int)Pm1[7, 0], (int)Pm1[7, 1]);

			user_Graphics.DrawLine(pen1, (int)Pm1[5, 0], (int)Pm1[5, 1], (int)Pm1[1, 0], (int)Pm1[1, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[5, 0], (int)Pm1[5, 1], (int)Pm1[4, 0], (int)Pm1[4, 1]);

			user_Graphics.DrawLine(pen1, (int)Pm1[7, 0], (int)Pm1[7, 1], (int)Pm1[4, 0], (int)Pm1[4, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[7, 0], (int)Pm1[7, 1], (int)Pm1[3, 0], (int)Pm1[3, 1]);
		}
	}
}
