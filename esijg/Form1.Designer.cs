namespace esijg
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
            this.studs_b = new System.Windows.Forms.Button();
            this.profs_b = new System.Windows.Forms.Button();
            this.grades_b = new System.Windows.Forms.Button();
            this.objects_b = new System.Windows.Forms.Button();
            this.groups_b = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // studs_b
            // 
            this.studs_b.Location = new System.Drawing.Point(15, 96);
            this.studs_b.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.studs_b.Name = "studs_b";
            this.studs_b.Size = new System.Drawing.Size(350, 37);
            this.studs_b.TabIndex = 0;
            this.studs_b.Text = "Students";
            this.studs_b.UseVisualStyleBackColor = true;
            this.studs_b.Click += new System.EventHandler(this.studs_b_Click);
            // 
            // profs_b
            // 
            this.profs_b.Location = new System.Drawing.Point(15, 143);
            this.profs_b.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.profs_b.Name = "profs_b";
            this.profs_b.Size = new System.Drawing.Size(350, 37);
            this.profs_b.TabIndex = 1;
            this.profs_b.Text = "Teachers";
            this.profs_b.UseVisualStyleBackColor = true;
            this.profs_b.Click += new System.EventHandler(this.profs_b_Click);
            // 
            // grades_b
            // 
            this.grades_b.Location = new System.Drawing.Point(15, 190);
            this.grades_b.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.grades_b.Name = "grades_b";
            this.grades_b.Size = new System.Drawing.Size(350, 37);
            this.grades_b.TabIndex = 2;
            this.grades_b.Text = "Marks";
            this.grades_b.UseVisualStyleBackColor = true;
            this.grades_b.Click += new System.EventHandler(this.grades_b_Click);
            // 
            // objects_b
            // 
            this.objects_b.Location = new System.Drawing.Point(15, 237);
            this.objects_b.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.objects_b.Name = "objects_b";
            this.objects_b.Size = new System.Drawing.Size(350, 37);
            this.objects_b.TabIndex = 3;
            this.objects_b.Text = "Objects";
            this.objects_b.UseVisualStyleBackColor = true;
            this.objects_b.Click += new System.EventHandler(this.objects_b_Click);
            // 
            // groups_b
            // 
            this.groups_b.Location = new System.Drawing.Point(14, 284);
            this.groups_b.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groups_b.Name = "groups_b";
            this.groups_b.Size = new System.Drawing.Size(351, 37);
            this.groups_b.TabIndex = 4;
            this.groups_b.Text = "Groups";
            this.groups_b.UseVisualStyleBackColor = true;
            this.groups_b.Click += new System.EventHandler(this.groups_b_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(15, 330);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(352, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Averages";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::esijg.Properties.Resources.CEITI;
            this.pictureBox1.Location = new System.Drawing.Point(15, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 382);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groups_b);
            this.Controls.Add(this.objects_b);
            this.Controls.Add(this.grades_b);
            this.Controls.Add(this.profs_b);
            this.Controls.Add(this.studs_b);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Main menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button studs_b;
        private System.Windows.Forms.Button profs_b;
        private System.Windows.Forms.Button grades_b;
        private System.Windows.Forms.Button objects_b;
        private System.Windows.Forms.Button groups_b;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

