using CPSConnectModel;
using CPSConnectService.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
namespace CPSConnectAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalendarsListController : ControllerBase
    {
        #region Private Variables
        private readonly ICPSCalenderListService _cpsCalenderListService;
        private const string EXTERNAL_URLS = "ExternalUrls";
        private const string CPS_EXTERNAL_URL = "CPSExternalURL";
        private IConfiguration _configuration;
        #endregion

        #region Constructor
        public CalendarsListController(ICPSCalenderListService cpsCalenderListService,IConfiguration configuration)
        {
            this._cpsCalenderListService = cpsCalenderListService;
            this._configuration = configuration;
        }
        #endregion

        #region Public Functions
        /// <summary>
        /// Get - Calender List Wrapper API
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<CalendarsResult> Get()
        {
            //Gets the URL from appsettings.json
           string url = _configuration.GetSection(EXTERNAL_URLS)?[CPS_EXTERNAL_URL];
            //Call the service method GetCalendesResult from the DI iniatialized service instance            
            return _cpsCalenderListService.GetCalendesResult(url);
        }
        #endregion
    }
}
