using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace TaobaoTools.Data
{
    public class ItemDataContainer
    {
        bool mModified = false;
        Dictionary<long, ItemData> mItemDatas = new Dictionary<long, ItemData>();

        public bool Modified { get { return mModified; } set { mModified = value; } }

        public bool HasItem(long id)
        {
            return mItemDatas.ContainsKey(id);
        }

        public ItemData GetItem(long id)
        {
            ItemData itemData;
            mItemDatas.TryGetValue(id, out itemData);
            return itemData;
        }

        public void AddOrUpdate(ItemData itemData)
        {
            mItemDatas[itemData.ID] = itemData;
            mModified = true;
        }
        
        [Serializable]
        public class DataContainer
        {
            List<ItemData> mItemDatas = new List<ItemData>();
            public List<ItemData> ItemDatas { get { return mItemDatas; } }

            public DataContainer() { }
            public DataContainer(Dictionary<long, ItemData> itemDatas)
            {
                mItemDatas.AddRange(itemDatas.Values);
            }
        }

        public void Save(String fileName)
        {
            try
            {
                if (!mModified)
                    return;

                XmlSerializer ser = new XmlSerializer(typeof(DataContainer));
                StreamWriter sw = new StreamWriter(fileName);
                DataContainer data = new DataContainer(mItemDatas);
                ser.Serialize(sw, data);
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Load(String fileName)
        {
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(DataContainer));
                StreamReader sr = new StreamReader(fileName);
                DataContainer data = (DataContainer)ser.Deserialize(sr);
                sr.Close();

                mItemDatas.Clear();
                foreach (ItemData itemData in data.ItemDatas)
                    mItemDatas[itemData.ID] = itemData;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
