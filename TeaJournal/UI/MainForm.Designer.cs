
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TeaBrewTime = new System.Windows.Forms.DateTimePicker();
            this.TeaBrewNotes = new System.Windows.Forms.RichTextBox();
            this.TeaBrewingName = new System.Windows.Forms.RichTextBox();
            this.TeaName = new System.Windows.Forms.RichTextBox();
            this.TeaTypes = new System.Windows.Forms.ComboBox();
            this.TeaList = new System.Windows.Forms.ListBox();
            this.TeaNotes = new System.Windows.Forms.RichTextBox();
            this.FirstTab = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.addTea = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.TeaList.Items.AddRange(new object[] {
            "test1",
            "test2"});
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
            // FirstTab
            // 
            this.FirstTab.Location = new System.Drawing.Point(12, 12);
            this.FirstTab.Name = "FirstTab";
            this.FirstTab.Size = new System.Drawing.Size(106, 96);
            this.FirstTab.TabIndex = 1;
            this.FirstTab.Text = "Teas";
            this.FirstTab.UseVisualStyleBackColor = true;
            this.FirstTab.Click += new System.EventHandler(this.TeaTab_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(124, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 96);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(236, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 96);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.FirstTab);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button FirstTab;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox TeaNotes;
        private System.Windows.Forms.ListBox TeaList;
        private System.Windows.Forms.ComboBox TeaTypes;
        private System.Windows.Forms.RichTextBox TeaBrewingName;
        private System.Windows.Forms.RichTextBox TeaName;
        private System.Windows.Forms.RichTextBox TeaBrewNotes;
        private System.Windows.Forms.DateTimePicker TeaBrewTime;
        private System.Windows.Forms.Button addTea;
    }
}

