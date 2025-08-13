# How to customize the icons in Syncfusion WPF TreeViewAdv?

Follow the below steps, can customize the [WPF TreeViewAdv](https://help.syncfusion.com/wpf/classic/treeview/overview) icon using MVVM.

**Step 1:** Create a Model class to responsible for exposing data from the ViewModel.

**Step 2:** Create a view model class and add the properties to bind the values. The ImagePosition property to determine the position of the TreeViewAdv icon.

**Step 3:** Define the TreeViewAdv control and bind the ItemSource property.

**Step 4:** Define the DataContext and ItemTemplate of TreeViewAdv to appear the items.

**Step 5:** Define the ItemContainerStyle for add the icons to respective [RightImageSource](https://help.syncfusion.com/cr/wpf/Syncfusion.Windows.Tools.Controls.TreeViewItemAdv.html#Syncfusion_Windows_Tools_Controls_TreeViewItemAdv_RightImageSource) and [LeftImageSource](https://help.syncfusion.com/cr/wpf/Syncfusion.Windows.Tools.Controls.TreeViewItemAdv.html#Syncfusion_Windows_Tools_Controls_TreeViewItemAdv_LeftImageSource) collection based on ImagePosition property.

```xml
<Grid>
    <syncfusion:TreeViewAdv x:Name="TreeViewAdv"
                            ItemsSource="{Binding TreeItems}"
                            Width="150"
                            Height="150">
        <syncfusion:TreeViewAdv.DataContext>
            <local:ViewModel />
        </syncfusion:TreeViewAdv.DataContext>

        <syncfusion:TreeViewAdv.ItemTemplate>
            <!-- Binding to SubItems to build the hierarchy -->
            <HierarchicalDataTemplate ItemsSource="{Binding SubItems}">
                <TextBlock Text="{Binding Header}" />
            </HierarchicalDataTemplate>
        </syncfusion:TreeViewAdv.ItemTemplate>

        <syncfusion:TreeViewAdv.ItemContainerStyle>
            <Style TargetType="syncfusion:TreeViewItemAdv">
                <Style.Triggers>
                    <DataTrigger Binding="{Binding ImagePosition}" Value="Right">
                        <Setter Property="RightImageSource" Value="{Binding Image}" />
                    </DataTrigger>
                    <DataTrigger Binding="{Binding ImagePosition}" Value="Left">
                        <Setter Property="LeftImageSource" Value="{Binding Image}" />
                    </DataTrigger>
                </Style.Triggers>
            </Style>
        </syncfusion:TreeViewAdv.ItemContainerStyle>
    </syncfusion:TreeViewAdv>
</Grid>
```

```csharp
public class ViewModel
{
    public ObservableCollection<Model> TreeItems { get; set; }

    public ViewModel()
    {
        // The TreeItems collection is initialized here.
        TreeItems = new ObservableCollection<Model>();
        PopulateData();
    }

    private void PopulateData()
    {
        // The data is added directly to the TreeItems property of the class.
        Model root1 = new Model() { Header = "Mailbox", Image = "Images/root.png", ImagePosition = "Right" };
        TreeItems.Add(root1);

        Model root2 = new Model() { Header = "Calendar", Image = "Images/calendar.png", ImagePosition = "Right" };
        TreeItems.Add(root2);

        Model root3 = new Model() { Header = "Contacts", Image = "Images/contacts.png", ImagePosition = "Right" };
        TreeItems.Add(root3);

        Model root4 = new Model() { Header = "Deleted Items", Image = "Images/deleted.png", ImagePosition = "Left" };
        TreeItems.Add(root4);

        Model root5 = new Model() { Header = "Drafts", Image = "Images/drafts.png", ImagePosition = "Left" };
        TreeItems.Add(root5);
    }
}
```

```csharp
public class Model
{
    public string Header { get; set; }
    public string Image { get; set; }
    public string ImagePosition { get; set; }
}
```
