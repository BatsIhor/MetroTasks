using Apex.MVVM;
using MetroTasks.Pages;
using MetroTasks.Pages.Apex;
using MetroTasks.Pages.TaskList;
using MetroTasks.Pages.TheModel;
using MetroTasks.Pages.ThePages;
using MetroTasks.Pages.TheShell;
using MetroTasks.ViewModels;

namespace MetroTasks
{
    /// <summary>
    /// The MainViewModel ViewModel class.
    /// </summary>
    [ViewModel]
    public class MainViewModel : PageViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainViewModel"/> class.
        /// </summary>
        public MainViewModel()
        {
            Title = "MetroTasks";
            CreatePages();
        }

        /// <summary>
        /// Creates the pages.
        /// </summary>
        private void CreatePages()
        {
            PageViewModel homeViewModel = new PageViewModel()
            {
                IsSelected = true,
                Title = "Home"
            };

            homeViewModel.Pages.Add(new ApexViewModel() { IsSelected = true });
            homeViewModel.Pages.Add(new TheShellViewModel());
            homeViewModel.Pages.Add(new TheModelViewModel());
            homeViewModel.Pages.Add(new ThePagesViewModel());
            homeViewModel.Pages.Add(new TasksViewModel());
            homeViewModel.Pages.Add(new TasksViewModel());

            var collectionViewModel = new PageViewModel() { Title = "Collection" };

            collectionViewModel.Pages.Add(new MusicViewModel() { IsSelected = true });
            collectionViewModel.Pages.Add(new PicturesViewModel());

            Pages.Add(homeViewModel);
            Pages.Add(collectionViewModel);
        }
    }
}
