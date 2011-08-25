﻿namespace BizHawk.MultiClient
{
    partial class HexEditor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HexEditor));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dumpToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.memoryDomainsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dataSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.byteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.byteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.byteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.enToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.goToAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addToRamWatchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.freezeAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.autoloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveWindowsSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.restoreWindowSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ViewerContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.pokeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.freezeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addToRamWatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MemoryViewerBox = new System.Windows.Forms.GroupBox();
			this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
			this.AddressesLabel = new System.Windows.Forms.Label();
			this.unfreezeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.unfreezeAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.ViewerContextMenuStrip.SuspendLayout();
			this.MemoryViewerBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.settingsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(584, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dumpToFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// dumpToFileToolStripMenuItem
			// 
			this.dumpToFileToolStripMenuItem.Image = global::BizHawk.MultiClient.Properties.Resources.SaveAs;
			this.dumpToFileToolStripMenuItem.Name = "dumpToFileToolStripMenuItem";
			this.dumpToFileToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.dumpToFileToolStripMenuItem.Text = "&Dump to file...";
			this.dumpToFileToolStripMenuItem.Click += new System.EventHandler(this.dumpToFileToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memoryDomainsToolStripMenuItem,
            this.dataSizeToolStripMenuItem,
            this.enToolStripMenuItem,
            this.toolStripSeparator2,
            this.goToAddressToolStripMenuItem,
            this.addToRamWatchToolStripMenuItem1,
            this.freezeAddressToolStripMenuItem,
            this.unfreezeAllToolStripMenuItem});
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
			this.optionsToolStripMenuItem.Text = "&Options";
			this.optionsToolStripMenuItem.DropDownOpened += new System.EventHandler(this.optionsToolStripMenuItem_DropDownOpened);
			// 
			// memoryDomainsToolStripMenuItem
			// 
			this.memoryDomainsToolStripMenuItem.Name = "memoryDomainsToolStripMenuItem";
			this.memoryDomainsToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
			this.memoryDomainsToolStripMenuItem.Text = "&Memory Domains";
			this.memoryDomainsToolStripMenuItem.DropDownOpened += new System.EventHandler(this.memoryDomainsToolStripMenuItem_DropDownOpened);
			// 
			// dataSizeToolStripMenuItem
			// 
			this.dataSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byteToolStripMenuItem,
            this.byteToolStripMenuItem1,
            this.byteToolStripMenuItem2});
			this.dataSizeToolStripMenuItem.Name = "dataSizeToolStripMenuItem";
			this.dataSizeToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
			this.dataSizeToolStripMenuItem.Text = "Data Size";
			// 
			// byteToolStripMenuItem
			// 
			this.byteToolStripMenuItem.Name = "byteToolStripMenuItem";
			this.byteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.byteToolStripMenuItem.Text = "1 Byte";
			this.byteToolStripMenuItem.Click += new System.EventHandler(this.byteToolStripMenuItem_Click);
			// 
			// byteToolStripMenuItem1
			// 
			this.byteToolStripMenuItem1.Name = "byteToolStripMenuItem1";
			this.byteToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.byteToolStripMenuItem1.Text = "2 Byte";
			this.byteToolStripMenuItem1.Click += new System.EventHandler(this.byteToolStripMenuItem1_Click);
			// 
			// byteToolStripMenuItem2
			// 
			this.byteToolStripMenuItem2.Name = "byteToolStripMenuItem2";
			this.byteToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
			this.byteToolStripMenuItem2.Text = "4 Byte";
			this.byteToolStripMenuItem2.Click += new System.EventHandler(this.byteToolStripMenuItem2_Click);
			// 
			// enToolStripMenuItem
			// 
			this.enToolStripMenuItem.Name = "enToolStripMenuItem";
			this.enToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
			this.enToolStripMenuItem.Text = "Big Endian";
			this.enToolStripMenuItem.Click += new System.EventHandler(this.enToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(201, 6);
			// 
			// goToAddressToolStripMenuItem
			// 
			this.goToAddressToolStripMenuItem.Name = "goToAddressToolStripMenuItem";
			this.goToAddressToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
			this.goToAddressToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
			this.goToAddressToolStripMenuItem.Text = "&Go to Address...";
			this.goToAddressToolStripMenuItem.Click += new System.EventHandler(this.goToAddressToolStripMenuItem_Click);
			// 
			// addToRamWatchToolStripMenuItem1
			// 
			this.addToRamWatchToolStripMenuItem1.Image = global::BizHawk.MultiClient.Properties.Resources.FindHS;
			this.addToRamWatchToolStripMenuItem1.Name = "addToRamWatchToolStripMenuItem1";
			this.addToRamWatchToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
			this.addToRamWatchToolStripMenuItem1.Text = "Add to Ram Watch";
			this.addToRamWatchToolStripMenuItem1.Click += new System.EventHandler(this.addToRamWatchToolStripMenuItem1_Click);
			// 
			// freezeAddressToolStripMenuItem
			// 
			this.freezeAddressToolStripMenuItem.Image = global::BizHawk.MultiClient.Properties.Resources.Freeze;
			this.freezeAddressToolStripMenuItem.Name = "freezeAddressToolStripMenuItem";
			this.freezeAddressToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
			this.freezeAddressToolStripMenuItem.Text = "&Freeze Address";
			this.freezeAddressToolStripMenuItem.Click += new System.EventHandler(this.freezeAddressToolStripMenuItem_Click);
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoloadToolStripMenuItem,
            this.saveWindowsSettingsToolStripMenuItem,
            this.toolStripSeparator3,
            this.restoreWindowSizeToolStripMenuItem});
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
			this.settingsToolStripMenuItem.Text = "&Settings";
			this.settingsToolStripMenuItem.DropDownOpened += new System.EventHandler(this.settingsToolStripMenuItem_DropDownOpened);
			// 
			// autoloadToolStripMenuItem
			// 
			this.autoloadToolStripMenuItem.Name = "autoloadToolStripMenuItem";
			this.autoloadToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
			this.autoloadToolStripMenuItem.Text = "Auto-load";
			this.autoloadToolStripMenuItem.Click += new System.EventHandler(this.autoloadToolStripMenuItem_Click);
			// 
			// saveWindowsSettingsToolStripMenuItem
			// 
			this.saveWindowsSettingsToolStripMenuItem.Name = "saveWindowsSettingsToolStripMenuItem";
			this.saveWindowsSettingsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
			this.saveWindowsSettingsToolStripMenuItem.Text = "Save windows settings";
			this.saveWindowsSettingsToolStripMenuItem.Click += new System.EventHandler(this.saveWindowsSettingsToolStripMenuItem_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(191, 6);
			// 
			// restoreWindowSizeToolStripMenuItem
			// 
			this.restoreWindowSizeToolStripMenuItem.Name = "restoreWindowSizeToolStripMenuItem";
			this.restoreWindowSizeToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
			this.restoreWindowSizeToolStripMenuItem.Text = "&Restore Window Size";
			this.restoreWindowSizeToolStripMenuItem.Click += new System.EventHandler(this.restoreWindowSizeToolStripMenuItem_Click);
			// 
			// ViewerContextMenuStrip
			// 
			this.ViewerContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pokeToolStripMenuItem,
            this.freezeToolStripMenuItem,
            this.addToRamWatchToolStripMenuItem,
            this.unfreezeAllToolStripMenuItem1});
			this.ViewerContextMenuStrip.Name = "ViewerContextMenuStrip";
			this.ViewerContextMenuStrip.Size = new System.Drawing.Size(176, 114);
			// 
			// pokeToolStripMenuItem
			// 
			this.pokeToolStripMenuItem.Image = global::BizHawk.MultiClient.Properties.Resources.poke;
			this.pokeToolStripMenuItem.Name = "pokeToolStripMenuItem";
			this.pokeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
			this.pokeToolStripMenuItem.Text = "&Poke";
			this.pokeToolStripMenuItem.Click += new System.EventHandler(this.pokeToolStripMenuItem_Click);
			// 
			// freezeToolStripMenuItem
			// 
			this.freezeToolStripMenuItem.Image = global::BizHawk.MultiClient.Properties.Resources.Freeze;
			this.freezeToolStripMenuItem.Name = "freezeToolStripMenuItem";
			this.freezeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
			this.freezeToolStripMenuItem.Text = "&Freeze";
			this.freezeToolStripMenuItem.Click += new System.EventHandler(this.freezeToolStripMenuItem_Click);
			// 
			// addToRamWatchToolStripMenuItem
			// 
			this.addToRamWatchToolStripMenuItem.Image = global::BizHawk.MultiClient.Properties.Resources.FindHS;
			this.addToRamWatchToolStripMenuItem.Name = "addToRamWatchToolStripMenuItem";
			this.addToRamWatchToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
			this.addToRamWatchToolStripMenuItem.Text = "&Add to Ram Watch";
			this.addToRamWatchToolStripMenuItem.Click += new System.EventHandler(this.addToRamWatchToolStripMenuItem_Click);
			// 
			// MemoryViewerBox
			// 
			this.MemoryViewerBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.MemoryViewerBox.ContextMenuStrip = this.ViewerContextMenuStrip;
			this.MemoryViewerBox.Controls.Add(this.vScrollBar1);
			this.MemoryViewerBox.Controls.Add(this.AddressesLabel);
			this.MemoryViewerBox.Location = new System.Drawing.Point(12, 27);
			this.MemoryViewerBox.MaximumSize = new System.Drawing.Size(600, 1024);
			this.MemoryViewerBox.MinimumSize = new System.Drawing.Size(495, 200);
			this.MemoryViewerBox.Name = "MemoryViewerBox";
			this.MemoryViewerBox.Size = new System.Drawing.Size(558, 262);
			this.MemoryViewerBox.TabIndex = 2;
			this.MemoryViewerBox.TabStop = false;
			this.MemoryViewerBox.Paint += new System.Windows.Forms.PaintEventHandler(this.MemoryViewerBox_Paint);
			// 
			// vScrollBar1
			// 
			this.vScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.vScrollBar1.LargeChange = 16;
			this.vScrollBar1.Location = new System.Drawing.Point(539, 8);
			this.vScrollBar1.Name = "vScrollBar1";
			this.vScrollBar1.Size = new System.Drawing.Size(16, 251);
			this.vScrollBar1.TabIndex = 1;
			this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
			// 
			// AddressesLabel
			// 
			this.AddressesLabel.AutoSize = true;
			this.AddressesLabel.BackColor = System.Drawing.Color.White;
			this.AddressesLabel.ContextMenuStrip = this.ViewerContextMenuStrip;
			this.AddressesLabel.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddressesLabel.Location = new System.Drawing.Point(6, 16);
			this.AddressesLabel.Name = "AddressesLabel";
			this.AddressesLabel.Size = new System.Drawing.Size(28, 14);
			this.AddressesLabel.TabIndex = 0;
			this.AddressesLabel.Text = "RAM";
			this.AddressesLabel.MouseLeave += new System.EventHandler(this.AddressesLabel_MouseLeave);
			this.AddressesLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddressesLabel_MouseMove);
			this.AddressesLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddressesLabel_MouseClick);
			// 
			// unfreezeAllToolStripMenuItem
			// 
			this.unfreezeAllToolStripMenuItem.Image = global::BizHawk.MultiClient.Properties.Resources.Unfreeze;
			this.unfreezeAllToolStripMenuItem.Name = "unfreezeAllToolStripMenuItem";
			this.unfreezeAllToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
			this.unfreezeAllToolStripMenuItem.Text = "Unfreeze All";
			this.unfreezeAllToolStripMenuItem.Click += new System.EventHandler(this.unfreezeAllToolStripMenuItem_Click);
			// 
			// unfreezeAllToolStripMenuItem1
			// 
			this.unfreezeAllToolStripMenuItem1.Image = global::BizHawk.MultiClient.Properties.Resources.Unfreeze;
			this.unfreezeAllToolStripMenuItem1.Name = "unfreezeAllToolStripMenuItem1";
			this.unfreezeAllToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
			this.unfreezeAllToolStripMenuItem1.Text = "&Unfreeze All";
			this.unfreezeAllToolStripMenuItem1.Click += new System.EventHandler(this.unfreezeAllToolStripMenuItem1_Click);
			// 
			// HexEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 301);
			this.Controls.Add(this.MemoryViewerBox);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(528, 180);
			this.Name = "HexEditor";
			this.Text = "HexEditor";
			this.Load += new System.EventHandler(this.HexEditor_Load);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HexEditor_KeyUp);
			this.Resize += new System.EventHandler(this.HexEditor_Resize);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HexEditor_KeyDown);
			this.ResizeEnd += new System.EventHandler(this.HexEditor_ResizeEnd);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ViewerContextMenuStrip.ResumeLayout(false);
			this.MemoryViewerBox.ResumeLayout(false);
			this.MemoryViewerBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dumpToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memoryDomainsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem byteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem goToAddressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreWindowSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoloadToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem enToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ViewerContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem pokeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freezeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToRamWatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem addToRamWatchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveWindowsSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freezeAddressToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.GroupBox MemoryViewerBox;
		private System.Windows.Forms.Label AddressesLabel;
		private System.Windows.Forms.VScrollBar vScrollBar1;
		private System.Windows.Forms.ToolStripMenuItem unfreezeAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem unfreezeAllToolStripMenuItem1;
    }
}