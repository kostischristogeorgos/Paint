
namespace Proeraitikh2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.backcolor_picturebox = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.program_draw_comboBox = new System.Windows.Forms.ComboBox();
            this.clear_button = new System.Windows.Forms.Button();
            this.color_picturebox = new System.Windows.Forms.PictureBox();
            this.exit_button = new System.Windows.Forms.PictureBox();
            this.color_button = new System.Windows.Forms.Button();
            this.width_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.shape_comboBox = new System.Windows.Forms.ComboBox();
            this.house_timer = new System.Windows.Forms.Timer(this.components);
            this.csharp_timer = new System.Windows.Forms.Timer(this.components);
            this.smily_timer = new System.Windows.Forms.Timer(this.components);
            this.time_elapsed_timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.drawingOptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freeDrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pensWidthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pxToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pxToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pxToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backcolor_picturebox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.color_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_button)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backcolor_picturebox
            // 
            this.backcolor_picturebox.BackColor = System.Drawing.Color.White;
            this.backcolor_picturebox.Controls.Add(this.label2);
            this.backcolor_picturebox.Controls.Add(this.program_draw_comboBox);
            this.backcolor_picturebox.Controls.Add(this.clear_button);
            this.backcolor_picturebox.Controls.Add(this.color_picturebox);
            this.backcolor_picturebox.Controls.Add(this.exit_button);
            this.backcolor_picturebox.Controls.Add(this.color_button);
            this.backcolor_picturebox.Controls.Add(this.width_comboBox);
            this.backcolor_picturebox.Controls.Add(this.label3);
            this.backcolor_picturebox.Controls.Add(this.label1);
            this.backcolor_picturebox.Controls.Add(this.shape_comboBox);
            this.backcolor_picturebox.Location = new System.Drawing.Point(-1, 26);
            this.backcolor_picturebox.Name = "backcolor_picturebox";
            this.backcolor_picturebox.Size = new System.Drawing.Size(1103, 53);
            this.backcolor_picturebox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(725, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Let the Program to Draw";
            // 
            // program_draw_comboBox
            // 
            this.program_draw_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.program_draw_comboBox.FormattingEnabled = true;
            this.program_draw_comboBox.Items.AddRange(new object[] {
            "A house!",
            "C# !",
            "Smily!"});
            this.program_draw_comboBox.Location = new System.Drawing.Point(898, 14);
            this.program_draw_comboBox.Name = "program_draw_comboBox";
            this.program_draw_comboBox.Size = new System.Drawing.Size(121, 21);
            this.program_draw_comboBox.TabIndex = 18;
            this.program_draw_comboBox.SelectedIndexChanged += new System.EventHandler(this.program_draw_comboBox_SelectedIndexChanged);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(648, 12);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(59, 23);
            this.clear_button.TabIndex = 11;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // color_picturebox
            // 
            this.color_picturebox.BackColor = System.Drawing.Color.Black;
            this.color_picturebox.Location = new System.Drawing.Point(611, 15);
            this.color_picturebox.Name = "color_picturebox";
            this.color_picturebox.Size = new System.Drawing.Size(18, 20);
            this.color_picturebox.TabIndex = 16;
            this.color_picturebox.TabStop = false;
            // 
            // exit_button
            // 
            this.exit_button.Image = global::Proeraitikh2.Properties.Resources.exit;
            this.exit_button.Location = new System.Drawing.Point(1046, 3);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(40, 38);
            this.exit_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit_button.TabIndex = 15;
            this.exit_button.TabStop = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click_1);
            // 
            // color_button
            // 
            this.color_button.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color_button.Location = new System.Drawing.Point(492, 13);
            this.color_button.Name = "color_button";
            this.color_button.Size = new System.Drawing.Size(109, 23);
            this.color_button.TabIndex = 14;
            this.color_button.Text = "Choose color";
            this.color_button.UseVisualStyleBackColor = true;
            this.color_button.Click += new System.EventHandler(this.color_button_Click_1);
            // 
            // width_comboBox
            // 
            this.width_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.width_comboBox.FormattingEnabled = true;
            this.width_comboBox.Items.AddRange(new object[] {
            "1px",
            "2px",
            "3px",
            "5px"});
            this.width_comboBox.Location = new System.Drawing.Point(346, 14);
            this.width_comboBox.Name = "width_comboBox";
            this.width_comboBox.Size = new System.Drawing.Size(121, 21);
            this.width_comboBox.TabIndex = 13;
            this.width_comboBox.SelectedIndexChanged += new System.EventHandler(this.width_comboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(258, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Pen\'s Width";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Drawing Shape";
            // 
            // shape_comboBox
            // 
            this.shape_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shape_comboBox.FormattingEnabled = true;
            this.shape_comboBox.Items.AddRange(new object[] {
            "Free Draw",
            "Line",
            "Ellipse",
            "Rectangle",
            "Circle"});
            this.shape_comboBox.Location = new System.Drawing.Point(123, 14);
            this.shape_comboBox.Name = "shape_comboBox";
            this.shape_comboBox.Size = new System.Drawing.Size(121, 21);
            this.shape_comboBox.TabIndex = 11;
            this.shape_comboBox.SelectedIndexChanged += new System.EventHandler(this.shape_comboBox_SelectedIndexChanged);
            // 
            // house_timer
            // 
            this.house_timer.Interval = 1000;
            this.house_timer.Tick += new System.EventHandler(this.house_timer_Tick);
            // 
            // csharp_timer
            // 
            this.csharp_timer.Interval = 1000;
            this.csharp_timer.Tick += new System.EventHandler(this.csharp_timer_Tick);
            // 
            // smily_timer
            // 
            this.smily_timer.Interval = 1000;
            this.smily_timer.Tick += new System.EventHandler(this.smily_timer_Tick);
            // 
            // time_elapsed_timer
            // 
            this.time_elapsed_timer.Interval = 1000;
            this.time_elapsed_timer.Tick += new System.EventHandler(this.time_elapsed_timer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawingOptionToolStripMenuItem,
            this.pensWidthToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1100, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // drawingOptionToolStripMenuItem
            // 
            this.drawingOptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.freeDrawToolStripMenuItem,
            this.lineToolStripMenuItem,
            this.ellipseToolStripMenuItem,
            this.rectangleToolStripMenuItem,
            this.circleToolStripMenuItem});
            this.drawingOptionToolStripMenuItem.Name = "drawingOptionToolStripMenuItem";
            this.drawingOptionToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.drawingOptionToolStripMenuItem.Text = "Drawing Option";
            // 
            // freeDrawToolStripMenuItem
            // 
            this.freeDrawToolStripMenuItem.Name = "freeDrawToolStripMenuItem";
            this.freeDrawToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.freeDrawToolStripMenuItem.Text = "Free Draw";
            this.freeDrawToolStripMenuItem.Click += new System.EventHandler(this.freeDrawToolStripMenuItem_Click);
            // 
            // lineToolStripMenuItem
            // 
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            this.lineToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.lineToolStripMenuItem.Text = "Line";
            this.lineToolStripMenuItem.Click += new System.EventHandler(this.lineToolStripMenuItem_Click);
            // 
            // ellipseToolStripMenuItem
            // 
            this.ellipseToolStripMenuItem.Name = "ellipseToolStripMenuItem";
            this.ellipseToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.ellipseToolStripMenuItem.Text = "Ellipse";
            this.ellipseToolStripMenuItem.Click += new System.EventHandler(this.ellipseToolStripMenuItem_Click);
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
            // 
            // circleToolStripMenuItem
            // 
            this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            this.circleToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.circleToolStripMenuItem.Text = "Circle";
            this.circleToolStripMenuItem.Click += new System.EventHandler(this.circleToolStripMenuItem_Click);
            // 
            // pensWidthToolStripMenuItem
            // 
            this.pensWidthToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pxToolStripMenuItem,
            this.pxToolStripMenuItem1,
            this.pxToolStripMenuItem2,
            this.pxToolStripMenuItem3});
            this.pensWidthToolStripMenuItem.Name = "pensWidthToolStripMenuItem";
            this.pensWidthToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.pensWidthToolStripMenuItem.Text = "Pen\'s Width";
            // 
            // pxToolStripMenuItem
            // 
            this.pxToolStripMenuItem.Name = "pxToolStripMenuItem";
            this.pxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pxToolStripMenuItem.Text = "1px";
            this.pxToolStripMenuItem.Click += new System.EventHandler(this.pxToolStripMenuItem_Click);
            // 
            // pxToolStripMenuItem1
            // 
            this.pxToolStripMenuItem1.Name = "pxToolStripMenuItem1";
            this.pxToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.pxToolStripMenuItem1.Text = "2px";
            this.pxToolStripMenuItem1.Click += new System.EventHandler(this.pxToolStripMenuItem1_Click);
            // 
            // pxToolStripMenuItem2
            // 
            this.pxToolStripMenuItem2.Name = "pxToolStripMenuItem2";
            this.pxToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.pxToolStripMenuItem2.Text = "3px";
            this.pxToolStripMenuItem2.Click += new System.EventHandler(this.pxToolStripMenuItem2_Click);
            // 
            // pxToolStripMenuItem3
            // 
            this.pxToolStripMenuItem3.Name = "pxToolStripMenuItem3";
            this.pxToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.pxToolStripMenuItem3.Text = "5px";
            this.pxToolStripMenuItem3.Click += new System.EventHandler(this.pxToolStripMenuItem3_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(1, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 2);
            this.panel1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1100, 542);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backcolor_picturebox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.backcolor_picturebox.ResumeLayout(false);
            this.backcolor_picturebox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.color_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_button)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel backcolor_picturebox;
        private System.Windows.Forms.PictureBox color_picturebox;
        private System.Windows.Forms.PictureBox exit_button;
        private System.Windows.Forms.Button color_button;
        private System.Windows.Forms.ComboBox width_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox shape_comboBox;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox program_draw_comboBox;
        private System.Windows.Forms.Timer house_timer;
        private System.Windows.Forms.Timer csharp_timer;
        private System.Windows.Forms.Timer smily_timer;
        private System.Windows.Forms.Timer time_elapsed_timer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem drawingOptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pensWidthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pxToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pxToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem pxToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem freeDrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ellipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}

