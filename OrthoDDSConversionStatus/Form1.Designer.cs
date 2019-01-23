namespace OrthoDDSConversionStatus
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.lblJpgCount = new System.Windows.Forms.Label();
            this.lblDDSCount = new System.Windows.Forms.Label();
            this.lblPercentageComplete = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.lblFolderPath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblJpgCount
            // 
            this.lblJpgCount.AutoSize = true;
            this.lblJpgCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJpgCount.Location = new System.Drawing.Point(45, 85);
            this.lblJpgCount.Name = "lblJpgCount";
            this.lblJpgCount.Size = new System.Drawing.Size(111, 20);
            this.lblJpgCount.TabIndex = 1;
            this.lblJpgCount.Text = "JPG Count:0";
            // 
            // lblDDSCount
            // 
            this.lblDDSCount.AutoSize = true;
            this.lblDDSCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDDSCount.Location = new System.Drawing.Point(45, 114);
            this.lblDDSCount.Name = "lblDDSCount";
            this.lblDDSCount.Size = new System.Drawing.Size(115, 20);
            this.lblDDSCount.TabIndex = 2;
            this.lblDDSCount.Text = "DDS Count:0";
            // 
            // lblPercentageComplete
            // 
            this.lblPercentageComplete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPercentageComplete.AutoSize = true;
            this.lblPercentageComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentageComplete.Location = new System.Drawing.Point(172, 146);
            this.lblPercentageComplete.Name = "lblPercentageComplete";
            this.lblPercentageComplete.Size = new System.Drawing.Size(115, 20);
            this.lblPercentageComplete.TabIndex = 3;
            this.lblPercentageComplete.Text = "0% Complete";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(49, 33);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(97, 23);
            this.btnSelectFolder.TabIndex = 4;
            this.btnSelectFolder.Text = "Select Folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // lblFolderPath
            // 
            this.lblFolderPath.AutoSize = true;
            this.lblFolderPath.Location = new System.Drawing.Point(49, 63);
            this.lblFolderPath.Name = "lblFolderPath";
            this.lblFolderPath.Size = new System.Drawing.Size(100, 13);
            this.lblFolderPath.TabIndex = 5;
            this.lblFolderPath.Text = "Folder not selected.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 209);
            this.Controls.Add(this.lblFolderPath);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.lblPercentageComplete);
            this.Controls.Add(this.lblDDSCount);
            this.Controls.Add(this.lblJpgCount);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Ortho JPG to DDS Status";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblJpgCount;
        private System.Windows.Forms.Label lblDDSCount;
        private System.Windows.Forms.Label lblPercentageComplete;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Label lblFolderPath;
    }
}

