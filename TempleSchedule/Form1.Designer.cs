namespace TempleSchedule {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.button1 = new System.Windows.Forms.Button();
			this.labelNumWards = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.button2 = new System.Windows.Forms.Button();
			this.labelNumTimes = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this.button3 = new System.Windows.Forms.Button();
			this.labelNumBlackoutDates = new System.Windows.Forms.Label();
			this.makeScheduleButton = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnInterval = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnWeekday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnWeekdaysNeeded = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnSaturday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnSaturdaysNeeded = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnTotalNeeded = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.numericUpDownWeekends = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.numericUpDownWeekdays = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.groupBox1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.flowLayoutPanel3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.flowLayoutPanel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeekends)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeekdays)).BeginInit();
			this.groupBox5.SuspendLayout();
			this.flowLayoutPanel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.flowLayoutPanel1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(481, 55);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Wards";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.button1);
			this.flowLayoutPanel1.Controls.Add(this.labelNumWards);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(475, 36);
			this.flowLayoutPanel1.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(3, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Choose";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.loadWards);
			// 
			// labelNumWards
			// 
			this.labelNumWards.AutoSize = true;
			this.labelNumWards.Location = new System.Drawing.Point(84, 8);
			this.labelNumWards.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
			this.labelNumWards.Name = "labelNumWards";
			this.labelNumWards.Size = new System.Drawing.Size(52, 13);
			this.labelNumWards.TabIndex = 2;
			this.labelNumWards.Text = "0 Loaded";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.flowLayoutPanel2);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox2.Location = new System.Drawing.Point(0, 55);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(481, 55);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Times";
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Controls.Add(this.button2);
			this.flowLayoutPanel2.Controls.Add(this.labelNumTimes);
			this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 16);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(475, 36);
			this.flowLayoutPanel2.TabIndex = 1;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(3, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Choose";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// labelNumTimes
			// 
			this.labelNumTimes.AutoSize = true;
			this.labelNumTimes.Location = new System.Drawing.Point(84, 8);
			this.labelNumTimes.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
			this.labelNumTimes.Name = "labelNumTimes";
			this.labelNumTimes.Size = new System.Drawing.Size(52, 13);
			this.labelNumTimes.TabIndex = 3;
			this.labelNumTimes.Text = "0 Loaded";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.flowLayoutPanel3);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox3.Location = new System.Drawing.Point(0, 110);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(481, 55);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Blackout Dates";
			// 
			// flowLayoutPanel3
			// 
			this.flowLayoutPanel3.Controls.Add(this.button3);
			this.flowLayoutPanel3.Controls.Add(this.labelNumBlackoutDates);
			this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 16);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			this.flowLayoutPanel3.Size = new System.Drawing.Size(475, 36);
			this.flowLayoutPanel3.TabIndex = 1;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(3, 3);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 1;
			this.button3.Text = "Choose";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.loadBlackoutDates);
			// 
			// labelNumBlackoutDates
			// 
			this.labelNumBlackoutDates.AutoSize = true;
			this.labelNumBlackoutDates.Location = new System.Drawing.Point(84, 8);
			this.labelNumBlackoutDates.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
			this.labelNumBlackoutDates.Name = "labelNumBlackoutDates";
			this.labelNumBlackoutDates.Size = new System.Drawing.Size(52, 13);
			this.labelNumBlackoutDates.TabIndex = 2;
			this.labelNumBlackoutDates.Text = "0 Loaded";
			// 
			// makeScheduleButton
			// 
			this.makeScheduleButton.BackColor = System.Drawing.SystemColors.Control;
			this.makeScheduleButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.makeScheduleButton.Location = new System.Drawing.Point(0, 446);
			this.makeScheduleButton.Name = "makeScheduleButton";
			this.makeScheduleButton.Size = new System.Drawing.Size(481, 31);
			this.makeScheduleButton.TabIndex = 4;
			this.makeScheduleButton.Text = "Make a Schedule";
			this.makeScheduleButton.UseVisualStyleBackColor = false;
			this.makeScheduleButton.Click += new System.EventHandler(this.makeScheduleButton_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.listView1);
			this.groupBox4.Controls.Add(this.flowLayoutPanel4);
			this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox4.Location = new System.Drawing.Point(0, 165);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(481, 244);
			this.groupBox4.TabIndex = 5;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Options";
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnInterval,
            this.columnWeekday,
            this.columnWeekdaysNeeded,
            this.columnSaturday,
            this.columnSaturdaysNeeded,
            this.columnTotal,
            this.columnTotalNeeded});
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.GridLines = true;
			this.listView1.Location = new System.Drawing.Point(3, 52);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.ShowGroups = false;
			this.listView1.Size = new System.Drawing.Size(475, 189);
			this.listView1.TabIndex = 2;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnInterval
			// 
			this.columnInterval.Text = "Interval";
			this.columnInterval.Width = 97;
			// 
			// columnWeekday
			// 
			this.columnWeekday.Text = "Weekdays";
			this.columnWeekday.Width = 66;
			// 
			// columnWeekdaysNeeded
			// 
			this.columnWeekdaysNeeded.Text = "Needed";
			// 
			// columnSaturday
			// 
			this.columnSaturday.Text = "Saturdays";
			this.columnSaturday.Width = 65;
			// 
			// columnSaturdaysNeeded
			// 
			this.columnSaturdaysNeeded.Text = "Needed";
			// 
			// columnTotal
			// 
			this.columnTotal.Text = "Total";
			// 
			// columnTotalNeeded
			// 
			this.columnTotalNeeded.Text = "Needed";
			// 
			// flowLayoutPanel4
			// 
			this.flowLayoutPanel4.Controls.Add(this.numericUpDown1);
			this.flowLayoutPanel4.Controls.Add(this.label1);
			this.flowLayoutPanel4.Controls.Add(this.numericUpDownWeekends);
			this.flowLayoutPanel4.Controls.Add(this.label2);
			this.flowLayoutPanel4.Controls.Add(this.numericUpDownWeekdays);
			this.flowLayoutPanel4.Controls.Add(this.label3);
			this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 16);
			this.flowLayoutPanel4.Name = "flowLayoutPanel4";
			this.flowLayoutPanel4.Size = new System.Drawing.Size(475, 36);
			this.flowLayoutPanel4.TabIndex = 1;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(3, 3);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(31, 20);
			this.numericUpDown1.TabIndex = 0;
			this.numericUpDown1.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(37, 6);
			this.label1.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Parts of Year";
			// 
			// numericUpDownWeekends
			// 
			this.numericUpDownWeekends.Location = new System.Drawing.Point(108, 3);
			this.numericUpDownWeekends.Name = "numericUpDownWeekends";
			this.numericUpDownWeekends.Size = new System.Drawing.Size(31, 20);
			this.numericUpDownWeekends.TabIndex = 2;
			this.numericUpDownWeekends.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.numericUpDownWeekends.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(142, 6);
			this.label2.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Saturdays";
			// 
			// numericUpDownWeekdays
			// 
			this.numericUpDownWeekdays.Location = new System.Drawing.Point(199, 3);
			this.numericUpDownWeekdays.Name = "numericUpDownWeekdays";
			this.numericUpDownWeekdays.Size = new System.Drawing.Size(31, 20);
			this.numericUpDownWeekdays.TabIndex = 4;
			this.numericUpDownWeekdays.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
			this.numericUpDownWeekdays.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(233, 6);
			this.label3.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Weekdays";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.flowLayoutPanel5);
			this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox5.Location = new System.Drawing.Point(0, 409);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(481, 37);
			this.groupBox5.TabIndex = 6;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Results";
			// 
			// flowLayoutPanel5
			// 
			this.flowLayoutPanel5.Controls.Add(this.linkLabel1);
			this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 16);
			this.flowLayoutPanel5.Name = "flowLayoutPanel5";
			this.flowLayoutPanel5.Size = new System.Drawing.Size(475, 18);
			this.flowLayoutPanel5.TabIndex = 1;
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Enabled = false;
			this.linkLabel1.Location = new System.Drawing.Point(3, 0);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(78, 13);
			this.linkLabel1.TabIndex = 0;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "View Schedule";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(481, 477);
			this.Controls.Add(this.makeScheduleButton);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Temple Schedule Generator";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.flowLayoutPanel3.ResumeLayout(false);
			this.flowLayoutPanel3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.flowLayoutPanel4.ResumeLayout(false);
			this.flowLayoutPanel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeekends)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeekdays)).EndInit();
			this.groupBox5.ResumeLayout(false);
			this.flowLayoutPanel5.ResumeLayout(false);
			this.flowLayoutPanel5.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button makeScheduleButton;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.NumericUpDown numericUpDownWeekends;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numericUpDownWeekdays;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Label labelNumWards;
		private System.Windows.Forms.Label labelNumBlackoutDates;
		private System.Windows.Forms.Label labelNumTimes;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnInterval;
		private System.Windows.Forms.ColumnHeader columnWeekday;
		private System.Windows.Forms.ColumnHeader columnSaturday;
		private System.Windows.Forms.ColumnHeader columnTotal;
		private System.Windows.Forms.ColumnHeader columnWeekdaysNeeded;
		private System.Windows.Forms.ColumnHeader columnSaturdaysNeeded;
		private System.Windows.Forms.ColumnHeader columnTotalNeeded;
	}
}

