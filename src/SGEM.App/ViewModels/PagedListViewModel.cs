using System.Collections.Generic;

namespace SGEM.App.ViewModels
{
    public class PagedListViewModel<TViewMode> where TViewMode : ViewModel
    {
        public List<TViewMode> Collection { get; set; }
        public int Amount { get; set; }
    }
}
