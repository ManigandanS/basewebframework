﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using LD.SPPipeManage.Bussiness.Wrappers;

namespace LD.SPPipeManage.Bussiness.UrlSender
{
    public class UrlSender
    {
        public static void SendRequest(object request)
        {
            UrlSendTask sendTask = request as UrlSendTask;

            if (sendTask == null)
                throw new AbandonedMutexException(" sendTask is null ");


            try
            {
                bool requestOk = false;

                string errorMessage = string.Empty;

                requestOk = SendRequest(sendTask.SendUrl, 3000, sendTask.OkMessage, out errorMessage);

                if (requestOk)
                {
                    UpdatePaymentSendSuccessAndUrl(sendTask.SendUrl, sendTask.PaymentID);
                }
                else
                {
                    Console.WriteLine(errorMessage);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void UpdatePaymentSendSuccessAndUrl(string url,int paymentID)
        {
            SPPaymentInfoWrapper.UpdateUrlSuccessSend(paymentID, url);
        }

        private static bool SendRequest(string requesturl, int timeOut, string okMessage, out string errorMessage)
        {
            try
            {
                errorMessage = "";

                HttpWebRequest webRequest = (HttpWebRequest)HttpWebRequest.Create(requesturl);

                webRequest.Timeout = timeOut;

                HttpWebResponse webResponse = null;

                webResponse = (HttpWebResponse)webRequest.GetResponse();


                if (webResponse.StatusCode == HttpStatusCode.OK)
                {
                    StreamReader sr = new StreamReader(webResponse.GetResponseStream(), Encoding.Default);

                    string responseText = sr.ReadToEnd();

                    bool result = responseText.Trim().ToLower().Equals(okMessage);

                    if (!result)
                    {
                        errorMessage = responseText;
                    }

                    return result;
                }

                errorMessage = "web error Status:" + webResponse.StatusCode.ToString();

                return false;
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
                return false;
            }
        }
    }
}
