Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace Printing_Built_in_Example
    #Region "#myprintdailystyle"
    Friend Class MyDailyPrintStyle
        Inherits DevExpress.XtraScheduler.Printing.DailyPrintStyle

        Public Sub New()
            MyBase.New(False)
            ' Print information on appointments which do not fall in the PrintTime interval.
            MyBase.PrintAllAppointments = True
            ' Do not use time slots displayed in the Day view of the SchedulerControl.
            MyBase.UseActiveViewTimeScale = False
            ' Determine the row height (specify the time interval of a time slot).
            MyBase.TimeSlots.Clear()
            MyBase.TimeSlots.Add(TimeSpan.FromMinutes(15), "15Minutes")
            ' Specify the time interval to print.
            MyBase.PrintTime = New DevExpress.XtraScheduler.TimeOfDayInterval(TimeSpan.FromHours(12), TimeSpan.FromHours(14))
        End Sub

        Protected Overrides ReadOnly Property DefaultDisplayName() As String
            Get
                Return "My DailyPrintStyle"
            End Get
        End Property
    End Class
    #End Region ' #myprintdailystyle
End Namespace
