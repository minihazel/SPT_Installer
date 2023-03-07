namespace SPT_Installer
{
    partial class installerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(installerForm));
            this.watermarkPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.livePanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.liveList = new System.Windows.Forms.ListBox();
            this.liveFind = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sptPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sptList = new System.Windows.Forms.ListBox();
            this.sptFind = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.installPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.installer_premodded = new System.Windows.Forms.Button();
            this.installer_regular = new System.Windows.Forms.Button();
            this.onHover_premodded = new System.Windows.Forms.Panel();
            this.onHover_regular = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkFolders = new System.Windows.Forms.Timer(this.components);
            this.watermarkPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.livePanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.sptPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.installPanel.SuspendLayout();
            this.onHover_premodded.SuspendLayout();
            this.onHover_regular.SuspendLayout();
            this.SuspendLayout();
            // 
            // watermarkPanel
            // 
            this.watermarkPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.watermarkPanel.Controls.Add(this.label2);
            this.watermarkPanel.Controls.Add(this.pictureBox1);
            this.watermarkPanel.Controls.Add(this.label1);
            this.watermarkPanel.Font = new System.Drawing.Font("Bahnschrift", 18F);
            this.watermarkPanel.Location = new System.Drawing.Point(46, 41);
            this.watermarkPanel.Name = "watermarkPanel";
            this.watermarkPanel.Size = new System.Drawing.Size(372, 69);
            this.watermarkPanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(83, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Supports Escape From Tarkov 0.13.2.21743";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(123)))), ((int)(((byte)(137)))));
            this.label1.Location = new System.Drawing.Point(81, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "SPT-AKI Manual Installer";
            // 
            // livePanel
            // 
            this.livePanel.Controls.Add(this.label4);
            this.livePanel.Controls.Add(this.panel3);
            this.livePanel.Controls.Add(this.liveFind);
            this.livePanel.Controls.Add(this.label3);
            this.livePanel.Location = new System.Drawing.Point(464, 154);
            this.livePanel.Name = "livePanel";
            this.livePanel.Size = new System.Drawing.Size(427, 397);
            this.livePanel.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Light", 8F);
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(9, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Location:";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.liveList);
            this.panel3.Location = new System.Drawing.Point(12, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(412, 310);
            this.panel3.TabIndex = 4;
            // 
            // liveList
            // 
            this.liveList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.liveList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.liveList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.liveList.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.liveList.ForeColor = System.Drawing.Color.LightGray;
            this.liveList.FormattingEnabled = true;
            this.liveList.ItemHeight = 18;
            this.liveList.Location = new System.Drawing.Point(1, 3);
            this.liveList.Name = "liveList";
            this.liveList.Size = new System.Drawing.Size(408, 306);
            this.liveList.TabIndex = 0;
            // 
            // liveFind
            // 
            this.liveFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.liveFind.BackColor = System.Drawing.Color.DimGray;
            this.liveFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.liveFind.FlatAppearance.BorderSize = 0;
            this.liveFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.liveFind.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liveFind.ForeColor = System.Drawing.Color.LightGray;
            this.liveFind.Location = new System.Drawing.Point(334, 5);
            this.liveFind.Name = "liveFind";
            this.liveFind.Size = new System.Drawing.Size(90, 42);
            this.liveFind.TabIndex = 2;
            this.liveFind.Text = "Find";
            this.liveFind.UseVisualStyleBackColor = false;
            this.liveFind.Click += new System.EventHandler(this.liveFind_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(9, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Live folder";
            // 
            // sptPanel
            // 
            this.sptPanel.Controls.Add(this.label5);
            this.sptPanel.Controls.Add(this.panel2);
            this.sptPanel.Controls.Add(this.sptFind);
            this.sptPanel.Controls.Add(this.label6);
            this.sptPanel.Location = new System.Drawing.Point(46, 154);
            this.sptPanel.Name = "sptPanel";
            this.sptPanel.Size = new System.Drawing.Size(372, 397);
            this.sptPanel.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Light", 8F);
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(9, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Location:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.sptList);
            this.panel2.Location = new System.Drawing.Point(12, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 310);
            this.panel2.TabIndex = 4;
            // 
            // sptList
            // 
            this.sptList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sptList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.sptList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sptList.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.sptList.ForeColor = System.Drawing.Color.LightGray;
            this.sptList.FormattingEnabled = true;
            this.sptList.ItemHeight = 18;
            this.sptList.Location = new System.Drawing.Point(1, 3);
            this.sptList.Name = "sptList";
            this.sptList.Size = new System.Drawing.Size(353, 306);
            this.sptList.TabIndex = 1;
            // 
            // sptFind
            // 
            this.sptFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sptFind.BackColor = System.Drawing.Color.DimGray;
            this.sptFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sptFind.FlatAppearance.BorderSize = 0;
            this.sptFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sptFind.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sptFind.ForeColor = System.Drawing.Color.LightGray;
            this.sptFind.Location = new System.Drawing.Point(279, 5);
            this.sptFind.Name = "sptFind";
            this.sptFind.Size = new System.Drawing.Size(90, 42);
            this.sptFind.TabIndex = 2;
            this.sptFind.Text = "Find";
            this.sptFind.UseVisualStyleBackColor = false;
            this.sptFind.Click += new System.EventHandler(this.sptFind_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(9, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "New installation folder";
            // 
            // installPanel
            // 
            this.installPanel.Controls.Add(this.onHover_regular);
            this.installPanel.Controls.Add(this.onHover_premodded);
            this.installPanel.Controls.Add(this.panel4);
            this.installPanel.Controls.Add(this.installer_premodded);
            this.installPanel.Controls.Add(this.installer_regular);
            this.installPanel.Location = new System.Drawing.Point(464, 41);
            this.installPanel.Name = "installPanel";
            this.installPanel.Size = new System.Drawing.Size(427, 107);
            this.installPanel.TabIndex = 3;
            this.installPanel.Visible = false;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.label8.ForeColor = System.Drawing.Color.DarkGray;
            this.label8.Location = new System.Drawing.Point(3, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "RaidTimers mod";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(3, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Custom profile";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(213, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 42);
            this.panel4.TabIndex = 4;
            // 
            // installer_premodded
            // 
            this.installer_premodded.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.installer_premodded.BackColor = System.Drawing.Color.DodgerBlue;
            this.installer_premodded.Cursor = System.Windows.Forms.Cursors.Hand;
            this.installer_premodded.FlatAppearance.BorderSize = 0;
            this.installer_premodded.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.installer_premodded.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installer_premodded.ForeColor = System.Drawing.Color.Transparent;
            this.installer_premodded.Location = new System.Drawing.Point(5, 5);
            this.installer_premodded.Name = "installer_premodded";
            this.installer_premodded.Size = new System.Drawing.Size(200, 42);
            this.installer_premodded.TabIndex = 3;
            this.installer_premodded.Text = "Install pre-modded SPT";
            this.installer_premodded.UseVisualStyleBackColor = false;
            this.installer_premodded.MouseEnter += new System.EventHandler(this.button4_MouseEnter);
            this.installer_premodded.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            // 
            // installer_regular
            // 
            this.installer_regular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.installer_regular.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.installer_regular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.installer_regular.FlatAppearance.BorderSize = 0;
            this.installer_regular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.installer_regular.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installer_regular.ForeColor = System.Drawing.Color.Transparent;
            this.installer_regular.Location = new System.Drawing.Point(222, 5);
            this.installer_regular.Name = "installer_regular";
            this.installer_regular.Size = new System.Drawing.Size(200, 42);
            this.installer_regular.TabIndex = 2;
            this.installer_regular.Text = "Install SPT";
            this.installer_regular.UseVisualStyleBackColor = false;
            this.installer_regular.MouseEnter += new System.EventHandler(this.installer_regular_MouseEnter);
            this.installer_regular.MouseLeave += new System.EventHandler(this.installer_regular_MouseLeave);
            // 
            // onHover_premodded
            // 
            this.onHover_premodded.Controls.Add(this.label8);
            this.onHover_premodded.Controls.Add(this.label7);
            this.onHover_premodded.Location = new System.Drawing.Point(0, 53);
            this.onHover_premodded.Name = "onHover_premodded";
            this.onHover_premodded.Size = new System.Drawing.Size(203, 51);
            this.onHover_premodded.TabIndex = 5;
            this.onHover_premodded.Visible = false;
            // 
            // onHover_regular
            // 
            this.onHover_regular.Controls.Add(this.label9);
            this.onHover_regular.Controls.Add(this.label10);
            this.onHover_regular.Location = new System.Drawing.Point(224, 53);
            this.onHover_regular.Name = "onHover_regular";
            this.onHover_regular.Size = new System.Drawing.Size(203, 51);
            this.onHover_regular.TabIndex = 7;
            this.onHover_regular.Visible = false;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.label9.ForeColor = System.Drawing.Color.DarkGray;
            this.label9.Location = new System.Drawing.Point(3, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Plug and play";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.label10.ForeColor = System.Drawing.Color.DarkGray;
            this.label10.Location = new System.Drawing.Point(3, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(197, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "No downgrading";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // checkFolders
            // 
            this.checkFolders.Tick += new System.EventHandler(this.checkFolders_Tick);
            // 
            // installerForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(936, 573);
            this.Controls.Add(this.installPanel);
            this.Controls.Add(this.sptPanel);
            this.Controls.Add(this.livePanel);
            this.Controls.Add(this.watermarkPanel);
            this.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "installerForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.installerForm_FormClosing);
            this.Load += new System.EventHandler(this.installerForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.installerForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.installerForm_DragEnter);
            this.watermarkPanel.ResumeLayout(false);
            this.watermarkPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.livePanel.ResumeLayout(false);
            this.livePanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.sptPanel.ResumeLayout(false);
            this.sptPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.installPanel.ResumeLayout(false);
            this.onHover_premodded.ResumeLayout(false);
            this.onHover_regular.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel watermarkPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel livePanel;
        private System.Windows.Forms.Button liveFind;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel sptPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button sptFind;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox liveList;
        private System.Windows.Forms.ListBox sptList;
        private System.Windows.Forms.Panel installPanel;
        private System.Windows.Forms.Button installer_regular;
        private System.Windows.Forms.Button installer_premodded;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel onHover_premodded;
        private System.Windows.Forms.Panel onHover_regular;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer checkFolders;
    }
}

