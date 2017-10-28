namespace MovieDB
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
            this.OpenFile_Button = new System.Windows.Forms.Button();
            this.File_Label = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.MoviesInTree_Label = new System.Windows.Forms.Label();
            this.MoviesInFile_Label = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Output_TextBox = new System.Windows.Forms.TextBox();
            this.Search_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Search_TextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenFile_Button
            // 
            this.OpenFile_Button.Location = new System.Drawing.Point(12, 12);
            this.OpenFile_Button.Name = "OpenFile_Button";
            this.OpenFile_Button.Size = new System.Drawing.Size(75, 23);
            this.OpenFile_Button.TabIndex = 0;
            this.OpenFile_Button.Text = "Open File";
            this.OpenFile_Button.UseVisualStyleBackColor = true;
            this.OpenFile_Button.Click += new System.EventHandler(this.OpenFile_Button_Click);
            // 
            // File_Label
            // 
            this.File_Label.AutoSize = true;
            this.File_Label.Location = new System.Drawing.Point(12, 38);
            this.File_Label.Name = "File_Label";
            this.File_Label.Size = new System.Drawing.Size(66, 13);
            this.File_Label.TabIndex = 1;
            this.File_Label.Text = "Current File: ";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.MoviesInTree_Label);
            this.splitContainer1.Panel1.Controls.Add(this.MoviesInFile_Label);
            this.splitContainer1.Panel1.Controls.Add(this.OpenFile_Button);
            this.splitContainer1.Panel1.Controls.Add(this.File_Label);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(501, 267);
            this.splitContainer1.SplitterDistance = 62;
            this.splitContainer1.TabIndex = 2;
            // 
            // MoviesInTree_Label
            // 
            this.MoviesInTree_Label.AutoSize = true;
            this.MoviesInTree_Label.Location = new System.Drawing.Point(262, 17);
            this.MoviesInTree_Label.Name = "MoviesInTree_Label";
            this.MoviesInTree_Label.Size = new System.Drawing.Size(84, 13);
            this.MoviesInTree_Label.TabIndex = 3;
            this.MoviesInTree_Label.Text = "Movies In Tree: ";
            // 
            // MoviesInFile_Label
            // 
            this.MoviesInFile_Label.AutoSize = true;
            this.MoviesInFile_Label.Location = new System.Drawing.Point(93, 17);
            this.MoviesInFile_Label.Name = "MoviesInFile_Label";
            this.MoviesInFile_Label.Size = new System.Drawing.Size(78, 13);
            this.MoviesInFile_Label.TabIndex = 2;
            this.MoviesInFile_Label.Text = "Movies In File: ";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.textBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.Output_TextBox);
            this.splitContainer2.Panel2.Controls.Add(this.Search_Button);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Panel2.Controls.Add(this.Search_TextBox);
            this.splitContainer2.Size = new System.Drawing.Size(501, 201);
            this.splitContainer2.SplitterDistance = 269;
            this.splitContainer2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(269, 201);
            this.textBox1.TabIndex = 0;
            // 
            // Output_TextBox
            // 
            this.Output_TextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Output_TextBox.Location = new System.Drawing.Point(0, 77);
            this.Output_TextBox.Multiline = true;
            this.Output_TextBox.Name = "Output_TextBox";
            this.Output_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Output_TextBox.Size = new System.Drawing.Size(228, 124);
            this.Output_TextBox.TabIndex = 3;
            // 
            // Search_Button
            // 
            this.Search_Button.Location = new System.Drawing.Point(141, 48);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(75, 23);
            this.Search_Button.TabIndex = 2;
            this.Search_Button.Text = "Search";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Movie Title to Search For";
            // 
            // Search_TextBox
            // 
            this.Search_TextBox.Location = new System.Drawing.Point(6, 22);
            this.Search_TextBox.Name = "Search_TextBox";
            this.Search_TextBox.Size = new System.Drawing.Size(210, 20);
            this.Search_TextBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 267);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenFile_Button;
        private System.Windows.Forms.Label File_Label;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label MoviesInFile_Label;
        private System.Windows.Forms.Label MoviesInTree_Label;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Search_TextBox;
        private System.Windows.Forms.TextBox Output_TextBox;
    }
}

