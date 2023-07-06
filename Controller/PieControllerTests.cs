using EmptyMVCShop01.Controllers;
using EmptyMVCShop01.Models;
using EmptyMVCShop01.ViewModels;
using EmptyMVCShop01Tests.Mocks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyMVCShop01Tests.Controller
{
    public class PieControllerTests
    {
        //یک متد تست باید اسمش کاملن شرح بده که داره چی کار میکنه
        //اتربیوت فکت که برای اکس یونیت هستش به متد اضافه میشه تا اون متد رو تبدیل به متد تست بکنه
        //خب ما یک پوشه ماک هم درست میکنیم وریپوزیتوری های ماک رو اونجا قرار میدیم
        [Fact] 
        public void ListEmpetyCategoryReturnAllPies()
        {
            //arange
            //خب ما نیاز داریم برای ارینج بیایم و پای کنترلر رو بیاریم و
            //پای کنترلر به ای پای ریپوزیتوری و ای کتگوری ریپوزیتوری احتیاج داره
            //ما رفتیم این ریپوزیتوری هارو ماک کردیم بعد اومدیم از خود ماکش مستقیم استفاده نکردیم. تقریبا
            //مثل همیشه که با دیپندنسی کار میکردیم اومدیم ریختیمشون داخل یک متغیر دیگه بعد
            //اون متغیر هارو دادیم به کانستراکتور پایکنترلر وبعد ریختیمش باز داخل یک متغیر دیگه

            Mock<IPieRepository> mockPieRepository = RepositoryMocks.GetPieRepository();
            var mockCateguryRepository = RepositoryMocks.GetCategoryRepository();

            var pieController = new PieController(mockPieRepository.Object,mockCateguryRepository.Object);

            //act
            var result = pieController.PieList("");

            //assert
            var viewResult = Assert.IsType<ViewResult>(result);
            //میگه ایا ریزالت در انتها ویو برمیگرداند  در واقع اون ویو از جنس ویو ریزالت هستش ویو ریزالت برمیگردونه یا نه
            var pieListViewModel= Assert.IsAssignableFrom<PieListViewModel>(viewResult.ViewData.Model);
            //میگه مدلی که ویو ریزالت داره بر میگردونتش ایا از جنس پای لیست ویو مدل هستش؟
            Assert.Equal(10, pieListViewModel.Pies.Count());
            //اینم میگه پای هایی که پای لیست ویو مدل بر میگردونه ایا ده تان
            //بعد هم تست ران ال تستس
        }

    }
}
