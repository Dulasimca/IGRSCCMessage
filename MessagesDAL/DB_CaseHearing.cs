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
                var _caseModel = _DataContext.casehearing.ToList();// (from _dbCaseHearingEntity in _DataContext.casehearing
                return _caseModel;
            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}
