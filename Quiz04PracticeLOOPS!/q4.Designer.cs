namespace Quiz04PracticeLOOPS_
{
    partial class q4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(q4));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.q4;
            pictureBox1.Location = new Point(71, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 103);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Location = new Point(43, 20);
            label1.Name = "label1";
            label1.Size = new Size(285, 49);
            label1.TabIndex = 1;
            label1.Text = "Use nested loops to print a 5×5 grid showing coordinates:";
            // 
            // label2
            // 
            label2.Location = new Point(110, 190);
            label2.Name = "label2";
            label2.Size = new Size(79, 27);
            label2.TabIndex = 2;
            label2.Text = "2 marks";
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(264, 172);
            button1.Name = "button1";
            button1.Size = new Size(75, 72);
            button1.TabIndex = 3;
            button1.Text = "Return to Quiz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // q4
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(351, 256);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaption;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "q4";
            Text = "ICS3U Question 04";
            Load += q4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}