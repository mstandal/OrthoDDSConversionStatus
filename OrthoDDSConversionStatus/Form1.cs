using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace OrthoDDSConversionStatus
{
    public partial class Form1 : Form
    {
        Int32 JPGFileCount = 0;
        Int32 DDSFileCount = 0;
        int PercentageComplete = 0;

        String FolderPath = "";
       
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static Int32 GetFileCount(String ImportFolder, String FileMask)
        {
            string sErrorString;
            String[] files;
            Int32 FileCount = 0;
            try
            {

                files = Directory.GetFiles(ImportFolder, FileMask);

                // Sort the files so they're in date order.
                if (files.Length > 0)
                {
                    FileCount = files.Length;
                }

                return FileCount;
            }
            catch (UnauthorizedAccessException e)
            {
                sErrorString = String.Format("Directory.GetFiles(): {0}; {1}; [Path: {2}]",
                    e.Message,
                    e.Source,
                    ImportFolder
                    );
                // Log
                MessageBox.Show(sErrorString);
            }
            catch (ArgumentNullException e)
            {
                sErrorString = String.Format("Directory.GetFiles(): {0}; {1}; [Path: {2}]",
                    e.Message,
                    e.Source,
                    ImportFolder
                    );
                // Log
                MessageBox.Show(sErrorString);
            }
            catch (ArgumentException e)
            {
                sErrorString = String.Format("Directory.GetFiles(): {0}; {1}; [Path: {2}]",
                    e.Message,
                    e.Source,
                    ImportFolder
                    );
                // Log
                MessageBox.Show(sErrorString);
            }
            catch (PathTooLongException e)
            {
                sErrorString = String.Format("Directory.GetFiles(): {0}; {1}; [Path: {2}]",
                    e.Message,
                    e.Source,
                    ImportFolder
                    );
                // Log
                MessageBox.Show(sErrorString);
            }
            catch (DirectoryNotFoundException e)
            {
                sErrorString = String.Format("Directory.GetFiles(): {0}; {1}; [Path: {2}]",
                    e.Message,
                    e.Source,
                    ImportFolder
                    );
                // Log
                MessageBox.Show(sErrorString);
            }

            return -1;
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();

            DialogResult result = folder.ShowDialog();

            if(result != DialogResult.Abort || result != DialogResult.Cancel || result != DialogResult.No)
            {
                FolderPath = folder.SelectedPath;
                lblFolderPath.Text = String.Format("Folder: {0}", FolderPath);
                GetJPGFileCount();
                StartTimer();
            }
        }

        private void GetJPGFileCount()
        {
            JPGFileCount = GetFileCount(FolderPath, "*.JPG");
            lblJpgCount.Text = String.Format("JPG Count: {0}", JPGFileCount); 
        }

        private void GetDDSFileCount()
        {
            DDSFileCount = GetFileCount(FolderPath, "*.DDS");
            lblDDSCount.Text = String.Format("DDS Count: {0}", DDSFileCount);
        }

        private void StartTimer()
        {
            timer1.Enabled = true;
        }

        private void SetPercentageDone()
        {
            PercentageComplete = (int)(0.5f + ((100f * DDSFileCount) / JPGFileCount));
            lblPercentageComplete.Text = String.Format("{0}% Complete", PercentageComplete);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetDDSFileCount();
            SetPercentageDone();
        }
    }

    
}
