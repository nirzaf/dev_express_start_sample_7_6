using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using sample_7_6.ViewModels;

namespace sample_7_6.Views {
  public partial class TaskView : DevExpress.XtraEditors.XtraUserControl {
    public TaskView() {
      InitializeComponent();
    }

    private void TaskView_Load(object sender, EventArgs e) {
      var fluent = mvvmContext1.OfType<TaskViewModel>();
      fluent.SetObjectDataSourceBinding(taskViewModelBindingSource);
    }
  }
}
