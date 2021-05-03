using System;
using Xunit;
using CPSConnectService.Services;
using System.Linq;
using System.Collections;
using CPSConnectModel;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace CPSConnectTest
{
    public class CPSServiceTest
    {
        [Fact]
        public void TestExternalServiceCall()
        {
            string url = @"https://api.cps.edu/Calendar/cps/calendarslist";
            CPSCalenderListService cpsConnectService = new CPSCalenderListService();
            var calendarResult = cpsConnectService.GetCalendesResult(url);
            Assert.NotNull(calendarResult);
            Assert.True(calendarResult.Any());
        }
    }
}
