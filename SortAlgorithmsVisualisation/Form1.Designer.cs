﻿
namespace SortAlgorithmsVisualisation
{
    partial class MainWindow
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
            this.ActionPanel = new System.Windows.Forms.Panel();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.BanerPanel = new System.Windows.Forms.Panel();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.BubbleButton = new System.Windows.Forms.Button();
            this.HeapButton = new System.Windows.Forms.Button();
            this.SelectionButton = new System.Windows.Forms.Button();
            this.QuickButton = new System.Windows.Forms.Button();
            this.MenuPanel.SuspendLayout();
            this.BanerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ActionPanel
            // 
            this.ActionPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ActionPanel.Location = new System.Drawing.Point(200, 71);
            this.ActionPanel.Name = "ActionPanel";
            this.ActionPanel.Size = new System.Drawing.Size(741, 459);
            this.ActionPanel.TabIndex = 0;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MenuPanel.Controls.Add(this.QuickButton);
            this.MenuPanel.Controls.Add(this.SelectionButton);
            this.MenuPanel.Controls.Add(this.HeapButton);
            this.MenuPanel.Controls.Add(this.BubbleButton);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(200, 530);
            this.MenuPanel.TabIndex = 0;
            // 
            // BanerPanel
            // 
            this.BanerPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BanerPanel.Controls.Add(this.GenerateButton);
            this.BanerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BanerPanel.Location = new System.Drawing.Point(200, 0);
            this.BanerPanel.Name = "BanerPanel";
            this.BanerPanel.Size = new System.Drawing.Size(741, 70);
            this.BanerPanel.TabIndex = 0;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(0, 0);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(212, 70);
            this.GenerateButton.TabIndex = 0;
            this.GenerateButton.Text = "Generate a new array";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // BubbleButton
            // 
            this.BubbleButton.Location = new System.Drawing.Point(0, 71);
            this.BubbleButton.Name = "BubbleButton";
            this.BubbleButton.Size = new System.Drawing.Size(200, 70);
            this.BubbleButton.TabIndex = 0;
            this.BubbleButton.Text = "Bubble";
            this.BubbleButton.UseVisualStyleBackColor = true;
            this.BubbleButton.Click += new System.EventHandler(this.BubbleButton_Click);
            // 
            // HeapButton
            // 
            this.HeapButton.Location = new System.Drawing.Point(0, 136);
            this.HeapButton.Name = "HeapButton";
            this.HeapButton.Size = new System.Drawing.Size(200, 70);
            this.HeapButton.TabIndex = 1;
            this.HeapButton.Text = "Heap";
            this.HeapButton.UseVisualStyleBackColor = true;
            this.HeapButton.Click += new System.EventHandler(this.HeapButton_Click);
            // 
            // SelectionButton
            // 
            this.SelectionButton.Location = new System.Drawing.Point(0, 202);
            this.SelectionButton.Name = "SelectionButton";
            this.SelectionButton.Size = new System.Drawing.Size(200, 70);
            this.SelectionButton.TabIndex = 2;
            this.SelectionButton.Text = "Selection";
            this.SelectionButton.UseVisualStyleBackColor = true;
            this.SelectionButton.Click += new System.EventHandler(this.SelectionButton_Click);
            // 
            // QuickButton
            // 
            this.QuickButton.Location = new System.Drawing.Point(0, 269);
            this.QuickButton.Name = "QuickButton";
            this.QuickButton.Size = new System.Drawing.Size(200, 70);
            this.QuickButton.TabIndex = 3;
            this.QuickButton.Text = "Quick";
            this.QuickButton.UseVisualStyleBackColor = true;
            this.QuickButton.Click += new System.EventHandler(this.QuickButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 530);
            this.Controls.Add(this.ActionPanel);
            this.Controls.Add(this.BanerPanel);
            this.Controls.Add(this.MenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainWindow";
            this.Text = "Sort Algorithms Visualisation";
            this.MenuPanel.ResumeLayout(false);
            this.BanerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ActionPanel;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel BanerPanel;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Button BubbleButton;
        private System.Windows.Forms.Button HeapButton;
        private System.Windows.Forms.Button SelectionButton;
        private System.Windows.Forms.Button QuickButton;
    }
}

