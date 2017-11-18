using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lv2ObjektnoProgramiranje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile1 = new OpenFileDialog();
            openFile1.Filter = "Text Files|*.rtf";

            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
               richTextBox1.LoadFile(openFile1.FileName, RichTextBoxStreamType.RichText);
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFile1.FileName.Length > 0)
            {
                richTextBox1.SaveFile(saveFile1.FileName);
            }
        }

        private void font_Click(object sender, EventArgs e)
        {
            FontDialog fontD = new FontDialog();
            fontD.ShowDialog();
            richTextBox1.SelectionFont = fontD.Font;
        }

        private void color_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.ShowDialog();
            richTextBox1.SelectionColor = color.Color;
        }

        private void button2_Click(object sender, EventArgs e) //REDO
        {
            richTextBox1.Redo();
        }

        private void undo_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void cut_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();

        }

        private void copy_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();

        }

        private void paste_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }
    }
}
