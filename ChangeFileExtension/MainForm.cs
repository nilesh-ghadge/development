using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeFileExtension
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        // Opens up a folder browser dialog when you click on the ellipsis button
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = folderBrowserDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtBox_selectedDirectory.Text = folderBrowserDialog1.SelectedPath;
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Exception while selecting a directory: " + ex.Message,"Error",MessageBoxButtons.OK);
            }
        }

        // Recursively searches from the selected directory for files with matching extension
        internal void SearchDirectory(string sDir)
        {
            try
            {
                string extension = "*" + cmbBox_selectedExtension.SelectedItem;
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    foreach (string f in Directory.GetFiles(d,extension))
                    {                        
                        lstBox_directoryContents.Items.Add(f);   
                    }
                    SearchDirectory(d);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception while searching the directory: " + ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        //Selects all the items in the listbox for directory files
        private void chkBox_selectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox_selectAll.CheckState == CheckState.Checked)
            {
                for (int i = 0; i < lstBox_directoryContents.Items.Count; i++)
                {
                    lstBox_directoryContents.SetSelected(i, true);
                }
            }
            else {
                lstBox_directoryContents.SelectedIndex = -1;
            }
        }

        private void cmbBox_selectedExtension_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstBox_directoryContents.Items.Clear();
            SearchDirectory(folderBrowserDialog1.SelectedPath);
        }

        //Function which actually changes the file extensions of the selected files. 
        private void btn_changeFileExtension_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbBox_targetExtension.SelectedIndex != -1 && lstBox_directoryContents.SelectedIndex != -1)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to move the selected files from " + cmbBox_selectedExtension.SelectedItem.ToString() + " to " + cmbBox_targetExtension.SelectedItem.ToString() + "?","Confirm Move?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        progressBar.Visible = true;
                        progressBar.Value = 10;
                        string targetExtension = cmbBox_targetExtension.SelectedItem.ToString();
                        var listOfFileNames = lstBox_directoryContents.SelectedItems;
                        int count = 0;
                        foreach (var item in listOfFileNames)
                        {
                            if (count == listOfFileNames.Count / 2) {
                                progressBar.Value = 50;
                            }
                            if (count == listOfFileNames.Count) {
                                progressBar.Value = 100;
                            }
                            count++;
                            File.Move(item.ToString(), Path.ChangeExtension(item.ToString(), targetExtension));
                        }
                        progressBar.Visible = false;
                        MessageBox.Show("File extensions have been changed successfully", "Success", MessageBoxButtons.OK);
                        ClearUpUI();
                    }
                }
                else {
                    if (lstBox_directoryContents.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please select atleast one file", "Error", MessageBoxButtons.OK);
                        lstBox_directoryContents.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Please select a target extension", "Error", MessageBoxButtons.OK);
                        cmbBox_targetExtension.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception while changing file extensions: " + ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        //Function to clear up the UI after a successful execution
        internal void ClearUpUI() {
            try
            {
                lstBox_directoryContents.Items.Clear();
                chkBox_selectAll.Checked = false;
            }
            catch (Exception ex) {
                MessageBox.Show("Exception while clearing up UI: " + ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

    }
}
