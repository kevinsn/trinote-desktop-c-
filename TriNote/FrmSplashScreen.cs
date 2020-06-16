using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriNote
{
    public partial class FrmSplashScreen : Form
    {
        Timer timer;

        public FrmSplashScreen()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = (1);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Refresh
            // MessageBox.Show("Estou no timer");

            loadingBar.Width += 5;

            if (loadingBar.Width >= 400)
            {
                timer.Stop();                
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.Show();

                this.Hide();                
            }

        }
    }
}
