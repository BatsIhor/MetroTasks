using System.Windows.Controls;

using Apex.Behaviours;
using Apex.MVVM;

namespace MetroTasks.Pages.TaskList
{
    /// <summary>
    /// Interaction logic for ThePagesView.xaml
    /// </summary>
    [View(typeof(TasksViewModel))]
    public partial class TasksView : UserControl, IView
    {
        public TasksView()
        {
            InitializeComponent();
        }

        public void OnActivated()
        {
            SlideFadeInBehaviour.DoSlideFadeIn(this);
        }

        public void OnDeactivated()
        {
        }
    }
}
