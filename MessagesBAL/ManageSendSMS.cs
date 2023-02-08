using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MessagesBAL
{
   public class ManageSendSMS
    {
       

        public void SendMessage(MessageEntity message)
        {
            try
            {
                HttpWebRequest request;

                string url = "http://bulksmsplans.com/api/send_sms";

                string responseBody = string.Empty;

                string requestBody = string.Empty;

                request = (HttpWebRequest)HttpWebRequest.Create(url);

                requestBody = JsonConvert.SerializeObject(message);

                request.Accept = "application/json";

                request.ContentType = "application/json;charset=utf-8";

                byte[] byteData = UTF8Encoding.UTF8.GetBytes(requestBody.ToString());



                request.Method = "POST";

                request.ContentLength = byteData.Length;

                using (Stream postStream = request.GetRequestStream())
                {

                    postStream.Write(byteData, 0, byteData.Length);

                }



                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {

                    using (var reader = new StreamReader(response.GetResponseStream()))
                    {

                        responseBody = reader.ReadToEnd();

                    }

                }
            }
            catch (Exception ex)
            {

                throw;
            }
           
        }
    }
}
