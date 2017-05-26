using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client_script_installer
{
    public partial class Installer : Form
    {
        string pathToScript = String.Empty;
        public Installer()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void csgopathbutton_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(openFileDialog1.FileName);
                if (openFileDialog1.FileName.Contains("csgo.exe"))
                {
                    pathToScript = openFileDialog1.FileName.Replace("csgo.exe", "csgo\\cfg\\gamestate_integration_consolesample.cfg");
                    string scriptPayload = "Oh hello.";
                    System.IO.File.WriteAllText(pathToScript, scriptPayload);
                    MessageBox.Show("OK");
                }
                else
                {

                }
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
