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
		double[,] Rx = new double[4, 4];
		double[,] Ry = new double[4, 4];
		double[,] Rz = new double[4, 4];
		double[,] Px = new double[4, 4];
		double[,] Py = new double[4, 4];
		double[,] Pz = new double[4, 4];

		Pen pen1;
		Pen pen2;
		int x0, x, y0, y, n = 0;
		Bitmap canvas;
		Color user_color;

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

			double[,] T = Px;

			drawProj(multiplicateMatrix(m1, T));
			drawProj(multiplicateMatrix(m2, T));
			drawProj(multiplicateMatrix(m3, T));
			drawProj(multiplicateMatrix(m4, T));
			drawProj(multiplicateMatrix(m9, T));
			drawProj(multiplicateMatrix(m5, T));
			drawProj(multiplicateMatrix(m6, T));
			drawProj(multiplicateMatrix(m7, T));
			drawProj(multiplicateMatrix(m8, T));

			pictureBox1.Image = canvas;
		}

		Graphics user_Graphics;
		double del;

		public Form1()
		{
			InitializeComponent();

			user_color = Color.Blue;
			pen1 = new Pen(user_color, 2);
			pen2 = new Pen(Color.LightGreen, 2);
			canvas = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);
			user_Graphics = Graphics.FromImage(canvas);
			x0 = (int)(ClientRectangle.Width / 2);
			y0 = (int)(ClientRectangle.Height / 2) - 60;
			user_Graphics.FillRectangle(Brushes.White, 0, 0, ClientRectangle.Width, ClientRectangle.Height);
			del = ClientRectangle.Height / 20.0 + 2.0;
			user_Graphics.DrawLine(Pens.Gray, x0, 2, x0, ClientRectangle.Height - 2);
			user_Graphics.DrawLine(Pens.Gray, 2, y0, ClientRectangle.Width - 2, y0);
			pictureBox1.Image = canvas;
		}

		private void pictureBox1_Paint(object sender, PaintEventArgs e)
		{

			m1 = new double[8, 4]{ 
				   { x0 - del * 3.5, y0 - del * 4.0, y0, 1.0},	                // 0
				   { x0 + del * 3.5, y0 - del * 4.0, y0, 1.0},					// 1
				   { x0 + del * 3.5, y0 + del * 4.0, y0, 1.0},					// 2
				   { x0 - del * 3.5, y0 + del * 4.0, y0, 1.0},					// 3
				   { x0 - del * 3.5, y0 - del * 4.0, y0 - del * 1.5, 1.0},		// 4
				   { x0 + del * 3.5, y0 - del * 4.0, y0 - del * 1.5, 1.0},		// 5
				   { x0 + del * 3.5, y0 + del * 4.0, y0 - del * 1.5, 1.0},		// 6											// 6
				   { x0 - del * 3.5, y0 + del * 4.0, y0 - del * 1.5, 1.0} };    // 7											// 7											


			m2 = new double[8, 4]{ 
				   { x0 - del * 3.5 / 2.0, y0 - del * 2.5, y0, 1.0},	                // 0
				   { x0 + del * 3.5 / 2.0, y0 - del * 2.5, y0, 1.0},					// 1
				   { x0 + del * 3.5 / 2.0, y0 - del * 2.8, y0, 1.0},					// 2
				   { x0 - del * 3.5 / 2.0, y0 - del * 2.8, y0, 1.0},					// 3
				   { x0 - del * 3.5 / 2.0, y0 - del * 2.5, y0 + del * 1.5, 1.0},		// 4
				   { x0 + del * 3.5 / 2.0, y0 - del * 2.5, y0 + del * 1.5, 1.0},		// 5
				   { x0 + del * 3.5 / 2.0, y0 - del * 2.8, y0 + del * 1.5, 1.0},		// 6											// 6
				   { x0 - del * 3.5 / 2.0, y0 - del * 2.8, y0 + del * 1.5, 1.0} };      // 7

			m3 = new double[8, 4]{ 
				   { x0 - del * 2.9, y0 - del * 2.0, y0, 1.0},	                // 0
				   { x0 - del * 2.5, y0 - del * 2.0, y0, 1.0},					// 1
				   { x0 - del * 2.5, y0 + del * 1.0, y0, 1.0},					// 2
				   { x0 - del * 2.9, y0 + del * 1.0, y0, 1.0},					// 3
				   { x0 - del * 2.9, y0 - del * 2.0, y0 + del * 2.0, 1.0},		// 4
				   { x0 - del * 2.5, y0 - del * 2.0, y0 + del * 2.0, 1.0},		// 5
				   { x0 - del * 2.5, y0 + del * 1.0, y0 + del * 2.0, 1.0},		// 6											// 6
				   { x0 - del * 2.9, y0 + del * 1.0, y0 + del * 2.0, 1.0} };    // 7

			m4 = new double[8, 4]{ 
				   { x0 - del * 1.5, y0 - del * 2.0, y0, 1.0},	// 0
				   { x0 + del * 1.5, y0 - del * 2.0, y0, 1.0},					// 1
				   { x0 + del * 1.5, y0 + del * 4.0, y0, 1.0},					// 2
				   { x0 - del * 1.5, y0 + del * 4.0, y0, 1.0},					// 3
				   { x0 - del * 1.5, y0 - del * 2.0, y0 - del * 0.5, 1.0},		// 4
				   { x0 + del * 1.5, y0 - del * 2.0, y0 - del * 0.5, 1.0},		// 5
				   { x0 + del * 1.5, y0 + del * 4.0, y0 - del * 0.5, 1.0},		// 6											// 6
				   { x0 - del * 1.5, y0 + del * 4.0, y0 - del * 0.5, 1.0} };    // 7

			m5 = new double[8, 4]{ 
				   { x0 - del * 1.9, y0 + del * 4.0, y0 + del * 1.2, 1.0},	// 0
				   { x0 + del * 4.2, y0 + del * 4.0, y0 + del * 1.2, 1.0},	// 1
				   { x0 + del * 4.2, y0 + del * 4.5, y0 + del * 1.2, 1.0},	// 2
				   { x0 - del * 1.9, y0 + del * 4.5, y0 + del * 1.2, 1.0},	// 3
				   { x0 - del * 1.9, y0 + del * 4.0, y0 - del * 1.5, 1.0},  // 4
				   { x0 + del * 4.2, y0 + del * 4.0, y0 - del * 1.5, 1.0},	// 5
				   { x0 + del * 4.2, y0 + del * 4.5, y0 - del * 1.5, 1.0},  // 6											// 6
				   { x0 - del * 1.9, y0 + del * 4.5, y0 - del * 1.5, 1.0} };// 7

			m6 = new double[8, 4]{ 
				   { x0 - del * 1.9, y0 + del * 4.5, y0 + del * 2.4, 1.0},	    // 0
				   { x0 + del * 5.2, y0 + del * 4.5, y0 + del * 2.4, 1.0},		// 1
				   { x0 + del * 5.2, y0 + del * 5.0, y0 + del * 2.4, 1.0},		// 2
				   { x0 - del * 1.9, y0 + del * 5.0, y0 + del * 2.4, 1.0},		// 3
				   { x0 - del * 1.9, y0 + del * 4.5, y0 - del * 1.5, 1.0},		// 4
				   { x0 + del * 5.2, y0 + del * 4.5, y0 - del * 1.5, 1.0},		// 5
				   { x0 + del * 5.2, y0 + del * 5.0, y0 - del * 1.5, 1.0},		// 6											// 6
				   { x0 - del * 1.9, y0 + del * 5.0, y0 - del * 1.5, 1.0} };    // 7

			m7 = new double[8, 4]{ 
				   { x0 - del * 1.9, y0 + del * 5.0, y0 + del * 3.6, 1.0},	    // 0
				   { x0 + del * 6.5, y0 + del * 5.0, y0 + del * 3.6, 1.0},		// 1
				   { x0 + del * 6.5, y0 + del * 5.5, y0 + del * 3.6, 1.0},		// 2
				   { x0 - del * 1.9, y0 + del * 5.5, y0 + del * 3.6, 1.0},		// 3
				   { x0 - del * 1.9, y0 + del * 5.0, y0 - del * 1.5, 1.0},		// 4
				   { x0 + del * 6.5, y0 + del * 5.0, y0 - del * 1.5, 1.0},		// 5
				   { x0 + del * 6.5, y0 + del * 5.5, y0 - del * 1.5, 1.0},		// 6											// 6
				   { x0 - del * 1.9, y0 + del * 5.5, y0 - del * 1.5, 1.0} };    // 7

			m8 = new double[8, 4]{ 
				   { x0 - del * 1.9, y0 + del * 5.5, y0 + del * 4.1, 1.0},	    // 0
				   { x0 - del * 4.2, y0 + del * 5.5, y0 + del * 4.1, 1.0},		// 1
				   { x0 - del * 4.2, y0 + del * 2.5, y0 + del * 4.1, 1.0},		// 2
				   { x0 - del * 1.9, y0 + del * 2.5, y0 + del * 4.1, 1.0},		// 3
				   { x0 - del * 1.9, y0 + del * 5.5, y0 - del * 0.8, 1.0},		// 4
				   { x0 - del * 4.2, y0 + del * 5.5, y0 - del * 0.8, 1.0},		// 5
				   { x0 - del * 4.2, y0 + del * 2.5, y0 - del * 0.8, 1.0},		// 6											// 6
				   { x0 - del * 1.9, y0 + del * 2.5, y0 - del * 0.8, 1.0} };    // 7

			m9 = new double[8, 4]{ 
				   { x0 - del * 0.9, y0 - del * 1.0, y0 - del * 0.5, 1.0},	// 0
				   { x0 + del * 0.9, y0 - del * 1.0, y0 - del * 0.5, 1.0},	// 1
				   { x0 + del * 0.9, y0 + del * 4.0, y0 - del * 0.5, 1.0},  // 2
				   { x0 - del * 0.9, y0 + del * 4.0, y0 - del * 0.5, 1.0},  // 3
				   { x0 - del * 0.9, y0 - del * 1.0, y0 - del * 1.0, 1.0},  // 4
				   { x0 + del * 0.9, y0 - del * 1.0, y0 - del * 1.0, 1.0},  // 5
				   { x0 + del * 0.9, y0 + del * 4.0, y0 - del * 1.0, 1.0},  // 6											// 6
				   { x0 - del * 0.9, y0 + del * 4.0, y0 - del * 1.0, 1.0} };// 7

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
			user_Graphics.DrawLine(pen1, (int)Pm1[0, 2], (int)Pm1[0, 1], (int)Pm1[1, 2], (int)Pm1[1, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[0, 2], (int)Pm1[0, 1], (int)Pm1[3, 2], (int)Pm1[3, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[0, 2], (int)Pm1[0, 1], (int)Pm1[4, 2], (int)Pm1[4, 1]);

			user_Graphics.DrawLine(pen1, (int)Pm1[6, 2], (int)Pm1[6, 1], (int)Pm1[2, 2], (int)Pm1[2, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[6, 2], (int)Pm1[6, 1], (int)Pm1[5, 2], (int)Pm1[5, 1]);
			user_Graphics.DrawLine(pen1, (int)Pm1[6, 2], (int)Pm1[6, 1], (int)Pm1[7, 2], (int)Pm1[7, 1]);
		}
	}
}
