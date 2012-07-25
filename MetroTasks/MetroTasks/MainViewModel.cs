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
            //  Set the title.
            Title = "MetroTasks";

            //  Create the pages.
            CreatePages();
        }

        /// <summary>
        /// Creates the pages.
        /// </summary>
        private void CreatePages()
        {
            //  Create the 'home' section.
            var homeViewModel = new PageViewModel()
            {
                IsSelected = true,
                Title = "Home"
            };

            //  Add home pages.
            homeViewModel.Pages.Add(new ApexViewModel() { IsSelected = true });
            homeViewModel.Pages.Add(new TheShellViewModel());
            homeViewModel.Pages.Add(new TheModelViewModel());
            homeViewModel.Pages.Add(new ThePagesViewModel());
            homeViewModel.Pages.Add(new TasksViewModel());

            //  Create the 'collection' section.
            var collectionViewModel = new PageViewModel() { Title = "Collection" };

            //  Add the collection pages.
            collectionViewModel.Pages.Add(new MusicViewModel() { IsSelected = true });
            collectionViewModel.Pages.Add(new PicturesViewModel());

            //  Add the page groups to the view model.
            Pages.Add(homeViewModel);
            Pages.Add(collectionViewModel);
        }
    }
}
