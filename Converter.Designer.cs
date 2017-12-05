﻿namespace Echoes
{
    partial class Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Converter));
            this.convertButton = new ModifiedControls.ModifiedButton();
            this.loadingProgress = new ModifiedControls.ModifiedProgressBar();
            this.convertWorker = new System.ComponentModel.BackgroundWorker();
            this.outputPathText = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.convertList = new System.Windows.Forms.ListBox();
            this.outputPathButton = new ModifiedControls.ModifiedButton();
            this.SuspendLayout();
            // 
            // convertButton
            // 
            this.convertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.convertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertButton.Font = new System.Drawing.Font("White Rabbit", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.convertButton.Location = new System.Drawing.Point(579, 144);
            this.convertButton.Margin = new System.Windows.Forms.Padding(2);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(72, 36);
            this.convertButton.TabIndex = 45;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = false;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // loadingProgress
            // 
            this.loadingProgress.Location = new System.Drawing.Point(11, 185);
            this.loadingProgress.Name = "loadingProgress";
            this.loadingProgress.Size = new System.Drawing.Size(640, 23);
            this.loadingProgress.TabIndex = 47;
            // 
            // convertWorker
            // 
            this.convertWorker.WorkerReportsProgress = true;
            this.convertWorker.WorkerSupportsCancellation = true;
            this.convertWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.convertWorker_DoWork);
            this.convertWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.convertWorker_ProgressChanged);
            this.convertWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.convertWorker_RunWorkerCompleted);
            // 
            // outputPathText
            // 
            this.outputPathText.Location = new System.Drawing.Point(11, 160);
            this.outputPathText.Name = "outputPathText";
            this.outputPathText.Size = new System.Drawing.Size(522, 20);
            this.outputPathText.TabIndex = 48;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(12, 144);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(39, 13);
            this.outputLabel.TabIndex = 49;
            this.outputLabel.Text = "Output";
            // 
            // convertList
            // 
            this.convertList.FormattingEnabled = true;
            this.convertList.Location = new System.Drawing.Point(11, 12);
            this.convertList.Name = "convertList";
            this.convertList.Size = new System.Drawing.Size(640, 121);
            this.convertList.TabIndex = 50;
            // 
            // outputPathButton
            // 
            this.outputPathButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.outputPathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outputPathButton.Font = new System.Drawing.Font("White Rabbit", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputPathButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.outputPathButton.Location = new System.Drawing.Point(538, 160);
            this.outputPathButton.Margin = new System.Windows.Forms.Padding(2);
            this.outputPathButton.Name = "outputPathButton";
            this.outputPathButton.Size = new System.Drawing.Size(37, 20);
            this.outputPathButton.TabIndex = 51;
            this.outputPathButton.Text = "...";
            this.outputPathButton.UseVisualStyleBackColor = false;
            this.outputPathButton.Click += new System.EventHandler(this.outputPathButton_Click);
            // 
            // Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 214);
            this.Controls.Add(this.outputPathButton);
            this.Controls.Add(this.convertList);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.outputPathText);
            this.Controls.Add(this.loadingProgress);
            this.Controls.Add(this.convertButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Converter";
            this.Text = "Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ModifiedControls.ModifiedButton convertButton;
        private ModifiedControls.ModifiedProgressBar loadingProgress;
        private System.ComponentModel.BackgroundWorker convertWorker;
        private System.Windows.Forms.TextBox outputPathText;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.ListBox convertList;
        private ModifiedControls.ModifiedButton outputPathButton;
    }
}