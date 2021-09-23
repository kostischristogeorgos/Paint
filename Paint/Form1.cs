using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Proeraitikh2
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen p;
        Color color;
        SolidBrush solidBrush = new SolidBrush(Color.SaddleBrown);
        int drawing_option, starting_X, starting_Y,finishing_X,finishing_Y;
        bool mouse_pressed = false;
        int count;
        int time_elapsed = 0;
        public Form1()
        {
            InitializeComponent();
            time_elapsed_timer.Enabled = true;
            time_elapsed_timer.Start(); // Starts the timer which counts the time since the launch.
        }

        private void Form1_Load(object sender, EventArgs e)
        {   // Initialises the graphics and the pen. 
            g = this.CreateGraphics();
            p = new Pen(Color.Black);
            shape_comboBox.SelectedIndex = 0;
            width_comboBox.SelectedIndex = 0;
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {   // Gets the coordinates of the first click.
            mouse_pressed = true;
            starting_X = e.X;
            starting_Y = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {   // If the drawing options is free draw in every move of the mouse it draw's a line.
            if (drawing_option == 1)
            {
               if (mouse_pressed)
                {
                   g.DrawLine(p, starting_X, starting_Y, e.X, e.Y);
                   starting_X = e.X;
                   starting_Y = e.Y;
               }
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {   if(e.Y< 79)
            {
                MessageBox.Show("You are not allowed to draw in the menu panel!" + Environment.NewLine + "What you drew there didn't register!");
            }
            mouse_pressed = false;
            // Based on each drawing option it draws the respective shape and calls the function that stores the data in the database.
            if(drawing_option == 1)
            {
                Write_to_DB(drawing_option, time_elapsed);
            }
            else if (drawing_option == 2) {
                finishing_X = e.X;
                finishing_Y = e.Y;
                g.DrawLine(p, starting_X, starting_Y, finishing_X, finishing_Y);
                Write_to_DB(drawing_option, time_elapsed);
            }
            else if (drawing_option == 3)
            {
                finishing_X = e.X;
                finishing_Y = e.Y;
                g.DrawEllipse(p, Math.Min(starting_X, finishing_X), Math.Min(starting_Y, finishing_Y), Math.Abs(starting_X - finishing_X), Math.Abs(starting_Y - finishing_Y));
                Write_to_DB(drawing_option, time_elapsed);
            }
            else if (drawing_option == 4)
            {
                finishing_X = e.X;
                finishing_Y = e.Y;
                g.DrawRectangle(p, Math.Min(starting_X, finishing_X), Math.Min(starting_Y, finishing_Y), Math.Abs(starting_X - finishing_X), Math.Abs(starting_Y - finishing_Y));
                Write_to_DB(drawing_option, time_elapsed);
            }
            else if (drawing_option == 5)
            {
                finishing_X = e.X;
                finishing_Y = e.Y;
                g.DrawEllipse(p, Math.Min(starting_X, finishing_X), Math.Min(starting_Y, finishing_Y), Math.Abs(starting_Y - finishing_Y), Math.Abs(starting_Y - finishing_Y));
                Write_to_DB(drawing_option, time_elapsed);
            }
        }

        private void width_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {   // Changes the pen's width based on the combo box's selected index.
            if(width_comboBox.SelectedIndex == 0)
            {
                p.Width = 1;
            }
            else if (width_comboBox.SelectedIndex == 1)
            {
                p.Width = 2;
            }
            else if(width_comboBox.SelectedIndex == 2)
            {
                p.Width = 3;
            }
            else
            {
                p.Width = 5;
            }
        }

        private void shape_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {   // Changes the drawing option based on the combo box's selected index.
            if(shape_comboBox.SelectedIndex == 0)
            {
                drawing_option = 1;
            }
            else if(shape_comboBox.SelectedIndex == 1)
            {
                drawing_option = 2;
            }
            else if(shape_comboBox.SelectedIndex == 2)
            {
                drawing_option = 3;
            }
            else if (shape_comboBox.SelectedIndex == 3)
            {
                drawing_option = 4;
            }
            else
            {
                drawing_option = 5;
            }
        }


        private void clear_button_Click(object sender, EventArgs e)
        {   // When pressed it refreshed the form and clears the drawning panel.
            this.Refresh();
        }


        private void color_button_Click_1(object sender, EventArgs e)
        {   // It sets the pen's color to the chosen color.
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
                p.Color = color;
                color_picturebox.BackColor = color;
            }
        }

      

        private void exit_button_Click_1(object sender, EventArgs e)
        {   // Closes the program.
            this.Close();
        }


        private void program_draw_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {   // Based on this combo box's selected index the program draws a drawing.
            // It starts each drawing's timer, it stops the other drawings' timers and clears the drawing panel.
            if (program_draw_comboBox.SelectedIndex == 0)
            {
                csharp_timer.Enabled = false;
                smily_timer.Enabled = false;
                house_timer.Enabled = true;
                house_timer.Start();
                count = 0;
                clear_button.PerformClick();
                p.Width = 5;
                p.Color = Color.SaddleBrown;
            }
            else if(program_draw_comboBox.SelectedIndex == 1)
            {
                house_timer.Enabled = false;
                smily_timer.Enabled = false;
                csharp_timer.Enabled = true;
                csharp_timer.Start();
                count = 0;
                clear_button.PerformClick();
                p.Width = 5;
                p.Color = Color.MediumPurple;
            }
            else if(program_draw_comboBox.SelectedIndex == 2)
            {
                house_timer.Enabled = false;
                csharp_timer.Enabled = false;
                smily_timer.Enabled = true;
                smily_timer.Start();
                count = 0;
                clear_button.PerformClick();
                p.Width = 4;
                p.Color = Color.Black;
                solidBrush.Color = Color.Beige;
            }
        }
        private void house_timer_Tick(object sender, EventArgs e)
        {
            // Instructions for the first drawing to be drawn.   
            if(count  == 0)
            {
                g.DrawLine(p, 400, 500, 400, 300);
            }
            if(count == 1)
            {
                g.DrawLine(p, 700, 500, 700, 300);
            }
            if(count == 2)
            {
                g.DrawLine(p, 400, 500, 700, 500);
            }
            if(count == 3)
            {
                solidBrush.Color = Color.SaddleBrown;
                g.DrawLine(p, 400, 300, 700, 300);
                g.DrawRectangle(p, 520, 420, 60, 80);
                g.DrawRectangle(p, 900, 400, 50, 100);
                g.FillRectangle(solidBrush, 900, 400, 50, 100);
                g.DrawRectangle(p, 200, 400, 50, 100);
                g.FillRectangle(solidBrush, 200, 400, 50, 100);
                p.Color = Color.DarkGreen;
                Point[] points1 = { new Point(850, 400), new Point(925, 200), new Point(1000, 400) };
                Point[] points2 = { new Point(150, 400), new Point(225, 250), new Point(300, 400) };
                g.DrawPolygon(p, points1);
                g.DrawPolygon(p, points2);
                solidBrush.Color = Color.DarkGreen;
                g.FillPolygon(solidBrush, points1);
                g.FillPolygon(solidBrush, points2);
               
            }
            if(count == 4)
            {
                p.Color = Color.SaddleBrown;
                g.DrawLine(p, 400, 300, 550, 200);
                g.DrawRectangle(p, 420, 320, 50, 50);
                p.Color = Color.Yellow;
                for(int i =0;i < 4; i++)
                {
                    g.DrawEllipse(p, 190 + i * 10, 340 + i * 10, 1, 1);
                    g.DrawEllipse(p, 260 - i * 10, 340 - i * 10, 1, 1);
                    g.DrawEllipse(p, 890 + i * 10, 340 + i * 10, 1, 1);
                    g.DrawEllipse(p, 960 - i * 10, 340 - i * 10, 1, 1);
                }
                p.Color = Color.SaddleBrown;            
            }
            if(count == 5)
            {
                g.DrawLine(p,550, 200, 700, 300);
                g.DrawRectangle(p, 620, 320, 50, 50);
                p.Color = Color.Yellow;
                g.DrawEllipse(p,100, 100, 100, 100);
                solidBrush.Color = Color.Yellow;
                g.FillEllipse(solidBrush, 100, 100, 100, 100);
                house_timer.Enabled = false;
            }
            count++;
            
        }



        private void csharp_timer_Tick(object sender, EventArgs e)
        {   // Instructions for the second drawing to be drawn.
            if (count == 0)
            {

                g.DrawArc(p, new Rectangle(300,200,100,150), 90, 180);
            }
            if(count == 1)
            {
                g.DrawLine(p, 450, 230, 550, 240);
                g.DrawLine(p, 435, 330, 540, 340);
                
            }
            if(count == 2)
            {
                g.DrawLine(p, 480, 200, 450, 360);
                g.DrawLine(p, 520, 200, 490, 365);
                
            }
            if(count == 3)
            {
                g.DrawLine(p,590,200,590,330);
                g.DrawEllipse(p,590,350,1,1);
                csharp_timer.Enabled = false;
            }
            count++;
        }
        private void smily_timer_Tick(object sender, EventArgs e)
        {
            // Instructions for the third drawing to be drawn.
            if (count == 0)
            {
                g.DrawEllipse(p,400, 200, 200, 200);
                g.FillEllipse(solidBrush, 400, 200, 200, 200);

            }
            if(count == 1)
            {
                g.DrawEllipse(p, 450, 240, 10, 10);
                g.DrawEllipse(p, 550, 240, 10, 10);
                solidBrush.Color = Color.Black;
                g.FillEllipse(solidBrush, 450, 240, 10, 10);
                g.FillEllipse(solidBrush, 550, 240, 10, 10);
            }
            if(count == 2)
            {
                p.Color = Color.Black;
                g.DrawArc(p, new Rectangle(440, 270, 130, 100), 0, 180);
                g.DrawArc(p, new Rectangle(490, 250, 25, 60), 0, 90);
                smily_timer.Enabled = false;
            }
            count++;
        }
        private void time_elapsed_timer_Tick(object sender, EventArgs e)
        {   // In each tick the time_elapsed is incremented by 1 second.
            time_elapsed++;
        }

        private void Write_to_DB(int option, int time_elapsed)
        {
            try
            {   // It connects to the database and inserts the shape and the time that it was drawn.
                String connectionString = "Data Source=Database1.db;Version=3;";
                SQLiteConnection connection = new SQLiteConnection(connectionString);
                connection.Open();

                String shape = null;
                if (option == 1) shape = "Free Draw";
                if (option == 2) shape = "Line";
                if (option == 3) shape = "Ellipse";
                if (option == 4) shape = "Rectangle";
                if (option == 5) shape = "Circle";
                String query = "insert into Shapes(Shape,Timestamp) VALUES(@shape,@timestamp)";

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@shape", shape);
                command.Parameters.AddWithValue("@timestamp", time_elapsed);
                
                int return_value = command.ExecuteNonQuery();
                connection.Close();
            }
            catch (SQLiteException)
            {
                MessageBox.Show("There was an exception with the Database");
            }
        }

        // Based on each menu strip's item click it does the respective actions for each button.
        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 1;
            width_comboBox.SelectedIndex = 0;
        }

        private void pxToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            p.Width = 2;
            width_comboBox.SelectedIndex = 1;
        }

        private void pxToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            p.Width = 3;
            width_comboBox.SelectedIndex = 2;
        }

        private void pxToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            p.Width = 5;
            width_comboBox.SelectedIndex = 3;
        }

        private void freeDrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawing_option = 1;
            shape_comboBox.SelectedIndex = 0;
        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawing_option = 2;
            shape_comboBox.SelectedIndex = 1;
        }

        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawing_option = 3;
            shape_comboBox.SelectedIndex = 2;
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawing_option = 4;
            shape_comboBox.SelectedIndex = 3;
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawing_option = 5;
            shape_comboBox.SelectedIndex = 4;
        }
    }
}
