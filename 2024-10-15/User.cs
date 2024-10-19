using System;

namespace _2024_10_15
{
	public class User
	{
		public int Id;
		public string Username;
		public string Password;
		public int Points
		{
			get => _points;
			set
			{
				_points = value;
				if (AutoSavePoints) Database.Update(this);
				if (PointsChanged != null) PointsChanged(this);
			}
		}
		int _points;
		public bool AutoSavePoints = false;
		public Action<User> PointsChanged;
	}
}
