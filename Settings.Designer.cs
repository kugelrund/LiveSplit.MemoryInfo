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
            this.rightTextOverrideControl = new LiveSplit.MemoryInfo.TextStyleOverrideControl();
            this.txtRightText = new System.Windows.Forms.TextBox();
            this.tlpBackground = new System.Windows.Forms.TableLayoutPanel();
            this.lblBackgroundColor = new System.Windows.Forms.Label();
            this.cmbGradientType = new System.Windows.Forms.ComboBox();
            this.btnBackgroundColor1 = new System.Windows.Forms.Button();
            this.chkDisplay2Rows = new System.Windows.Forms.CheckBox();
            this.btnBackgroundColor2 = new System.Windows.Forms.Button();
            this.grpLeftText = new System.Windows.Forms.GroupBox();
            this.tlpLeftText = new System.Windows.Forms.TableLayoutPanel();
            this.leftTextOverrideControl = new LiveSplit.MemoryInfo.TextStyleOverrideControl();
            this.txtLeftText = new System.Windows.Forms.TextBox();
            this.grpMemoryAddresses = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvMemoryAddresses = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.btnRemoveRow = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtProcessName = new System.Windows.Forms.TextBox();
            this.lblProcessName = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemoryAddresses)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.tlpMain.Location = new System.Drawing.Point(9, 9);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(4);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 6;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(594, 615);
            this.tlpMain.TabIndex = 0;
            // 
            // grpRightText
            // 
            this.grpRightText.Controls.Add(this.tlpRightText);
            this.grpRightText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRightText.Location = new System.Drawing.Point(4, 464);
            this.grpRightText.Margin = new System.Windows.Forms.Padding(4);
            this.grpRightText.Name = "grpRightText";
            this.grpRightText.Padding = new System.Windows.Forms.Padding(4);
            this.grpRightText.Size = new System.Drawing.Size(586, 142);
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
            this.tlpRightText.Location = new System.Drawing.Point(4, 19);
            this.tlpRightText.Margin = new System.Windows.Forms.Padding(4);
            this.tlpRightText.Name = "tlpRightText";
            this.tlpRightText.RowCount = 2;
            this.tlpRightText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tlpRightText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRightText.Size = new System.Drawing.Size(578, 119);
            this.tlpRightText.TabIndex = 0;
            // 
            // rightTextOverrideControl
            // 
            this.rightTextOverrideControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightTextOverrideControl.Location = new System.Drawing.Point(5, 36);
            this.rightTextOverrideControl.Margin = new System.Windows.Forms.Padding(5);
            this.rightTextOverrideControl.Name = "rightTextOverrideControl";
            this.rightTextOverrideControl.OverrideColor = false;
            this.rightTextOverrideControl.OverrideFont = false;
            this.rightTextOverrideControl.OverridingColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rightTextOverrideControl.OverridingFont = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.rightTextOverrideControl.Size = new System.Drawing.Size(568, 78);
            this.rightTextOverrideControl.TabIndex = 0;
            // 
            // txtRightText
            // 
            this.txtRightText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRightText.Location = new System.Drawing.Point(4, 4);
            this.txtRightText.Margin = new System.Windows.Forms.Padding(4);
            this.txtRightText.Name = "txtRightText";
            this.txtRightText.Size = new System.Drawing.Size(570, 22);
            this.txtRightText.TabIndex = 1;
            // 
            // tlpBackground
            // 
            this.tlpBackground.ColumnCount = 5;
            this.tlpBackground.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBackground.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 187F));
            this.tlpBackground.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpBackground.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpBackground.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBackground.Controls.Add(this.lblBackgroundColor, 1, 0);
            this.tlpBackground.Controls.Add(this.cmbGradientType, 4, 0);
            this.tlpBackground.Controls.Add(this.btnBackgroundColor1, 2, 0);
            this.tlpBackground.Controls.Add(this.chkDisplay2Rows, 0, 0);
            this.tlpBackground.Controls.Add(this.btnBackgroundColor2, 3, 0);
            this.tlpBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBackground.Location = new System.Drawing.Point(4, 274);
            this.tlpBackground.Margin = new System.Windows.Forms.Padding(4);
            this.tlpBackground.Name = "tlpBackground";
            this.tlpBackground.RowCount = 1;
            this.tlpBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBackground.Size = new System.Drawing.Size(586, 32);
            this.tlpBackground.TabIndex = 0;
            // 
            // lblBackgroundColor
            // 
            this.lblBackgroundColor.AutoSize = true;
            this.lblBackgroundColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBackgroundColor.Location = new System.Drawing.Point(168, 0);
            this.lblBackgroundColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBackgroundColor.Name = "lblBackgroundColor";
            this.lblBackgroundColor.Size = new System.Drawing.Size(179, 32);
            this.lblBackgroundColor.TabIndex = 0;
            this.lblBackgroundColor.Text = "Background Color:";
            this.lblBackgroundColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.cmbGradientType.Location = new System.Drawing.Point(425, 4);
            this.cmbGradientType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGradientType.Name = "cmbGradientType";
            this.cmbGradientType.Size = new System.Drawing.Size(157, 24);
            this.cmbGradientType.TabIndex = 1;
            this.cmbGradientType.SelectedIndexChanged += new System.EventHandler(this.cmbGradientType_SelectedIndexChanged);
            // 
            // btnBackgroundColor1
            // 
            this.btnBackgroundColor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBackgroundColor1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackgroundColor1.Location = new System.Drawing.Point(355, 4);
            this.btnBackgroundColor1.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackgroundColor1.Name = "btnBackgroundColor1";
            this.btnBackgroundColor1.Size = new System.Drawing.Size(27, 24);
            this.btnBackgroundColor1.TabIndex = 2;
            this.btnBackgroundColor1.UseVisualStyleBackColor = false;
            this.btnBackgroundColor1.Click += new System.EventHandler(this.ColorButtonClick);
            // 
            // chkDisplay2Rows
            // 
            this.chkDisplay2Rows.AutoSize = true;
            this.chkDisplay2Rows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkDisplay2Rows.Location = new System.Drawing.Point(4, 4);
            this.chkDisplay2Rows.Margin = new System.Windows.Forms.Padding(4);
            this.chkDisplay2Rows.Name = "chkDisplay2Rows";
            this.chkDisplay2Rows.Size = new System.Drawing.Size(156, 24);
            this.chkDisplay2Rows.TabIndex = 3;
            this.chkDisplay2Rows.Text = "Display 2 Rows";
            this.chkDisplay2Rows.UseVisualStyleBackColor = true;
            // 
            // btnBackgroundColor2
            // 
            this.btnBackgroundColor2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBackgroundColor2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackgroundColor2.Location = new System.Drawing.Point(390, 4);
            this.btnBackgroundColor2.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackgroundColor2.Name = "btnBackgroundColor2";
            this.btnBackgroundColor2.Size = new System.Drawing.Size(27, 24);
            this.btnBackgroundColor2.TabIndex = 3;
            this.btnBackgroundColor2.UseVisualStyleBackColor = false;
            this.btnBackgroundColor2.Click += new System.EventHandler(this.ColorButtonClick);
            // 
            // grpLeftText
            // 
            this.grpLeftText.Controls.Add(this.tlpLeftText);
            this.grpLeftText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpLeftText.Location = new System.Drawing.Point(4, 314);
            this.grpLeftText.Margin = new System.Windows.Forms.Padding(4);
            this.grpLeftText.Name = "grpLeftText";
            this.grpLeftText.Padding = new System.Windows.Forms.Padding(4);
            this.grpLeftText.Size = new System.Drawing.Size(586, 142);
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
            this.tlpLeftText.Location = new System.Drawing.Point(4, 19);
            this.tlpLeftText.Margin = new System.Windows.Forms.Padding(4);
            this.tlpLeftText.Name = "tlpLeftText";
            this.tlpLeftText.RowCount = 2;
            this.tlpLeftText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tlpLeftText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLeftText.Size = new System.Drawing.Size(578, 119);
            this.tlpLeftText.TabIndex = 0;
            // 
            // leftTextOverrideControl
            // 
            this.leftTextOverrideControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftTextOverrideControl.Location = new System.Drawing.Point(5, 36);
            this.leftTextOverrideControl.Margin = new System.Windows.Forms.Padding(5);
            this.leftTextOverrideControl.Name = "leftTextOverrideControl";
            this.leftTextOverrideControl.OverrideColor = false;
            this.leftTextOverrideControl.OverrideFont = false;
            this.leftTextOverrideControl.OverridingColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.leftTextOverrideControl.OverridingFont = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.leftTextOverrideControl.Size = new System.Drawing.Size(568, 78);
            this.leftTextOverrideControl.TabIndex = 0;
            // 
            // txtLeftText
            // 
            this.txtLeftText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLeftText.Location = new System.Drawing.Point(4, 4);
            this.txtLeftText.Margin = new System.Windows.Forms.Padding(4);
            this.txtLeftText.Name = "txtLeftText";
            this.txtLeftText.Size = new System.Drawing.Size(570, 22);
            this.txtLeftText.TabIndex = 1;
            // 
            // grpMemoryAddresses
            // 
            this.grpMemoryAddresses.Controls.Add(this.tableLayoutPanel2);
            this.grpMemoryAddresses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMemoryAddresses.Location = new System.Drawing.Point(4, 4);
            this.grpMemoryAddresses.Margin = new System.Windows.Forms.Padding(4);
            this.grpMemoryAddresses.Name = "grpMemoryAddresses";
            this.grpMemoryAddresses.Padding = new System.Windows.Forms.Padding(4);
            this.grpMemoryAddresses.Size = new System.Drawing.Size(586, 242);
            this.grpMemoryAddresses.TabIndex = 3;
            this.grpMemoryAddresses.TabStop = false;
            this.grpMemoryAddresses.Text = "Memory Addresses";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dgvMemoryAddresses, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 19);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(578, 219);
            this.tableLayoutPanel2.TabIndex = 1;
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
            this.dgvMemoryAddresses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMemoryAddresses.Location = new System.Drawing.Point(4, 4);
            this.dgvMemoryAddresses.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMemoryAddresses.Name = "dgvMemoryAddresses";
            this.dgvMemoryAddresses.RowHeadersVisible = false;
            this.dgvMemoryAddresses.Size = new System.Drawing.Size(570, 146);
            this.dgvMemoryAddresses.TabIndex = 0;
            this.dgvMemoryAddresses.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvMemoryAddresses_CellValidating);
            this.dgvMemoryAddresses.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemoryAddresses_CellValueChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.Controls.Add(this.btnAddRow, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnRemoveRow, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 154);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(578, 35);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // btnAddRow
            // 
            this.btnAddRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddRow.Location = new System.Drawing.Point(4, 4);
            this.btnAddRow.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(165, 27);
            this.btnAddRow.TabIndex = 3;
            this.btnAddRow.Text = "Add";
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // btnRemoveRow
            // 
            this.btnRemoveRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoveRow.Location = new System.Drawing.Point(177, 4);
            this.btnRemoveRow.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveRow.Name = "btnRemoveRow";
            this.btnRemoveRow.Size = new System.Drawing.Size(165, 27);
            this.btnRemoveRow.TabIndex = 4;
            this.btnRemoveRow.Text = "Remove";
            this.btnRemoveRow.UseVisualStyleBackColor = true;
            this.btnRemoveRow.Click += new System.EventHandler(this.btnRemoveRow_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtProcessName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblProcessName, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 189);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(578, 30);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // txtProcessName
            // 
            this.txtProcessName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtProcessName.Location = new System.Drawing.Point(179, 4);
            this.txtProcessName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProcessName.Name = "txtProcessName";
            this.txtProcessName.Size = new System.Drawing.Size(395, 22);
            this.txtProcessName.TabIndex = 1;
            // 
            // lblProcessName
            // 
            this.lblProcessName.AutoSize = true;
            this.lblProcessName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProcessName.Location = new System.Drawing.Point(4, 0);
            this.lblProcessName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProcessName.Name = "lblProcessName";
            this.lblProcessName.Size = new System.Drawing.Size(167, 30);
            this.lblProcessName.TabIndex = 2;
            this.lblProcessName.Text = "Name of process:";
            this.lblProcessName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.FillWeight = 6F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Type.FillWeight = 14F;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // NumBytes
            // 
            this.NumBytes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumBytes.FillWeight = 8F;
            this.NumBytes.HeaderText = "Num";
            this.NumBytes.Name = "NumBytes";
            this.NumBytes.ReadOnly = true;
            // 
            // Module
            // 
            this.Module.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Module.FillWeight = 20F;
            this.Module.HeaderText = "Module";
            this.Module.Name = "Module";
            // 
            // Base
            // 
            this.Base.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Base.FillWeight = 15F;
            this.Base.HeaderText = "Base";
            this.Base.Name = "Base";
            // 
            // Offsets
            // 
            this.Offsets.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Offsets.FillWeight = 43F;
            this.Offsets.HeaderText = "Offsets (comma separated)";
            this.Offsets.Name = "Offsets";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Settings";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.Size = new System.Drawing.Size(612, 633);
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
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemoryAddresses)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnRemoveRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumBytes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Module;
        private System.Windows.Forms.DataGridViewTextBoxColumn Base;
        private System.Windows.Forms.DataGridViewTextBoxColumn Offsets;
    }
}
