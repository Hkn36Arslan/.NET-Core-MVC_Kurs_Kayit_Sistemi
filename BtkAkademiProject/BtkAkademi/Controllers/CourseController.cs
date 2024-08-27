using Microsoft.AspNetCore.Mvc;
using BtkAkademi.Models;

namespace BtkAkademi.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            var model = Repository.Applications; // Hafızada tutulan kayıtlı kişileri oluşturulan model değişkenine atayarak index sayfasında listelemek üzere model değişkeni gönderildi.
            return View(model);
        }
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost] // Formdan gelen verileri almak için kullanılıyor.
        [ValidateAntiForgeryToken] // Güvenli veri aktarımını sağlar.
        public IActionResult Apply([FromForm] Candidate model) // FromForm ifadesi hangi yapıdan veri geldiğini ifade eder, Candidate ilgili verilerin modeli.
        {
            if(Repository.Applications.Any(c => c.Email.Equals(model.Email))){ // Bu if bloğu form üzerinden alınan Email bilgisini kullanır ve kayıtlı Emailler ile karşılaştırarak aynı Email ile başvuru yapanlara hata mesajı gönderir.
                ModelState.AddModelError("","Three is already an application for you.");
            }

            if (ModelState.IsValid) // Bu if bloğu ise gönderilen formun tam istenilen formatta olup olmadığını kontrol eder ve ona göre hafızaya kayıt işlemi yapar.
            {
                Repository.Add(model);
                return View("Feedback", model); // Hafızaya kaydedilen modeli Feedback sayfasına gönderir.
            }
            return View();

        }
    }
}