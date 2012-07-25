using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Apex;
using Apex.MVVM;
using MetroTasks.Models;
using MetroTasks.ViewModels;

namespace MetroTasks.Pages.TheModel
{
    /// <summary>
    /// The TheModelViewModel ViewModel class.
    /// </summary>
    public class TheModelViewModel : PageViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TheModelViewModel"/> class.
        /// </summary>
        public TheModelViewModel()
        {
            Title = "The Model";
        }
    }
}
