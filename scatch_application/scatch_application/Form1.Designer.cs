namespace scatch_application
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
            this.panelBackground = new System.Windows.Forms.Panel();
            this.character = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.teleportButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rightButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textbox_right = new System.Windows.Forms.TextBox();
            this.textbox_left = new System.Windows.Forms.TextBox();
            this.textbox_down = new System.Windows.Forms.TextBox();
            this.textbox_up = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.character)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBackground.AutoSize = true;
            this.panelBackground.BackColor = System.Drawing.Color.LightGray;
            this.panelBackground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBackground.Controls.Add(this.character);
            this.panelBackground.Cursor = System.Windows.Forms.Cursors.No;
            this.panelBackground.Location = new System.Drawing.Point(374, 92);
            this.panelBackground.Margin = new System.Windows.Forms.Padding(3, 55, 25, 55);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(600, 600);
            this.panelBackground.TabIndex = 0;
            this.panelBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // character
            // 
            this.character.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.character.BackColor = System.Drawing.Color.Transparent;
            this.character.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.character.Image = ((System.Drawing.Image)(resources.GetObject("character.Image")));
            this.character.Location = new System.Drawing.Point(245, 237);
            this.character.Name = "character";
            this.character.Size = new System.Drawing.Size(100, 100);
            this.character.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.character.TabIndex = 0;
            this.character.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Actions";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.teleportButton);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.rightButton);
            this.panel3.Controls.Add(this.leftButton);
            this.panel3.Controls.Add(this.downButton);
            this.panel3.Controls.Add(this.upButton);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.textbox_right);
            this.panel3.Controls.Add(this.textbox_left);
            this.panel3.Controls.Add(this.textbox_down);
            this.panel3.Controls.Add(this.textbox_up);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Location = new System.Drawing.Point(31, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(314, 187);
            this.panel3.TabIndex = 16;
            // 
            // teleportButton
            // 
            this.teleportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.teleportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teleportButton.Location = new System.Drawing.Point(228, 145);
            this.teleportButton.Margin = new System.Windows.Forms.Padding(3, 3, 35, 3);
            this.teleportButton.Name = "teleportButton";
            this.teleportButton.Size = new System.Drawing.Size(47, 28);
            this.teleportButton.TabIndex = 17;
            this.teleportButton.Text = "GO";
            this.teleportButton.UseVisualStyleBackColor = true;
            this.teleportButton.Click += new System.EventHandler(this.teleportButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Teleport Randomly";
            // 
            // rightButton
            // 
            this.rightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightButton.Location = new System.Drawing.Point(228, 111);
            this.rightButton.Margin = new System.Windows.Forms.Padding(3, 3, 35, 3);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(47, 28);
            this.rightButton.TabIndex = 15;
            this.rightButton.Text = "GO";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // leftButton
            // 
            this.leftButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.leftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftButton.Location = new System.Drawing.Point(228, 77);
            this.leftButton.Margin = new System.Windows.Forms.Padding(3, 3, 35, 3);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(47, 28);
            this.leftButton.TabIndex = 14;
            this.leftButton.Text = "GO";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // downButton
            // 
            this.downButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.downButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downButton.Location = new System.Drawing.Point(228, 43);
            this.downButton.Margin = new System.Windows.Forms.Padding(3, 5, 35, 3);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(47, 28);
            this.downButton.TabIndex = 13;
            this.downButton.Text = "GO";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // upButton
            // 
            this.upButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.upButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upButton.Location = new System.Drawing.Point(228, 7);
            this.upButton.Margin = new System.Windows.Forms.Padding(3, 3, 35, 3);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(47, 28);
            this.upButton.TabIndex = 12;
            this.upButton.Text = "GO";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(146, 114);
            this.label10.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "right";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(146, 80);
            this.label11.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "left";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(146, 48);
            this.label12.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 20);
            this.label12.TabIndex = 9;
            this.label12.Text = "down";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(146, 10);
            this.label13.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 20);
            this.label13.TabIndex = 8;
            this.label13.Text = "up";
            // 
            // textbox_right
            // 
            this.textbox_right.Location = new System.Drawing.Point(65, 114);
            this.textbox_right.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.textbox_right.Name = "textbox_right";
            this.textbox_right.Size = new System.Drawing.Size(68, 20);
            this.textbox_right.TabIndex = 7;
            this.textbox_right.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_right_KeyPress);
            // 
            // textbox_left
            // 
            this.textbox_left.Location = new System.Drawing.Point(65, 80);
            this.textbox_left.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.textbox_left.Name = "textbox_left";
            this.textbox_left.Size = new System.Drawing.Size(68, 20);
            this.textbox_left.TabIndex = 6;
            this.textbox_left.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_left_KeyPress);
            // 
            // textbox_down
            // 
            this.textbox_down.Location = new System.Drawing.Point(65, 46);
            this.textbox_down.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.textbox_down.Name = "textbox_down";
            this.textbox_down.Size = new System.Drawing.Size(68, 20);
            this.textbox_down.TabIndex = 5;
            this.textbox_down.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_down_KeyPress);
            // 
            // textbox_up
            // 
            this.textbox_up.Location = new System.Drawing.Point(65, 10);
            this.textbox_up.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.textbox_up.Name = "textbox_up";
            this.textbox_up.Size = new System.Drawing.Size(68, 20);
            this.textbox_up.TabIndex = 4;
            this.textbox_up.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_up_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(10, 112);
            this.label14.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 20);
            this.label14.TabIndex = 3;
            this.label14.Text = "Move";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(10, 78);
            this.label15.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "Move";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(10, 46);
            this.label16.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 20);
            this.label16.TabIndex = 1;
            this.label16.Text = "Move";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(10, 12);
            this.label17.Margin = new System.Windows.Forms.Padding(10, 20, 3, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 20);
            this.label17.TabIndex = 0;
            this.label17.Text = "Move";
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.ItemHeight = 20;
            this.listBoxOutput.Location = new System.Drawing.Point(31, 344);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(314, 284);
            this.listBoxOutput.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 37);
            this.label2.TabIndex = 20;
            this.label2.Text = "History";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxOutput);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Group Soft Builder - Finals Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.character)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.PictureBox character;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textbox_right;
        private System.Windows.Forms.TextBox textbox_left;
        private System.Windows.Forms.TextBox textbox_down;
        private System.Windows.Forms.TextBox textbox_up;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListBox listBoxOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button teleportButton;
        private System.Windows.Forms.Label label3;
    }
}

