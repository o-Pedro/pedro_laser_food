using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laser_food
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //=== PROGRESS BAR ===
            SendMessage(progressBar1.Handle, 0x410, (IntPtr)2, IntPtr.Zero);

            progressBar1.Value = 0;
            timer1.Start();
        }
   
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //=== PROGRESSO DA PROGRESS BAR ===
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;

                if (progressBar1.Value == 100)
                {
                    progressBar1.Refresh();

                    timer1.Stop();

                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }
            }
        }
    }
}
