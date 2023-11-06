namespace ConnectionTunnel
{
   partial class ComPlugin
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
         this.ip_editor = new System.Windows.Forms.TextBox();
         this.port_editor = new System.Windows.Forms.NumericUpDown();
         this.speed_editor = new System.Windows.Forms.ComboBox();
         this.com_names_editor = new System.Windows.Forms.ComboBox();
         this.conn_mode_editor = new System.Windows.Forms.ComboBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.groupBox1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.port_editor)).BeginInit();
         this.SuspendLayout();
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.label3);
         this.groupBox1.Controls.Add(this.label2);
         this.groupBox1.Controls.Add(this.label1);
         this.groupBox1.Controls.Add(this.ip_editor);
         this.groupBox1.Controls.Add(this.port_editor);
         this.groupBox1.Controls.Add(this.speed_editor);
         this.groupBox1.Controls.Add(this.com_names_editor);
         this.groupBox1.Controls.Add(this.conn_mode_editor);
         this.groupBox1.Location = new System.Drawing.Point(3, 1);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(243, 112);
         this.groupBox1.TabIndex = 5;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Host 1";
         // 
         // ip_editor
         // 
         this.ip_editor.Location = new System.Drawing.Point(105, -8);
         this.ip_editor.Name = "ip_editor";
         this.ip_editor.Size = new System.Drawing.Size(121, 20);
         this.ip_editor.TabIndex = 4;
         this.ip_editor.Text = "127.0.0.1";
         // 
         // port_editor
         // 
         this.port_editor.Location = new System.Drawing.Point(84, 3);
         this.port_editor.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
         this.port_editor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this.port_editor.Name = "port_editor";
         this.port_editor.Size = new System.Drawing.Size(120, 20);
         this.port_editor.TabIndex = 3;
         this.port_editor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
         // 
         // speed_editor
         // 
         this.speed_editor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.speed_editor.FormattingEnabled = true;
         this.speed_editor.Location = new System.Drawing.Point(116, 72);
         this.speed_editor.Name = "speed_editor";
         this.speed_editor.Size = new System.Drawing.Size(121, 21);
         this.speed_editor.TabIndex = 2;
         // 
         // com_names_editor
         // 
         this.com_names_editor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.com_names_editor.FormattingEnabled = true;
         this.com_names_editor.Location = new System.Drawing.Point(116, 45);
         this.com_names_editor.Name = "com_names_editor";
         this.com_names_editor.Size = new System.Drawing.Size(121, 21);
         this.com_names_editor.TabIndex = 1;
         // 
         // conn_mode_editor
         // 
         this.conn_mode_editor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.conn_mode_editor.FormattingEnabled = true;
         this.conn_mode_editor.Location = new System.Drawing.Point(116, 18);
         this.conn_mode_editor.Name = "conn_mode_editor";
         this.conn_mode_editor.Size = new System.Drawing.Size(121, 21);
         this.conn_mode_editor.TabIndex = 0;
         this.conn_mode_editor.SelectedIndexChanged += new System.EventHandler(this.connectionType_OnChange);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 21);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(99, 13);
         this.label1.TabIndex = 5;
         this.label1.Text = "Rodzaj połączenia:";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(12, 48);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(0, 13);
         this.label2.TabIndex = 6;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(12, 75);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(0, 13);
         this.label3.TabIndex = 7;
         // 
         // ComPlugin
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.groupBox1);
         this.Name = "ComPlugin";
         this.Size = new System.Drawing.Size(250, 116);
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.port_editor)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.ComboBox speed_editor;
      private System.Windows.Forms.ComboBox com_names_editor;
      private System.Windows.Forms.ComboBox conn_mode_editor;
      private System.Windows.Forms.NumericUpDown port_editor;
      private System.Windows.Forms.TextBox ip_editor;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label2;
   }
}
