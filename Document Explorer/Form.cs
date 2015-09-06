using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Document_Explorer
{
    public partial class MainForm : Form
    {
        private void RefreshTagList()
        {
            Global.SelectedTagList = new List<string>();
            UI_TagList.Items.Clear();
            foreach (string tag in Global.TagList)
            {
                UI_TagList.Items.Add(tag); 
            }
        }

        private void RefreshDocumentList()
        {
            UI_DocumentList.Items.Clear();
            foreach (DocumentInfo doc in Global.DocumentList)
            {
                if (doc.MatchTag(Global.SelectedTagList))
                {
                    //Console.WriteLine(doc.Name);
                    UI_DocumentList.Items.Add(doc.Name);
                }
            }
            //Console.WriteLine("--------------");
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Global.Initialize();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.ReloadConfig();
            Global.RefreshList();
            RefreshTagList();
            RefreshDocumentList();
        }



        private void UI_TagList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                Global.SelectedTagList.Add(UI_TagList.Items[e.Index].ToString());
            }
            else
            {
                Global.SelectedTagList.Remove(UI_TagList.Items[e.Index].ToString());
            }
            RefreshDocumentList();
        }




    }
}
