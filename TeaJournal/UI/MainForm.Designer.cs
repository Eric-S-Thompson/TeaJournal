
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.addTea = new System.Windows.Forms.Button();
            this.TeaBrewTime = new System.Windows.Forms.DateTimePicker();
            this.TeaBrewNotes = new System.Windows.Forms.RichTextBox();
            this.TeaBrewingName = new System.Windows.Forms.RichTextBox();
            this.TeaName = new System.Windows.Forms.RichTextBox();
            this.TeaTypes = new System.Windows.Forms.ComboBox();
            this.TeaList = new System.Windows.Forms.ListBox();
            this.TeaNotes = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericUpDownSec = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownMin = new System.Windows.Forms.NumericUpDown();
            this.buttonTimerStop = new System.Windows.Forms.Button();
            this.buttonTimerStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addTea);
            this.panel1.Controls.Add(this.TeaBrewTime);
            this.panel1.Controls.Add(this.TeaBrewNotes);
            this.panel1.Controls.Add(this.TeaBrewingName);
            this.panel1.Controls.Add(this.TeaName);
            this.panel1.Controls.Add(this.TeaTypes);
            this.panel1.Controls.Add(this.TeaList);
            this.panel1.Controls.Add(this.TeaNotes);
            this.panel1.Location = new System.Drawing.Point(12, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 324);
            this.panel1.TabIndex = 0;
            // 
            // addTea
            // 
            this.addTea.Location = new System.Drawing.Point(224, -1);
            this.addTea.Name = "addTea";
            this.addTea.Size = new System.Drawing.Size(94, 29);
            this.addTea.TabIndex = 8;
            this.addTea.Text = "Add";
            this.addTea.UseVisualStyleBackColor = true;
            this.addTea.Click += new System.EventHandler(this.addTea_Click);
            // 
            // TeaBrewTime
            // 
            this.TeaBrewTime.CustomFormat = "mm:ss";
            this.TeaBrewTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TeaBrewTime.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TeaBrewTime.Location = new System.Drawing.Point(446, 35);
            this.TeaBrewTime.MinDate = new System.DateTime(1753, 1, 2, 0, 0, 0, 0);
            this.TeaBrewTime.Name = "TeaBrewTime";
            this.TeaBrewTime.ShowUpDown = true;
            this.TeaBrewTime.Size = new System.Drawing.Size(65, 27);
            this.TeaBrewTime.TabIndex = 4;
            this.TeaBrewTime.TabStop = false;
            this.TeaBrewTime.Value = new System.DateTime(2000, 1, 1, 13, 0, 0, 0);
            // 
            // TeaBrewNotes
            // 
            this.TeaBrewNotes.Location = new System.Drawing.Point(446, 70);
            this.TeaBrewNotes.Name = "TeaBrewNotes";
            this.TeaBrewNotes.Size = new System.Drawing.Size(330, 111);
            this.TeaBrewNotes.TabIndex = 6;
            this.TeaBrewNotes.Text = "";
            // 
            // TeaBrewingName
            // 
            this.TeaBrewingName.AccessibleName = "TeaBrewingType";
            this.TeaBrewingName.Location = new System.Drawing.Point(611, 35);
            this.TeaBrewingName.Name = "TeaBrewingName";
            this.TeaBrewingName.Size = new System.Drawing.Size(165, 29);
            this.TeaBrewingName.TabIndex = 5;
            this.TeaBrewingName.Text = "";
            // 
            // TeaName
            // 
            this.TeaName.AccessibleName = "TeaName";
            this.TeaName.Location = new System.Drawing.Point(446, 0);
            this.TeaName.Name = "TeaName";
            this.TeaName.Size = new System.Drawing.Size(330, 29);
            this.TeaName.TabIndex = 3;
            this.TeaName.Text = "";
            this.TeaName.TextChanged += new System.EventHandler(this.TeaName_TextChanged);
            // 
            // TeaTypes
            // 
            this.TeaTypes.FormattingEnabled = true;
            this.TeaTypes.Items.AddRange(new object[] {
            "White",
            "Green",
            "Oolong",
            "Black",
            "Herbal",
            "Other"});
            this.TeaTypes.Location = new System.Drawing.Point(1, 1);
            this.TeaTypes.Name = "TeaTypes";
            this.TeaTypes.Size = new System.Drawing.Size(217, 28);
            this.TeaTypes.TabIndex = 2;
            this.TeaTypes.SelectedIndexChanged += new System.EventHandler(this.TeaType_Changed);
            // 
            // TeaList
            // 
            this.TeaList.FormattingEnabled = true;
            this.TeaList.ItemHeight = 20;
            this.TeaList.Location = new System.Drawing.Point(0, 40);
            this.TeaList.Name = "TeaList";
            this.TeaList.Size = new System.Drawing.Size(218, 284);
            this.TeaList.TabIndex = 1;
            this.TeaList.SelectedIndexChanged += new System.EventHandler(this.TeaList_SelectedIndexChanged);
            // 
            // TeaNotes
            // 
            this.TeaNotes.Location = new System.Drawing.Point(446, 183);
            this.TeaNotes.Name = "TeaNotes";
            this.TeaNotes.Size = new System.Drawing.Size(330, 141);
            this.TeaNotes.TabIndex = 7;
            this.TeaNotes.Text = "";
            this.TeaNotes.TextChanged += new System.EventHandler(this.ExtraNotes_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numericUpDownSec);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.numericUpDownMin);
            this.panel2.Controls.Add(this.buttonTimerStop);
            this.panel2.Controls.Add(this.buttonTimerStart);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(597, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 96);
            this.panel2.TabIndex = 1;
            // 
            // numericUpDownSec
            // 
            this.numericUpDownSec.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownSec.Location = new System.Drawing.Point(99, 32);
            this.numericUpDownSec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownSec.Name = "numericUpDownSec";
            this.numericUpDownSec.Size = new System.Drawing.Size(65, 27);
            this.numericUpDownSec.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Timer";
            // 
            // numericUpDownMin
            // 
            this.numericUpDownMin.Location = new System.Drawing.Point(0, 32);
            this.numericUpDownMin.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownMin.Name = "numericUpDownMin";
            this.numericUpDownMin.Size = new System.Drawing.Size(65, 27);
            this.numericUpDownMin.TabIndex = 2;
            // 
            // buttonTimerStop
            // 
            this.buttonTimerStop.Location = new System.Drawing.Point(99, 64);
            this.buttonTimerStop.Name = "buttonTimerStop";
            this.buttonTimerStop.Size = new System.Drawing.Size(86, 29);
            this.buttonTimerStop.TabIndex = 5;
            this.buttonTimerStop.Text = "Stop";
            this.buttonTimerStop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTimerStop.UseVisualStyleBackColor = true;
            this.buttonTimerStop.Click += new System.EventHandler(this.buttonTimerStop_Click);
            // 
            // buttonTimerStart
            // 
            this.buttonTimerStart.Location = new System.Drawing.Point(0, 66);
            this.buttonTimerStart.Name = "buttonTimerStart";
            this.buttonTimerStart.Size = new System.Drawing.Size(93, 29);
            this.buttonTimerStart.TabIndex = 4;
            this.buttonTimerStart.Text = "Start";
            this.buttonTimerStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTimerStart.UseVisualStyleBackColor = true;
            this.buttonTimerStart.Click += new System.EventHandler(this.buttonTimerStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "s";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "m";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
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
    }
}

