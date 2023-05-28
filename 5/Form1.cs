using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void selectAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            editorRichTextBox.SelectAll();
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            editorRichTextBox.Cut();
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            editorRichTextBox.Copy();
        }

        private void pasetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editorRichTextBox.Paste();
        }

        private void fontButton_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                editorRichTextBox.SelectionFont = fontDialog.Font;
            }
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                editorRichTextBox.SelectionColor = colorDialog.Color;
            }
        }
    }
}
