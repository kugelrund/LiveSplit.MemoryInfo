namespace LiveSplit.MemoryInfo
{
    partial class TextStyleOverrideControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpTextStyleOverride = new System.Windows.Forms.TableLayoutPanel();
            this.chkOverrideFont = new System.Windows.Forms.CheckBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.chkOverrideColor = new System.Windows.Forms.CheckBox();
            this.tlpTextStyleOverride.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpTextStyleOverride
            // 
            this.tlpTextStyleOverride.ColumnCount = 2;
            this.tlpTextStyleOverride.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlpTextStyleOverride.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTextStyleOverride.Controls.Add(this.chkOverrideFont, 0, 1);
            this.tlpTextStyleOverride.Controls.Add(this.btnColor, 1, 0);
            this.tlpTextStyleOverride.Controls.Add(this.btnFont, 1, 1);
            this.tlpTextStyleOverride.Controls.Add(this.chkOverrideColor, 0, 0);
            this.tlpTextStyleOverride.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTextStyleOverride.Location = new System.Drawing.Point(0, 0);
            this.tlpTextStyleOverride.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTextStyleOverride.Name = "tlpTextStyleOverride";
            this.tlpTextStyleOverride.RowCount = 2;
            this.tlpTextStyleOverride.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTextStyleOverride.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTextStyleOverride.Size = new System.Drawing.Size(391, 81);
            this.tlpTextStyleOverride.TabIndex = 0;
            // 
            // chkOverrideFont
            // 
            this.chkOverrideFont.AutoSize = true;
            this.chkOverrideFont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkOverrideFont.Location = new System.Drawing.Point(3, 43);
            this.chkOverrideFont.Name = "chkOverrideFont";
            this.chkOverrideFont.Size = new System.Drawing.Size(124, 35);
            this.chkOverrideFont.TabIndex = 1;
            this.chkOverrideFont.Text = "Override Font:";
            this.chkOverrideFont.UseVisualStyleBackColor = true;
            this.chkOverrideFont.CheckedChanged += new System.EventHandler(this.chkOverrideFont_CheckedChanged);
            // 
            // btnColor
            // 
            this.btnColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnColor.Location = new System.Drawing.Point(133, 3);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(255, 34);
            this.btnColor.TabIndex = 0;
            this.btnColor.Text = "Choose...";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnFont
            // 
            this.btnFont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFont.Location = new System.Drawing.Point(133, 43);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(255, 35);
            this.btnFont.TabIndex = 1;
            this.btnFont.Text = "Choose...";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // chkOverrideColor
            // 
            this.chkOverrideColor.AutoSize = true;
            this.chkOverrideColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkOverrideColor.Location = new System.Drawing.Point(3, 3);
            this.chkOverrideColor.Name = "chkOverrideColor";
            this.chkOverrideColor.Size = new System.Drawing.Size(124, 34);
            this.chkOverrideColor.TabIndex = 2;
            this.chkOverrideColor.Text = "Override Color:";
            this.chkOverrideColor.UseVisualStyleBackColor = true;
            this.chkOverrideColor.CheckedChanged += new System.EventHandler(this.chkOverrideColor_CheckedChanged);
            // 
            // TextStyleOverrideControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpTextStyleOverride);
            this.Name = "TextStyleOverrideControl";
            this.Size = new System.Drawing.Size(391, 81);
            this.tlpTextStyleOverride.ResumeLayout(false);
            this.tlpTextStyleOverride.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.TableLayoutPanel tlpTextStyleOverride;
        private System.Windows.Forms.CheckBox chkOverrideFont;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.CheckBox chkOverrideColor;
    }
}
