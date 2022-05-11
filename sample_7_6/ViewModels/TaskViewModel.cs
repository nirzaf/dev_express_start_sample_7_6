using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;

namespace sample_7_6.ViewModels {
  [POCOViewModel]
  public class TaskViewModel {
    public virtual string Subject { get; set; }
    public virtual DateTime DueDate { get; set; }

    //public TaskViewModel() {
    //  Subject = "Something important";
    //  DueDate = DateTime.Today.AddDays(1);
    //}

    protected TaskViewModel(string subject, DateTime dueDate) {
      this.Subject = subject;
      this.DueDate = dueDate;
    }

    protected TaskViewModel() : this("Something important", DateTime.Now.AddDays(1)) { }

    public static TaskViewModel Create(string subject, DateTime dueDate) =>
        ViewModelSource.Create(() => new TaskViewModel(subject, dueDate));

    public static TaskViewModel Create() =>
        ViewModelSource.Create(() => new TaskViewModel());

    public void Postpone() {
      DueDate = DueDate + TimeSpan.FromDays(1);
    }

    public virtual bool Done { get; set; }

    public bool CanMarkDone() => !Done;

    public void MarkDone() {
      if (MessageBoxService.ShowMessage(
        "Are you sure?", "Question",
        MessageButton.YesNo, MessageIcon.Question,
        MessageResult.No) == MessageResult.Yes)
        Done = true;
    }

    protected void OnDoneChanged() => this.RaiseCanExecuteChanged(x => x.MarkDone());

    [ServiceProperty]
    protected virtual IMessageBoxService MessageBoxService { get { return null; } }
  }
}