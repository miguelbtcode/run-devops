using Shopping.Client.Models;

namespace Shopping.Client.Data;

public static class ProductContext
{
    public static readonly List<Product> Products =
    [
        new()
        {
            Name = "IPhone X",
            Description =
                "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
            ImageFile = "product-1.png",
            Price = 950.00M,
            Category = "Smart Phone",
        },
        new()
        {
            Name = "Samsung 10",
            Description =
                "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
            ImageFile = "product-2.png",
            Price = 840.00M,
            Category = "Smart Phone",
        },
        new()
        {
            Name = "Huawei Plus",
            Description =
                "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
            ImageFile = "product-3.png",
            Price = 650.00M,
            Category = "White Appliances",
        },
        new()
        {
            Name = "Xiaomi Mi 9",
            Description =
                "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
            ImageFile = "product-4.png",
            Price = 470.00M,
            Category = "White Appliances",
        },
        new()
        {
            Name = "HTC U11+ Plus",
            Description =
                "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
            ImageFile = "product-5.png",
            Price = 380.00M,
            Category = "Smart Phone",
        },
        new()
        {
            Name = "LG G7 ThinQ Ending",
            Description =
                "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
            ImageFile = "product-6.png",
            Price = 240.00M,
            Category = "Home Kitchen",
        },
    ];
}
