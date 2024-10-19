using System;
using System.Drawing;
using System.Windows.Forms;
namespace _2024_10_15
{
	public class Car : PictureBox
	{
		public Timer moveTimer = new Timer { Interval = 25 };
		public Action<Car> Finish;
		public Func<Car, bool> CollisionCheck;
		public Action NewCar;
		public Car()
		{
			BackColor = Color.Red;
			Width = 150;
			Height = 75;
			Top = 489 / 3;
			Left = -Width - 10;
			moveTimer.Tick += (s, e) =>
			{
				if (CollisionCheck(this))
				{
					Left += 2;
					if (Left >= 816)
					{
						moveTimer.Stop();
						Finish(this);
					}
					if (NewCar != null && Left > 10)
					{
						NewCar();
						NewCar = null;
					}
				}
			};
			moveTimer.Start();
		}
	}
}
