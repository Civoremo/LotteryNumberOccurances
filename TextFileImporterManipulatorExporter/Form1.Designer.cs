namespace TextFileImporterManipulatorExporter
{
    partial class MainForm
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
            this.listTextFileDisplay = new System.Windows.Forms.ListBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.listTextCollection = new System.Windows.Forms.ListBox();
            this.listBoxCounted = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listTextFileDisplay
            // 
            this.listTextFileDisplay.FormattingEnabled = true;
            this.listTextFileDisplay.Location = new System.Drawing.Point(12, 55);
            this.listTextFileDisplay.Name = "listTextFileDisplay";
            this.listTextFileDisplay.Size = new System.Drawing.Size(156, 173);
            this.listTextFileDisplay.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(93, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // listTextCollection
            // 
            this.listTextCollection.FormattingEnabled = true;
            this.listTextCollection.Location = new System.Drawing.Point(174, 55);
            this.listTextCollection.Name = "listTextCollection";
            this.listTextCollection.Size = new System.Drawing.Size(148, 173);
            this.listTextCollection.TabIndex = 3;
            // 
            // listBoxCounted
            // 
            this.listBoxCounted.FormattingEnabled = true;
            this.listBoxCounted.Location = new System.Drawing.Point(328, 55);
            this.listBoxCounted.Name = "listBoxCounted";
            this.listBoxCounted.Size = new System.Drawing.Size(150, 173);
            this.listBoxCounted.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 250);
            this.Controls.Add(this.listBoxCounted);
            this.Controls.Add(this.listTextCollection);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.listTextFileDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Text File Import/Export App";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listTextFileDisplay;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox listTextCollection;
        private System.Windows.Forms.ListBox listBoxCounted;
    }
}

