using System;
using System.Windows.Forms;
using System.Timers;

namespace ClockOpp
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer timer;

        public Form1()
        {
            InitializeComponent();
            StartClock();
        }

        private void StartClock()
        {
            timer = new System.Timers.Timer(1000); // Update every second
            timer.Elapsed += UpdateClock;
            timer.Start();
        }

        private void UpdateClock(object sender, ElapsedEventArgs e)
        {
            // Update the clock and date labels on the UI thread
            Invoke(new Action(() =>
            {
                lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
                lblDate.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            }));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
