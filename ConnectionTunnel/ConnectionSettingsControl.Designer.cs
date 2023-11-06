namespace ConnectionTunnel
{
   partial class ConnectionSettingsControl
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

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.comboBox1 = new System.Windows.Forms.ComboBox();
         this.comboBox2 = new System.Windows.Forms.ComboBox();
         this.comboBox3 = new System.Windows.Forms.ComboBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.groupBox1.SuspendLayout();
         this.SuspendLayout();
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.label3);
         this.groupBox1.Controls.Add(this.label2);
         this.groupBox1.Controls.Add(this.label1);
         this.groupBox1.Controls.Add(this.comboBox3);
         this.groupBox1.Controls.Add(this.comboBox2);
         this.groupBox1.Controls.Add(this.comboBox1);
         this.groupBox1.Location = new System.Drawing.Point(3, 3);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(221, 117);
         this.groupBox1.TabIndex = 0;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Host";
         // 
         // comboBox1
         // 
         this.comboBox1.FormattingEnabled = true;
         this.comboBox1.Location = new System.Drawing.Point(73, 21);
         this.comboBox1.Name = "comboBox1";
         this.comboBox1.Size = new System.Drawing.Size(121, 21);
         this.comboBox1.TabIndex = 0;
         // 
         // comboBox2
         // 
         this.comboBox2.FormattingEnabled = true;
         this.comboBox2.Location = new System.Drawing.Point(73, 51);
         this.comboBox2.Name = "comboBox2";
         this.comboBox2.Size = new System.Drawing.Size(121, 21);
         this.comboBox2.TabIndex = 1;
         // 
         // comboBox3
         // 
         this.comboBox3.FormattingEnabled = true;
         this.comboBox3.Location = new System.Drawing.Point(73, 81);
         this.comboBox3.Name = "comboBox3";
         this.comboBox3.Size = new System.Drawing.Size(121, 21);
         this.comboBox3.TabIndex = 2;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(20, 24);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(28, 13);
         this.label1.TabIndex = 3;
         this.label1.Text = "Typ:";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(20, 54);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(35, 13);
         this.label2.TabIndex = 4;
         this.label2.Text = "label2";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(20, 84);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(35, 13);
         this.label3.TabIndex = 5;
         this.label3.Text = "label3";
         // 
         // ConnectionSettingsControl
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.groupBox1);
         this.Name = "ConnectionSettingsControl";
         this.Size = new System.Drawing.Size(230, 122);
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.ComboBox comboBox3;
      private System.Windows.Forms.ComboBox comboBox2;
      private System.Windows.Forms.ComboBox comboBox1;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
   }
}
