using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_installer
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();

            MaximizeBox = false;
            TopMost = true;


            Process.Start("microsoft-edge:");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string msiafterburner = "https://msi.ru.com/Windows-10/MSI-Afterburner.exe";
            Process.Start(msiafterburner);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string aimp = "https://www.aimp.ru/?do=download.file&id=3";
            Process.Start(aimp);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string discord = "https://discord.com/api/downloads/distributions/app/installers/latest?channel=stable&platform=win&arch=x86";
            Process.Start(discord);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string amdadrenalin = "https://drivers.amd.com/drivers/installer/23.30/whql/amd-software-adrenalin-edition-23.12.1-minimalsetup-231205_web.exe";
            Process.Start(amdadrenalin);
        }

        private void geforceexperiencebutton_Click(object sender, EventArgs e)
        {
            string geforceexperience = "https://ru.download.nvidia.com/GFE/GFEClient/3.27.0.120/GeForce_Experience_v3.27.0.120.exe";
            Process.Start(geforceexperience);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            string steam = "https://cdn.cloudflare.steamstatic.com/client/installer/SteamSetup.exe";
            Process.Start(steam);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            string geforceexperience = "https://ru.download.nvidia.com/GFE/GFEClient/3.27.0.120/GeForce_Experience_v3.27.0.120.exe";
            Process.Start(geforceexperience);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://docs.google.com/forms/d/e/1FAIpQLSdUTeYOW-Mn5GNE1R_LwGQTrdqwRUrFBDd0A7AjgYjk3-Ffcg/viewform?usp=sf_link");
        }

        private void winrarlabel_Click(object sender, EventArgs e)
        {

        }

        private void winrarbutton_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.rarlab.com/rar/winrar-x64-700b3.exe");
        }

        private void sevenzipbutton_Click(object sender, EventArgs e)
        {
            Process.Start("https://7-zip.org/a/7z2301-x64.exe");
        }

        private void epicgamesbutton_Click(object sender, EventArgs e)
        {
            Process.Start("https://launcher-public-service-prod06.ol.epicgames.com/launcher/api/installer/download/EpicGamesLauncherInstaller.msi");
        }
    }
}
