Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Printing
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace Printing_Built_in_Example
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Shared RandomInstance As New Random()
        Private myPrintStyle As New MyDailyPrintStyle()

        Private CustomEventList As New BindingList(Of CustomAppointment)()

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            InitAppointments()
            schedulerControl1.Start = Date.Now
            'schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource;
            schedulerControl1.ActiveViewType = SchedulerViewType.Day
        End Sub

        Private Sub InitAppointments()
            Dim aptmappings As AppointmentMappingInfo = Me.schedulerStorage1.Appointments.Mappings
            aptmappings.Start = "StartTime"
            aptmappings.End = "EndTime"
            aptmappings.Subject = "Subject"
            aptmappings.AllDay = "AllDay"
            aptmappings.Description = "Description"
            aptmappings.Label = "Label"
            aptmappings.Location = "Location"
            aptmappings.RecurrenceInfo = "RecurrenceInfo"
            aptmappings.ReminderInfo = "ReminderInfo"
            aptmappings.Status = "Status"
            aptmappings.Type = "EventType"
            aptmappings.ResourceId = "ResourceID"

            Dim resmappings As ResourceMappingInfo = Me.schedulerStorage1.Resources.Mappings
            resmappings.Id = "ResID"
            resmappings.Caption = "Name"
            resmappings.Color = "ResColor"

            GenerateResources(3)
            GenerateEvents(CustomEventList)
            Me.schedulerStorage1.Appointments.DataSource = CustomEventList
        End Sub


        Private Sub GenerateResources(ByVal number As Integer)
            For i As Integer = 1 To number
                Dim res As Resource = schedulerStorage1.CreateResource(i, String.Format("Resource {0}", i))
                schedulerStorage1.Resources.Add(res)
            Next i
        End Sub
        Private Sub GenerateEvents(ByVal eventList As BindingList(Of CustomAppointment))

            Dim subjPrefix As String = "Max Fowler's "
            eventList.Add(CreateEvent(subjPrefix & "meeting", 1, 2, 5))
            eventList.Add(CreateEvent(subjPrefix & "travel", 2, 3, 6))
            eventList.Add(CreateEvent(subjPrefix & "phone call", 3, 0, 10))
        End Sub
        Private Function CreateEvent(ByVal subject As String, ByVal resourceId As Object, ByVal status As Integer, ByVal label As Integer) As CustomAppointment
            Dim apt As New CustomAppointment()
            apt.Subject = subject
            apt.ResourceID = resourceId
            Dim rnd As Random = RandomInstance
            Dim rangeInMinutes As Integer = 60 * 24
            apt.StartTime = Date.Today + TimeSpan.FromMinutes(rnd.Next(0, rangeInMinutes))
            apt.EndTime = apt.StartTime.Add(TimeSpan.FromMinutes(rnd.Next(0, rangeInMinutes \ 4)))
            apt.Status = status
            apt.Label = label
            Return apt
        End Function

        Private Sub btnAddMyPrintStyle_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddMyDailyPrintStyle.ItemClick
            Me.schedulerControl1.PrintStyles.Add(Me.myPrintStyle)
        End Sub

        Private Sub btnShowPreview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnShowPreview.ItemClick
            schedulerControl1.ShowPrintPreview(Me.myPrintStyle)
        End Sub

        Private Sub btnUseDayViewScale_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles Selection.ItemClick
'            #Region "#customizeprintstyle"
            Dim printStyle As DailyPrintStyle = CType(schedulerControl1.PrintStyles(SchedulerPrintStyleKind.Daily), DailyPrintStyle)
            printStyle.UseActiveViewTimeScale = True
            printStyle.PrintTime.Start = schedulerControl1.SelectedInterval.Start.TimeOfDay
            printStyle.PrintTime.End = schedulerControl1.SelectedInterval.End.TimeOfDay
            If (Me.schedulerControl1.DayView.TimeScale.Minutes < 30) AndAlso (printStyle.PrintTime.Duration.TotalHours > 4) Then
                printStyle.CalendarHeaderVisible = False
                printStyle.AutoScaleHeadingsFont = False
                printStyle.HeadingsFont = New Font("Verdana", 8)
                printStyle.AppointmentFont = New Font("Verdana", 8)
            End If
            schedulerControl1.ShowPrintPreview(printStyle)
'            #End Region ' #customizeprintstyle
        End Sub

    End Class
End Namespace
