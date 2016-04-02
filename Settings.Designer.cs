namespace LiveSplit.MemoryInfo
{
    partial class Settings
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.grpRightText = new System.Windows.Forms.GroupBox();
            this.tlpRightText = new System.Windows.Forms.TableLayoutPanel();
            this.txtRightText = new System.Windows.Forms.TextBox();
            this.tlpBackground = new System.Windows.Forms.TableLayoutPanel();
            this.lblBackgroundColor = new System.Windows.Forms.Label();
            this.cmbGradientType = new System.Windows.Forms.ComboBox();
            this.btnBackgroundColor1 = new System.Windows.Forms.Button();
            this.chkDisplay2Rows = new System.Windows.Forms.CheckBox();
            this.btnBackgroundColor2 = new System.Windows.Forms.Button();
            this.grpLeftText = new System.Windows.Forms.GroupBox();
            this.tlpLeftText = new System.Windows.Forms.TableLayoutPanel();
            this.txtLeftText = new System.Windows.Forms.TextBox();
            this.grpMemoryAddresses = new System.Windows.Forms.GroupBox();
            this.btnRemoveRow = new System.Windows.Forms.Button();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.lblProcessName = new System.Windows.Forms.Label();
            this.txtProcessName = new System.Windows.Forms.TextBox();
            this.dgvMemoryAddresses = new System.Windows.Forms.DataGridView();
            this.rightTextOverrideControl = new LiveSplit.MemoryInfo.TextStyleOverrideControl();
            this.leftTextOverrideControl = new LiveSplit.MemoryInfo.TextStyleOverrideControl();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NumBytes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Module = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Base = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Offsets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpMain.SuspendLayout();
            this.grpRightText.SuspendLayout();
            this.tlpRightText.SuspendLayout();
            this.tlpBackground.SuspendLayout();
            this.grpLeftText.SuspendLayout();
            this.tlpLeftText.SuspendLayout();
            this.grpMemoryAddresses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemoryAddresses)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.grpRightText, 0, 4);
            this.tlpMain.Controls.Add(this.tlpBackground, 0, 2);
            this.tlpMain.Controls.Add(this.grpLeftText, 0, 3);
            this.tlpMain.Controls.Add(this.grpMemoryAddresses, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 6;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 205F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(459, 491);
            this.tlpMain.TabIndex = 0;
            // 
            // grpRightText
            // 
            this.grpRightText.Controls.Add(this.tlpRightText);
            this.grpRightText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRightText.Location = new System.Drawing.Point(3, 377);
            this.grpRightText.Name = "grpRightText";
            this.grpRightText.Size = new System.Drawing.Size(453, 109);
            this.grpRightText.TabIndex = 2;
            this.grpRightText.TabStop = false;
            this.grpRightText.Text = "Right Text";
            // 
            // tlpRightText
            // 
            this.tlpRightText.ColumnCount = 1;
            this.tlpRightText.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRightText.Controls.Add(this.rightTextOverrideControl, 0, 1);
            this.tlpRightText.Controls.Add(this.txtRightText, 0, 0);
            this.tlpRightText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRightText.Location = new System.Drawing.Point(3, 16);
            this.tlpRightText.Name = "tlpRightText";
            this.tlpRightText.RowCount = 2;
            this.tlpRightText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpRightText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRightText.Size = new System.Drawing.Size(447, 90);
            this.tlpRightText.TabIndex = 0;
            // 
            // txtRightText
            // 
            this.txtRightText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRightText.Location = new System.Drawing.Point(3, 3);
            this.txtRightText.Name = "txtRightText";
            this.txtRightText.Size = new System.Drawing.Size(441, 20);
            this.txtRightText.TabIndex = 1;
            // 
            // tlpBackground
            // 
            this.tlpBackground.ColumnCount = 5;
            this.tlpBackground.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBackground.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tlpBackground.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpBackground.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpBackground.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBackground.Controls.Add(this.lblBackgroundColor, 1, 0);
            this.tlpBackground.Controls.Add(this.cmbGradientType, 4, 0);
            this.tlpBackground.Controls.Add(this.btnBackgroundColor1, 2, 0);
            this.tlpBackground.Controls.Add(this.chkDisplay2Rows, 0, 0);
            this.tlpBackground.Controls.Add(this.btnBackgroundColor2, 3, 0);
            this.tlpBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBackground.Location = new System.Drawing.Point(3, 228);
            this.tlpBackground.Name = "tlpBackground";
            this.tlpBackground.RowCount = 1;
            this.tlpBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBackground.Size = new System.Drawing.Size(453, 28);
            this.tlpBackground.TabIndex = 0;
            // 
            // lblBackgroundColor
            // 
            this.lblBackgroundColor.AutoSize = true;
            this.lblBackgroundColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBackgroundColor.Location = new System.Drawing.Point(144, 0);
            this.lblBackgroundColor.Name = "lblBackgroundColor";
            this.lblBackgroundColor.Size = new System.Drawing.Size(104, 28);
            this.lblBackgroundColor.TabIndex = 0;
            this.lblBackgroundColor.Text = "Background Color:";
            this.lblBackgroundColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbGradientType
            // 
            this.cmbGradientType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbGradientType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGradientType.FormattingEnabled = true;
            this.cmbGradientType.Items.AddRange(new object[] {
            "Plain",
            "Vertical",
            "Horizontal"});
            this.cmbGradientType.Location = new System.Drawing.Point(314, 3);
            this.cmbGradientType.Name = "cmbGradientType";
            this.cmbGradientType.Size = new System.Drawing.Size(136, 21);
            this.cmbGradientType.TabIndex = 1;
            this.cmbGradientType.SelectedIndexChanged += new System.EventHandler(this.cmbGradientType_SelectedIndexChanged);
            // 
            // btnBackgroundColor1
            // 
            this.btnBackgroundColor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBackgroundColor1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackgroundColor1.Location = new System.Drawing.Point(254, 3);
            this.btnBackgroundColor1.Name = "btnBackgroundColor1";
            this.btnBackgroundColor1.Size = new System.Drawing.Size(24, 22);
            this.btnBackgroundColor1.TabIndex = 2;
            this.btnBackgroundColor1.UseVisualStyleBackColor = false;
            this.btnBackgroundColor1.Click += new System.EventHandler(this.ColorButtonClick);
            // 
            // chkDisplay2Rows
            // 
            this.chkDisplay2Rows.AutoSize = true;
            this.chkDisplay2Rows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkDisplay2Rows.Location = new System.Drawing.Point(3, 3);
            this.chkDisplay2Rows.Name = "chkDisplay2Rows";
            this.chkDisplay2Rows.Size = new System.Drawing.Size(135, 22);
            this.chkDisplay2Rows.TabIndex = 3;
            this.chkDisplay2Rows.Text = "Display 2 Rows";
            this.chkDisplay2Rows.UseVisualStyleBackColor = true;
            // 
            // btnBackgroundColor2
            // 
            this.btnBackgroundColor2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBackgroundColor2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackgroundColor2.Location = new System.Drawing.Point(284, 3);
            this.btnBackgroundColor2.Name = "btnBackgroundColor2";
            this.btnBackgroundColor2.Size = new System.Drawing.Size(24, 22);
            this.btnBackgroundColor2.TabIndex = 3;
            this.btnBackgroundColor2.UseVisualStyleBackColor = false;
            this.btnBackgroundColor2.Click += new System.EventHandler(this.ColorButtonClick);
            // 
            // grpLeftText
            // 
            this.grpLeftText.Controls.Add(this.tlpLeftText);
            this.grpLeftText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpLeftText.Location = new System.Drawing.Point(3, 262);
            this.grpLeftText.Name = "grpLeftText";
            this.grpLeftText.Size = new System.Drawing.Size(453, 109);
            this.grpLeftText.TabIndex = 1;
            this.grpLeftText.TabStop = false;
            this.grpLeftText.Text = "Left Text";
            // 
            // tlpLeftText
            // 
            this.tlpLeftText.ColumnCount = 1;
            this.tlpLeftText.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLeftText.Controls.Add(this.leftTextOverrideControl, 0, 1);
            this.tlpLeftText.Controls.Add(this.txtLeftText, 0, 0);
            this.tlpLeftText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLeftText.Location = new System.Drawing.Point(3, 16);
            this.tlpLeftText.Name = "tlpLeftText";
            this.tlpLeftText.RowCount = 2;
            this.tlpLeftText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpLeftText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLeftText.Size = new System.Drawing.Size(447, 90);
            this.tlpLeftText.TabIndex = 0;
            // 
            // txtLeftText
            // 
            this.txtLeftText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLeftText.Location = new System.Drawing.Point(3, 3);
            this.txtLeftText.Name = "txtLeftText";
            this.txtLeftText.Size = new System.Drawing.Size(441, 20);
            this.txtLeftText.TabIndex = 1;
            // 
            // grpMemoryAddresses
            // 
            this.grpMemoryAddresses.Controls.Add(this.btnRemoveRow);
            this.grpMemoryAddresses.Controls.Add(this.btnAddRow);
            this.grpMemoryAddresses.Controls.Add(this.lblProcessName);
            this.grpMemoryAddresses.Controls.Add(this.txtProcessName);
            this.grpMemoryAddresses.Controls.Add(this.dgvMemoryAddresses);
            this.grpMemoryAddresses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMemoryAddresses.Location = new System.Drawing.Point(3, 3);
            this.grpMemoryAddresses.Name = "grpMemoryAddresses";
            this.grpMemoryAddresses.Size = new System.Drawing.Size(453, 199);
            this.grpMemoryAddresses.TabIndex = 3;
            this.grpMemoryAddresses.TabStop = false;
            this.grpMemoryAddresses.Text = "Memory Addresses";
            // 
            // btnRemoveRow
            // 
            this.btnRemoveRow.Location = new System.Drawing.Point(84, 144);
            this.btnRemoveRow.Name = "btnRemoveRow";
            this.btnRemoveRow.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveRow.TabIndex = 4;
            this.btnRemoveRow.Text = "Remove";
            this.btnRemoveRow.UseVisualStyleBackColor = true;
            this.btnRemoveRow.Click += new System.EventHandler(this.btnRemoveRow_Click);
            // 
            // btnAddRow
            // 
            this.btnAddRow.Location = new System.Drawing.Point(3, 144);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(75, 23);
            this.btnAddRow.TabIndex = 3;
            this.btnAddRow.Text = "Add";
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // lblProcessName
            // 
            this.lblProcessName.AutoSize = true;
            this.lblProcessName.Location = new System.Drawing.Point(3, 176);
            this.lblProcessName.Name = "lblProcessName";
            this.lblProcessName.Size = new System.Drawing.Size(90, 13);
            this.lblProcessName.TabIndex = 2;
            this.lblProcessName.Text = "Name of process:";
            // 
            // txtProcessName
            // 
            this.txtProcessName.Location = new System.Drawing.Point(105, 173);
            this.txtProcessName.Name = "txtProcessName";
            this.txtProcessName.Size = new System.Drawing.Size(345, 20);
            this.txtProcessName.TabIndex = 1;
            // 
            // dgvMemoryAddresses
            // 
            this.dgvMemoryAddresses.AllowUserToAddRows = false;
            this.dgvMemoryAddresses.AllowUserToDeleteRows = false;
            this.dgvMemoryAddresses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemoryAddresses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Type,
            this.NumBytes,
            this.Module,
            this.Base,
            this.Offsets});
            this.dgvMemoryAddresses.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvMemoryAddresses.Location = new System.Drawing.Point(3, 16);
            this.dgvMemoryAddresses.Name = "dgvMemoryAddresses";
            this.dgvMemoryAddresses.RowHeadersVisible = false;
            this.dgvMemoryAddresses.Size = new System.Drawing.Size(447, 122);
            this.dgvMemoryAddresses.TabIndex = 0;
            this.dgvMemoryAddresses.Columns[Type.Index].ValueType = typeof(AddressType);
            this.dgvMemoryAddresses.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvMemoryAddresses_CellValidating);
            this.dgvMemoryAddresses.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemoryAddresses_CellValueChanged);
            // 
            // rightTextOverrideControl
            // 
            this.rightTextOverrideControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightTextOverrideControl.Location = new System.Drawing.Point(3, 28);
            this.rightTextOverrideControl.Name = "rightTextOverrideControl";
            this.rightTextOverrideControl.OverrideColor = false;
            this.rightTextOverrideControl.OverrideFont = false;
            this.rightTextOverrideControl.OverridingColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rightTextOverrideControl.OverridingFont = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.rightTextOverrideControl.Size = new System.Drawing.Size(441, 59);
            this.rightTextOverrideControl.TabIndex = 0;
            // 
            // leftTextOverrideControl
            // 
            this.leftTextOverrideControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftTextOverrideControl.Location = new System.Drawing.Point(3, 28);
            this.leftTextOverrideControl.Name = "leftTextOverrideControl";
            this.leftTextOverrideControl.OverrideColor = false;
            this.leftTextOverrideControl.OverrideFont = false;
            this.leftTextOverrideControl.OverridingColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.leftTextOverrideControl.OverridingFont = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.leftTextOverrideControl.Size = new System.Drawing.Size(441, 59);
            this.leftTextOverrideControl.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 27;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Type.Width = 67;
            // 
            // NumBytes
            // 
            this.NumBytes.HeaderText = "Num";
            this.NumBytes.Name = "NumBytes";
            this.NumBytes.ReadOnly = true;
            this.NumBytes.Width = 40;
            // 
            // Module
            // 
            this.Module.HeaderText = "Module";
            this.Module.Name = "Module";
            this.Module.Width = 75;
            // 
            // Base
            // 
            this.Base.HeaderText = "Base";
            this.Base.Name = "Base";
            this.Base.Width = 75;
            // 
            // Offsets
            // 
            this.Offsets.HeaderText = "Offsets (comma separated)";
            this.Offsets.Name = "Offsets";
            this.Offsets.Width = 156;
            // 
            // Settings
            // 
            this.Controls.Add(this.tlpMain);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(459, 491);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.HandleDestroyed += new System.EventHandler(this.settings_HandleDestroyed);
            this.tlpMain.ResumeLayout(false);
            this.grpRightText.ResumeLayout(false);
            this.tlpRightText.ResumeLayout(false);
            this.tlpRightText.PerformLayout();
            this.tlpBackground.ResumeLayout(false);
            this.tlpBackground.PerformLayout();
            this.grpLeftText.ResumeLayout(false);
            this.tlpLeftText.ResumeLayout(false);
            this.tlpLeftText.PerformLayout();
            this.grpMemoryAddresses.ResumeLayout(false);
            this.grpMemoryAddresses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemoryAddresses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpBackground;
        private System.Windows.Forms.GroupBox grpLeftText;
        private System.Windows.Forms.TableLayoutPanel tlpLeftText;
        public TextStyleOverrideControl leftTextOverrideControl;
        private System.Windows.Forms.GroupBox grpRightText;
        private System.Windows.Forms.TableLayoutPanel tlpRightText;
        public TextStyleOverrideControl rightTextOverrideControl;
        private System.Windows.Forms.TextBox txtRightText;
        private System.Windows.Forms.TextBox txtLeftText;
        private System.Windows.Forms.CheckBox chkDisplay2Rows;
        private System.Windows.Forms.Label lblBackgroundColor;
        private System.Windows.Forms.ComboBox cmbGradientType;
        private System.Windows.Forms.Button btnBackgroundColor1;
        private System.Windows.Forms.Button btnBackgroundColor2;
        private System.Windows.Forms.GroupBox grpMemoryAddresses;
        private System.Windows.Forms.DataGridView dgvMemoryAddresses;
        private System.Windows.Forms.Label lblProcessName;
        private System.Windows.Forms.TextBox txtProcessName;
        private System.Windows.Forms.Button btnRemoveRow;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumBytes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Module;
        private System.Windows.Forms.DataGridViewTextBoxColumn Base;
        private System.Windows.Forms.DataGridViewTextBoxColumn Offsets;
    }
}
