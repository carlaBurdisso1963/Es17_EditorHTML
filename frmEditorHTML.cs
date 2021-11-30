using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es17_EditorHTML
{
    public partial class frmEditorHTML : Form
    {
        public frmEditorHTML()
        {
            InitializeComponent();
        }
        private void frmEditorHTML_Load(object sender, EventArgs e)
        {
            webBrowserHTML.Navigate("http:\\www.vallauri.edu");
        }
        private void nuovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu Nuovo");
        }

        private void nuovoToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ToolStrip Nuovo");
        }

        private void tabControlHTML_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage.Name == "tabPageWEB")
                webBrowserHTML.DocumentText = txtHTML.Text;
        }
    }
}
