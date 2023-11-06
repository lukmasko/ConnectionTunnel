namespace ConnectionTunnel
{
   partial class SettingsForm
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
         this.tabControl1 = new System.Windows.Forms.TabControl();
         this.tabPage1 = new System.Windows.Forms.TabPage();
         this.stopButton = new System.Windows.Forms.Button();
         this.tabPage2 = new System.Windows.Forms.TabPage();
         this.tabPage3 = new System.Windows.Forms.TabPage();
         this.saveSettingsButton = new System.Windows.Forms.Button();
         this.cancelSettingsButton = new System.Windows.Forms.Button();
         this.pluginCom1 = new ConnectionTunnel.ComPlugin();
         this.pluginCom2 = new ConnectionTunnel.ComPlugin();
         this.tabControl1.SuspendLayout();
         this.tabPage1.SuspendLayout();
         this.SuspendLayout();
         // 
         // tabControl1
         // 
         this.tabControl1.Controls.Add(this.tabPage1);
         this.tabControl1.Controls.Add(this.tabPage2);
         this.tabControl1.Controls.Add(this.tabPage3);
         this.tabControl1.Location = new System.Drawing.Point(12, 12);
         this.tabControl1.Name = "tabControl1";
         this.tabControl1.SelectedIndex = 0;
         this.tabControl1.Size = new System.Drawing.Size(589, 177);
         this.tabControl1.TabIndex = 0;
         // 
         // tabPage1
         // 
         this.tabPage1.Controls.Add(this.pluginCom2);
         this.tabPage1.Controls.Add(this.pluginCom1);
         this.tabPage1.Controls.Add(this.stopButton);
         this.tabPage1.Location = new System.Drawing.Point(4, 22);
         this.tabPage1.Name = "tabPage1";
         this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage1.Size = new System.Drawing.Size(581, 151);
         this.tabPage1.TabIndex = 0;
         this.tabPage1.Text = "Połączenia";
         this.tabPage1.UseVisualStyleBackColor = true;
         // 
         // stopButton
         // 
         this.stopButton.Enabled = false;
         this.stopButton.FlatAppearance.BorderSize = 0;
         this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.stopButton.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.stopButton.Image = global::ConnectionTunnel.Properties.Resources.arrow_up_down_bold_outline_custom;
         this.stopButton.Location = new System.Drawing.Point(250, 21);
         this.stopButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
         this.stopButton.Name = "stopButton";
         this.stopButton.Size = new System.Drawing.Size(75, 112);
         this.stopButton.TabIndex = 3;
         this.stopButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
         this.stopButton.UseVisualStyleBackColor = true;
         // 
         // tabPage2
         // 
         this.tabPage2.Location = new System.Drawing.Point(4, 22);
         this.tabPage2.Name = "tabPage2";
         this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage2.Size = new System.Drawing.Size(581, 151);
         this.tabPage2.TabIndex = 1;
         this.tabPage2.Text = "Ogólne";
         this.tabPage2.UseVisualStyleBackColor = true;
         // 
         // tabPage3
         // 
         this.tabPage3.Location = new System.Drawing.Point(4, 22);
         this.tabPage3.Name = "tabPage3";
         this.tabPage3.Size = new System.Drawing.Size(581, 151);
         this.tabPage3.TabIndex = 2;
         this.tabPage3.Text = "Logowanie";
         this.tabPage3.UseVisualStyleBackColor = true;
         // 
         // saveSettingsButton
         // 
         this.saveSettingsButton.FlatAppearance.BorderSize = 0;
         this.saveSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.saveSettingsButton.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.saveSettingsButton.Image = global::ConnectionTunnel.Properties.Resources.content_save_settings_custom;
         this.saveSettingsButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
         this.saveSettingsButton.Location = new System.Drawing.Point(491, 191);
         this.saveSettingsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
         this.saveSettingsButton.Name = "saveSettingsButton";
         this.saveSettingsButton.Size = new System.Drawing.Size(110, 84);
         this.saveSettingsButton.TabIndex = 3;
         this.saveSettingsButton.Text = "Zapisz";
         this.saveSettingsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
         this.saveSettingsButton.UseVisualStyleBackColor = true;
         this.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
         // 
         // cancelSettingsButton
         // 
         this.cancelSettingsButton.FlatAppearance.BorderSize = 0;
         this.cancelSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.cancelSettingsButton.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.cancelSettingsButton.Image = global::ConnectionTunnel.Properties.Resources.cancel_custom;
         this.cancelSettingsButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
         this.cancelSettingsButton.Location = new System.Drawing.Point(374, 191);
         this.cancelSettingsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
         this.cancelSettingsButton.Name = "cancelSettingsButton";
         this.cancelSettingsButton.Size = new System.Drawing.Size(110, 84);
         this.cancelSettingsButton.TabIndex = 2;
         this.cancelSettingsButton.Text = "Anuluj";
         this.cancelSettingsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
         this.cancelSettingsButton.UseVisualStyleBackColor = true;
         this.cancelSettingsButton.Click += new System.EventHandler(this.cancelSettingsButton_Click);
         // 
         // pluginCom1
         // 
         this.pluginCom1.Location = new System.Drawing.Point(6, 21);
         this.pluginCom1.Name = "pluginCom1";
         this.pluginCom1.Size = new System.Drawing.Size(250, 116);
         this.pluginCom1.TabIndex = 4;
         // 
         // pluginCom2
         // 
         this.pluginCom2.Location = new System.Drawing.Point(325, 21);
         this.pluginCom2.Name = "pluginCom2";
         this.pluginCom2.Size = new System.Drawing.Size(250, 116);
         this.pluginCom2.TabIndex = 5;
         // 
         // SettingsForm
         // 
         this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(606, 281);
         this.Controls.Add(this.saveSettingsButton);
         this.Controls.Add(this.cancelSettingsButton);
         this.Controls.Add(this.tabControl1);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.MaximumSize = new System.Drawing.Size(622, 320);
         this.MinimizeBox = false;
         this.MinimumSize = new System.Drawing.Size(622, 320);
         this.Name = "SettingsForm";
         this.Text = "SettingsForm";
         this.tabControl1.ResumeLayout(false);
         this.tabPage1.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TabControl tabControl1;
      private System.Windows.Forms.TabPage tabPage1;
      private System.Windows.Forms.TabPage tabPage2;
      private System.Windows.Forms.TabPage tabPage3;
      private System.Windows.Forms.Button stopButton;
      private System.Windows.Forms.Button cancelSettingsButton;
      private System.Windows.Forms.Button saveSettingsButton;
      private ComPlugin pluginCom1;
      private ComPlugin pluginCom2;
   }
}