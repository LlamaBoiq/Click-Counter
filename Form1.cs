using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Click_counter
{
    public partial class Form1 : Form
    {
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public void ChangeFormStatus()
        {
            this.Text = "Click Counter - Clicks: " + counter.ToString();
        }

        public void SetBackgroundDark()
        {
            this.BackColor = Color.FromArgb(30, 30, 30);
            label2.ForeColor = Color.FromArgb(255, 255, 255);
            label1.ForeColor = Color.FromArgb(175, 175, 175);
            checkBox1.ForeColor = Color.FromArgb(175, 175, 175);
            TransparencyText.ForeColor = Color.FromArgb(200, 200, 200);
            button1.BackColor = Color.FromArgb(60, 60, 60);
            button2.BackColor = Color.FromArgb(60, 60, 60);
            button2.ForeColor = Color.FromArgb(230, 230, 230);
            button1.ForeColor = Color.FromArgb(230, 230, 230);
        }

        public void LetThereBeLight()
        {
            this.BackColor = Form.DefaultBackColor;
            button1.BackColor = DefaultBackColor;
            button1.ForeColor = DefaultForeColor;
            label2.ForeColor = DefaultForeColor;
            label1.ForeColor = DefaultForeColor;
            checkBox1.ForeColor = DefaultForeColor;
            TransparencyText.ForeColor = DefaultForeColor;
            button2.BackColor = DefaultBackColor;
            button2.ForeColor = DefaultForeColor;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            counter++;
            label2.Text = counter.ToString();
            ChangeFormStatus();
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            counter++;
            label2.Text = counter.ToString();
            ChangeFormStatus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChangeFormStatus();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            System.Windows.Forms.Form.ActiveForm.Opacity = ((double)(trackBar1.Value) / 100.0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (counter > 0)
            {
                DialogResult res = MessageBox.Show("Are you sure you want to RESET? Your last number was " + counter.ToString(), "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    DialogResult = DialogResult.OK;
                    counter = 0;
                    label2.Text = counter.ToString();
                }
                if (res == DialogResult.Cancel)
                {
                    DialogResult = DialogResult.Cancel;
                }
            }
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.Checked = true;
                SetBackgroundDark();
            }
            else
            {
                LetThereBeLight();
            }
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;

            }
            else if (WindowState == FormWindowState.Maximized)
            {

                this.FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(counter > 0)
            {
                DialogResult res = MessageBox.Show("Are you sure you want to EXIT? Your last number was " + counter.ToString(), "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    DialogResult = DialogResult.OK;
                    e.Cancel = false;
                }
                if (res == DialogResult.Cancel)
                {
                    DialogResult = DialogResult.Cancel;
                    e.Cancel = true;
                }
            }
        }
    }
}
