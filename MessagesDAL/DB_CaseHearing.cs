using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MessagesDAL
{
    public class DB_CaseHearing
    {
         
        public DB_CaseHearing( )
        {
        }
        public List<MessageData> GetCaseHearing()
        {
            try
            {
                EF_IGRSCC_DataContext _DataContext = new EF_IGRSCC_DataContext();
                var _caseModel = //_DataContext.casehearing// (from _dbCaseHearingEntity in _DataContext.casehearing
                (from casehearing in _DataContext.casehearing
                join Courtcase in _DataContext.courtcase on casehearing.courtcaseid equals Courtcase.courtcaseid
                join Legalopinion in _DataContext.legalopinion on casehearing.courtcaseid equals Legalopinion.courtcaseid
                join Legalpanel_master in _DataContext.legalpanel_master on Legalopinion.lawyerid equals Legalpanel_master.lawyerid
                 select new MessageData
                {
                    CaseNumber = Courtcase.casenumber,
                    PhoneNumber = Legalpanel_master.phonenumber,
                    CaseYear = Courtcase.caseyear,
                    Petitioner = Courtcase.petitionername,
                    HearingDate = casehearing.hearingdate,
                     
                 }).ToList();
                return _caseModel;
            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}
