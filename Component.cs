using LiveSplit.ComponentUtil;
using LiveSplit.Model;
using LiveSplit.UI;
using LiveSplit.UI.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;

namespace LiveSplit.MemoryInfo
{
    public class Component : IComponent
    {
        private InfoTextComponent InternalComponent { get; set; }
        private Settings settings = new Settings();
        private List<DeepPointer> pointers = new List<DeepPointer>();
        private List<MemoryAddressInfo> addressInfos;
        private System.Diagnostics.Process process;

        public string ComponentName => "MemoryInfo";

        public float PaddingTop => InternalComponent.PaddingTop;
        public float PaddingLeft => InternalComponent.PaddingLeft;
        public float PaddingBottom => InternalComponent.PaddingBottom;
        public float PaddingRight => InternalComponent.PaddingRight;

        public float VerticalHeight => InternalComponent.VerticalHeight;
        public float MinimumWidth => InternalComponent.MinimumWidth;
        public float HorizontalWidth => InternalComponent.HorizontalWidth;
        public float MinimumHeight => InternalComponent.MinimumHeight;

        public IDictionary<string, Action> ContextMenuControls => null;

        public Component(LiveSplitState state)
        {
            InternalComponent = new InfoTextComponent("", "");
            settings.AddressesChanged += Settings_AddressesChanged;
        }

        private void Settings_AddressesChanged(object sender, EventArgs e)
        {
            addressInfos = settings.GetAddressInfos();
            pointers.Clear();
            foreach (MemoryAddressInfo info in addressInfos)
            {
                if (string.IsNullOrEmpty(info.module))
                {
                    pointers.Add(new DeepPointer(info.baseAddress, info.offsets));
                }
                else
                {
                    pointers.Add(new DeepPointer(info.module, info.baseAddress, info.offsets));
                }
            }
        }

        private void PrepareDraw(LiveSplitState state, LayoutMode mode)
        {
            InternalComponent.DisplayTwoRows = settings.Display2Rows;
            InternalComponent.NameLabel.HasShadow = InternalComponent.ValueLabel.HasShadow = state.LayoutSettings.DropShadows;

            if (string.IsNullOrEmpty(settings.LeftText) || string.IsNullOrEmpty(settings.RightText))
            {
                InternalComponent.NameLabel.HorizontalAlignment = StringAlignment.Center;
                InternalComponent.ValueLabel.HorizontalAlignment = StringAlignment.Center;
                InternalComponent.NameLabel.VerticalAlignment = StringAlignment.Center;
                InternalComponent.ValueLabel.VerticalAlignment = StringAlignment.Center;
            }
            else
            {
                InternalComponent.NameLabel.HorizontalAlignment = StringAlignment.Near;
                InternalComponent.ValueLabel.HorizontalAlignment = StringAlignment.Far;
                InternalComponent.NameLabel.VerticalAlignment =
                    (mode == LayoutMode.Horizontal || settings.Display2Rows) ? StringAlignment.Near : StringAlignment.Center;
                InternalComponent.ValueLabel.VerticalAlignment =
                    (mode == LayoutMode.Horizontal || settings.Display2Rows) ? StringAlignment.Far : StringAlignment.Center;
            }

            if (settings.leftTextOverrideControl.OverrideColor)
            {
                InternalComponent.NameLabel.ForeColor = settings.leftTextOverrideControl.OverridingColor;
            }
            else
            {
                InternalComponent.NameLabel.ForeColor = state.LayoutSettings.TextColor;
            }
            if (settings.rightTextOverrideControl.OverrideColor)
            {
                InternalComponent.ValueLabel.ForeColor = settings.rightTextOverrideControl.OverridingColor;
            }
            else
            {
                InternalComponent.ValueLabel.ForeColor = state.LayoutSettings.TextColor;
            }

            if (settings.leftTextOverrideControl.OverrideFont)
            {
                InternalComponent.NameLabel.Font = settings.leftTextOverrideControl.OverridingFont;
            }
            else
            {
                InternalComponent.NameLabel.Font = state.LayoutSettings.TextFont;
            }
            if (settings.rightTextOverrideControl.OverrideFont)
            {
                InternalComponent.ValueLabel.Font = settings.rightTextOverrideControl.OverridingFont;
            }
            else
            {
                InternalComponent.ValueLabel.Font = state.LayoutSettings.TextFont;
            }
        }

