﻿using System;
using System.Drawing;
using System.Windows.Forms;
namespace _2024_10_15
{
	public class Train : PictureBox
	{
		public Timer moveTimer = new Timer { Interval = 10 };
		public Action<Train> Finish;
		public Func<Train, bool> CollisionCheck;
		public Train()
		{
			BackColor = Color.Black;
			Width = 50;
			Height = 300;
			Top = 1000;
			Left = 489 / 2 + Width;
			moveTimer.Tick += (s, e) =>
			{
				moveTimer.Stop();
				if (CollisionCheck(this))
				{
					Top -= 4;
					if (Top < -Height)
					{
						moveTimer.Stop();
						Finish(this);
					}
					moveTimer.Start();
				}
			};
			moveTimer.Start();
		}
	}
}
