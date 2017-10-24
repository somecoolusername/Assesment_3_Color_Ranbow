namespace ColorsSelection
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.alphaTextBox = new System.Windows.Forms.TextBox();
            this.blueTextBox = new System.Windows.Forms.TextBox();
            this.greenTextBox = new System.Windows.Forms.TextBox();
            this.redTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.colorSelectorButton = new System.Windows.Forms.Button();
            this.colorNameTextBox = new System.Windows.Forms.TextBox();
            this.htmlHexCodeTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorPictureBox = new System.Windows.Forms.PictureBox();
            this.exportJsonButton = new System.Windows.Forms.Button();
            this.colorsDataGridView = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.exportExternButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorsDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.alphaTextBox);
            this.groupBox1.Controls.Add(this.blueTextBox);
            this.groupBox1.Controls.Add(this.greenTextBox);
            this.groupBox1.Controls.Add(this.redTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(368, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(99, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RGB(A)";
            // 
            // alphaTextBox
            // 
            this.alphaTextBox.Location = new System.Drawing.Point(27, 96);
            this.alphaTextBox.Name = "alphaTextBox";
            this.alphaTextBox.ReadOnly = true;
            this.alphaTextBox.Size = new System.Drawing.Size(66, 20);
            this.alphaTextBox.TabIndex = 15;
            // 
            // blueTextBox
            // 
            this.blueTextBox.Location = new System.Drawing.Point(27, 70);
            this.blueTextBox.Name = "blueTextBox";
            this.blueTextBox.ReadOnly = true;
            this.blueTextBox.Size = new System.Drawing.Size(66, 20);
            this.blueTextBox.TabIndex = 14;
            // 
            // greenTextBox
            // 
            this.greenTextBox.Location = new System.Drawing.Point(27, 44);
            this.greenTextBox.Name = "greenTextBox";
            this.greenTextBox.ReadOnly = true;
            this.greenTextBox.Size = new System.Drawing.Size(66, 20);
            this.greenTextBox.TabIndex = 13;
            // 
            // redTextBox
            // 
            this.redTextBox.Location = new System.Drawing.Point(27, 19);
            this.redTextBox.Name = "redTextBox";
            this.redTextBox.ReadOnly = true;
            this.redTextBox.Size = new System.Drawing.Size(66, 20);
            this.redTextBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "G";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "R";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.colorSelectorButton);
            this.groupBox2.Controls.Add(this.colorNameTextBox);
            this.groupBox2.Controls.Add(this.htmlHexCodeTextBox);
            this.groupBox2.Location = new System.Drawing.Point(149, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 131);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Color Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "HTML Hex Code";
            // 
            // colorSelectorButton
            // 
            this.colorSelectorButton.Location = new System.Drawing.Point(114, 102);
            this.colorSelectorButton.Name = "colorSelectorButton";
            this.colorSelectorButton.Size = new System.Drawing.Size(93, 23);
            this.colorSelectorButton.TabIndex = 4;
            this.colorSelectorButton.Text = "Select Color";
            this.colorSelectorButton.UseVisualStyleBackColor = true;
            this.colorSelectorButton.Click += new System.EventHandler(this.colorSelectorButton_Click);
            // 
            // colorNameTextBox
            // 
            this.colorNameTextBox.Location = new System.Drawing.Point(100, 19);
            this.colorNameTextBox.Name = "colorNameTextBox";
            this.colorNameTextBox.ReadOnly = true;
            this.colorNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.colorNameTextBox.TabIndex = 1;
            // 
            // htmlHexCodeTextBox
            // 
            this.htmlHexCodeTextBox.Location = new System.Drawing.Point(100, 45);
            this.htmlHexCodeTextBox.Name = "htmlHexCodeTextBox";
            this.htmlHexCodeTextBox.ReadOnly = true;
            this.htmlHexCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.htmlHexCodeTextBox.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(483, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "(Ctrl + E) Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // colorPictureBox
            // 
            this.colorPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPictureBox.Location = new System.Drawing.Point(12, 28);
            this.colorPictureBox.Name = "colorPictureBox";
            this.colorPictureBox.Size = new System.Drawing.Size(131, 131);
            this.colorPictureBox.TabIndex = 3;
            this.colorPictureBox.TabStop = false;
            // 
            // exportJsonButton
            // 
            this.exportJsonButton.Enabled = false;
            this.exportJsonButton.Location = new System.Drawing.Point(349, 209);
            this.exportJsonButton.Name = "exportJsonButton";
            this.exportJsonButton.Size = new System.Drawing.Size(100, 23);
            this.exportJsonButton.TabIndex = 5;
            this.exportJsonButton.Text = "Export To Json";
            this.exportJsonButton.UseVisualStyleBackColor = true;
            this.exportJsonButton.Click += new System.EventHandler(this.exportJsonButton_Click);
            // 
            // colorsDataGridView
            // 
            this.colorsDataGridView.AllowUserToAddRows = false;
            this.colorsDataGridView.AllowUserToDeleteRows = false;
            this.colorsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.colorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.colorsDataGridView.Location = new System.Drawing.Point(6, 19);
            this.colorsDataGridView.Name = "colorsDataGridView";
            this.colorsDataGridView.ReadOnly = true;
            this.colorsDataGridView.Size = new System.Drawing.Size(443, 184);
            this.colorsDataGridView.TabIndex = 6;
            // 
            // addButton
            // 
            this.addButton.Enabled = false;
            this.addButton.Location = new System.Drawing.Point(6, 209);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Enabled = false;
            this.removeButton.Location = new System.Drawing.Point(87, 209);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 8;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.exportExternButton);
            this.groupBox3.Controls.Add(this.colorsDataGridView);
            this.groupBox3.Controls.Add(this.exportJsonButton);
            this.groupBox3.Controls.Add(this.addButton);
            this.groupBox3.Controls.Add(this.removeButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 165);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(455, 238);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datagrid";
            // 
            // exportExternButton
            // 
            this.exportExternButton.Enabled = false;
            this.exportExternButton.Location = new System.Drawing.Point(243, 209);
            this.exportExternButton.Name = "exportExternButton";
            this.exportExternButton.Size = new System.Drawing.Size(100, 23);
            this.exportExternButton.TabIndex = 9;
            this.exportExternButton.Text = "Export To Extern";
            this.exportExternButton.UseVisualStyleBackColor = true;
            this.exportExternButton.Click += new System.EventHandler(this.exportExternButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 415);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.colorPictureBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(499, 454);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorsDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox colorNameTextBox;
        private System.Windows.Forms.TextBox htmlHexCodeTextBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.PictureBox colorPictureBox;
        private System.Windows.Forms.Button colorSelectorButton;
        private System.Windows.Forms.Button exportJsonButton;
        private System.Windows.Forms.DataGridView colorsDataGridView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox alphaTextBox;
        private System.Windows.Forms.TextBox blueTextBox;
        private System.Windows.Forms.TextBox greenTextBox;
        private System.Windows.Forms.TextBox redTextBox;
        private System.Windows.Forms.Button exportExternButton;
    }
}

