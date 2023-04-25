
namespace TeaJournal
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.NotePanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TeaNotes = new System.Windows.Forms.RichTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TeaName = new System.Windows.Forms.RichTextBox();
            this.TeaBrewNotes = new System.Windows.Forms.RichTextBox();
            this.TeaBrewTime = new System.Windows.Forms.DateTimePicker();
            this.TeaBrewingName = new System.Windows.Forms.RichTextBox();
            this.buttonRemoveTea = new System.Windows.Forms.Button();
            this.addTea = new System.Windows.Forms.Button();
            this.TeaTypes = new System.Windows.Forms.ComboBox();
            this.TeaList = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonTimerStart = new System.Windows.Forms.Button();
            this.buttonTimerStop = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownSec = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMin = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.ListPanel = new System.Windows.Forms.Panel();
            this.NotePanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).BeginInit();
            this.ListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotePanel
            // 
            this.NotePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotePanel.AutoSize = true;
            this.NotePanel.Controls.Add(this.panel3);
            this.NotePanel.Controls.Add(this.panel4);
            this.NotePanel.Location = new System.Drawing.Point(247, 118);
            this.NotePanel.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.NotePanel.Name = "NotePanel";
            this.NotePanel.Size = new System.Drawing.Size(547, 328);
            this.NotePanel.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TeaNotes);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(547, 254);
            this.panel3.TabIndex = 3;
            // 
            // TeaNotes
            // 
            this.TeaNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(133)))), ((int)(((byte)(84)))));
            this.TeaNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TeaNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TeaNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.TeaNotes.Location = new System.Drawing.Point(0, 0);
            this.TeaNotes.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.TeaNotes.Name = "TeaNotes";
            this.TeaNotes.Size = new System.Drawing.Size(547, 254);
            this.TeaNotes.TabIndex = 7;
            this.TeaNotes.Text = "";
            this.TeaNotes.TextChanged += new System.EventHandler(this.ExtraNotes_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.TeaName);
            this.panel4.Controls.Add(this.TeaBrewNotes);
            this.panel4.Controls.Add(this.TeaBrewTime);
            this.panel4.Controls.Add(this.TeaBrewingName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(547, 74);
            this.panel4.TabIndex = 3;
            // 
            // TeaName
            // 
            this.TeaName.AccessibleName = "TeaName";
            this.TeaName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(131)))));
            this.TeaName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TeaName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.TeaName.Location = new System.Drawing.Point(0, 0);
            this.TeaName.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.TeaName.Multiline = false;
            this.TeaName.Name = "TeaName";
            this.TeaName.Size = new System.Drawing.Size(188, 31);
            this.TeaName.TabIndex = 3;
            this.TeaName.Text = "";
            this.TeaName.TextChanged += new System.EventHandler(this.TeaName_TextChanged);
            // 
            // TeaBrewNotes
            // 
            this.TeaBrewNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TeaBrewNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(137)))), ((int)(((byte)(104)))));
            this.TeaBrewNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TeaBrewNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.TeaBrewNotes.Location = new System.Drawing.Point(196, 0);
            this.TeaBrewNotes.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.TeaBrewNotes.Name = "TeaBrewNotes";
            this.TeaBrewNotes.Size = new System.Drawing.Size(351, 66);
            this.TeaBrewNotes.TabIndex = 6;
            this.TeaBrewNotes.Text = "";
            // 
            // TeaBrewTime
            // 
            this.TeaBrewTime.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(111)))), ((int)(((byte)(90)))));
            this.TeaBrewTime.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(111)))), ((int)(((byte)(90)))));
            this.TeaBrewTime.CustomFormat = "mm:ss";
            this.TeaBrewTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TeaBrewTime.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TeaBrewTime.Location = new System.Drawing.Point(0, 39);
            this.TeaBrewTime.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.TeaBrewTime.MinDate = new System.DateTime(1753, 1, 2, 0, 0, 0, 0);
            this.TeaBrewTime.Name = "TeaBrewTime";
            this.TeaBrewTime.ShowUpDown = true;
            this.TeaBrewTime.Size = new System.Drawing.Size(80, 27);
            this.TeaBrewTime.TabIndex = 4;
            this.TeaBrewTime.TabStop = false;
            this.TeaBrewTime.Value = new System.DateTime(2000, 1, 1, 13, 0, 0, 0);
            // 
            // TeaBrewingName
            // 
            this.TeaBrewingName.AccessibleName = "TeaBrewingType";
            this.TeaBrewingName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(137)))), ((int)(((byte)(104)))));
            this.TeaBrewingName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TeaBrewingName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.TeaBrewingName.Location = new System.Drawing.Point(84, 39);
            this.TeaBrewingName.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.TeaBrewingName.Multiline = false;
            this.TeaBrewingName.Name = "TeaBrewingName";
            this.TeaBrewingName.Size = new System.Drawing.Size(104, 27);
            this.TeaBrewingName.TabIndex = 5;
            this.TeaBrewingName.Text = "";
            // 
            // buttonRemoveTea
            // 
            this.buttonRemoveTea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonRemoveTea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(177)))), ((int)(((byte)(228)))));
            this.buttonRemoveTea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemoveTea.FlatAppearance.BorderSize = 0;
            this.buttonRemoveTea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveTea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.buttonRemoveTea.Location = new System.Drawing.Point(114, 28);
            this.buttonRemoveTea.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.buttonRemoveTea.Name = "buttonRemoveTea";
            this.buttonRemoveTea.Size = new System.Drawing.Size(115, 44);
            this.buttonRemoveTea.TabIndex = 9;
            this.buttonRemoveTea.Text = "Remove";
            this.buttonRemoveTea.UseVisualStyleBackColor = false;
            this.buttonRemoveTea.Click += new System.EventHandler(this.buttonRemoveTea_Click);
            // 
            // addTea
            // 
            this.addTea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addTea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(177)))), ((int)(((byte)(228)))));
            this.addTea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addTea.FlatAppearance.BorderSize = 0;
            this.addTea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.addTea.Location = new System.Drawing.Point(0, 28);
            this.addTea.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.addTea.Name = "addTea";
            this.addTea.Size = new System.Drawing.Size(115, 44);
            this.addTea.TabIndex = 8;
            this.addTea.Text = "Add";
            this.addTea.UseVisualStyleBackColor = false;
            this.addTea.Click += new System.EventHandler(this.addTea_Click);
            // 
            // TeaTypes
            // 
            this.TeaTypes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TeaTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(111)))), ((int)(((byte)(90)))));
            this.TeaTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TeaTypes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.TeaTypes.FormattingEnabled = true;
            this.TeaTypes.Items.AddRange(new object[] {
            "White",
            "Green",
            "Oolong",
            "Black",
            "Herbal",
            "Other"});
            this.TeaTypes.Location = new System.Drawing.Point(-1, 0);
            this.TeaTypes.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.TeaTypes.Name = "TeaTypes";
            this.TeaTypes.Size = new System.Drawing.Size(230, 28);
            this.TeaTypes.TabIndex = 2;
            this.TeaTypes.SelectedIndexChanged += new System.EventHandler(this.TeaType_Changed);
            // 
            // TeaList
            // 
            this.TeaList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(111)))), ((int)(((byte)(90)))));
            this.TeaList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TeaList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TeaList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.TeaList.FormattingEnabled = true;
            this.TeaList.ItemHeight = 20;
            this.TeaList.Location = new System.Drawing.Point(0, 74);
            this.TeaList.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.TeaList.Name = "TeaList";
            this.TeaList.Size = new System.Drawing.Size(230, 360);
            this.TeaList.TabIndex = 1;
            this.TeaList.SelectedIndexChanged += new System.EventHandler(this.TeaList_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(202)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.buttonTimerStart);
            this.panel2.Controls.Add(this.buttonTimerStop);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(247, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 98);
            this.panel2.TabIndex = 1;
            // 
            // buttonTimerStart
            // 
            this.buttonTimerStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(177)))), ((int)(((byte)(228)))));
            this.buttonTimerStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTimerStart.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonTimerStart.FlatAppearance.BorderSize = 0;
            this.buttonTimerStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimerStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.buttonTimerStart.Location = new System.Drawing.Point(0, 45);
            this.buttonTimerStart.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.buttonTimerStart.Name = "buttonTimerStart";
            this.buttonTimerStart.Size = new System.Drawing.Size(94, 53);
            this.buttonTimerStart.TabIndex = 4;
            this.buttonTimerStart.Text = "Start";
            this.buttonTimerStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTimerStart.UseVisualStyleBackColor = false;
            this.buttonTimerStart.Click += new System.EventHandler(this.buttonTimerStart_Click);
            // 
            // buttonTimerStop
            // 
            this.buttonTimerStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(177)))), ((int)(((byte)(228)))));
            this.buttonTimerStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTimerStop.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonTimerStop.FlatAppearance.BorderSize = 0;
            this.buttonTimerStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimerStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.buttonTimerStop.Location = new System.Drawing.Point(128, 45);
            this.buttonTimerStop.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.buttonTimerStop.Name = "buttonTimerStop";
            this.buttonTimerStop.Size = new System.Drawing.Size(94, 53);
            this.buttonTimerStop.TabIndex = 5;
            this.buttonTimerStop.Text = "Stop";
            this.buttonTimerStop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTimerStop.UseVisualStyleBackColor = false;
            this.buttonTimerStop.Click += new System.EventHandler(this.buttonTimerStop_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numericUpDownSec);
            this.panel1.Controls.Add(this.numericUpDownMin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 25);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(66, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "m";
            // 
            // numericUpDownSec
            // 
            this.numericUpDownSec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.numericUpDownSec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownSec.Dock = System.Windows.Forms.DockStyle.Right;
            this.numericUpDownSec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.numericUpDownSec.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownSec.Location = new System.Drawing.Point(147, 0);
            this.numericUpDownSec.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.numericUpDownSec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownSec.Name = "numericUpDownSec";
            this.numericUpDownSec.Size = new System.Drawing.Size(60, 23);
            this.numericUpDownSec.TabIndex = 3;
            // 
            // numericUpDownMin
            // 
            this.numericUpDownMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.numericUpDownMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownMin.Dock = System.Windows.Forms.DockStyle.Left;
            this.numericUpDownMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.numericUpDownMin.Location = new System.Drawing.Point(0, 0);
            this.numericUpDownMin.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.numericUpDownMin.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownMin.Name = "numericUpDownMin";
            this.numericUpDownMin.Size = new System.Drawing.Size(66, 23);
            this.numericUpDownMin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label2.Location = new System.Drawing.Point(207, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "s";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Timer";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ListPanel
            // 
            this.ListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListPanel.AutoSize = true;
            this.ListPanel.Controls.Add(this.buttonRemoveTea);
            this.ListPanel.Controls.Add(this.addTea);
            this.ListPanel.Controls.Add(this.TeaList);
            this.ListPanel.Controls.Add(this.TeaTypes);
            this.ListPanel.Location = new System.Drawing.Point(12, 12);
            this.ListPanel.Name = "ListPanel";
            this.ListPanel.Size = new System.Drawing.Size(230, 434);
            this.ListPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(198)))), ((int)(((byte)(145)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ListPanel);
            this.Controls.Add(this.NotePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "TeaJournal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.NotePanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).EndInit();
            this.ListPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel NotePanel;
        private System.Windows.Forms.RichTextBox TeaNotes;
        private System.Windows.Forms.ListBox TeaList;
        private System.Windows.Forms.ComboBox TeaTypes;
        private System.Windows.Forms.RichTextBox TeaBrewingName;
        private System.Windows.Forms.RichTextBox TeaName;
        private System.Windows.Forms.RichTextBox TeaBrewNotes;
        private System.Windows.Forms.DateTimePicker TeaBrewTime;
        private System.Windows.Forms.Button addTea;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonTimerStop;
        private System.Windows.Forms.Button buttonTimerStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownMin;
        private System.Windows.Forms.NumericUpDown numericUpDownSec;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buttonRemoveTea;
        private System.Windows.Forms.Panel ListPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}

