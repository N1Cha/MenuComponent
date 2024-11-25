using MenuItem_Model = MenuComponent.Models.MenuItem;

namespace MenuComponent.Demo
{
    public class InMemoryData
    {
        public List<MenuItem_Model> Vehicles { get; } = new List<MenuItem_Model>()
        {
            new MenuItem_Model("Cars", new List<MenuItem_Model>()
            {
                new MenuItem_Model("Ferrari", new List<MenuItem_Model>()
                {
                    new MenuItem_Model("Roma", new List<MenuItem_Model>()
                    {
                        new MenuItem_Model("3.9 L F154 BH twin-turbo V8 612HP", null),
                    }),
                }),
                new MenuItem_Model("Toyota", null),
                new MenuItem_Model("Alfa Romeo", new List<MenuItem_Model>()
                {
                    new MenuItem_Model("Junior", new List<MenuItem_Model>()
                    {
                        new MenuItem_Model("1.2 THP (EB2ADTD) I3 turbo mild hybrid", null),
                    }),
                    new MenuItem_Model("Tonale", new List<MenuItem_Model>()
                    {
                        new MenuItem_Model("Petrol",  new List<MenuItem_Model>()
                        {
                            new MenuItem_Model("2.0 L TBI-M T4 Multiair turbo I4 petrol", null),
                            new MenuItem_Model("2.9 L 690T twin turbo V6 petrol", null),
                        }),
                        new MenuItem_Model("Diesel",  new List<MenuItem_Model>()
                        {
                            new MenuItem_Model("2.2 L JTDm Multijet II TD I4 diesel", null),
                        }),
                    }),
                    new MenuItem_Model("Stelvio", new List<MenuItem_Model>()
                    {
                        new MenuItem_Model("2.0 L TBI-M T4 Multiair turbo I4 petrol", null),
                        new MenuItem_Model("2.9 L 690T twin turbo V6 petrol", null),
                        new MenuItem_Model("2.2 L JTDm Multijet II TD I4 diesel", null),
                    }),
                    new MenuItem_Model("Guilia",  new List<MenuItem_Model>()
                    {
                        new MenuItem_Model("2.0 L GME T4 Multiair turbo I4 Petrol", null),
                        new MenuItem_Model("2.9 L 690T twin-turbo V6 Petrol", null),
                        new MenuItem_Model("2.2 L JTDm Multijet II I4 Diesel", null),
                    }),
                })
            }),
            new MenuItem_Model("Busses", new List<MenuItem_Model>()
            {
                new MenuItem_Model("Scania",  new List<MenuItem_Model>()
                {
                    new MenuItem_Model("Citywide", new List<MenuItem_Model>()
                    {
                        new MenuItem_Model("Diesel, 280-360 hp", null),
                        new MenuItem_Model("GAS, 250-320 hp", null),
                        new MenuItem_Model("Hubrid", null),
                    }),
                    new MenuItem_Model("Touring", new List<MenuItem_Model>()
                    {
                        new MenuItem_Model("Diesel, 360-520 hp", null),
                    }),
                }),
                new MenuItem_Model("Volvo", new List<MenuItem_Model>()
                {
                    new MenuItem_Model("7900", new List<MenuItem_Model>()
                    {
                        new MenuItem_Model("Diesel, 235-290 hp", null),
                        new MenuItem_Model("Hubrid", null),
                    }),
                    new MenuItem_Model("9700", new List<MenuItem_Model>()
                    {
                        new MenuItem_Model("Diesel, 380-500 hp", null),
                    }),
                })
            }),
             new MenuItem_Model("Trucks", new List<MenuItem_Model>()
            {
                new MenuItem_Model("Mercedes-Benz",  new List<MenuItem_Model>()
                {
                    new MenuItem_Model("Actros",null),
                    new MenuItem_Model("Arocs",null),
                })
            })
        };

        public List<MenuItem_Model> Products { get; } = new List<MenuItem_Model>()
        {
            new MenuItem_Model("Electronics", new List<MenuItem_Model>()
            {
                new MenuItem_Model("Phones", new List<MenuItem_Model>()
                {
                    new MenuItem_Model("Smartphones", new List<MenuItem_Model>()
                    {
                        new MenuItem_Model("Android", new List<MenuItem_Model>()
                        {
                            new MenuItem_Model("Samsung", null),
                            new MenuItem_Model("Google", null),
                        }),
                        new MenuItem_Model("iOS", null),
                    }),
                    new MenuItem_Model("Feature Phones", null),
                }),
                new MenuItem_Model("Laptops", new List<MenuItem_Model>()
                {
                    new MenuItem_Model("Gaming Laptops", null),
                    new MenuItem_Model("Business Laptops", null),
                    new MenuItem_Model("Ultrabooks", null),
                }),
                new MenuItem_Model("Cameras", null),
            }),
            new MenuItem_Model("Home Appliances", new List<MenuItem_Model>()
            {
                new MenuItem_Model("Kitchen Appliances", new List<MenuItem_Model>()
                {
                    new MenuItem_Model("Refrigerators", null),
                    new MenuItem_Model("Microwaves", null),
                    new MenuItem_Model("Ovens", null),
                }),
                new MenuItem_Model("Laundry Appliances", new List<MenuItem_Model>()
                {
                    new MenuItem_Model("Washing Machines", null),
                    new MenuItem_Model("Dryers", null),
                }),
            }),
            new MenuItem_Model("Furniture", new List<MenuItem_Model>()
            {
                new MenuItem_Model("Living Room", new List<MenuItem_Model>()
                {
                    new MenuItem_Model("Sofas", null),
                    new MenuItem_Model("Coffee Tables", null),
                }),
                new MenuItem_Model("Bedroom", new List<MenuItem_Model>()
                {
                    new MenuItem_Model("Beds", null),
                    new MenuItem_Model("Wardrobes", null),
                }),
            }),
            new MenuItem_Model("Clothing", new List<MenuItem_Model>()
            {
                new MenuItem_Model("Men's Clothing", new List<MenuItem_Model>()
                { 
                    new MenuItem_Model("Shirts", null),
                    new MenuItem_Model("Pants", null),
                    new MenuItem_Model("Shoes", null),
                }),
                new MenuItem_Model("Women's Clothing", new List<MenuItem_Model>()
                { 
                    new MenuItem_Model("Dresses", null),
                    new MenuItem_Model("Tops", null), 
                    new MenuItem_Model("Shoes", null), 
                }), 
                new MenuItem_Model("Children's Clothing", null), 
            }), 
            new MenuItem_Model("Books & Media", new List<MenuItem_Model>()
            { 
                new MenuItem_Model("Books", new List<MenuItem_Model>() 
                { 
                    new MenuItem_Model("Fiction", null),
                    new MenuItem_Model("Non-fiction", null),
                    new MenuItem_Model("Children's Books", null), 
                }), new MenuItem_Model("Movies", null),
                new MenuItem_Model("Music", null), }),
        };

        public List<MenuItem_Model> SupportItems { get; } = new List<MenuItem_Model>()
        {
            new MenuItem_Model("Contact Us", new List<MenuItem_Model>()
            {
                new MenuItem_Model("Email", null),
                new MenuItem_Model("Phone", null),
                new MenuItem_Model("Live Chat", null),
            }),
            new MenuItem_Model("Troubleshooting", new List<MenuItem_Model>()
            {
                new MenuItem_Model("Common Issues", null),
                new MenuItem_Model("Technical Support", null),
            }),
            new MenuItem_Model("FAQ", null),
        };
    }
}
