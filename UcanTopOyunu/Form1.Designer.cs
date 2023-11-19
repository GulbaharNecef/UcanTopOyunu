namespace UcanTopOyunu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ball = new Button();
            kontrol = new Button();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Lime;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(26, 436);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.BackColor = Color.Yellow;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(521, 26);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(632, 47);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 2;
            label3.Text = "3";
            // 
            // label4
            // 
            label4.BackColor = Color.Lime;
            label4.Location = new Point(507, 18);
            label4.Name = "label4";
            label4.Size = new Size(26, 436);
            label4.TabIndex = 3;
            // 
            // ball
            // 
            ball.BackColor = Color.Red;
            ball.Location = new Point(162, 122);
            ball.Name = "ball";
            ball.Size = new Size(20, 20);
            ball.TabIndex = 4;
            ball.UseVisualStyleBackColor = false;
            // 
            // kontrol
            // 
            kontrol.BackColor = Color.Cyan;
            kontrol.Location = new Point(256, 431);
            kontrol.Name = "kontrol";
            kontrol.Size = new Size(75, 23);
            kontrol.TabIndex = 5;
            kontrol.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(595, 44);
            button1.Name = "button1";
            button1.Size = new Size(20, 20);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 488);
            Controls.Add(button1);
            Controls.Add(kontrol);
            Controls.Add(ball);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            MouseMove += Form1_MouseMove;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button ball;
        private Button kontrol;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}