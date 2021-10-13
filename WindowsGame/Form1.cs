using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsGame
{
    public partial class Form1 : Form
    {
        Ship ship = new Ship();

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Continuous;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            ship.CycleCount = track_motorCycles.Value;
            UpdateUI();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ship = new Ship();
            UpdateUI();
        }

        private void UpdateUI()
        {
            progressBar1.Maximum = ship.Capacity;

            if(ship.GetShipLoad() <= ship.Capacity)
            {
                progressBar1.Value = ship.GetShipLoad();    
            }

            label_shipLabel.Text = ship.ToString();

            label_cycleCount.Text = ship.CycleCount.ToString();
            label_carCount.Text = ship.CarCount.ToString();
            label_truckCount.Text = ship.TruckCount.ToString();
            label_trainCount.Text = ship.TrainCarCount.ToString();

            if (ship.OverUnder() == 0)
                progressBar1.ForeColor = Color.Green;

            if (ship.OverUnder() > 0)
                progressBar1.ForeColor = Color.Yellow;

            if (ship.OverUnder() < 0)
                progressBar1.ForeColor = Color.Red;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void track_cars_Scroll(object sender, EventArgs e)
        {
            ship.CarCount = track_cars.Value;
            UpdateUI();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void track_trucks_Scroll(object sender, EventArgs e)
        {
            ship.TruckCount = track_trucks.Value;
            UpdateUI();
        }

        private void track_trainCars_Scroll(object sender, EventArgs e)
        {
            ship.TrainCarCount = track_trainCars.Value;
            UpdateUI();
        }
    }
}
