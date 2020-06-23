using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WPFTreeViewAdv
{
    class ViewModel
    {
        public ObservableCollection<Model> TreeItems { get; set; }

        public ViewModel()
        {
            TreeItems = PopulateData();
        }

        private ObservableCollection<Model> PopulateData()
        {
            TreeItems = new ObservableCollection<Model>();
            Model Root1 = new Model() { Header = "Mailbox",  Image = "Images/root.png", ImagePosition = "Right" };
            TreeItems.Add(Root1);
            Model Root2 = new Model() { Header = "Calendar", Image = "Images/calendar.png", ImagePosition = "Right" };
            TreeItems.Add(Root2);
            Model Root3 = new Model() { Header = "Contacts", Image = "Images/contacts.png", ImagePosition = "Right" };
            TreeItems.Add(Root3);
            Model Root4 = new Model() { Header = "Deleted Items", Image = "Images/deleted.png", ImagePosition = "Left" };
            TreeItems.Add(Root4);
            Model Root5 = new Model() { Header = "Drafts", Image = "Images/drafts.png", ImagePosition = "Left" };
            TreeItems.Add(Root5);
            return TreeItems;
        }
    }
}