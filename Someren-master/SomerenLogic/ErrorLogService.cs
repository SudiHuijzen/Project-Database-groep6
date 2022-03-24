using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenLogic
{
    public class ErrorLogService
    {
        ErrorLogDao logErrordb;

        public ErrorLogService()
        {
            this.logErrordb = new ErrorLogDao();
        }

        public List<ErrorLog> GetErrorLogs()
        {
            List<ErrorLog> errorLogs = logErrordb.GetAll();
            return errorLogs;
        }

        public void AddErroLog(string error)
        {
            logErrordb.AddError(error);
        }
    }
}
