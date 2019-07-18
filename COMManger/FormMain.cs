using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace COMManger
{
    public partial class FormMain : Form
    {
        RegistryKey Root;
        RegistryKey Key;
        byte[] OriginalCfg;
        byte[] CurrentCfg;

        byte[] BITList = new byte[]
        {
            1,
            2,
            4,
            8,
            16,
            32,
            64,
            128,
        };

        public FormMain()
        {
            InitializeComponent();

            Root = Registry.LocalMachine;
            Key = Root.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\COM Name Arbiter", true);
        }

        private void ApplyResource()
        {
            ComponentResourceManager res = new ComponentResourceManager(typeof(FormMain));
            foreach (Control ctl in Controls)
            {
                res.ApplyResources(ctl, ctl.Name);
            }
            this.Text = res.GetString("FormMain.Text");
            this.ResumeLayout(false);
            this.PerformLayout();
            res.ApplyResources(this, "$this");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            OriginalCfg = (byte[])Key.GetValue("ComDB");
            CurrentCfg = new byte[OriginalCfg.Length];
            Array.Copy(OriginalCfg, 0, CurrentCfg, 0, OriginalCfg.Length);

            RefreshList(CurrentCfg);

            CB_Language.SelectedIndex = 0;
        }

        private void FormMain_Closing(object sender, EventArgs e)
        {
            if(!CurrentCfg.SequenceEqual(OriginalCfg))
            {
                ComponentResourceManager res = new ComponentResourceManager(typeof(FormMain));
                if (MessageBox.Show(res.GetString("NoSaveAlert"), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    BT_Save_Click(null, null);
            }
        }

        private void RefreshList(byte[] argc)
        {
            COMList.Items.Clear();

            for (int i = 0; i < argc.Length; i++)
            {
                for (int j = 0; j < BITList.Length; j++)
                {
                    if ((argc[i] & BITList[j]) == BITList[j])
                        COMList.Items.Add($"COM{i * 8 + j + 1}", 0);
                }
            }
        }

        private void CB_Language_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(CB_Language.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("zh-CN");
                    break;
                case 1:
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("EN");
                    break;
            }
            
            ApplyResource();
        }

        private void BT_Delete_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in COMList.SelectedItems)
            {
                int Index = Convert.ToInt32(item.Text.Remove(0, 3)) - 1;
                int Block = Index / 8;
                Index = Index % 8;
                CurrentCfg[Block] = (byte)(CurrentCfg[Block] & ~BITList[Index]);
            }

            RefreshList(CurrentCfg);
        }

        private void BT_Clear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < CurrentCfg.Length; i++)
                CurrentCfg[i] = 0;

            RefreshList(CurrentCfg);
        }

        private void BT_Save_Click(object sender, EventArgs e)
        {
            ComponentResourceManager res = new ComponentResourceManager(typeof(FormMain));

            try
            {
                Key.SetValue("COMDb", CurrentCfg);
                Array.Copy(CurrentCfg, 0, OriginalCfg, 0, CurrentCfg.Length);
                MessageBox.Show(res.GetString("SaveOK"));
            }
            catch(Exception)
            {
                MessageBox.Show(res.GetString("SaveFail"));
            }
        }
    }
}
