namespace Calculator
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
            this.b_1 = new System.Windows.Forms.Button();
            this.b_2 = new System.Windows.Forms.Button();
            this.b_3 = new System.Windows.Forms.Button();
            this.b_4 = new System.Windows.Forms.Button();
            this.b_7 = new System.Windows.Forms.Button();
            this.b_5 = new System.Windows.Forms.Button();
            this.b_8 = new System.Windows.Forms.Button();
            this.b_6 = new System.Windows.Forms.Button();
            this.b_9 = new System.Windows.Forms.Button();
            this.b_dot = new System.Windows.Forms.Button();
            this.b_0 = new System.Windows.Forms.Button();
            this.b_equals = new System.Windows.Forms.Button();
            this.b_subs = new System.Windows.Forms.Button();
            this.b_multi = new System.Windows.Forms.Button();
            this.b_div = new System.Windows.Forms.Button();
            this.b_sum = new System.Windows.Forms.Button();
            this.b_save = new System.Windows.Forms.Button();
            this.b_load = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.b_close = new System.Windows.Forms.Button();
            this.cb_Visual_type = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // b_1
            // 
            this.b_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_1.Location = new System.Drawing.Point(49, 89);
            this.b_1.Name = "b_1";
            this.b_1.Size = new System.Drawing.Size(35, 30);
            this.b_1.TabIndex = 2;
            this.b_1.Text = "1";
            this.b_1.UseVisualStyleBackColor = true;
            this.b_1.Click += new System.EventHandler(this.b_1_Click);
            // 
            // b_2
            // 
            this.b_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_2.Location = new System.Drawing.Point(90, 89);
            this.b_2.Name = "b_2";
            this.b_2.Size = new System.Drawing.Size(35, 30);
            this.b_2.TabIndex = 2;
            this.b_2.Text = "2";
            this.b_2.UseVisualStyleBackColor = true;
            this.b_2.Click += new System.EventHandler(this.b_2_Click);
            // 
            // b_3
            // 
            this.b_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_3.Location = new System.Drawing.Point(131, 89);
            this.b_3.Name = "b_3";
            this.b_3.Size = new System.Drawing.Size(35, 30);
            this.b_3.TabIndex = 2;
            this.b_3.Text = "3";
            this.b_3.UseVisualStyleBackColor = true;
            this.b_3.Click += new System.EventHandler(this.b_3_Click);
            // 
            // b_4
            // 
            this.b_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_4.Location = new System.Drawing.Point(49, 125);
            this.b_4.Name = "b_4";
            this.b_4.Size = new System.Drawing.Size(35, 30);
            this.b_4.TabIndex = 2;
            this.b_4.Text = "4";
            this.b_4.UseVisualStyleBackColor = true;
            this.b_4.Click += new System.EventHandler(this.b_4_Click);
            // 
            // b_7
            // 
            this.b_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_7.Location = new System.Drawing.Point(49, 161);
            this.b_7.Name = "b_7";
            this.b_7.Size = new System.Drawing.Size(35, 30);
            this.b_7.TabIndex = 2;
            this.b_7.Text = "7";
            this.b_7.UseVisualStyleBackColor = true;
            this.b_7.Click += new System.EventHandler(this.b_7_Click);
            // 
            // b_5
            // 
            this.b_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_5.Location = new System.Drawing.Point(90, 125);
            this.b_5.Name = "b_5";
            this.b_5.Size = new System.Drawing.Size(35, 30);
            this.b_5.TabIndex = 2;
            this.b_5.Text = "5";
            this.b_5.UseVisualStyleBackColor = true;
            this.b_5.Click += new System.EventHandler(this.b_5_Click);
            // 
            // b_8
            // 
            this.b_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_8.Location = new System.Drawing.Point(90, 161);
            this.b_8.Name = "b_8";
            this.b_8.Size = new System.Drawing.Size(35, 30);
            this.b_8.TabIndex = 2;
            this.b_8.Text = "8";
            this.b_8.UseVisualStyleBackColor = true;
            this.b_8.Click += new System.EventHandler(this.b_8_Click);
            // 
            // b_6
            // 
            this.b_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_6.Location = new System.Drawing.Point(131, 125);
            this.b_6.Name = "b_6";
            this.b_6.Size = new System.Drawing.Size(35, 30);
            this.b_6.TabIndex = 2;
            this.b_6.Text = "6";
            this.b_6.UseVisualStyleBackColor = true;
            this.b_6.Click += new System.EventHandler(this.b_6_Click);
            // 
            // b_9
            // 
            this.b_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_9.Location = new System.Drawing.Point(131, 161);
            this.b_9.Name = "b_9";
            this.b_9.Size = new System.Drawing.Size(35, 30);
            this.b_9.TabIndex = 2;
            this.b_9.Text = "9";
            this.b_9.UseVisualStyleBackColor = true;
            this.b_9.Click += new System.EventHandler(this.b_9_Click);
            // 
            // b_dot
            // 
            this.b_dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_dot.Location = new System.Drawing.Point(49, 197);
            this.b_dot.Name = "b_dot";
            this.b_dot.Size = new System.Drawing.Size(35, 30);
            this.b_dot.TabIndex = 2;
            this.b_dot.Text = ".";
            this.b_dot.UseVisualStyleBackColor = true;
            this.b_dot.Click += new System.EventHandler(this.b_dot_Click);
            // 
            // b_0
            // 
            this.b_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_0.Location = new System.Drawing.Point(90, 197);
            this.b_0.Name = "b_0";
            this.b_0.Size = new System.Drawing.Size(35, 30);
            this.b_0.TabIndex = 2;
            this.b_0.Text = "0";
            this.b_0.UseVisualStyleBackColor = true;
            this.b_0.Click += new System.EventHandler(this.b_0_Click);
            // 
            // b_equals
            // 
            this.b_equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_equals.Location = new System.Drawing.Point(131, 197);
            this.b_equals.Name = "b_equals";
            this.b_equals.Size = new System.Drawing.Size(35, 30);
            this.b_equals.TabIndex = 2;
            this.b_equals.Text = "=";
            this.b_equals.UseVisualStyleBackColor = true;
            this.b_equals.Click += new System.EventHandler(this.b_equals_Click);
            // 
            // b_subs
            // 
            this.b_subs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_subs.Location = new System.Drawing.Point(172, 125);
            this.b_subs.Name = "b_subs";
            this.b_subs.Size = new System.Drawing.Size(35, 30);
            this.b_subs.TabIndex = 2;
            this.b_subs.Text = "-";
            this.b_subs.UseVisualStyleBackColor = true;
            this.b_subs.Click += new System.EventHandler(this.b_subs_Click);
            // 
            // b_multi
            // 
            this.b_multi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_multi.Location = new System.Drawing.Point(172, 161);
            this.b_multi.Name = "b_multi";
            this.b_multi.Size = new System.Drawing.Size(35, 30);
            this.b_multi.TabIndex = 2;
            this.b_multi.Text = "*";
            this.b_multi.UseVisualStyleBackColor = true;
            this.b_multi.Click += new System.EventHandler(this.b_multi_Click);
            // 
            // b_div
            // 
            this.b_div.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_div.Location = new System.Drawing.Point(172, 197);
            this.b_div.Name = "b_div";
            this.b_div.Size = new System.Drawing.Size(35, 30);
            this.b_div.TabIndex = 2;
            this.b_div.Text = "/";
            this.b_div.UseVisualStyleBackColor = true;
            this.b_div.Click += new System.EventHandler(this.b_div_Click);
            // 
            // b_sum
            // 
            this.b_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_sum.Location = new System.Drawing.Point(172, 89);
            this.b_sum.Name = "b_sum";
            this.b_sum.Size = new System.Drawing.Size(35, 30);
            this.b_sum.TabIndex = 2;
            this.b_sum.Text = "+";
            this.b_sum.UseVisualStyleBackColor = true;
            this.b_sum.Click += new System.EventHandler(this.b_sum_Click);
            // 
            // b_save
            // 
            this.b_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_save.Location = new System.Drawing.Point(213, 89);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(76, 30);
            this.b_save.TabIndex = 3;
            this.b_save.Text = "save";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // b_load
            // 
            this.b_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_load.Location = new System.Drawing.Point(213, 125);
            this.b_load.Name = "b_load";
            this.b_load.Size = new System.Drawing.Size(76, 30);
            this.b_load.TabIndex = 3;
            this.b_load.Text = "load";
            this.b_load.UseVisualStyleBackColor = true;
            this.b_load.Click += new System.EventHandler(this.b_load_Click);
            // 
            // Display
            // 
            this.Display.AutoSize = true;
            this.Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Display.Location = new System.Drawing.Point(102, 9);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(0, 20);
            this.Display.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // b_close
            // 
            this.b_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_close.Location = new System.Drawing.Point(213, 161);
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(76, 30);
            this.b_close.TabIndex = 3;
            this.b_close.Text = "close";
            this.b_close.UseVisualStyleBackColor = true;
            this.b_close.Click += new System.EventHandler(this.b_close_click);
            // 
            // cb_Visual_type
            // 
            this.cb_Visual_type.FormattingEnabled = true;
            this.cb_Visual_type.Location = new System.Drawing.Point(214, 198);
            this.cb_Visual_type.Name = "cb_Visual_type";
            this.cb_Visual_type.Size = new System.Drawing.Size(75, 21);
            this.cb_Visual_type.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 260);
            this.ControlBox = false;
            this.Controls.Add(this.cb_Visual_type);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.b_close);
            this.Controls.Add(this.b_load);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.b_sum);
            this.Controls.Add(this.b_3);
            this.Controls.Add(this.b_div);
            this.Controls.Add(this.b_2);
            this.Controls.Add(this.b_multi);
            this.Controls.Add(this.b_equals);
            this.Controls.Add(this.b_9);
            this.Controls.Add(this.b_0);
            this.Controls.Add(this.b_dot);
            this.Controls.Add(this.b_8);
            this.Controls.Add(this.b_subs);
            this.Controls.Add(this.b_7);
            this.Controls.Add(this.b_6);
            this.Controls.Add(this.b_5);
            this.Controls.Add(this.b_4);
            this.Controls.Add(this.b_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button b_1;
        private System.Windows.Forms.Button b_2;
        private System.Windows.Forms.Button b_3;
        private System.Windows.Forms.Button b_4;
        private System.Windows.Forms.Button b_7;
        private System.Windows.Forms.Button b_5;
        private System.Windows.Forms.Button b_8;
        private System.Windows.Forms.Button b_6;
        private System.Windows.Forms.Button b_9;
        private System.Windows.Forms.Button b_dot;
        private System.Windows.Forms.Button b_0;
        private System.Windows.Forms.Button b_equals;
        private System.Windows.Forms.Button b_subs;
        private System.Windows.Forms.Button b_multi;
        private System.Windows.Forms.Button b_div;
        private System.Windows.Forms.Button b_sum;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.Button b_load;
        private System.Windows.Forms.Label Display;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button b_close;
        private System.Windows.Forms.ComboBox cb_Visual_type;
    }
}

