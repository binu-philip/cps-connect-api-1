using CPSConnectModel;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSConnectService.Interfaces
{
    public interface ICPSCalenderListService
    {
        /// <summary>
        /// GetCalendesResult
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        IEnumerable<CalendarsResult> GetCalendesResult(string url);
    }
}
