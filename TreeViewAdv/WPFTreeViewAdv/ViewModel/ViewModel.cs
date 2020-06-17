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
            Model Root4 = new Model() { Header = "Deleted Items", Image = "Images/deleted.png", ImagePosition = "Right" };
            TreeItems.Add(Root4);
            Model Root5 = new Model() { Header = "Drafts", Image = "Images/drafts.png", ImagePosition = "Right" };
            TreeItems.Add(Root5);
            Model Root6 = new Model() { Header = "Inbox", Image = "Images/inbox.png", ImagePosition = "Right" };
            TreeItems.Add(Root6);
            Model Root7 = new Model() { Header = "Outbox", Image = "Images/outbox.png", ImagePosition = "Right" };
            TreeItems.Add(Root7);
            Model Root8 = new Model() { Header = "Sent Items", Image = "Images/sentItems.png", ImagePosition = "Right" };
            TreeItems.Add(Root8);
            Model Root9 = new Model() { Header = "Personal", Image = "Images/folders.png", ImagePosition = "Right" };
            TreeItems.Add(Root9);
            Model Root10 = new Model() { Header = "Junk", Image = "Images/junk.png", ImagePosition = "Right" };
            TreeItems.Add(Root10);
            Model Root11 = new Model() { Header = "Journal", Image = "Images/notes.png", ImagePosition = "Right" };
            TreeItems.Add(Root11);
            return TreeItems;
        }
    }
}