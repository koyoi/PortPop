﻿namespace PortPop
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.notifyPortAddedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyPortRemovedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyDriveAddedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyDriveRemovedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notifyPortAddedToolStripMenuItem,
            this.notifyPortRemovedToolStripMenuItem,
            this.notifyDriveAddedToolStripMenuItem,
            this.notifyDriveRemovedToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(213, 142);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.exitToolStripMenuItem.Text = "終了(&X)";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(209, 6);
            // 
            // notifyPortAddedToolStripMenuItem
            // 
            this.notifyPortAddedToolStripMenuItem.Checked = true;
            this.notifyPortAddedToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.notifyPortAddedToolStripMenuItem.Name = "notifyPortAddedToolStripMenuItem";
            this.notifyPortAddedToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.notifyPortAddedToolStripMenuItem.Text = "シリアルポートの追加を通知";
            this.notifyPortAddedToolStripMenuItem.Click += new System.EventHandler(this.notifyPortAddedToolStripMenuItem_Click);
            // 
            // notifyPortRemovedToolStripMenuItem
            // 
            this.notifyPortRemovedToolStripMenuItem.Checked = true;
            this.notifyPortRemovedToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.notifyPortRemovedToolStripMenuItem.Name = "notifyPortRemovedToolStripMenuItem";
            this.notifyPortRemovedToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.notifyPortRemovedToolStripMenuItem.Text = "シリアルポートの取外しを通知";
            this.notifyPortRemovedToolStripMenuItem.Click += new System.EventHandler(this.notifyPortRemovedToolStripMenuItem_Click);
            // 
            // notifyDriveAddedToolStripMenuItem
            // 
            this.notifyDriveAddedToolStripMenuItem.Checked = true;
            this.notifyDriveAddedToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.notifyDriveAddedToolStripMenuItem.Name = "notifyDriveAddedToolStripMenuItem";
            this.notifyDriveAddedToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.notifyDriveAddedToolStripMenuItem.Text = "ドライブの追加を通知";
            this.notifyDriveAddedToolStripMenuItem.Click += new System.EventHandler(this.notifyDriveAddedToolStripMenuItem_Click);
            // 
            // notifyDriveRemovedToolStripMenuItem
            // 
            this.notifyDriveRemovedToolStripMenuItem.Checked = true;
            this.notifyDriveRemovedToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.notifyDriveRemovedToolStripMenuItem.Name = "notifyDriveRemovedToolStripMenuItem";
            this.notifyDriveRemovedToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.notifyDriveRemovedToolStripMenuItem.Text = "ドライブの取外しを通知";
            this.notifyDriveRemovedToolStripMenuItem.Click += new System.EventHandler(this.notifyDriveRemovedToolStripMenuItem_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "PortPop";
            this.notifyIcon.Visible = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 90);
            this.Name = "FormMain";
            this.Text = "PortPop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notifyPortAddedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notifyPortRemovedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notifyDriveAddedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notifyDriveRemovedToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

