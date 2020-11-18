#define TECLA
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_Tema4_Ejer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = " Ventana! ";
            this.KeyPreview = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = "X: " + e.X + " Y: " + e.Y;
        }

        private void Button1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = "X: " + (e.X + button1.Location.X) + " Y: " + (e.Y + button1.Location.Y);
        }



        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_MouseMove_1(object sender, MouseEventArgs e)
        {
            this.Text = "X: " + (e.X + button2.Location.X) + " Y: " + (e.Y + button2.Location.Y);

        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            this.Text = " Ventana! ";
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button.Equals(MouseButtons.Left))
            {
                button1.BackColor = Color.Red;
            }
            if (e.Button.Equals(MouseButtons.Right))
            {
                button2.BackColor = Color.Red;
            }
        }

        private void Button2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button.Equals(MouseButtons.Right))
            {
                button2.BackColor = Color.Red;
            }
        }

        private void Button2_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button.Equals(MouseButtons.Right))
            {
                button2.BackColor = new Button().BackColor;
            }
            if (e.Button.Equals(MouseButtons.Left))
            {
                button1.BackColor = new Button().BackColor;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Text = " Ventana! ";
            }
            else
            {
#if TECLA
                this.Text = "" + e.KeyData;
#else
                this.Text = "" + e.KeyCode;
#endif
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("¿De verdad?", "CAPTION!", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
            {
                e.Cancel = true;
            }

        }
    }
}