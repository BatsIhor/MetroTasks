using System.Collections.ObjectModel;

using Apex.Controls;
using Apex.MVVM;

namespace MetroTasks.Pages
{
    [ViewModel]
    public class PageViewModel : ViewModel, ISelectableItem
    {
        /// <summary>
        /// The Pages observable collection.
        /// </summary>
        private readonly ObservableCollection<PageViewModel> pagesProperty = new ObservableCollection<PageViewModel>();

        /// <summary>
        /// The NotifyingProperty for the Title property.
        /// </summary>
        private readonly NotifyingProperty titleProperty = new NotifyingProperty("Title", typeof(string), default(string));

        /// <summary>
        /// The NotifyingProperty for the IsSelected property.
        /// </summary>
        private readonly NotifyingProperty isSelectedProperty = new NotifyingProperty("IsSelected", typeof(bool), default(bool));

        /// <summary>
        /// The NotifyingProperty for the ActivePage property.
        /// </summary>
        private readonly NotifyingProperty activePageProperty = new NotifyingProperty("ActivePage", typeof(PageViewModel), default(PageViewModel));

        /// <summary>
        /// Gets or sets Title.
        /// </summary>
        /// <value>The value of Title.</value>
        public string Title
        {
            get
            {
                return (string)GetValue(this.titleProperty);
            }

            set
            {
                SetValue(this.titleProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is selected.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is selected; otherwise, <c>false</c>.
        /// </value>
        public bool IsSelected
        {
            get
            {
                return (bool)GetValue(this.isSelectedProperty);
            }

            set
            {
                SetValue(this.isSelectedProperty, value);
            }
        }
        
        /// <summary>
        /// Gets the Pages observable collection.
        /// </summary>
        /// <value>The Pages observable collection.</value>
        public ObservableCollection<PageViewModel> Pages
        {
            get { return this.pagesProperty; }
        }

        /// <summary>
        /// Gets or sets ActivePage.
        /// </summary>
        /// <value>The value of ActivePage.</value>
        public PageViewModel ActivePage
        {
            get
            {
                return (PageViewModel)GetValue(this.activePageProperty);
            }

            set
            {
                SetValue(this.activePageProperty, value);
            }
        }

        public void OnSelected()
        {
        }

        public void OnDeselected()
        {
        }
    }
}
