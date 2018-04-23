Namespace Printing_Built_in_Example
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim timeRuler1 As New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler2 As New DevExpress.XtraScheduler.TimeRuler()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Dim superToolTip1 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem1 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem1 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip2 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem2 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem2 As New DevExpress.Utils.ToolTipItem()
            Dim superToolTip3 As New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem3 As New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem3 As New DevExpress.Utils.ToolTipItem()
            Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.openScheduleItem1 = New DevExpress.XtraScheduler.UI.OpenScheduleItem()
            Me.saveScheduleItem1 = New DevExpress.XtraScheduler.UI.SaveScheduleItem()
            Me.printPreviewItem1 = New DevExpress.XtraScheduler.UI.PrintPreviewItem()
            Me.printItem1 = New DevExpress.XtraScheduler.UI.PrintItem()
            Me.printPageSetupItem1 = New DevExpress.XtraScheduler.UI.PrintPageSetupItem()
            Me.btnAddMyDailyPrintStyle = New DevExpress.XtraBars.BarButtonItem()
            Me.btnShowPreview = New DevExpress.XtraBars.BarButtonItem()
            Me.fileRibbonPage1 = New DevExpress.XtraScheduler.UI.FileRibbonPage()
            Me.commonRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.CommonRibbonPageGroup()
            Me.printRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.PrintRibbonPageGroup()
            Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            Me.dateNavigator1 = New DevExpress.XtraScheduler.DateNavigator()
            Me.schedulerBarController1 = New DevExpress.XtraScheduler.UI.SchedulerBarController()
            Me.repositoryItemFontEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit()
            Me.Test = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.repositoryItemFontEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit()
            Me.Selection = New DevExpress.XtraBars.BarButtonItem()
            DirectCast(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.dateNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.schedulerBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemFontEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' schedulerControl1
            ' 
            Me.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl1.Location = New System.Drawing.Point(0, 142)
            Me.schedulerControl1.MenuManager = Me.ribbonControl1
            Me.schedulerControl1.Name = "schedulerControl1"
            Me.schedulerControl1.Size = New System.Drawing.Size(605, 419)
            Me.schedulerControl1.Start = New Date(2014, 9, 3, 0, 0, 0, 0)
            Me.schedulerControl1.Storage = Me.schedulerStorage1
            Me.schedulerControl1.TabIndex = 0
            Me.schedulerControl1.Text = "schedulerControl1"
            Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1)
            Me.schedulerControl1.Views.GanttView.Enabled = False
            Me.schedulerControl1.Views.MonthView.Enabled = False
            Me.schedulerControl1.Views.TimelineView.Enabled = False
            Me.schedulerControl1.Views.WeekView.Enabled = False
            Me.schedulerControl1.Views.WorkWeekView.Enabled = False
            Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.openScheduleItem1, Me.saveScheduleItem1, Me.printPreviewItem1, Me.printItem1, Me.printPageSetupItem1, Me.btnAddMyDailyPrintStyle, Me.btnShowPreview, Me.Selection})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 12
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.fileRibbonPage1})
            Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemFontEdit1, Me.repositoryItemFontEdit2})
            Me.ribbonControl1.Size = New System.Drawing.Size(784, 142)
            ' 
            ' openScheduleItem1
            ' 
            Me.openScheduleItem1.Id = 1
            Me.openScheduleItem1.Name = "openScheduleItem1"
            ' 
            ' saveScheduleItem1
            ' 
            Me.saveScheduleItem1.Id = 2
            Me.saveScheduleItem1.Name = "saveScheduleItem1"
            ' 
            ' printPreviewItem1
            ' 
            Me.printPreviewItem1.Id = 3
            Me.printPreviewItem1.Name = "printPreviewItem1"
            ' 
            ' printItem1
            ' 
            Me.printItem1.Id = 4
            Me.printItem1.Name = "printItem1"
            ' 
            ' printPageSetupItem1
            ' 
            Me.printPageSetupItem1.Id = 5
            Me.printPageSetupItem1.Name = "printPageSetupItem1"
            ' 
            ' btnAddMyDailyPrintStyle
            ' 
            Me.btnAddMyDailyPrintStyle.Caption = "Add MyDailyPrintStyle"
            Me.btnAddMyDailyPrintStyle.Glyph = (DirectCast(resources.GetObject("btnAddMyDailyPrintStyle.Glyph"), System.Drawing.Image))
            Me.btnAddMyDailyPrintStyle.Id = 6
            Me.btnAddMyDailyPrintStyle.LargeGlyph = (DirectCast(resources.GetObject("btnAddMyDailyPrintStyle.LargeGlyph"), System.Drawing.Image))
            Me.btnAddMyDailyPrintStyle.Name = "btnAddMyDailyPrintStyle"
            Me.btnAddMyDailyPrintStyle.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            toolTipTitleItem1.Text = "MyDailyPrintStyle"
            toolTipItem1.LeftIndent = 6
            toolTipItem1.Text = "Create MyDailyPrintStyle and add it to the collection of print styles."
            superToolTip1.Items.Add(toolTipTitleItem1)
            superToolTip1.Items.Add(toolTipItem1)
            Me.btnAddMyDailyPrintStyle.SuperTip = superToolTip1
            ' 
            ' btnShowPreview
            ' 
            Me.btnShowPreview.Caption = "MyDailyPrintStyle"
            Me.btnShowPreview.Glyph = (DirectCast(resources.GetObject("btnShowPreview.Glyph"), System.Drawing.Image))
            Me.btnShowPreview.Id = 7
            Me.btnShowPreview.LargeGlyph = (DirectCast(resources.GetObject("btnShowPreview.LargeGlyph"), System.Drawing.Image))
            Me.btnShowPreview.Name = "btnShowPreview"
            Me.btnShowPreview.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            toolTipTitleItem2.Text = "Print Preview"
            toolTipItem2.LeftIndent = 6
            toolTipItem2.Text = "Show print preview using MyDailyPrintStyle."
            superToolTip2.Items.Add(toolTipTitleItem2)
            superToolTip2.Items.Add(toolTipItem2)
            Me.btnShowPreview.SuperTip = superToolTip2
            ' 
            ' fileRibbonPage1
            ' 
            Me.fileRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.commonRibbonPageGroup1, Me.printRibbonPageGroup1, Me.Test})
            Me.fileRibbonPage1.Name = "fileRibbonPage1"
            ' 
            ' commonRibbonPageGroup1
            ' 
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.openScheduleItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.saveScheduleItem1)
            Me.commonRibbonPageGroup1.Name = "commonRibbonPageGroup1"
            ' 
            ' printRibbonPageGroup1
            ' 
            Me.printRibbonPageGroup1.ItemLinks.Add(Me.printPreviewItem1)
            Me.printRibbonPageGroup1.ItemLinks.Add(Me.printItem1)
            Me.printRibbonPageGroup1.ItemLinks.Add(Me.printPageSetupItem1)
            Me.printRibbonPageGroup1.Name = "printRibbonPageGroup1"
            ' 
            ' dateNavigator1
            ' 
            Me.dateNavigator1.Dock = System.Windows.Forms.DockStyle.Right
            Me.dateNavigator1.Location = New System.Drawing.Point(605, 142)
            Me.dateNavigator1.Name = "dateNavigator1"
        Me.dateNavigator1.CellPadding = New System.Windows.Forms.Padding(2)
            Me.dateNavigator1.SchedulerControl = Me.schedulerControl1
            Me.dateNavigator1.Size = New System.Drawing.Size(179, 419)
            Me.dateNavigator1.TabIndex = 2
            ' 
            ' schedulerBarController1
            ' 
            Me.schedulerBarController1.BarItems.Add(Me.openScheduleItem1)
            Me.schedulerBarController1.BarItems.Add(Me.saveScheduleItem1)
            Me.schedulerBarController1.BarItems.Add(Me.printPreviewItem1)
            Me.schedulerBarController1.BarItems.Add(Me.printItem1)
            Me.schedulerBarController1.BarItems.Add(Me.printPageSetupItem1)
            Me.schedulerBarController1.Control = Me.schedulerControl1
            ' 
            ' repositoryItemFontEdit1
            ' 
            Me.repositoryItemFontEdit1.AutoHeight = False
            Me.repositoryItemFontEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1"
            ' 
            ' Test
            ' 
            Me.Test.ItemLinks.Add(Me.btnAddMyDailyPrintStyle)
            Me.Test.ItemLinks.Add(Me.btnShowPreview)
            Me.Test.ItemLinks.Add(Me.Selection)
            Me.Test.Name = "Test"
            Me.Test.Text = "Test"
            ' 
            ' repositoryItemFontEdit2
            ' 
            Me.repositoryItemFontEdit2.AutoHeight = False
            Me.repositoryItemFontEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemFontEdit2.Name = "repositoryItemFontEdit2"
            ' 
            ' Selection
            ' 
            Me.Selection.Caption = "Selection with DayView TimeScale"
            Me.Selection.Glyph = (DirectCast(resources.GetObject("Selection.Glyph"), System.Drawing.Image))
            Me.Selection.Id = 10
            Me.Selection.LargeGlyph = (DirectCast(resources.GetObject("Selection.LargeGlyph"), System.Drawing.Image))
            Me.Selection.Name = "Selection"
            Me.Selection.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            toolTipTitleItem3.Text = "Print Preview Selection"
            toolTipItem3.LeftIndent = 6
            toolTipItem3.Text = "Click an drag in the scheduler to select a time interval. Click this button to ad" & "just print style settings and show the print preview."
            superToolTip3.Items.Add(toolTipTitleItem3)
            superToolTip3.Items.Add(toolTipItem3)
            Me.Selection.SuperTip = superToolTip3
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(784, 561)
            Me.Controls.Add(Me.schedulerControl1)
            Me.Controls.Add(Me.dateNavigator1)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.dateNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.schedulerBarController1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemFontEdit2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
        Private schedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
        Private openScheduleItem1 As DevExpress.XtraScheduler.UI.OpenScheduleItem
        Private saveScheduleItem1 As DevExpress.XtraScheduler.UI.SaveScheduleItem
        Private printPreviewItem1 As DevExpress.XtraScheduler.UI.PrintPreviewItem
        Private printItem1 As DevExpress.XtraScheduler.UI.PrintItem
        Private printPageSetupItem1 As DevExpress.XtraScheduler.UI.PrintPageSetupItem
        Private fileRibbonPage1 As DevExpress.XtraScheduler.UI.FileRibbonPage
        Private commonRibbonPageGroup1 As DevExpress.XtraScheduler.UI.CommonRibbonPageGroup
        Private printRibbonPageGroup1 As DevExpress.XtraScheduler.UI.PrintRibbonPageGroup
        Private dateNavigator1 As DevExpress.XtraScheduler.DateNavigator
        Private schedulerBarController1 As DevExpress.XtraScheduler.UI.SchedulerBarController
        Private WithEvents btnAddMyDailyPrintStyle As DevExpress.XtraBars.BarButtonItem
        Private WithEvents btnShowPreview As DevExpress.XtraBars.BarButtonItem
        Private repositoryItemFontEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemFontEdit
        Private repositoryItemFontEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemFontEdit
        Private Test As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private WithEvents Selection As DevExpress.XtraBars.BarButtonItem
    End Class
End Namespace

