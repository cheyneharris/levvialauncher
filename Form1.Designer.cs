namespace LevviaLauncher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.problemButton = new System.Windows.Forms.Button();
            this.problemBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ema2Button = new System.Windows.Forms.Button();
            this.apa2Button = new System.Windows.Forms.Button();
            this.ema3Button = new System.Windows.Forms.Button();
            this.apa3Button = new System.Windows.Forms.Button();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.resetButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.snowButton = new System.Windows.Forms.Button();
            this.snowBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pbiButton = new System.Windows.Forms.Button();
            this.pbiBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.environmentBox = new System.Windows.Forms.ComboBox();
            this.launchButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.problemButton);
            this.panel1.Controls.Add(this.problemBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 43);
            this.panel1.TabIndex = 0;
            // 
            // problemButton
            // 
            this.problemButton.Location = new System.Drawing.Point(0, 19);
            this.problemButton.Name = "problemButton";
            this.problemButton.Size = new System.Drawing.Size(160, 23);
            this.problemButton.TabIndex = 2;
            this.problemButton.Text = "Empty";
            this.problemButton.UseVisualStyleBackColor = true;
            this.problemButton.Visible = false;
            this.problemButton.Click += new System.EventHandler(this.problemButton_Click_1);
            // 
            // problemBox
            // 
            this.problemBox.Location = new System.Drawing.Point(0, 19);
            this.problemBox.Name = "problemBox";
            this.problemBox.Size = new System.Drawing.Size(160, 22);
            this.problemBox.TabIndex = 1;
            this.problemBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Problem Ticket";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ema2Button
            // 
            this.ema2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ema2Button.Location = new System.Drawing.Point(3, 18);
            this.ema2Button.Name = "ema2Button";
            this.ema2Button.Size = new System.Drawing.Size(62, 23);
            this.ema2Button.TabIndex = 2;
            this.ema2Button.Text = "EMA v2";
            this.ema2Button.UseVisualStyleBackColor = true;
            this.ema2Button.Click += new System.EventHandler(this.ema2Button_Click);
            // 
            // apa2Button
            // 
            this.apa2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apa2Button.Location = new System.Drawing.Point(71, 18);
            this.apa2Button.Name = "apa2Button";
            this.apa2Button.Size = new System.Drawing.Size(62, 23);
            this.apa2Button.TabIndex = 3;
            this.apa2Button.Text = "APA v2";
            this.apa2Button.UseVisualStyleBackColor = true;
            this.apa2Button.Click += new System.EventHandler(this.apa2Button_Click);
            // 
            // ema3Button
            // 
            this.ema3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ema3Button.Location = new System.Drawing.Point(139, 18);
            this.ema3Button.Name = "ema3Button";
            this.ema3Button.Size = new System.Drawing.Size(62, 23);
            this.ema3Button.TabIndex = 4;
            this.ema3Button.Text = "EMA v3";
            this.ema3Button.UseVisualStyleBackColor = true;
            this.ema3Button.Click += new System.EventHandler(this.ema3Button_Click);
            // 
            // apa3Button
            // 
            this.apa3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apa3Button.Location = new System.Drawing.Point(207, 18);
            this.apa3Button.Name = "apa3Button";
            this.apa3Button.Size = new System.Drawing.Size(62, 23);
            this.apa3Button.TabIndex = 5;
            this.apa3Button.Text = "APA v3";
            this.apa3Button.UseVisualStyleBackColor = true;
            this.apa3Button.Click += new System.EventHandler(this.apa3Button_Click);
            // 
            // dashboardButton
            // 
            this.dashboardButton.Location = new System.Drawing.Point(519, 10);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Size = new System.Drawing.Size(149, 43);
            this.dashboardButton.TabIndex = 8;
            this.dashboardButton.Text = "SA ADO Dashboard";
            this.dashboardButton.UseVisualStyleBackColor = true;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "App Insights";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.resetButton);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.ema2Button);
            this.panel4.Controls.Add(this.apa2Button);
            this.panel4.Controls.Add(this.apa3Button);
            this.panel4.Controls.Add(this.ema3Button);
            this.panel4.Location = new System.Drawing.Point(859, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(405, 43);
            this.panel4.TabIndex = 14;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Crimson;
            this.resetButton.ForeColor = System.Drawing.SystemColors.Control;
            this.resetButton.Location = new System.Drawing.Point(291, 4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 36);
            this.resetButton.TabIndex = 12;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.snowButton);
            this.panel2.Controls.Add(this.snowBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(181, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 43);
            this.panel2.TabIndex = 15;
            // 
            // snowButton
            // 
            this.snowButton.Location = new System.Drawing.Point(0, 18);
            this.snowButton.Name = "snowButton";
            this.snowButton.Size = new System.Drawing.Size(160, 23);
            this.snowButton.TabIndex = 3;
            this.snowButton.Text = "Empty";
            this.snowButton.UseVisualStyleBackColor = true;
            this.snowButton.Visible = false;
            this.snowButton.Click += new System.EventHandler(this.snowButton_Click_1);
            // 
            // snowBox
            // 
            this.snowBox.Location = new System.Drawing.Point(0, 19);
            this.snowBox.Name = "snowBox";
            this.snowBox.Size = new System.Drawing.Size(160, 22);
            this.snowBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "SNOW Incident";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pbiButton);
            this.panel5.Controls.Add(this.pbiBox);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(350, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(163, 43);
            this.panel5.TabIndex = 16;
            // 
            // pbiButton
            // 
            this.pbiButton.Location = new System.Drawing.Point(0, 18);
            this.pbiButton.Name = "pbiButton";
            this.pbiButton.Size = new System.Drawing.Size(160, 23);
            this.pbiButton.TabIndex = 3;
            this.pbiButton.Text = "Empty";
            this.pbiButton.UseVisualStyleBackColor = true;
            this.pbiButton.Visible = false;
            this.pbiButton.Click += new System.EventHandler(this.pbiButton_Click_1);
            // 
            // pbiBox
            // 
            this.pbiBox.Location = new System.Drawing.Point(0, 19);
            this.pbiBox.Name = "pbiBox";
            this.pbiBox.Size = new System.Drawing.Size(160, 22);
            this.pbiBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "PBI";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.environmentBox);
            this.panel3.Controls.Add(this.launchButton);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(674, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(182, 43);
            this.panel3.TabIndex = 17;
            // 
            // environmentBox
            // 
            this.environmentBox.FormattingEnabled = true;
            this.environmentBox.Location = new System.Drawing.Point(3, 18);
            this.environmentBox.Name = "environmentBox";
            this.environmentBox.Size = new System.Drawing.Size(128, 24);
            this.environmentBox.TabIndex = 3;
            this.environmentBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // launchButton
            // 
            this.launchButton.Image = ((System.Drawing.Image)(resources.GetObject("launchButton.Image")));
            this.launchButton.Location = new System.Drawing.Point(137, -1);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(42, 41);
            this.launchButton.TabIndex = 2;
            this.launchButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Levvia Environments";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 56);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dashboardButton);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Levvia Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox problemBox;
        private System.Windows.Forms.Button ema2Button;
        private System.Windows.Forms.Button apa2Button;
        private System.Windows.Forms.Button ema3Button;
        private System.Windows.Forms.Button apa3Button;
        private System.Windows.Forms.Button dashboardButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox snowBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox pbiBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button launchButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox environmentBox;
        private System.Windows.Forms.Button problemButton;
        private System.Windows.Forms.Button snowButton;
        private System.Windows.Forms.Button pbiButton;
        private System.Windows.Forms.Button resetButton;
    }
}

