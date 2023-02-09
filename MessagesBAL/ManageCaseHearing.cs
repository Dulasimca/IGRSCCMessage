using System;
using MessagesDAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Configuration;
using System.Collections.Generic;
using AuditLog;

namespace MessagesBAL
{
    public class ManageCaseHearing
    {
        private readonly DB_CaseHearing DB_Case;
        public ManageCaseHearing()
        {
            DB_Case = new DB_CaseHearing();
        }

        public void CaseHearing()
        {
            try
            {
                List<MessageData> list = new List<MessageData>();
                list = DB_Case.GetCaseHearing();
                foreach (var item in list)
                {
                    //check date diff
                    int i = GetDays(item.HearingDate);
                    if (i <= 2 && i >= 0)
                    {
                        MessageEntity post_values = new MessageEntity
                        {
                            api_id = "APIu8vjsK90106082",
                            api_password = "EXxgVrJF",
                            sms_type = "Transactional",
                            sms_encoding = "Text",
                            sender = "TYTECH",
                            number = item.PhoneNumber,
                            message = "IGRS Case hearing date CN : " + item.CaseNumber + " CY : " + item.CaseYear + " PN : " + item.Petitioner + " HD : " + item.HearingDate.ToString("dd-MM-yyyy") + " TYTECH", // + item.hearingdate.ToString("dd-MM-yyyy") +
                            template_id = "131502"//"1707167298991619055",
                        };
                        ManageSendSMS manageSend = new ManageSendSMS();
                        manageSend.SendMessage(post_values);
                    }
                }

            }
            catch (Exception ex)
            {
                ErrorLog.WriteError("CaseHearing : " + ex.Message);
            }
        }
        private int GetDays(DateTime ToDate)
        {
            int differenceInDays = 0;
            try
            {
                DateTime oldDate = DateTime.Now;
                DateTime newDate = ToDate;
                TimeSpan ts = newDate - oldDate;
                differenceInDays = ts.Days;
            }
            catch (Exception ex)
            {
                ErrorLog.WriteError("GetDays : " + ex.Message);
            }
            return differenceInDays;

        }

    }
}
