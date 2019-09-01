using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Restore_Mcafee_BUP_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
           // yeah boi
        }

        private void tbFile_DragDrop(object sender, DragEventArgs e)
        {
            string[] FilesFromDragDrop = (string[])e.Data.GetData(DataFormats.FileDrop);
            for (int x = 0; x < FilesFromDragDrop.Length; x++)
            {

                DateTime time = DateTime.Now;
                string format = "M-d-yyyy-hh-mm-ss";
                string newfilename = FilesFromDragDrop[x] + "__" + time.ToString(format) + ".restored";
                byte[] buffer1 = File.ReadAllBytes(FilesFromDragDrop[x]);
                if(buffer1.Length < 2048)
                {
                    tbresult.Text += "File is too small to be a BUP File (less than 2048 bytes), skipping!\r\n";
                    continue;
                }
                byte[] resultBuffer = new byte[buffer1.Length];
                for (int i = 0; i < buffer1.Length; i++)
                {
                    resultBuffer[i] = (byte)(buffer1[i] ^ 0x6a);
                }
                try
                {
                    byte[] bytes = resultBuffer.Skip(2048).ToArray<byte>();
                    File.WriteAllBytes(newfilename, bytes);
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Error! Cannot write to folder! You may not have permissions! Try re-launching with admin or place item in a folder you have access to!", "Error!");
                    tbresult.Text = "Error writing to folder. No permissions!\r\n";
                    continue;

                }
                tbresult.Text += "Saved to " + newfilename + "\r\n";
                
            }
            
        }


        private void tbFile_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        
    }
}
