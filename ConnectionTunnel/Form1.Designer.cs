namespace ConnectionTunnel
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
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.logsButton = new System.Windows.Forms.Button();
         this.stopButton = new System.Windows.Forms.Button();
         this.playButton = new System.Windows.Forms.Button();
         this.settingsButton = new System.Windows.Forms.Button();
         this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
         this.SuspendLayout();
         // 
         // groupBox1
         // 
         this.groupBox1.Location = new System.Drawing.Point(4, 88);
         this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
         this.groupBox1.Size = new System.Drawing.Size(442, 108);
         this.groupBox1.TabIndex = 2;
         this.groupBox1.TabStop = false;
         // 
         // logsButton
         // 
         this.logsButton.FlatAppearance.BorderSize = 0;
         this.logsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.logsButton.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.logsButton.Image = global::ConnectionTunnel.Properties.Resources.archive_custom;
         this.logsButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
         this.logsButton.Location = new System.Drawing.Point(336, 3);
         this.logsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
         this.logsButton.Name = "logsButton";
         this.logsButton.Size = new System.Drawing.Size(110, 84);
         this.logsButton.TabIndex = 4;
         this.logsButton.Text = "Logi";
         this.logsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
         this.logsButton.UseVisualStyleBackColor = true;
         this.logsButton.Click += new System.EventHandler(this.logsButton_Click);
         // 
         // stopButton
         // 
         this.stopButton.Enabled = false;
         this.stopButton.FlatAppearance.BorderSize = 0;
         this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.stopButton.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.stopButton.Image = global::ConnectionTunnel.Properties.Resources.stop_custom;
         this.stopButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
         this.stopButton.Location = new System.Drawing.Point(114, 3);
         this.stopButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
         this.stopButton.Name = "stopButton";
         this.stopButton.Size = new System.Drawing.Size(110, 84);
         this.stopButton.TabIndex = 2;
         this.stopButton.Text = "Zatrzymaj";
         this.stopButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
         this.stopButton.UseVisualStyleBackColor = true;
         this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
         // 
         // playButton
         // 
         this.playButton.FlatAppearance.BorderSize = 0;
         this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.playButton.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.playButton.Image = global::ConnectionTunnel.Properties.Resources.play_custom;
         this.playButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
         this.playButton.Location = new System.Drawing.Point(4, 3);
         this.playButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
         this.playButton.Name = "playButton";
         this.playButton.Size = new System.Drawing.Size(110, 84);
         this.playButton.TabIndex = 1;
         this.playButton.Text = "Uruchom";
         this.playButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
         this.playButton.UseVisualStyleBackColor = true;
         this.playButton.Click += new System.EventHandler(this.playButton_Click);
         // 
         // settingsButton
         // 
         this.settingsButton.FlatAppearance.BorderSize = 0;
         this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.settingsButton.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.settingsButton.Image = global::ConnectionTunnel.Properties.Resources.cog_custom;
         this.settingsButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
         this.settingsButton.Location = new System.Drawing.Point(225, 3);
         this.settingsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
         this.settingsButton.Name = "settingsButton";
         this.settingsButton.Size = new System.Drawing.Size(110, 84);
         this.settingsButton.TabIndex = 3;
         this.settingsButton.Text = "Ustawienia";
         this.settingsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
         this.settingsButton.UseVisualStyleBackColor = true;
         this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
         // 
         // notifyIcon1
         // 
         this.notifyIcon1.BalloonTipText = "xxx";
         this.notifyIcon1.BalloonTipTitle = "ddd";
         this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
         this.notifyIcon1.Text = "Connection Tunnel";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(450, 201);
         this.Controls.Add(this.logsButton);
         this.Controls.Add(this.stopButton);
         this.Controls.Add(this.playButton);
         this.Controls.Add(this.settingsButton);
         this.Controls.Add(this.groupBox1);
         this.Font = new System.Drawing.Font("Courier New", 8F);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
         this.MaximizeBox = false;
         this.MaximumSize = new System.Drawing.Size(466, 240);
         this.MinimizeBox = false;
         this.MinimumSize = new System.Drawing.Size(466, 240);
         this.Name = "Form1";
         this.Text = "Connection tunnel 1.00";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClosingEvent);
         this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormClosedEvent);
         this.ResumeLayout(false);

      }

      #endregion
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.Button settingsButton;
      private System.Windows.Forms.Button playButton;
      private System.Windows.Forms.Button stopButton;
      private System.Windows.Forms.Button logsButton;
      private System.Windows.Forms.NotifyIcon notifyIcon1;
   }
}

