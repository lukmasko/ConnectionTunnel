using ConnectionTunnel.Settings;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;

namespace ConnectionTunnel
{
   public partial class ComPlugin : UserControl
   {
      private ComSettings com_settings;
      private string[] com_names;

      public ComPlugin()
      {
         InitializeComponent();
         loadData();
      }

      private void loadData()
      {
         foreach (string connType in AppDefs.COM_TYPES)
            conn_mode_editor.Items.Add(connType);

         com_names = getComPorts();
         foreach (string comName in com_names)
            com_names_editor.Items.Add(comName);

         foreach (int comSpeed in AppDefs.COM_BAUDRATE)
            speed_editor.Items.Add(comSpeed);
      }

      internal void LoadSettings(ComSettings sett)
      {
         com_settings.ConnectionType = sett.ConnectionType;
         com_settings.RS232ComName = sett.RS232ComName;
         com_settings.RS232BaudRate = sett.RS232BaudRate;
         com_settings.USBComName = sett.USBComName;
         com_settings.TCPServerPort = sett.TCPServerPort;
         com_settings.TCPClientIP = sett.TCPClientIP;
         com_settings.TCPClientPort = sett.TCPClientPort;
         com_settings.WebSocketServerPort = sett.WebSocketServerPort;
         com_settings.WebSocketClientIP = sett.WebSocketClientIP;
         com_settings.WebSocketClientPort = sett.WebSocketClientPort;

         conn_mode_editor.SelectedIndex = com_settings.ConnectionType;
      }

      internal ComSettings GetSettings()
      {
         com_settings.ConnectionType = conn_mode_editor.SelectedIndex;

         switch (conn_mode_editor.SelectedIndex)
         {
            case 0: // RS232
               com_settings.RS232ComName = com_names_editor.Text;
               com_settings.RS232BaudRate = Convert.ToInt32(speed_editor.Text);
               break;
            case 1: // USB
               com_settings.USBComName = com_names_editor.Text;
               break;
            case 2: // TCP Server
               com_settings.TCPServerPort = Convert.ToInt32(port_editor.Text);
               break;
            case 3: // TCP Client
               com_settings.TCPClientIP = ip_editor.Text;
               com_settings.TCPClientPort = Convert.ToInt32(port_editor.Text);
               break;
            case 4: // WebSocket Server
               com_settings.WebSocketServerPort = Convert.ToInt32(port_editor.Text);
               break;
            case 5: // WebSocket Client
               com_settings.WebSocketClientIP = ip_editor.Text;
               com_settings.WebSocketClientPort = Convert.ToInt32(port_editor.Text);
               break;
         }
         return com_settings;
      }

      private void connectionType_OnChange(object sender, EventArgs e)
      {
         switch (conn_mode_editor.SelectedIndex)
         {
            case 0: // RS232
               com_names_editor.Visible = true;
               com_names_editor.Location = new System.Drawing.Point(116, 45);
               speed_editor.Visible = true;
               speed_editor.Location = new System.Drawing.Point(116, 72);
               ip_editor.Visible = false;
               port_editor.Visible = false;

               com_names_editor.SelectedIndex = getSelectedIndex(com_settings.RS232ComName, com_names);
               speed_editor.SelectedIndex = getSelectedIndex(com_settings.RS232BaudRate, AppDefs.COM_BAUDRATE);
               label2.Text = "Nazwa";
               label3.Text = "Prędkość";
               break;
            case 1: // USB
               com_names_editor.Visible = true;
               com_names_editor.Location = new System.Drawing.Point(116, 45);
               speed_editor.Visible = false;
               ip_editor.Visible = false;
               port_editor.Visible = false;

               com_names_editor.SelectedIndex = getSelectedIndex(com_settings.USBComName, com_names);
               label2.Text = "Nazwa";
               label3.Text = "";
               break;
            case 2: // TCP Server
               com_names_editor.Visible = false;
               speed_editor.Visible = false;
               ip_editor.Visible = false;
               port_editor.Visible = true;
               port_editor.Location = new System.Drawing.Point(116, 45);

               port_editor.Text = com_settings.TCPServerPort.ToString();
               label2.Text = "Port";
               label3.Text = "";
               break;
            case 3: // TCP Client
               com_names_editor.Visible = false;
               speed_editor.Visible = false;
               ip_editor.Visible = true;
               ip_editor.Location = new System.Drawing.Point(116, 45);
               port_editor.Visible = true;
               port_editor.Location = new System.Drawing.Point(116, 72);

               ip_editor.Text = com_settings.TCPClientIP;
               port_editor.Text = com_settings.TCPClientPort.ToString();
               label2.Text = "Adres";
               label3.Text = "Port";
               break;
            case 4: // WebSocket Server
               com_names_editor.Visible = false;
               speed_editor.Visible = false;
               ip_editor.Visible = false;
               port_editor.Visible = true;
               port_editor.Location = new System.Drawing.Point(116, 45);

               port_editor.Text = com_settings.WebSocketServerPort.ToString();
               label2.Text = "Port";
               label3.Text = "";
               break;
            case 5: // WebSocket Client
               com_names_editor.Visible = false;
               speed_editor.Visible = false;
               ip_editor.Visible = true;
               ip_editor.Location = new System.Drawing.Point(116, 45);
               port_editor.Visible = true;
               port_editor.Location = new System.Drawing.Point(116, 72);

               ip_editor.Text = com_settings.WebSocketClientIP;
               port_editor.Text = com_settings.WebSocketClientPort.ToString();
               label2.Text = "Adres";
               label3.Text = "Port";
               break;
         }
      }

      private string[] getComPorts()
      {
         List<string> cn = new List<string>();
         var ports = SerialPort.GetPortNames();
         string[] sortedList;

         try {
            sortedList = ports.OrderBy(port => Convert.ToInt32(port.Replace("COM", string.Empty))).ToArray();
         }
         catch {
            sortedList = ports;
         }

         foreach (string s in sortedList) {
            if (!s.Contains("COM"))
               continue;
            cn.Add(s);
         }

         return cn.ToArray();
      }

      private int getSelectedIndex(string val, string[]arr)
      {
         for(int i=0; i<arr.Length; i++) {
            if (arr[i].CompareTo(val) == 0)
               return i;
         }
         return 0;
      }

      private int getSelectedIndex(int val, int[] arr)
      {
         for (int i = 0; i < arr.Length; i++) {
            if (arr[i].CompareTo(val) == 0)
               return i;
         }
         return 0;
      }
   }
}
