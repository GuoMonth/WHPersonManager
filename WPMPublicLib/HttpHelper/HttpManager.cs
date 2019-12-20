using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Newtonsoft.Json;
using System.IO;

namespace WPMPublicLib.HttpHelper
{
    public class HttpManager
    {
        /// <summary>
        /// 发送请求消息
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public T PostMessage<T>(string url,string msg)
        {
            string result = string.Empty;
            HttpWebRequest request = null;
            HttpWebResponse res = null;
            string postDataStr = msg;
            byte[] bytData = null;
            try
            {
                bytData = Encoding.UTF8.GetBytes(postDataStr);
                request = System.Net.WebRequest.Create(new Uri(url)) as HttpWebRequest;
                request.Method = "POST";
                request.ContentType = "text/xml;charset=UTF-8";
                request.ContentLength = bytData.Length;
                request.Timeout = 100000;
                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(bytData, 0, bytData.Length);
                    stream.Close();
                }

                res = (HttpWebResponse)request.GetResponse();

                using (StreamReader sr = new StreamReader(res.GetResponseStream(), Encoding.UTF8))
                {
                    result = sr.ReadToEnd();
                    sr.Close();
                }

                return JsonConvert.DeserializeObject<T>(result);

            }
            catch (WebException ex)
            {
                res = (HttpWebResponse)ex.Response;
                //如果出现异常信息，此处捕捉异常信息，打开注释代码有助于继续判断！
                result = new StreamReader(res.GetResponseStream()).ReadToEnd();
                throw new Exception(result);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (res != null)
                {
                    res.Close();
                    res = null;
                }
            }
        }

        /// <summary>
        /// 获取请求消息
        /// </summary>
        /// <param name="sr"></param>
        /// <returns></returns>
        public string GetPostMsg(Stream sr)
        {
            byte[] b = new byte[sr.Length];
            sr.Read(b, 0, (int)sr.Length);
            return Encoding.UTF8.GetString(b);
        }

        /// <summary>
        /// 将json转换为指定类型的对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <returns></returns>
        public T JsonConver2Object<T>(string json)
        {
            return JsonConver2Object<T>(json);
        }

        /// <summary>
        /// 将对象转换为json
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public string Convert2Json(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}
