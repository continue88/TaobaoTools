using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace TaobaoTools.Data
{
    [Serializable]
    public class TradeDataContainer
    {
        bool mModified = false;
        Dictionary<long, TradeData> mTradeDatas = new Dictionary<long, TradeData>();

        public bool Modified { get { return mModified; } set { mModified = value; } }

        public bool HasItem(long id)
        {
            return mTradeDatas.ContainsKey(id);
        }

        public TradeData GetItem(long id)
        {
            TradeData TradeData;
            mTradeDatas.TryGetValue(id, out TradeData);
            return TradeData;
        }

        public void RemoveItem(long id)
        {
            if (mTradeDatas.Remove(id))
                mModified = true;
        }

        public void AddOrUpdate(TradeData TradeData)
        {
            mTradeDatas[TradeData.ID] = TradeData;
            mModified = true;
        }


        [Serializable]
        public class DataContainer
        {
            List<TradeData> mTradeDatas = new List<TradeData>();
            public List<TradeData> TradeDatas { get { return mTradeDatas; } }

            public DataContainer() { }
            public DataContainer(Dictionary<long, TradeData> TradeDatas)
            {
                mTradeDatas.AddRange(TradeDatas.Values);
            }
        }

        public void Save(String fileName)
        {
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(DataContainer));
                StreamWriter sw = new StreamWriter(fileName);
                DataContainer data = new DataContainer(mTradeDatas);
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

                mTradeDatas.Clear();
                foreach (TradeData TradeData in data.TradeDatas)
                    mTradeDatas[TradeData.ID] = TradeData;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
