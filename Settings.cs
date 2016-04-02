using LiveSplit.UI;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace LiveSplit.MemoryInfo
{
    enum AddressType
    {
        Int, Float, String
    }

    struct MemoryAddressInfo
    {
        public string module;
        public int baseAddress;
        public int[] offsets;
        public AddressType type;
        public int numBytes;
    }

    partial class Settings : UserControl
    {
        public bool Display2Rows { get; set; }

        public System.Drawing.Color BackgroundColor1 { get; set; }
        public System.Drawing.Color BackgroundColor2 { get; set; }
        public GradientType BackgroundGradient { get; set; }
        public string GradientString
        {
            get { return BackgroundGradient.ToString(); }
            set { BackgroundGradient = (GradientType)Enum.Parse(typeof(GradientType), value); }
        }

        public string LeftText { get; set; }
        public string RightText { get; set; }

        public string ProcessName { get; set; }

        public LayoutMode Mode { get; set; }

        private bool addressesChanged = false;
        public event EventHandler AddressesChanged;
        protected virtual void OnAddressesChanged(EventArgs e)
        {
            if (AddressesChanged != null)
            {
                AddressesChanged(this, e);
            }
        }

        public Settings()
        {
            InitializeComponent();

            ProcessName = "";
            
            BackgroundColor1 = System.Drawing.Color.Transparent;
            BackgroundColor2 = System.Drawing.Color.Transparent;
            BackgroundGradient = GradientType.Plain;
            
            LeftText = "Text";
            RightText = "";

            Type.DataSource = Enum.GetValues(typeof(AddressType));
            
            cmbGradientType.DataBindings.Add("SelectedItem", this, "GradientString", false, DataSourceUpdateMode.OnPropertyChanged);
            btnBackgroundColor1.DataBindings.Add("BackColor", this, "BackgroundColor1", false, DataSourceUpdateMode.OnPropertyChanged);
            btnBackgroundColor2.DataBindings.Add("BackColor", this, "BackgroundColor2", false, DataSourceUpdateMode.OnPropertyChanged);
            txtLeftText.DataBindings.Add("Text", this, "LeftText");
            txtRightText.DataBindings.Add("Text", this, "RightText");
            txtProcessName.DataBindings.Add("Text", this, "ProcessName");
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            if (Mode == LayoutMode.Horizontal)
            {
                chkDisplay2Rows.Enabled = false;
                chkDisplay2Rows.DataBindings.Clear();
                chkDisplay2Rows.Checked = true;
            }
            else
            {
                chkDisplay2Rows.Enabled = true;
                chkDisplay2Rows.DataBindings.Clear();
                chkDisplay2Rows.DataBindings.Add("Checked", this, "Display2Rows", false, DataSourceUpdateMode.OnPropertyChanged);
            }
        }

        private void settings_HandleDestroyed(object sender, EventArgs e)
        {
            if (addressesChanged)
            {
                addressesChanged = false;
                OnAddressesChanged(EventArgs.Empty);
            }
        }

        public List<MemoryAddressInfo> GetAddressInfos()
        {
            List<MemoryAddressInfo> addressInfos = new List<MemoryAddressInfo>(dgvMemoryAddresses.Rows.Count);
            MemoryAddressInfo addressInfo;

            foreach (DataGridViewRow row in dgvMemoryAddresses.Rows)
            {
                addressInfo = new MemoryAddressInfo();

                // module
                addressInfo.module = row.Cells[Module.Index].Value as string;
                // base address
                if (string.IsNullOrEmpty(row.Cells[Base.Index].Value as string))
                {
                    dgvMemoryAddresses.Rows.RemoveAt(row.Index);
                    continue;
                }
                else
                {
                    string offset = (row.Cells[Base.Index].Value as string).Trim();
                    TryParseHex(row.Cells[Base.Index].Value as string, out addressInfo.baseAddress);
                }
                // offsets
                if (!string.IsNullOrEmpty(row.Cells[Offsets.Index].Value as string))
                {
                    string[] offsets = (row.Cells[Offsets.Index].Value as string).Split(',');
                    addressInfo.offsets = new int[offsets.Length];
                    int j = 0;
                    foreach (string offset in offsets)
                    {
                        TryParseHex(offset.Trim(), out addressInfo.offsets[j]);
                        j += 1;
                    }
                }
                else
                {
                    addressInfo.offsets = new int[0];
                }
                // type
                addressInfo.type = (AddressType) row.Cells[Type.Index].Value;
                // num
                addressInfo.numBytes = (int)row.Cells[NumBytes.Index].Value;

                addressInfos.Add(addressInfo);
            }

            return addressInfos;
        }

        private void dgvMemoryAddresses_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == Type.Index)
            { 
                if (dgvMemoryAddresses.Rows[e.RowIndex].Cells[Type.Index].Value as string == "String")
                {
                    dgvMemoryAddresses.Rows[e.RowIndex].Cells[NumBytes.Index].ReadOnly = false;
                }
                else
                {
                    dgvMemoryAddresses.Rows[e.RowIndex].Cells[NumBytes.Index].ReadOnly = true;
                    dgvMemoryAddresses.Rows[e.RowIndex].Cells[NumBytes.Index].Value = 4;
                }
            }

            addressesChanged = true;
        }

        private void dgvMemoryAddresses_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string value = e.FormattedValue as string;

            if (e.ColumnIndex == NumBytes.Index)
            {
                int parsed;
                if (!int.TryParse(value, out parsed) || parsed <= 0)
                {
                    MessageBox.Show("'Num' has to be an integer bigger than 0!", "Invalid value!", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                    return;
                }
            }
            else if (e.ColumnIndex == Base.Index && !string.IsNullOrEmpty(value))
            {
                int parsed;
                if (!TryParseHex(value, out parsed))
                {
                    MessageBox.Show("'Base' has to be a hexadecimal number!", "Invalid value!", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                    return;
                }
            }
            else if (e.ColumnIndex == Offsets.Index)
            {
                int parsed;
                string[] offsets = value.Split(',');
                if (offsets.Length == 1 && string.IsNullOrEmpty(offsets[0]))
                {
                    return;
                }

                foreach (string offset in offsets)
                {
                    if (!TryParseHex(offset, out parsed))
                    {
                        MessageBox.Show("All offsets have to be hexadecimal numbers!", "Invalid value!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                        return;
                    }
                }
            }
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            int index = dgvMemoryAddresses.Rows.Add();
            dgvMemoryAddresses.Rows[index].Cells[ID.Index].Value = "{" + index + "}";
            dgvMemoryAddresses.Rows[index].Cells[Type.Index].Value = AddressType.Int;
            addressesChanged = true;
        }

        private void btnRemoveRow_Click(object sender, EventArgs e)
        {
            if (dgvMemoryAddresses.SelectedCells.Count > 0)
            {
                int index = dgvMemoryAddresses.SelectedCells[0].RowIndex;
                dgvMemoryAddresses.Rows.RemoveAt(index);

                for (int i = index; i < dgvMemoryAddresses.Rows.Count; i += 1)
                {
                    dgvMemoryAddresses.Rows[i].Cells[ID.Index].Value = "{" + i + "}";
                }
            }
            addressesChanged = true;
        }

        private void ColorButtonClick(object sender, EventArgs e)
        {
            SettingsHelper.ColorButtonClick((Button)sender, this);
        }

        private void cmbGradientType_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnBackgroundColor1.Visible = cmbGradientType.SelectedItem.ToString() != "Plain";
            btnBackgroundColor2.DataBindings.Clear();
            btnBackgroundColor2.DataBindings.Add("BackColor", this, btnBackgroundColor1.Visible ? "BackgroundColor2" : "BackgroundColor1", false, DataSourceUpdateMode.OnPropertyChanged);
            GradientString = cmbGradientType.SelectedItem.ToString();
        }

        public void SetSettings(System.Xml.XmlNode node)
        {
            System.Xml.XmlElement element = (System.Xml.XmlElement) node;

            if (element["MemoryAddresses"] != null)
            {
                dgvMemoryAddresses.Rows.Clear();

                int i;
                foreach (System.Xml.XmlNode childNode in element["MemoryAddresses"].ChildNodes)
                {
                    i = dgvMemoryAddresses.Rows.Add();
                    dgvMemoryAddresses.Rows[i].Cells[ID.Index].Value = "{" + (i + 1) + "}";
                    dgvMemoryAddresses.Rows[i].Cells[Type.Index].Value = SettingsHelper.ParseEnum<AddressType>(childNode["Type"]);
                    dgvMemoryAddresses.Rows[i].Cells[NumBytes.Index].Value = SettingsHelper.ParseInt(childNode["Num"]);
                    dgvMemoryAddresses.Rows[i].Cells[Module.Index].Value = SettingsHelper.ParseString(childNode["Module"]);
                    dgvMemoryAddresses.Rows[i].Cells[Base.Index].Value = SettingsHelper.ParseString(childNode["Base"]);
                    dgvMemoryAddresses.Rows[i].Cells[Offsets.Index].Value = SettingsHelper.ParseString(childNode["Offsets"]);
                    addressesChanged = true;
                }

                addressesChanged = false;
                OnAddressesChanged(EventArgs.Empty);
            }

            ProcessName = SettingsHelper.ParseString(element["ProcessName"]);
            leftTextOverrideControl.OverridingColor = SettingsHelper.ParseColor(element["LeftTextColor"]);
            leftTextOverrideControl.OverridingFont = SettingsHelper.GetFontFromElement(element["LeftTextFont"]);
            leftTextOverrideControl.OverrideColor = SettingsHelper.ParseBool(element["LeftTextOverrideColor"]);
            leftTextOverrideControl.OverrideFont = SettingsHelper.ParseBool(element["LeftTextOverrideFont"]);

            rightTextOverrideControl.OverridingColor = SettingsHelper.ParseColor(element["RightTextColor"]);
            rightTextOverrideControl.OverridingFont = SettingsHelper.GetFontFromElement(element["RightTextFont"]);
            rightTextOverrideControl.OverrideColor = SettingsHelper.ParseBool(element["RightTextOverrideColor"]);
            rightTextOverrideControl.OverrideFont = SettingsHelper.ParseBool(element["RightTextOverrideFont"]);
            
            BackgroundColor1 = SettingsHelper.ParseColor(element["BackgroundColor1"]);
            BackgroundColor2 = SettingsHelper.ParseColor(element["BackgroundColor2"]);
            GradientString = SettingsHelper.ParseString(element["BackgroundGradient"]);
            LeftText = SettingsHelper.ParseString(element["LeftText"]);
            RightText = SettingsHelper.ParseString(element["RightText"]);
            Display2Rows = SettingsHelper.ParseBool(element["Display2Rows"], false);
        }

        public System.Xml.XmlNode GetSettings(System.Xml.XmlDocument document)
        {
            System.Xml.XmlElement parent = document.CreateElement("Settings");
            CreateSettingsNode(document, parent);
            return parent;
        }

        public int GetSettingsHashCode()
        {
            return CreateSettingsNode(null, null);
        }

        private int CreateSettingsNode(System.Xml.XmlDocument document, System.Xml.XmlElement parent)
        {
            int hash = SettingsHelper.CreateSetting(document, parent, "Version", "1.0.0");

            System.Xml.XmlElement memoryAddressesNode = (document == null ? null : 
                                                                            document.CreateElement("MemoryAddresses"));
            System.Xml.XmlElement memoryAddressNode;
            foreach (DataGridViewRow row in dgvMemoryAddresses.Rows)
            {
                memoryAddressNode = (document == null ? null : document.CreateElement("MemoryAddress"));
                hash ^= SettingsHelper.CreateSetting(document, memoryAddressNode, "Type", row.Cells[Type.Index].Value ?? AddressType.Int);
                hash ^= SettingsHelper.CreateSetting(document, memoryAddressNode, "Num", row.Cells[NumBytes.Index].Value ?? 4);
                hash ^= SettingsHelper.CreateSetting(document, memoryAddressNode, "Module", row.Cells[Module.Index].Value ?? "");
                hash ^= SettingsHelper.CreateSetting(document, memoryAddressNode, "Base", row.Cells[Base.Index].Value ?? "");
                hash ^= SettingsHelper.CreateSetting(document, memoryAddressNode, "Offsets", row.Cells[Offsets.Index].Value ?? "");

                if (memoryAddressesNode != null)
                {
                    memoryAddressesNode.AppendChild(memoryAddressNode);
                }
            }

            if (parent != null)
            {
                parent.AppendChild(memoryAddressesNode);
            }

            return  hash ^
            SettingsHelper.CreateSetting(document, parent, "ProcessName", ProcessName) ^
            SettingsHelper.CreateSetting(document, parent, "LeftTextColor", leftTextOverrideControl.OverridingColor) ^
            SettingsHelper.CreateSetting(document, parent, "LeftTextFont", leftTextOverrideControl.OverridingFont) ^
            SettingsHelper.CreateSetting(document, parent, "LeftTextOverrideColor", leftTextOverrideControl.OverrideColor) ^
            SettingsHelper.CreateSetting(document, parent, "LeftTextOverrideFont", leftTextOverrideControl.OverrideFont) ^            
            SettingsHelper.CreateSetting(document, parent, "RightTextColor", rightTextOverrideControl.OverridingColor) ^
            SettingsHelper.CreateSetting(document, parent, "RightTextFont", rightTextOverrideControl.OverridingFont) ^
            SettingsHelper.CreateSetting(document, parent, "RightTextOverrideColor", rightTextOverrideControl.OverrideColor) ^
            SettingsHelper.CreateSetting(document, parent, "RightTextOverrideFont", rightTextOverrideControl.OverrideFont) ^
            SettingsHelper.CreateSetting(document, parent, "BackgroundColor1", BackgroundColor1) ^
            SettingsHelper.CreateSetting(document, parent, "BackgroundColor2", BackgroundColor2) ^
            SettingsHelper.CreateSetting(document, parent, "BackgroundGradient", BackgroundGradient) ^
            SettingsHelper.CreateSetting(document, parent, "LeftText", LeftText) ^
            SettingsHelper.CreateSetting(document, parent, "RightText", RightText) ^
            SettingsHelper.CreateSetting(document, parent, "Display2Rows", Display2Rows);
        }

        public static bool TryParseHex(string str, out int integer)
        {
            integer = 0;
            if (string.IsNullOrEmpty(str))
            {
                return false;
            }
            else
            {
                if (str.StartsWith("0x", StringComparison.CurrentCultureIgnoreCase))
                {
                    str = str.Substring(2);
                }

                return int.TryParse(str, NumberStyles.HexNumber, null, out integer);
            }
        }
    }
}
