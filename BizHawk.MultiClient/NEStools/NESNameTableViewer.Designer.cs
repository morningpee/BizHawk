﻿namespace BizHawk.MultiClient
{
	partial class NESNameTableViewer
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.autoloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveWindowPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.txtScanline = new System.Windows.Forms.TextBox();
			this.rbNametableNW = new System.Windows.Forms.RadioButton();
			this.rbNametableNE = new System.Windows.Forms.RadioButton();
			this.rbNametableSW = new System.Windows.Forms.RadioButton();
			this.rbNametableSE = new System.Windows.Forms.RadioButton();
			this.rbNametableAll = new System.Windows.Forms.RadioButton();
			this.NameTableView = new BizHawk.MultiClient.NameTableViewer();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.TileIDLabel = new System.Windows.Forms.Label();
			this.XYLabel = new System.Windows.Forms.Label();
			this.PPUAddressLabel = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.NameTableView);
			this.groupBox1.Location = new System.Drawing.Point(12, 36);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(545, 513);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(668, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoloadToolStripMenuItem,
            this.saveWindowPositionToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
			this.optionsToolStripMenuItem.Text = "&Options";
			this.optionsToolStripMenuItem.DropDownOpened += new System.EventHandler(this.optionsToolStripMenuItem_DropDownOpened);
			// 
			// autoloadToolStripMenuItem
			// 
			this.autoloadToolStripMenuItem.Name = "autoloadToolStripMenuItem";
			this.autoloadToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.autoloadToolStripMenuItem.Text = "Auto-load";
			this.autoloadToolStripMenuItem.Click += new System.EventHandler(this.autoloadToolStripMenuItem_Click);
			// 
			// saveWindowPositionToolStripMenuItem
			// 
			this.saveWindowPositionToolStripMenuItem.Name = "saveWindowPositionToolStripMenuItem";
			this.saveWindowPositionToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.saveWindowPositionToolStripMenuItem.Text = "Save Window Position";
			this.saveWindowPositionToolStripMenuItem.Click += new System.EventHandler(this.saveWindowPositionToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// txtScanline
			// 
			this.txtScanline.Location = new System.Drawing.Point(4, 19);
			this.txtScanline.Name = "txtScanline";
			this.txtScanline.Size = new System.Drawing.Size(60, 20);
			this.txtScanline.TabIndex = 2;
			this.txtScanline.Text = "0";
			this.txtScanline.TextChanged += new System.EventHandler(this.txtScanline_TextChanged);
			// 
			// rbNametableNW
			// 
			this.rbNametableNW.AutoSize = true;
			this.rbNametableNW.Location = new System.Drawing.Point(6, 19);
			this.rbNametableNW.Name = "rbNametableNW";
			this.rbNametableNW.Size = new System.Drawing.Size(14, 13);
			this.rbNametableNW.TabIndex = 4;
			this.rbNametableNW.UseVisualStyleBackColor = true;
			this.rbNametableNW.CheckedChanged += new System.EventHandler(this.rbNametable_CheckedChanged);
			// 
			// rbNametableNE
			// 
			this.rbNametableNE.AutoSize = true;
			this.rbNametableNE.Location = new System.Drawing.Point(56, 19);
			this.rbNametableNE.Name = "rbNametableNE";
			this.rbNametableNE.Size = new System.Drawing.Size(14, 13);
			this.rbNametableNE.TabIndex = 5;
			this.rbNametableNE.UseVisualStyleBackColor = true;
			this.rbNametableNE.CheckedChanged += new System.EventHandler(this.rbNametable_CheckedChanged);
			// 
			// rbNametableSW
			// 
			this.rbNametableSW.AutoSize = true;
			this.rbNametableSW.Location = new System.Drawing.Point(6, 57);
			this.rbNametableSW.Name = "rbNametableSW";
			this.rbNametableSW.Size = new System.Drawing.Size(14, 13);
			this.rbNametableSW.TabIndex = 6;
			this.rbNametableSW.UseVisualStyleBackColor = true;
			this.rbNametableSW.CheckedChanged += new System.EventHandler(this.rbNametable_CheckedChanged);
			// 
			// rbNametableSE
			// 
			this.rbNametableSE.AutoSize = true;
			this.rbNametableSE.Location = new System.Drawing.Point(56, 57);
			this.rbNametableSE.Name = "rbNametableSE";
			this.rbNametableSE.Size = new System.Drawing.Size(14, 13);
			this.rbNametableSE.TabIndex = 7;
			this.rbNametableSE.UseVisualStyleBackColor = true;
			this.rbNametableSE.CheckedChanged += new System.EventHandler(this.rbNametable_CheckedChanged);
			// 
			// rbNametableAll
			// 
			this.rbNametableAll.AutoSize = true;
			this.rbNametableAll.Checked = true;
			this.rbNametableAll.Location = new System.Drawing.Point(31, 38);
			this.rbNametableAll.Name = "rbNametableAll";
			this.rbNametableAll.Size = new System.Drawing.Size(14, 13);
			this.rbNametableAll.TabIndex = 9;
			this.rbNametableAll.TabStop = true;
			this.rbNametableAll.UseVisualStyleBackColor = true;
			this.rbNametableAll.CheckedChanged += new System.EventHandler(this.rbNametable_CheckedChanged);
			// 
			// NameTableView
			// 
			this.NameTableView.BackColor = System.Drawing.Color.Black;
			this.NameTableView.Location = new System.Drawing.Point(17, 19);
			this.NameTableView.Name = "NameTableView";
			this.NameTableView.Size = new System.Drawing.Size(512, 480);
			this.NameTableView.TabIndex = 0;
			this.NameTableView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NameTableView_MouseMove);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rbNametableNW);
			this.groupBox2.Controls.Add(this.rbNametableNE);
			this.groupBox2.Controls.Add(this.rbNametableAll);
			this.groupBox2.Controls.Add(this.rbNametableSW);
			this.groupBox2.Controls.Add(this.rbNametableSE);
			this.groupBox2.Location = new System.Drawing.Point(563, 94);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(76, 79);
			this.groupBox2.TabIndex = 11;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Nametable";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.txtScanline);
			this.groupBox3.Location = new System.Drawing.Point(563, 36);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(76, 52);
			this.groupBox3.TabIndex = 12;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Scanline";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.PPUAddressLabel);
			this.groupBox4.Controls.Add(this.XYLabel);
			this.groupBox4.Controls.Add(this.TileIDLabel);
			this.groupBox4.Controls.Add(this.label3);
			this.groupBox4.Controls.Add(this.label2);
			this.groupBox4.Controls.Add(this.label1);
			this.groupBox4.Location = new System.Drawing.Point(563, 179);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(99, 100);
			this.groupBox4.TabIndex = 13;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Properties";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tile ID:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "X / Y:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "PPU Addr:";
			// 
			// TileIDLabel
			// 
			this.TileIDLabel.AutoSize = true;
			this.TileIDLabel.Location = new System.Drawing.Point(66, 26);
			this.TileIDLabel.Name = "TileIDLabel";
			this.TileIDLabel.Size = new System.Drawing.Size(22, 13);
			this.TileIDLabel.TabIndex = 3;
			this.TileIDLabel.Text = "     ";
			// 
			// XYLabel
			// 
			this.XYLabel.AutoSize = true;
			this.XYLabel.Location = new System.Drawing.Point(66, 43);
			this.XYLabel.Name = "XYLabel";
			this.XYLabel.Size = new System.Drawing.Size(22, 13);
			this.XYLabel.TabIndex = 4;
			this.XYLabel.Text = "     ";
			// 
			// PPUAddressLabel
			// 
			this.PPUAddressLabel.AutoSize = true;
			this.PPUAddressLabel.Location = new System.Drawing.Point(66, 60);
			this.PPUAddressLabel.Name = "PPUAddressLabel";
			this.PPUAddressLabel.Size = new System.Drawing.Size(22, 13);
			this.PPUAddressLabel.TabIndex = 5;
			this.PPUAddressLabel.Text = "     ";
			// 
			// NESNameTableViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(668, 561);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "NESNameTableViewer";
			this.ShowIcon = false;
			this.Text = "NES Nametable Viewer";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NESNameTableViewer_FormClosed);
			this.Load += new System.EventHandler(this.NESNameTableViewer_Load);
			this.groupBox1.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private NameTableViewer NameTableView;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem autoloadToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveWindowPositionToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.TextBox txtScanline;
		private System.Windows.Forms.RadioButton rbNametableNW;
		private System.Windows.Forms.RadioButton rbNametableNE;
		private System.Windows.Forms.RadioButton rbNametableSW;
		private System.Windows.Forms.RadioButton rbNametableSE;
		private System.Windows.Forms.RadioButton rbNametableAll;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label PPUAddressLabel;
		private System.Windows.Forms.Label XYLabel;
		private System.Windows.Forms.Label TileIDLabel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}