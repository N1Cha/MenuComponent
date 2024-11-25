namespace MenuComponent.Models
{
    public class MenuItem
    {
        public MenuItem(string title, List<MenuItem> childItems) 
        {
            Title = title;
            ChildItems = childItems;
        }

        public string Title { get; set; }

        public List<MenuItem> ChildItems { get; set; }
    }
}
