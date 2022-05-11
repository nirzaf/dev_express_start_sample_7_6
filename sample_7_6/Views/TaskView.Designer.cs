namespace sample_7_6.Views {
  partial class TaskView {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
      this.SubjectTextEdit = new DevExpress.XtraEditors.TextEdit();
      this.taskViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.DueDateDateEdit = new DevExpress.XtraEditors.DateEdit();
      this.DoneCheckEdit = new DevExpress.XtraEditors.CheckEdit();
      this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
      this.bar1 = new DevExpress.XtraBars.Bar();
      this.bbiPostpone = new DevExpress.XtraBars.BarButtonItem();
      this.bbiMarkDone = new DevExpress.XtraBars.BarButtonItem();
      this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
      this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.ItemForSubject = new DevExpress.XtraLayout.LayoutControlItem();
      this.ItemForDueDate = new DevExpress.XtraLayout.LayoutControlItem();
      this.ItemForDone = new DevExpress.XtraLayout.LayoutControlItem();
      this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
      this.dataLayoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.SubjectTextEdit.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.taskViewModelBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DueDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DueDateDateEdit.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DoneCheckEdit.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ItemForSubject)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ItemForDueDate)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ItemForDone)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
      this.SuspendLayout();
      // 
      // dataLayoutControl1
      // 
      this.dataLayoutControl1.Controls.Add(this.SubjectTextEdit);
      this.dataLayoutControl1.Controls.Add(this.DueDateDateEdit);
      this.dataLayoutControl1.Controls.Add(this.DoneCheckEdit);
      this.dataLayoutControl1.DataSource = this.taskViewModelBindingSource;
      this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataLayoutControl1.Location = new System.Drawing.Point(0, 20);
      this.dataLayoutControl1.Name = "dataLayoutControl1";
      this.dataLayoutControl1.Root = this.Root;
      this.dataLayoutControl1.Size = new System.Drawing.Size(575, 338);
      this.dataLayoutControl1.TabIndex = 0;
      this.dataLayoutControl1.Text = "dataLayoutControl1";
      // 
      // SubjectTextEdit
      // 
      this.SubjectTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.taskViewModelBindingSource, "Subject", true));
      this.SubjectTextEdit.Location = new System.Drawing.Point(60, 12);
      this.SubjectTextEdit.Name = "SubjectTextEdit";
      this.SubjectTextEdit.Size = new System.Drawing.Size(503, 20);
      this.SubjectTextEdit.StyleController = this.dataLayoutControl1;
      this.SubjectTextEdit.TabIndex = 4;
      // 
      // taskViewModelBindingSource
      // 
      this.taskViewModelBindingSource.DataSource = typeof(sample_7_6.ViewModels.TaskViewModel);
      // 
      // DueDateDateEdit
      // 
      this.DueDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.taskViewModelBindingSource, "DueDate", true));
      this.DueDateDateEdit.EditValue = null;
      this.DueDateDateEdit.Location = new System.Drawing.Point(60, 36);
      this.DueDateDateEdit.Name = "DueDateDateEdit";
      this.DueDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.DueDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.DueDateDateEdit.Size = new System.Drawing.Size(503, 20);
      this.DueDateDateEdit.StyleController = this.dataLayoutControl1;
      this.DueDateDateEdit.TabIndex = 5;
      // 
      // DoneCheckEdit
      // 
      this.DoneCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.taskViewModelBindingSource, "Done", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.DoneCheckEdit.Location = new System.Drawing.Point(12, 60);
      this.DoneCheckEdit.MenuManager = this.barManager1;
      this.DoneCheckEdit.Name = "DoneCheckEdit";
      this.DoneCheckEdit.Properties.Caption = "Done";
      this.DoneCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
      this.DoneCheckEdit.Size = new System.Drawing.Size(551, 20);
      this.DoneCheckEdit.StyleController = this.dataLayoutControl1;
      this.DoneCheckEdit.TabIndex = 6;
      // 
      // barManager1
      // 
      this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
      this.barManager1.DockControls.Add(this.barDockControlTop);
      this.barManager1.DockControls.Add(this.barDockControlBottom);
      this.barManager1.DockControls.Add(this.barDockControlLeft);
      this.barManager1.DockControls.Add(this.barDockControlRight);
      this.barManager1.Form = this;
      this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiPostpone,
            this.bbiMarkDone});
      this.barManager1.MaxItemId = 2;
      // 
      // bar1
      // 
      this.bar1.BarName = "Tools";
      this.bar1.DockCol = 0;
      this.bar1.DockRow = 0;
      this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
      this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiPostpone),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiMarkDone)});
      this.bar1.Text = "Tools";
      // 
      // bbiPostpone
      // 
      this.bbiPostpone.Caption = "Postpone";
      this.bbiPostpone.Id = 0;
      this.bbiPostpone.ImageOptions.ImageUri.Uri = "Postpone";
      this.bbiPostpone.Name = "bbiPostpone";
      // 
      // bbiMarkDone
      // 
      this.bbiMarkDone.Caption = "Mark Done";
      this.bbiMarkDone.Id = 1;
      this.bbiMarkDone.Name = "bbiMarkDone";
      // 
      // barDockControlTop
      // 
      this.barDockControlTop.CausesValidation = false;
      this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
      this.barDockControlTop.Manager = this.barManager1;
      this.barDockControlTop.Size = new System.Drawing.Size(575, 20);
      // 
      // barDockControlBottom
      // 
      this.barDockControlBottom.CausesValidation = false;
      this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.barDockControlBottom.Location = new System.Drawing.Point(0, 358);
      this.barDockControlBottom.Manager = this.barManager1;
      this.barDockControlBottom.Size = new System.Drawing.Size(575, 0);
      // 
      // barDockControlLeft
      // 
      this.barDockControlLeft.CausesValidation = false;
      this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
      this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
      this.barDockControlLeft.Manager = this.barManager1;
      this.barDockControlLeft.Size = new System.Drawing.Size(0, 338);
      // 
      // barDockControlRight
      // 
      this.barDockControlRight.CausesValidation = false;
      this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
      this.barDockControlRight.Location = new System.Drawing.Point(575, 20);
      this.barDockControlRight.Manager = this.barManager1;
      this.barDockControlRight.Size = new System.Drawing.Size(0, 338);
      // 
      // Root
      // 
      this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
      this.Root.Name = "Root";
      this.Root.Size = new System.Drawing.Size(575, 338);
      this.Root.TextVisible = false;
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.AllowDrawBackground = false;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForSubject,
            this.ItemForDueDate,
            this.ItemForDone});
      this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup1.Name = "autoGeneratedGroup0";
      this.layoutControlGroup1.Size = new System.Drawing.Size(555, 318);
      // 
      // ItemForSubject
      // 
      this.ItemForSubject.Control = this.SubjectTextEdit;
      this.ItemForSubject.Location = new System.Drawing.Point(0, 0);
      this.ItemForSubject.Name = "ItemForSubject";
      this.ItemForSubject.Size = new System.Drawing.Size(555, 24);
      this.ItemForSubject.Text = "Subject";
      this.ItemForSubject.TextSize = new System.Drawing.Size(45, 13);
      // 
      // ItemForDueDate
      // 
      this.ItemForDueDate.Control = this.DueDateDateEdit;
      this.ItemForDueDate.Location = new System.Drawing.Point(0, 24);
      this.ItemForDueDate.Name = "ItemForDueDate";
      this.ItemForDueDate.Size = new System.Drawing.Size(555, 24);
      this.ItemForDueDate.Text = "Due Date";
      this.ItemForDueDate.TextSize = new System.Drawing.Size(45, 13);
      // 
      // ItemForDone
      // 
      this.ItemForDone.Control = this.DoneCheckEdit;
      this.ItemForDone.Location = new System.Drawing.Point(0, 48);
      this.ItemForDone.Name = "ItemForDone";
      this.ItemForDone.Size = new System.Drawing.Size(555, 270);
      this.ItemForDone.Text = "Done";
      this.ItemForDone.TextSize = new System.Drawing.Size(0, 0);
      this.ItemForDone.TextVisible = false;
      // 
      // mvvmContext1
      // 
      this.mvvmContext1.BindingExpressions.AddRange(new DevExpress.Utils.MVVM.BindingExpression[] {
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(sample_7_6.ViewModels.TaskViewModel), "Postpone", this.bbiPostpone),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(sample_7_6.ViewModels.TaskViewModel), "MarkDone", this.bbiMarkDone)});
      this.mvvmContext1.ContainerControl = this;
      this.mvvmContext1.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterMessageBoxService(null, false, DevExpress.Utils.MVVM.Services.DefaultMessageBoxServiceType.XtraMessageBox)});
      this.mvvmContext1.ViewModelType = typeof(sample_7_6.ViewModels.TaskViewModel);
      // 
      // TaskView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.dataLayoutControl1);
      this.Controls.Add(this.barDockControlLeft);
      this.Controls.Add(this.barDockControlRight);
      this.Controls.Add(this.barDockControlBottom);
      this.Controls.Add(this.barDockControlTop);
      this.Name = "TaskView";
      this.Size = new System.Drawing.Size(575, 358);
      this.Load += new System.EventHandler(this.TaskView_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
      this.dataLayoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.SubjectTextEdit.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.taskViewModelBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DueDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DueDateDateEdit.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DoneCheckEdit.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ItemForSubject)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ItemForDueDate)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ItemForDone)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }
    #endregion

    private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
    private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup Root;
    private DevExpress.XtraEditors.TextEdit SubjectTextEdit;
    private System.Windows.Forms.BindingSource taskViewModelBindingSource;
    private DevExpress.XtraEditors.DateEdit DueDateDateEdit;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraLayout.LayoutControlItem ItemForSubject;
    private DevExpress.XtraLayout.LayoutControlItem ItemForDueDate;
    private DevExpress.XtraBars.BarButtonItem bbiPostpone;
    private DevExpress.XtraBars.BarDockControl barDockControlLeft;
    private DevExpress.XtraBars.BarManager barManager1;
    private DevExpress.XtraBars.Bar bar1;
    private DevExpress.XtraBars.BarDockControl barDockControlTop;
    private DevExpress.XtraBars.BarDockControl barDockControlBottom;
    private DevExpress.XtraBars.BarDockControl barDockControlRight;
    private DevExpress.XtraEditors.CheckEdit DoneCheckEdit;
    private DevExpress.XtraBars.BarButtonItem bbiMarkDone;
    private DevExpress.XtraLayout.LayoutControlItem ItemForDone;
  }
}
