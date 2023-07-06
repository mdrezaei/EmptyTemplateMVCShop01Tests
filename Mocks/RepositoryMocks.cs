using EmptyMVCShop01.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyMVCShop01Tests.Mocks
{
    public class RepositoryMocks
    {
        //یه کلاس داریم یه کلاس دیگه هم توش تعریف کردیم
        //نستد کلاس
        //کلاس نست شده معمولن پرایویته
        //ولی میتونه پابلیک اینترنال پروتکتد و چیزای دیگه هم باشه ولی کیفیت کد پایین میاد اگه ویزیبل باشه
        //کلاس نستد و چیزایی که توشه به کانتینرش دسترسی دارن و اجزای داخل کانتینرش و
        //چیز هایی که کانتینرش بهشون دسترسی داره این اخری رو مطمئن نیستم 

        public static Mock<IPieRepository> GetPieRepository()
        {
            //این متد پابلیک یک ای پای ریپوزیتوری ماک شده رو برمیگردونه
            var pies = new List<Pie>()
            {
                new Pie
                {
                    Name = "Apple Pie",
                    Price = 12.95,
                    ShortDescription = "Our famous apple pies!",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Fruit pies"],
                    ImageUrl = "Images/Pic/applepie.jpg",
                    InStock = true,
                    IsPieOfTheWeek = true,
                    ImageThumbnailUrl = "Images/Pic/applepiesmall.jpg",
                    AllergyInformation = ""
                },
                new Pie
                {
                    Name = "Blueberry Cheese Cake",
                    Price = 18.95,
                    ShortDescription = "You'll love it!",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Cheese cakes"],
                    ImageUrl = "Images/Pic/blueberrycheesecake.jpg",
                    InStock = true,
                    IsPieOfTheWeek = false,
                    ImageThumbnailUrl =
                        "Images/Pic/blueberrycheesecakesmall.jpg",
                    AllergyInformation = ""
                },
                new Pie
                {
                    Name = "Cheese Cake",
                    Price = 18.95,
                    ShortDescription = "Plain cheese cake. Plain pleasure.",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Cheese cakes"],
                    ImageUrl = "Images/Pic/cheesecake.jpg",
                    InStock = true,
                    IsPieOfTheWeek = false,
                    ImageThumbnailUrl = "Images/Pic/cheesecakesmall.jpg",
                    AllergyInformation = ""
                },
                new Pie
                {
                    Name = "Cherry Pie",
                    Price = 15.95,
                    ShortDescription = "A summer classic!",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Fruit pies"],
                    ImageUrl = "Images/Pic/cherrypie.jpg",
                    InStock = true,
                    IsPieOfTheWeek = false,
                    ImageThumbnailUrl = "Images/Pic/cherrypiesmall.jpg",
                    AllergyInformation = ""
                },
                new Pie
                {
                    Name = "Christmas Apple Pie",
                    Price = 13.95,
                    ShortDescription = "Happy holidays with this pie!",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Seasonal pies"],
                    ImageUrl = "Images/Pic/christmasapplepie.jpg",
                    InStock = true,
                    IsPieOfTheWeek = false,
                    ImageThumbnailUrl =
                        "Images/Pic/christmasapplepiesmall.jpg",
                    AllergyInformation = ""
                },
                new Pie
                {
                    Name = "Cranberry Pie",
                    Price = 17.95,
                    ShortDescription = "A Christmas favorite",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Seasonal pies"],
                    ImageUrl = "Images/Pic/cranberrypie.jpg",
                    InStock = true,
                    IsPieOfTheWeek = false,
                    ImageThumbnailUrl =
                        "Images/Pic/cranberrypiesmall.jpg",
                    AllergyInformation = ""
                },
                new Pie
                {
                    Name = "Peach Pie",
                    Price = 15.95,
                    ShortDescription = "Sweet as peach",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Fruit pies"],
                    ImageUrl = "Images/Pic/peachpie.jpg",
                    InStock = false,
                    IsPieOfTheWeek = false,
                    ImageThumbnailUrl = "Images/Pic/peachpiesmall.jpg",
                    AllergyInformation = ""
                },
                new Pie
                {
                    Name = "Pumpkin Pie",
                    Price = 12.95,
                    ShortDescription = "Our Halloween favorite",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Seasonal pies"],
                    ImageUrl = "Images/Pic/pumpkinpie.jpg",
                    InStock = true,
                    IsPieOfTheWeek = true,
                    ImageThumbnailUrl = "Images/Pic/pumpkinpiesmall.jpg",
                    AllergyInformation = ""
                },
                new Pie
                {
                    Name = "Rhubarb Pie",
                    Price = 15.95,
                    ShortDescription = "My God, so sweet!",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Fruit pies"],
                    ImageUrl = "Images/Pic/rhubarbpie.jpg",
                    InStock = true,
                    IsPieOfTheWeek = true,
                    ImageThumbnailUrl = "Images/Pic/rhubarbpiesmall.jpg",
                    AllergyInformation = ""
                },
                new Pie
                {
                    Name = "Strawberry Pie",
                    Price = 15.95,
                    ShortDescription = "Our delicious strawberry pie!",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Fruit pies"],
                    ImageUrl = "Images/Pic/strawberrypie.jpg",
                    InStock = true,
                    IsPieOfTheWeek = false,
                    ImageThumbnailUrl =
                        "Images/Pic/strawberrypiesmall.jpg",
                    AllergyInformation = ""
                },
            };

            var mockPieRepository = new Mock<IPieRepository>();
            //mockPieRepository = mockPieRepository.Setup(repo => repo.AllPies).Returns(pies);//Error
            mockPieRepository.Setup(r => r.AllPies).Returns(pies);
            mockPieRepository.Setup(repo => repo.PiesOfTheWeek).Returns(pies.Where(p => p.IsPieOfTheWeek));
            mockPieRepository.Setup(repo => repo.GetPieById(It.IsAny<int>())).Returns(pies[0]);
            //سلام کلا کلاس it برای چکر هستش
            //اینجا
            //It.IsAny<int>()
            //یک تابع رو میتونید توش کال کنید و ببینید اینت بر میگردونه یا نه ، اگه آره که ترو میده
            //بیشتر برای تسته
            return mockPieRepository;
            //الان این که یه ریپوزیتوری ماک شده باید برگردونه این از این
            //ما اون بالا یه لیست هم از پای ها درست کردیم که درواقع یه دیتای ماک شده هست که خودمون درست کردیمش . شخصا خودمون
            //بعد اومدیم از 
            //Mock<>
            //توی نیم اسپیس 
            //Moq
            //استفاده کردیم تا یک ماک ریپوزیتوری بسازیم بر اساس ریپوزیتوری پای ریپوزیتوری . ولی
            //چون دیپندنسی اینجکشن نداره و میخوایم ایزوله باشه خود پای ریپوزیتوری رو استفاده نکردیم چون پایریپوزیتوری خودش
            //متد ها و پراپرتی هاش دستوراتش نوشته  شده و با دیپندنسی اینجکشن و انتیتی میره از دیتا بیس دیتا میاره
            //پس ما از قالب پای ریپوزیتوری یعنی اینترفیسش ، ای پای ریپوزیتوری ، استفاده میکنیم
            //خب این میاد پراپرتی ها و متد هارو ماک میکنه  ولی توی اینتر فیس که ما متد هامون عملکرد نداره که بیاد با عملکردشون ماک کنه
            //پس ما ماییم اینجا 
            //var mockPieRepository = new Mock<IPieRepository>();
            //از ای پای ریپازیتوری یک نسخه ماک شده میسازیم به اسم ماکپایریپوزیتوری
            //حالا باید بگیم که انگار هر کدوم از اون متد های ماک شدش چه کاری رو انجام بدن
            //لازم نیست حتمن کار کاملشون رو انجام بدن یا دقیق انجامش بدن
            //خب اسم شیئ ماک شده دات ستاپ پرانتز ستاپ رو مانند لامبدا پر میکنیم و بعد از علامت لامبدا اسم متد یا پراپرتی که
            //میخوایم عملکردش رو معلوم کنیم یا همون ست کنیم رو مینویسیم 
            //بعد پرانتز بسته و دنباله همون دات ریترن . در ریترن کاری رو که
            //باید انجام بشه هنگام صدا شدن متدی که در ستاپ بود رو مینویسیم
            //حالا شیئی که ما ماک کردیم همه چیزش امادست عملکرداش ست شده و اماده امادست
            //و در انتها ریترن میکنیم شیئ ماک شده رو چون این متد یه شئی ماک شده میخواد که برگرده
        }

        public static Mock<ICategoryRepository> GetCategoryRepository()
        {
            var categories = new List<Category>
            {
                new Category()
                {
                    CategoryId = 1,
                    CategoryName = "Fruit Pies",
                    Description = "Lorem ipsum"
                },
                new Category()
                {
                    CategoryId = 2,
                    CategoryName = "Cheese cakes",
                    Description = "Lorem ipsum"
                },
                new Category()
                {
                    CategoryId = 3,
                    CategoryName = "Fruit Pies",
                    Description = "Seasonal pies"
                }
            };

            var mockCategoryRepository = new Mock<ICategoryRepository>();
            mockCategoryRepository.Setup(repo => repo.AllCategories).Returns(categories);

            return mockCategoryRepository;
        }

        private static Dictionary<string, Category>? _categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (_categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Fruit pies" },
                        new Category { CategoryName = "Cheese cakes" },
                        new Category { CategoryName = "Seasonal pies" }
                    };

                    _categories = new Dictionary<string, Category>();

                    foreach (var genre in genresList)
                    {
                        _categories.Add(genre.CategoryName, genre);
                    }
                }

                return _categories;
            }
        }
    }
}