        private void DrawBackground(Graphics g, LiveSplitState state, float width, float height)
        {
            if (settings.BackgroundColor1.ToArgb() != Color.Transparent.ToArgb()
                || settings.BackgroundGradient != GradientType.Plain
                && settings.BackgroundColor2.ToArgb() != Color.Transparent.ToArgb())
            {
                bool horizontal = settings.BackgroundGradient == GradientType.Horizontal;
                bool plain = settings.BackgroundGradient == GradientType.Plain;
                LinearGradientBrush gradientBrush = new LinearGradientBrush(
                    new PointF(0, 0),
                    horizontal ? new PointF(width, 0) : new PointF(0, height),
                    settings.BackgroundColor1,
                    plain ? settings.BackgroundColor1 : settings.BackgroundColor2);
                g.FillRectangle(gradientBrush, 0, 0, width, height);
            }
        }

        public void DrawVertical(Graphics g, LiveSplitState state, float width, Region clipRegion)
        {
            DrawBackground(g, state, width, VerticalHeight);
            PrepareDraw(state, LayoutMode.Vertical);
            InternalComponent.DrawVertical(g, state, width, clipRegion);
        }

        public void DrawHorizontal(Graphics g, LiveSplitState state, float height, Region clipRegion)
        {
            DrawBackground(g, state, HorizontalWidth, height);
            PrepareDraw(state, LayoutMode.Horizontal);
            InternalComponent.DrawHorizontal(g, state, height, clipRegion);
        }
        
        public void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
        {
            if (process != null && !process.HasExited && process.ProcessName == settings.ProcessName)
            {
                object[] values = new object[addressInfos.Count];
                for (int i = 0; i < addressInfos.Count; i += 1)
                {
                    switch (addressInfos[i].type)
                    {
                        case AddressType.Int:
                            values[i] = pointers[i].Deref<int>(process);
                            break;
                        case AddressType.Float:
                            values[i] = pointers[i].Deref<float>(process);
                            break;
                        case AddressType.String:
                            values[i] = pointers[i].DerefString(process, addressInfos[i].numBytes);
                            break;
                        case AddressType.Timespan:
                            values[i] = TimeSpan.FromSeconds(pointers[i].Deref<float>(process)).ToString(@"hh\:mm\:ss\:ff");
                            break;
                    }
                }

                try
                {
                    InternalComponent.InformationName = string.Format(settings.LeftText, values);
                }
                catch
                {
                    InternalComponent.InformationName = settings.LeftText;
                }
                try
                {
                    InternalComponent.InformationValue = string.Format(settings.RightText, values);
                }
                catch
                {
                    InternalComponent.InformationValue = settings.RightText;
                }

                InternalComponent.LongestString = 
                    (InternalComponent.InformationName.Length > InternalComponent.InformationValue.Length) ? 
                    InternalComponent.InformationName : 
                    InternalComponent.InformationValue;
                InternalComponent.Update(invalidator, state, width, height, mode);
            }
            else
            {
                process = System.Diagnostics.Process.GetProcessesByName(settings.ProcessName).FirstOrDefault();
                InternalComponent.InformationName = settings.LeftText;
                InternalComponent.InformationValue = settings.RightText;
                InternalComponent.Update(invalidator, state, width, height, mode);
            }
        }

        public System.Windows.Forms.Control GetSettingsControl(LayoutMode mode)
        {
            settings.Mode = mode;
            return settings;
        }

        public void SetSettings(System.Xml.XmlNode settings)
        {
            this.settings.SetSettings(settings);
        }

        public System.Xml.XmlNode GetSettings(System.Xml.XmlDocument document)
        {
            return settings.GetSettings(document);
        }

        public int GetSettingsHashCode()
        {
            return settings.GetSettingsHashCode();
        }

        public void Dispose()
        {
            settings.AddressesChanged -= Settings_AddressesChanged;
            settings.Dispose();
        }
    }
}
