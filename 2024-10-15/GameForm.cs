using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
namespace _2024_10_15
{
    public partial class GameForm : Form
    {
        List<Car> cars = new List<Car>();
        Timer trainTimer = new Timer();
        Random rng = new Random();
        public GameForm()
        {
            InitializeComponent();
            Database.OpenConnection();
            //if (new LoginForm().ShowDialog() != DialogResult.OK)
            //{
            //    Environment.Exit(0);
            //}
            Database.Login("a", "a");
            label1.Text = $"Hello, {Database.ActiveUser.Username}!";
            label2.Text = $"Points: {Database.ActiveUser.Points}";
            Database.ActiveUser.AutoSavePoints = true;
            Database.ActiveUser.PointsChanged = (user) =>
            {
                label2.Text = $"Points: {user.Points}";
            };
            NewCar();
            //trainTimer.Interval = rng.Next(10000, 30000);
            trainTimer.Interval = 1000;
            trainTimer.Tick += (s, e) =>
            {
                //trainTimer.Interval = rng.Next(10000, 30000);
                trainTimer.Interval = 10000;
                Train train = new Train { Finish = Finish, CollisionCheck = CollisionCheck };
                Controls.Add(train);
                train.BringToFront();
            };
            trainTimer.Start();
        }
        void NewCar()
        {
            Car newCar = new Car { Finish = Finish, CollisionCheck = CollisionCheck, NewCar = NewCar };
            if (CollisionCheck(newCar))
            {
                cars.Add(newCar);
                Controls.Add(newCar);
                newCar.BringToFront();
            }
        }
        void Finish(Car car)
        {
            Database.ActiveUser.Points++;
            Controls.Remove(car);
            cars.Remove(car);
        }
        bool CollisionCheck(Car currentCar)
        {
            Rectangle carBounds = currentCar.Bounds;
            carBounds.X += 20;
            foreach (Car car in cars)
            {
                if (carBounds.IntersectsWith(car.Bounds) && currentCar != car) return false;
            }
            if (crossingGate.Visible && (crossingGate.Bounds.IntersectsWith(carBounds) && !(currentCar.Left + currentCar.Width > crossingGate.Left))) return false;
            return true;
        }
        void Finish(Train train)
        {
            train.moveTimer.Stop();
            Controls.Remove(train);
        }
        bool CollisionCheck(Train train)
        {
            foreach (Car car in cars)
            {
                if (train.Bounds.IntersectsWith(car.Bounds))
                {
                    trainTimer.Stop();
                    foreach (Car c in cars)
                    {
                        c.moveTimer.Stop();
                    }
                    MessageBox.Show("fail");
                    return false;
                }
            }
            return true;
        }
        private void toggleGatesButton_Click(object sender, EventArgs e)
        {
            crossingGate.Visible = !crossingGate.Visible;
        }
    }
}
