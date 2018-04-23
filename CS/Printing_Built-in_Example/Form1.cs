using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Printing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Printing_Built_in_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static Random RandomInstance = new Random();
        private MyDailyPrintStyle myPrintStyle = new MyDailyPrintStyle();

        private BindingList<CustomAppointment> CustomEventList = new BindingList<CustomAppointment>();

        private void Form1_Load(object sender, EventArgs e)
        {
            InitAppointments();
            schedulerControl1.Start = DateTime.Now;
            //schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource;
            schedulerControl1.ActiveViewType = SchedulerViewType.Day;
        }

        private void InitAppointments()
        {
            AppointmentMappingInfo aptmappings = this.schedulerStorage1.Appointments.Mappings;
            aptmappings.Start = "StartTime";
            aptmappings.End = "EndTime";
            aptmappings.Subject = "Subject";
            aptmappings.AllDay = "AllDay";
            aptmappings.Description = "Description";
            aptmappings.Label = "Label";
            aptmappings.Location = "Location";
            aptmappings.RecurrenceInfo = "RecurrenceInfo";
            aptmappings.ReminderInfo = "ReminderInfo";
            aptmappings.Status = "Status";
            aptmappings.Type = "EventType";
            aptmappings.ResourceId = "ResourceID";

            ResourceMappingInfo resmappings = this.schedulerStorage1.Resources.Mappings;
            resmappings.Id = "ResID";
            resmappings.Caption = "Name";
            resmappings.Color = "ResColor";

            GenerateResources(3);
            GenerateEvents(CustomEventList);
            this.schedulerStorage1.Appointments.DataSource = CustomEventList;
        }


        private void GenerateResources(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                Resource res = new Resource(i, String.Format("Resource {0}", i));
                this.schedulerStorage1.Resources.Add(res);
            }
        }
        private void GenerateEvents(BindingList<CustomAppointment> eventList)
        {

            string subjPrefix = "Max Fowler's ";
            eventList.Add(CreateEvent(subjPrefix + "meeting", 1, 2, 5));
            eventList.Add(CreateEvent(subjPrefix + "travel", 2, 3, 6));
            eventList.Add(CreateEvent(subjPrefix + "phone call", 3, 0, 10));
        }
        private CustomAppointment CreateEvent(string subject, object resourceId, int status, int label)
        {
            CustomAppointment apt = new CustomAppointment();
            apt.Subject = subject;
            apt.ResourceID = resourceId;
            Random rnd = RandomInstance;
            int rangeInMinutes = 60 * 24;
            apt.StartTime = DateTime.Today + TimeSpan.FromMinutes(rnd.Next(0, rangeInMinutes));
            apt.EndTime = apt.StartTime + TimeSpan.FromMinutes(rnd.Next(0, rangeInMinutes / 4));
            apt.Status = status;
            apt.Label = label;
            return apt;
        }

        private void btnAddMyPrintStyle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.schedulerControl1.PrintStyles.Add(this.myPrintStyle);
        }

        private void btnShowPreview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            schedulerControl1.ShowPrintPreview(this.myPrintStyle);
        }

        private void btnUseDayViewScale_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            #region #customizeprintstyle
            DailyPrintStyle printStyle = (DailyPrintStyle)schedulerControl1.PrintStyles[SchedulerPrintStyleKind.Daily];
            printStyle.UseActiveViewTimeScale = true;
            printStyle.PrintTime.Start = schedulerControl1.SelectedInterval.Start.TimeOfDay;
            printStyle.PrintTime.End = schedulerControl1.SelectedInterval.End.TimeOfDay;
            if ((this.schedulerControl1.DayView.TimeScale.Minutes < 30) && (printStyle.PrintTime.Duration.TotalHours > 4))
            {
                printStyle.CalendarHeaderVisible = false;
                printStyle.AutoScaleHeadingsFont = false;
                printStyle.HeadingsFont = new Font("Verdana", 8);
                printStyle.AppointmentFont = new Font("Verdana", 8);
            }
            schedulerControl1.ShowPrintPreview(printStyle);
            #endregion #customizeprintstyle
        }

    }
}
