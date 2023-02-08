using System;
using MessagesDAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Configuration;
using System.Collections.Generic;

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
                List<Casehearing> list = new List<Casehearing>();
                list = DB_Case.GetCaseHearing();
                foreach (var item in list)
                {
                    MessageEntity post_values = new MessageEntity
                    {
                        api_id = "APIu8vjsK90106082",
                        api_password = "EXxgVrJF",
                        sms_type = "Transactional",
                        sms_encoding = "Text",
                        sender = "TYTECH",
                        number = "9841214728",
                        message = "IGRS Case hearing date CN : 1253 CY : 2023 PN : dulasiayya HD : 10-02-2023 TYTECH", // + item.hearingdate.ToString("dd-MM-yyyy") +
                        template_id = "131502"//"1707167298991619055",
                    };
                    ManageSendSMS manageSend = new ManageSendSMS();
                    manageSend.SendMessage(post_values);
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
