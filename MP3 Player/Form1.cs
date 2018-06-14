/* Made by TheDarkJoker94. 
*  Check http://thedarkjoker94.cer33.com/ for more C# Tutorials 
*  and also SUBSCRIBE to my Youtube Channel http://www.youtube.com/user/TheDarkJoker094 
*  Thanks! */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MP3_Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] files, paths;
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = openFileDialog1.SafeFileNames; // Save only the names
                paths = openFileDialog1.FileNames; // Save the full paths
                for (int i = 0; i < files.Length; i++)
                {
                    listBox1.Items.Add(files[i]); // Add songs to the listbox
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = paths[listBox1.SelectedIndex]; // Play the song  
        }
    }
}
