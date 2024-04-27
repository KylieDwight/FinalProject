using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {

        int[] clock_pieces = { 0, 0, 0 };
        int[] flower_pieces = { 0, 0 };
        int[] wrench_pieces = { 0, 0 };
        int clockp = 0;
        int flowerp = 0;
        int wrenchp = 0;


        bool escape_1 = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
          

            if (clock_pieces[0] == 1 && clock_pieces[1] == 1 && clock_pieces[2] == 1)
                Clock_pb.Visible = true;
            if (wrench_pieces[0] == 1 && wrench_pieces[1] == 1)
                Wrench_pb.Visible = true;
            if (flower_pieces[0] == 1 && flower_pieces[1] == 1)
                Flower_pb.Visible = true;

            if (Clock_pb.Visible == true && Wrench_pb.Visible == true && Flower_pb.Visible == true)
            {
                Escape1.Visible = true;
                Escape1.Enabled = true;
            }

            clock_label_2.Text = clockp.ToString();
            flower_label_2.Text = flowerp.ToString();
            wrench_label_2.Text = wrenchp.ToString();
            

        }

        private void Escape1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congradulations!");
            this.Close();
        }

        private void background_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouseEvent = (MouseEventArgs)e;

            //Clock 1
            if (mouseEvent.X >= 0 && mouseEvent.X <= 0 + 39
                && mouseEvent.Y >= 249 && mouseEvent.Y <= 249 + 34
                && escape_1 == false)
            {
                clockp += 1;

                clock_pieces[0] = 1;
                clock_1_found.Visible = true;
            }

            //Clock 2
            if (mouseEvent.X >= 494 && mouseEvent.X <= 494 + 39
                && mouseEvent.Y >= 345 && mouseEvent.Y <= 345 + 34
                && escape_1 == false)
            {
                clockp += 1;

                clock_pieces[1] = 1;
                clock_2_found.Visible = true;
            }

            //Clock 3
            if (mouseEvent.X >= 678 && mouseEvent.X <= 678 + 39
                && mouseEvent.Y >= 88 && mouseEvent.Y <= 88 + 34
                && escape_1 == false)
            {
                clockp += 1;

                clock_pieces[2] = 1;
                clock_3_found.Visible = true;
            }

            //Flower 1
            if (mouseEvent.X >= 567 && mouseEvent.X <= 567 + 39
                && mouseEvent.Y >= 194 && mouseEvent.Y <= 194 + 34
                && escape_1 == false)
            {
                flowerp += 1;

                flower_pieces[0] = 1;
                flower_1_found.Visible = true;
            }

            //Flower 2
            if (mouseEvent.X >= 312 && mouseEvent.X <= 312 + 36
                && mouseEvent.Y >= 38 && mouseEvent.Y <= 38 + 34
                && escape_1 == false)
            {
                flowerp += 1;

                flower_pieces[1] = 1;
                flower_2_found.Visible = true;
            }

            //Wrench 1
            if (mouseEvent.X >= 138 && mouseEvent.X <= 138 + 31
                && mouseEvent.Y >= 179 && mouseEvent.Y <= 179 + 25
                && escape_1 == false)
            {
                wrenchp += 1;

                wrench_pieces[0] = 1;
                wrench_1_found.Visible = true;
            }

            //Wrench 2
            if (mouseEvent.X >= 567 && mouseEvent.X <= 567 + 24
                && mouseEvent.Y >= 50 && mouseEvent.Y <= 50 + 60
                && escape_1 == false)
            {
                wrenchp += 1;

                wrench_pieces[1] = 1;
                wrench_2_found.Visible = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
