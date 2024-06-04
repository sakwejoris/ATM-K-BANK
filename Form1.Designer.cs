namespace ATMK_BANK
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
            landingpage = new Label();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // landingpage
            // 
            landingpage.AutoSize = true;
            landingpage.BorderStyle = BorderStyle.FixedSingle;
            landingpage.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            landingpage.Location = new Point(164, -2);
            landingpage.Name = "landingpage";
            landingpage.Size = new Size(411, 52);
            landingpage.TabIndex = 0;
            landingpage.Text = "WELCOME TO K BANK";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(283, 66);
            label1.Name = "label1";
            label1.Size = new Size(155, 17);
            label1.TabIndex = 1;
            label1.Text = "ARE YOU A CUSTOMER?";
            // 
            // button2
            // 
            button2.Location = new Point(309, 112);
            button2.Name = "button2";
            button2.Size = new Size(106, 39);
            button2.TabIndex = 3;
            button2.Text = "YES";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(309, 188);
            button3.Name = "button3";
            button3.Size = new Size(106, 39);
            button3.TabIndex = 4;
            button3.Text = "NO";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.istockphoto_1364101169_612x612;
            ClientSize = new Size(699, 414);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(landingpage);
            Controls.Add(button2);
            Name = "Form1";
            Text = ",.";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label landingpage;
        private Label label1;
        private Button button2;
        private Button button3;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}
