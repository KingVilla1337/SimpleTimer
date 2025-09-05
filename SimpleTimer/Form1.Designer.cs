namespace SimpleTimer
{
    partial class StopWatch
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
            timer1 = new System.Windows.Forms.Timer(components);
            btnStart = new Button();
            btnReset = new Button();
            btnStop = new Button();
            lstLabs = new ListView();
            btnLab = new Button();
            btnListClear = new Button();
            lblTime = new MaterialSkin.Controls.MaterialLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // btnStart
            // 
            btnStart.Dock = DockStyle.Fill;
            btnStart.Location = new Point(6, 6);
            btnStart.Margin = new Padding(6);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(73, 26);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnReset
            // 
            btnReset.Dock = DockStyle.Fill;
            btnReset.Location = new Point(91, 44);
            btnReset.Margin = new Padding(6);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(74, 27);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnStop
            // 
            btnStop.Dock = DockStyle.Fill;
            btnStop.Location = new Point(6, 44);
            btnStop.Margin = new Padding(6);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(73, 27);
            btnStop.TabIndex = 3;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // lstLabs
            // 
            lstLabs.BackColor = SystemColors.Menu;
            lstLabs.Location = new Point(189, 92);
            lstLabs.Name = "lstLabs";
            lstLabs.Size = new Size(485, 184);
            lstLabs.TabIndex = 4;
            lstLabs.UseCompatibleStateImageBehavior = false;
            lstLabs.SelectedIndexChanged += lstLabs_SelectedIndexChanged;
            // 
            // btnLab
            // 
            btnLab.Dock = DockStyle.Fill;
            btnLab.Location = new Point(91, 6);
            btnLab.Margin = new Padding(6);
            btnLab.Name = "btnLab";
            btnLab.Size = new Size(74, 26);
            btnLab.TabIndex = 5;
            btnLab.Text = "Runde";
            btnLab.UseVisualStyleBackColor = true;
            btnLab.Click += btnLab_Click;
            // 
            // btnListClear
            // 
            btnListClear.Location = new Point(9, 454);
            btnListClear.Margin = new Padding(6);
            btnListClear.Name = "btnListClear";
            btnListClear.Size = new Size(105, 27);
            btnListClear.TabIndex = 2;
            btnListClear.Text = "Liste leeren";
            btnListClear.UseVisualStyleBackColor = true;
            btnListClear.Click += btnListClear_Click;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Depth = 0;
            lblTime.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTime.Location = new Point(353, 70);
            lblTime.MouseState = MaterialSkin.MouseState.HOVER;
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(63, 19);
            lblTime.TabIndex = 7;
            lblTime.Text = "00:00:00";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnStart, 0, 0);
            tableLayoutPanel1.Controls.Add(btnLab, 1, 0);
            tableLayoutPanel1.Controls.Add(btnStop, 0, 1);
            tableLayoutPanel1.Controls.Add(btnReset, 1, 1);
            tableLayoutPanel1.Location = new Point(12, 92);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(171, 77);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // StopWatch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 490);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(lblTime);
            Controls.Add(btnListClear);
            Controls.Add(lstLabs);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StopWatch";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Timer";
            Load += StopWatch_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Button btnStart;
        private Button btnReset;
        private Button btnStop;
        private ListView lstLabs;
        private Button btnLab;
        private Button btnListClear;
        private MaterialSkin.Controls.MaterialLabel lblTime;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
