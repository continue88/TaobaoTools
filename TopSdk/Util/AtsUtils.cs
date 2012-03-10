using System.Collections;
using System.IO;
using System.Net;
using System.Text;

namespace Top.Api.Util
{
    /// <summary>
    /// 异步API下载工具类。
    /// </summary>
    public abstract class AtsUtils
    {
        private const string CTYPE_ZIP = "application/zip";

        public static FileInfo Download(string url, string saveDir)
        {
            FileInfo file = null;
            WebUtils wu = new WebUtils();
            HttpWebRequest req = wu.GetWebRequest(url, "GET");
            req.ContentType = "application/x-www-form-urlencoded;charset=utf-8";

            HttpWebResponse rsp = (HttpWebResponse)req.GetResponse();
            if (CTYPE_ZIP.Equals(rsp.ContentType))
            {
                if (string.IsNullOrEmpty(saveDir))
                {
                    file = new FileInfo(Path.GetTempFileName() + ".zip");
                }
                else
                {
                    file = new FileInfo(Path.Combine(saveDir, Path.GetRandomFileName() + ".zip"));
                }

                using (Stream rspStream = rsp.GetResponseStream())
                {
                    byte[] bytes = new byte[1024];
                    int len = 0;

                    using (FileStream fileStream = new FileStream(file.FullName, FileMode.OpenOrCreate))
                    {
                        while ((len = rspStream.Read(bytes, 0, bytes.Length)) > 0)
                        {
                            fileStream.Write(bytes, 0, len);
                        }
                    }
                }
            }
            else
            {
                string json = wu.GetResponseAsString(rsp, Encoding.GetEncoding(rsp.CharacterSet));
                if (!string.IsNullOrEmpty(json))
                {
                    IDictionary dict = Top.Api.Util.TopUtils.ParseJson(json);
                    string errCode = dict["code"] as string;
                    string errMsg = dict["message"] as string;
                    throw new Top.Api.TopException(errCode, errMsg);
                }
            }
            return file;
        }

        public static FileInfo Download(string url)
        {
            return Download(url, null);
        }
    }
}
