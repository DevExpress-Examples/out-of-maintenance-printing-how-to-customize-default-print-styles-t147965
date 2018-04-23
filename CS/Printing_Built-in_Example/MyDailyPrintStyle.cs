using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_Built_in_Example
{
    #region #myprintdailystyle
    class MyDailyPrintStyle : DevExpress.XtraScheduler.Printing.DailyPrintStyle
    {
        public MyDailyPrintStyle()
            : base(false) {
            // Print information on appointments which do not fall in the PrintTime interval.
            base.PrintAllAppointments = true;
            // Do not use time slots displayed in the Day view of the SchedulerControl.
            base.UseActiveViewTimeScale = false;
            // Determine the row height (specify the time interval of a time slot).
            base.TimeSlots.Clear();
            base.TimeSlots.Add(TimeSpan.FromMinutes(15), "15Minutes");
            // Specify the time interval to print.
            base.PrintTime = new DevExpress.XtraScheduler.TimeOfDayInterval(TimeSpan.FromHours(12), TimeSpan.FromHours(14));
        }

        protected override string DefaultDisplayName
        {
            get
            {
                return "My DailyPrintStyle";
            }
        }
    }
    #endregion #myprintdailystyle
}
