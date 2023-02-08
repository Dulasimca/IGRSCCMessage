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
        public List<Casehearing> GetCaseHearing()
        {
            try
            {
                EF_IGRSCC_DataContext _DataContext = new EF_IGRSCC_DataContext();
                var _caseModel = //_DataContext.casehearing// (from _dbCaseHearingEntity in _DataContext.casehearing
                (from casehearing in _DataContext.casehearing
                join Courtcase in _DataContext.casehearing on casehearing.courtcaseid equals Courtcase.courtcaseid

                select new Casehearing
                {
                    id = casehearing.id,
                    zoneid = casehearing.zoneid,
                    districtid = casehearing.districtid,
                    sroid = casehearing.sroid,
                    casetypeid = casehearing.casetypeid,
                    courtcaseid = casehearing.courtcaseid,
                    hearingdate = casehearing.hearingdate,
                    remarks = casehearing.remarks,
                    createddate = casehearing.createddate,
                    flag = casehearing.flag,
                    userid = casehearing.userid,
                    courtcasename = Courtcase.courtcasename
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
