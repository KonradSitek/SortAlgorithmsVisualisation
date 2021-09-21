
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
            this.RadixButton = new System.Windows.Forms.Button();
            this.MergeButton = new System.Windows.Forms.Button();
            this.InsertionButton = new System.Windows.Forms.Button();
            this.QuickButton = new System.Windows.Forms.Button();
            this.SelectionButton = new System.Windows.Forms.Button();
            this.HeapButton = new System.Windows.Forms.Button();
            this.BubbleButton = new System.Windows.Forms.Button();
            this.BanerPanel = new System.Windows.Forms.Panel();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuPanel.SuspendLayout();
            this.BanerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ActionPanel
            // 
            this.ActionPanel.AutoSize = true;
            this.ActionPanel.BackColor = System.Drawing.Color.Lavender;
            this.ActionPanel.Location = new System.Drawing.Point(200, 78);
            this.ActionPanel.Name = "ActionPanel";
            this.ActionPanel.Size = new System.Drawing.Size(742, 451);
            this.ActionPanel.TabIndex = 0;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.MenuPanel.Controls.Add(this.label1);
            this.MenuPanel.Controls.Add(this.RadixButton);
            this.MenuPanel.Controls.Add(this.MergeButton);
            this.MenuPanel.Controls.Add(this.InsertionButton);
            this.MenuPanel.Controls.Add(this.QuickButton);
            this.MenuPanel.Controls.Add(this.SelectionButton);
            this.MenuPanel.Controls.Add(this.HeapButton);
            this.MenuPanel.Controls.Add(this.BubbleButton);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(200, 529);
            this.MenuPanel.TabIndex = 0;
            // 
            // RadixButton
            // 
            this.RadixButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.RadixButton.FlatAppearance.BorderSize = 0;
            this.RadixButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RadixButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RadixButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RadixButton.Location = new System.Drawing.Point(0, 456);
            this.RadixButton.Margin = new System.Windows.Forms.Padding(0);
            this.RadixButton.Name = "RadixButton";
            this.RadixButton.Size = new System.Drawing.Size(200, 73);
            this.RadixButton.TabIndex = 6;
            this.RadixButton.Text = "Radix";
            this.RadixButton.UseVisualStyleBackColor = false;
            this.RadixButton.Click += new System.EventHandler(this.RadixButton_Click);
            // 
            // MergeButton
            // 
            this.MergeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.MergeButton.FlatAppearance.BorderSize = 0;
            this.MergeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MergeButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MergeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MergeButton.Location = new System.Drawing.Point(0, 398);
            this.MergeButton.Margin = new System.Windows.Forms.Padding(0);
            this.MergeButton.Name = "MergeButton";
            this.MergeButton.Size = new System.Drawing.Size(200, 64);
            this.MergeButton.TabIndex = 5;
            this.MergeButton.Text = "Merge";
            this.MergeButton.UseVisualStyleBackColor = false;
            this.MergeButton.Click += new System.EventHandler(this.MergeButton_Click);
            // 
            // InsertionButton
            // 
            this.InsertionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.InsertionButton.FlatAppearance.BorderSize = 0;
            this.InsertionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertionButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InsertionButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.InsertionButton.Location = new System.Drawing.Point(0, 334);
            this.InsertionButton.Margin = new System.Windows.Forms.Padding(0);
            this.InsertionButton.Name = "InsertionButton";
            this.InsertionButton.Size = new System.Drawing.Size(200, 64);
            this.InsertionButton.TabIndex = 4;
            this.InsertionButton.Text = "Insertion";
            this.InsertionButton.UseVisualStyleBackColor = false;
            this.InsertionButton.Click += new System.EventHandler(this.InsertionButton_Click);
            // 
            // QuickButton
            // 
            this.QuickButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.QuickButton.FlatAppearance.BorderSize = 0;
            this.QuickButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuickButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.QuickButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.QuickButton.Location = new System.Drawing.Point(0, 206);
            this.QuickButton.Margin = new System.Windows.Forms.Padding(0);
            this.QuickButton.Name = "QuickButton";
            this.QuickButton.Size = new System.Drawing.Size(200, 64);
            this.QuickButton.TabIndex = 3;
            this.QuickButton.Text = "Quick";
            this.QuickButton.UseVisualStyleBackColor = false;
            this.QuickButton.Click += new System.EventHandler(this.QuickButton_Click);
            // 
            // SelectionButton
            // 
            this.SelectionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.SelectionButton.FlatAppearance.BorderSize = 0;
            this.SelectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectionButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SelectionButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SelectionButton.Location = new System.Drawing.Point(3, 270);
            this.SelectionButton.Margin = new System.Windows.Forms.Padding(0);
            this.SelectionButton.Name = "SelectionButton";
            this.SelectionButton.Size = new System.Drawing.Size(200, 64);
            this.SelectionButton.TabIndex = 2;
            this.SelectionButton.Text = "Selection";
            this.SelectionButton.UseVisualStyleBackColor = false;
            this.SelectionButton.Click += new System.EventHandler(this.SelectionButton_Click);
            // 
            // HeapButton
            // 
            this.HeapButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.HeapButton.FlatAppearance.BorderSize = 0;
            this.HeapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HeapButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HeapButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HeapButton.Location = new System.Drawing.Point(0, 142);
            this.HeapButton.Margin = new System.Windows.Forms.Padding(0);
            this.HeapButton.Name = "HeapButton";
            this.HeapButton.Size = new System.Drawing.Size(200, 64);
            this.HeapButton.TabIndex = 1;
            this.HeapButton.Text = "Heap";
            this.HeapButton.UseVisualStyleBackColor = false;
            this.HeapButton.Click += new System.EventHandler(this.HeapButton_Click);
            // 
            // BubbleButton
            // 
            this.BubbleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.BubbleButton.FlatAppearance.BorderSize = 0;
            this.BubbleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BubbleButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BubbleButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BubbleButton.Location = new System.Drawing.Point(-3, 78);
            this.BubbleButton.Margin = new System.Windows.Forms.Padding(0);
            this.BubbleButton.Name = "BubbleButton";
            this.BubbleButton.Size = new System.Drawing.Size(200, 64);
            this.BubbleButton.TabIndex = 0;
            this.BubbleButton.Text = "Bubble";
            this.BubbleButton.UseVisualStyleBackColor = false;
            this.BubbleButton.Click += new System.EventHandler(this.BubbleButton_Click);
            // 
            // BanerPanel
            // 
            this.BanerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.BanerPanel.Controls.Add(this.GenerateButton);
            this.BanerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BanerPanel.Location = new System.Drawing.Point(200, 0);
            this.BanerPanel.Name = "BanerPanel";
            this.BanerPanel.Size = new System.Drawing.Size(742, 82);
            this.BanerPanel.TabIndex = 0;
            // 
            // GenerateButton
            // 
            this.GenerateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.GenerateButton.FlatAppearance.BorderSize = 0;
            this.GenerateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GenerateButton.ForeColor = System.Drawing.Color.White;
            this.GenerateButton.Location = new System.Drawing.Point(223, 3);
            this.GenerateButton.Margin = new System.Windows.Forms.Padding(0);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(212, 79);
            this.GenerateButton.TabIndex = 0;
            this.GenerateButton.Text = "New array";
            this.GenerateButton.UseVisualStyleBackColor = false;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Centaur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 82);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select Type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(942, 529);
            this.Controls.Add(this.BanerPanel);
            this.Controls.Add(this.ActionPanel);
            this.Controls.Add(this.MenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainWindow";
            this.Text = "Sort Algorithms Visualisation";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.MenuPanel.ResumeLayout(false);
            this.BanerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button InsertionButton;
        private System.Windows.Forms.Button MergeButton;
        private System.Windows.Forms.Button RadixButton;
        private System.Windows.Forms.Label label1;
    }
}

