using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;

namespace Controls
{
    public partial class Controls : Form
    {
       

        public Controls()
        {
            InitializeComponent();
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            key.SetValue("Controls", Application.ExecutablePath);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            this.Left -= -1150;
            this.Size = new Size(121, 404);
           
            

        }

        

        
        

        private void label6_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.itworldinnovate.com");
        }

        

        

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 0");
            

        }

        

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            DialogResult r;
            string rr = "iT World Innovate is an iT firm that deals with \n Web Development \n App Development \n Software Development \n Graphic Design \n Video Editing \n Animations \n Photography \n Windows Installation \n And many more \n Contact Us Now on: \n 0248520036 \n 0501590493 \n 0545384910 \n \n Do you want to visit our instagram page?";
            r=MessageBox.Show(rr,"iT World Innovate",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if(r==DialogResult.Yes)
            {
                Process.Start("http://www.instagram.com/itworldinnovate");

            }
            else if(r==DialogResult.No)
            {
                string title = System.Windows.Forms.SystemInformation.UserName;
              
                MessageBox.Show("Hello! " + title +", Please kindly check our instagram page next time", "iT World Innovate", MessageBoxButtons.OK, MessageBoxIcon.Information);


            } 
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\WINDOWS\system32\rundll32.exe", "User32.dll,LockWorkStation");
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/r /t 0");
          
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            Application.SetSuspendState(PowerState.Suspend, true, true);
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Application.SetSuspendState(PowerState.Hibernate, true, true);
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToString("hh:mm:ss");

        }

       

     
        
       

        

        

        
        

        
        

       
       
        
       
       
       

        
    }
}
