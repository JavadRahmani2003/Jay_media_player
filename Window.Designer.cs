
namespace Jay_Media_Player
{
    partial class MediaPlayer
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
            this.AppMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whosDeveloperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Stop = new System.Windows.Forms.Button();
            this.VolumeController = new System.Windows.Forms.TrackBar();
            this.Volume = new System.Windows.Forms.Label();
            this.Counter = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.OpenMedia = new System.Windows.Forms.OpenFileDialog();
            this.PausePlay = new System.Windows.Forms.Button();
            this.MuteUnmute = new System.Windows.Forms.Button();
            this.AppMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeController)).BeginInit();
            this.SuspendLayout();
            // 
            // AppMenu
            // 
            this.AppMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AppMenu.BackColor = System.Drawing.Color.Transparent;
            this.AppMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.AppMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.programToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.AppMenu.Location = new System.Drawing.Point(0, 0);
            this.AppMenu.Name = "AppMenu";
            this.AppMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.AppMenu.Size = new System.Drawing.Size(136, 24);
            this.AppMenu.TabIndex = 0;
            this.AppMenu.Text = "AppMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.playToolStripMenuItem.Text = "Open File";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitAppToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.programToolStripMenuItem.Text = "Edit";
            // 
            // quitAppToolStripMenuItem
            // 
            this.quitAppToolStripMenuItem.Name = "quitAppToolStripMenuItem";
            this.quitAppToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.quitAppToolStripMenuItem.Text = "Quit App";
            this.quitAppToolStripMenuItem.Click += new System.EventHandler(this.quitAppToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whosDeveloperToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // whosDeveloperToolStripMenuItem
            // 
            this.whosDeveloperToolStripMenuItem.Name = "whosDeveloperToolStripMenuItem";
            this.whosDeveloperToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.whosDeveloperToolStripMenuItem.Text = "Who\'s Developer";
            this.whosDeveloperToolStripMenuItem.Click += new System.EventHandler(this.whosDeveloperToolStripMenuItem_Click);
            // 
            // Stop
            // 
            this.Stop.Image = global::Jay_Media_Player.Properties.Resources.Stop;
            this.Stop.Location = new System.Drawing.Point(170, 27);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 65);
            this.Stop.TabIndex = 4;
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // VolumeController
            // 
            this.VolumeController.Location = new System.Drawing.Point(251, 27);
            this.VolumeController.Name = "VolumeController";
            this.VolumeController.Size = new System.Drawing.Size(191, 45);
            this.VolumeController.TabIndex = 6;
            this.VolumeController.Value = 5;
            this.VolumeController.Scroll += new System.EventHandler(this.VolumeController_Scroll);
            // 
            // Volume
            // 
            this.Volume.AutoSize = true;
            this.Volume.Location = new System.Drawing.Point(258, 59);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(42, 13);
            this.Volume.TabIndex = 7;
            this.Volume.Text = "Volume";
            // 
            // Counter
            // 
            this.Counter.AutoSize = true;
            this.Counter.Location = new System.Drawing.Point(419, 59);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(27, 13);
            this.Counter.TabIndex = 8;
            this.Counter.Text = "50%";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(12, 106);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(82, 13);
            this.Status.TabIndex = 9;
            this.Status.Text = "No File Loaded!";
            // 
            // OpenMedia
            // 
            this.OpenMedia.FileName = "OpenMedia";
            // 
            // PausePlay
            // 
            this.PausePlay.Image = global::Jay_Media_Player.Properties.Resources.Play;
            this.PausePlay.Location = new System.Drawing.Point(89, 27);
            this.PausePlay.Name = "PausePlay";
            this.PausePlay.Size = new System.Drawing.Size(75, 65);
            this.PausePlay.TabIndex = 3;
            this.PausePlay.UseVisualStyleBackColor = true;
            this.PausePlay.Click += new System.EventHandler(this.PausePlay_Click);
            // 
            // MuteUnmute
            // 
            this.MuteUnmute.Image = global::Jay_Media_Player.Properties.Resources.unmute;
            this.MuteUnmute.Location = new System.Drawing.Point(8, 27);
            this.MuteUnmute.Name = "MuteUnmute";
            this.MuteUnmute.Size = new System.Drawing.Size(75, 65);
            this.MuteUnmute.TabIndex = 1;
            this.MuteUnmute.UseVisualStyleBackColor = true;
            this.MuteUnmute.Click += new System.EventHandler(this.MuteUnmute_Click);
            // 
            // MediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 137);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Counter);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.VolumeController);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.PausePlay);
            this.Controls.Add(this.MuteUnmute);
            this.Controls.Add(this.AppMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.AppMenu;
            this.MinimizeBox = false;
            this.Name = "MediaPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jay Audio Player";
            this.AppMenu.ResumeLayout(false);
            this.AppMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeController)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip AppMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whosDeveloperToolStripMenuItem;
        private System.Windows.Forms.Button MuteUnmute;
        private System.Windows.Forms.Button PausePlay;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.TrackBar VolumeController;
        private System.Windows.Forms.Label Volume;
        private System.Windows.Forms.Label Counter;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.OpenFileDialog OpenMedia;
    }
}

