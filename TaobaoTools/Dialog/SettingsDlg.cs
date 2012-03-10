using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TaobaoTools.Dialog
{
    public partial class SettingsDlg : Form
    {
        public SettingsDlg(String caption, Object obj)
        {
            InitializeComponent();

            Text = caption;
            propertyGrid1.SelectedObject = obj;
        }

        public class IntValue
        {
            int mValue = 0;

            public IntValue(int value)
            {
                mValue = value;
            }

            [DefaultValue(0)]
            public int Value { get { return mValue; } set { mValue = value; } }
        }

        public class FloatValue
        {
            float mValue = 0;

            public FloatValue(float value)
            {
                mValue = value;
            }

            [DefaultValue(0.0f)]
            public float Value { get { return mValue; } set { mValue = value; } }
        }
    }
}
