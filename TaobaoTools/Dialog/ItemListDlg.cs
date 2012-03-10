using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Top.Api;
using Top.Api.Request;
using Top.Api.Response;
using Top.Api.Domain;
using TaobaoTools.Data;
using System.Diagnostics;

namespace TaobaoTools.Dialog
{
    public partial class ItemListDlg : UserControl
    {
        long mPageSize = 40;
        long mTotalNum = 0;

        public ItemListDlg()
        {
            InitializeComponent();
        }

        private void ItemListDlg_Load(object sender, EventArgs e)
        {
            GetProductList(1);
        }

        void GetProductList(long pageIndex)
        {
            // request data.
            List<Item> itemList = TopClientHelper.GetProductList(pageIndex, mPageSize, out mTotalNum);

            // parse data.
            long pageNum = (mTotalNum + (mPageSize - 1)) / mPageSize;

            toolStripStatusLabelTotal.Text = String.Format("总共{0}宝贝，{1}/{2}页", mTotalNum, pageIndex, pageNum);

            if (!toolStripDropDownButton1.HasDropDownItems)
            {
                for (long i = 1; i <= pageNum; i++)
                {
                    ToolStripMenuItem tsItem = (ToolStripMenuItem)toolStripDropDownButton1.DropDownItems.Add(String.Format("第{0}页", i));
                    tsItem.Checked = (i == pageIndex);
                    tsItem.Click += new EventHandler(OnPageItem_Clicked);
                    tsItem.Tag = i;
                }
            }

            listView1.Items.Clear();
            foreach (Item item in itemList)
            {
                long itemIdx = (pageIndex - 1) * mPageSize + listView1.Items.Count + 1;
                ListViewItem lvItem = listView1.Items.Add(itemIdx.ToString());
                lvItem.SubItems.Add(item.NumIid.ToString());
                lvItem.SubItems.Add(item.Title);
                lvItem.SubItems.Add(item.Price);

                lvItem.Tag = item;

                UpdateItemData(lvItem);
            }
        }

        void OnPageItem_Clicked(object sender, EventArgs e)
        {
            ToolStripMenuItem selectItem = sender as ToolStripMenuItem;
            if (selectItem == null)
                return;

            // request another page.
            long pageIndex = (long)selectItem.Tag;
            GetProductList(pageIndex);

            foreach (ToolStripItem item in selectItem.GetCurrentParent().Items)
            {
                ToolStripMenuItem tsmItem = item as ToolStripMenuItem;
                tsmItem.Checked = (item == selectItem);
            }
        }

        void UpdateItemData(ListViewItem lvItem)
        {
            Item item = lvItem.Tag as Item;
            if (item == null)
                return;

            if (!Global.ItemDataContainer.HasItem(item.NumIid))
                return;

            ItemData itemData = Global.ItemDataContainer.GetItem(item.NumIid);
            if (lvItem.SubItems.Count < lvItem.ListView.Columns.Count)
            {
                lvItem.SubItems.Add(itemData.UserName);
                lvItem.SubItems.Add(itemData.ItemType);
            }
            else
            {
                lvItem.SubItems[lvItem.SubItems.Count - 2].Text = itemData.UserName;
                lvItem.SubItems[lvItem.SubItems.Count - 1].Text = itemData.ItemType;
            }
        }

        private void OnItemDoubleClicked(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count != 1)
                return;

            ListViewItem lvItem = listView1.SelectedItems[0];
            Item item = lvItem.Tag as Item;
            if (item == null)
                return;

            ItemDataInfo itemInfo = new ItemDataInfo(item);
            SettingsDlg dlg = new SettingsDlg("修改宝贝的属性", itemInfo);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (!String.IsNullOrEmpty(itemInfo.UserName) || !String.IsNullOrEmpty(itemInfo.ItemType))
                {
                    ItemData itemData = new ItemData();
                    itemData.ID = itemInfo.ItemID;
                    itemData.UserName = itemInfo.UserName;
                    itemData.ItemType = itemInfo.ItemType;
                    Global.ItemDataContainer.AddOrUpdate(itemData);

                    UpdateItemData(lvItem);
                }
            }
        }

        private void OnItemLinkClicked(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 1)
                return;
            
            ListViewItem lvItem = listView1.SelectedItems[0];
            Item item = lvItem.Tag as Item;
            if (item == null)
                return;

            Process.Start(String.Format("{0}?id={1}", Global.ITEM_URL, item.NumIid));
        }

        private void OnItemClicked(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(listView1, e.Location);
            }
        }
    }
}
