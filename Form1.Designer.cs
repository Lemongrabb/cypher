namespace Cypher
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.topPanel = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.inputText = new System.Windows.Forms.RichTextBox();
            this.cypherSelector = new System.Windows.Forms.ComboBox();
            this.outputText = new System.Windows.Forms.RichTextBox();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.logo);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(800, 90);
            this.topPanel.TabIndex = 0;
            // 
            // logo
            // 
            //this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(291, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(218, 65);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(149, 135);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(100, 96);
            this.inputText.TabIndex = 1;
            this.inputText.Text = "";
            this.inputText.TextChanged += new System.EventHandler(this.inputText_TextChanged);
            // 
            // cypherSelector
            // 
            this.cypherSelector.DisplayMember = "Text";
            this.cypherSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cypherSelector.FormattingEnabled = true;
            this.cypherSelector.Items.AddRange(new object[] {
            "Szyfr Cezara",
            "Szyfr podsawieniowy"});
            this.cypherSelector.Location = new System.Drawing.Point(332, 167);
            this.cypherSelector.Name = "cypherSelector";
            this.cypherSelector.Size = new System.Drawing.Size(121, 23);
            this.cypherSelector.TabIndex = 2;
            this.cypherSelector.ValueMember = "ID";
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(582, 149);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(100, 96);
            this.outputText.TabIndex = 3;
            this.outputText.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.cypherSelector);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.topPanel);
            this.Name = "Cypher";
            this.Text = "Cypher";
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox logo;
        public System.Windows.Forms.RichTextBox inputText;
        private System.Windows.Forms.ComboBox cypherSelector;
        private System.Windows.Forms.RichTextBox outputText;
    }
}

