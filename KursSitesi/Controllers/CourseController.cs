
using Microsoft.AspNetCore.Mvc;
using KursSitesi.Models;

namespace KursSitesi.Controllers
{
    public class CourseController : Controller
    {
     public IActionResult Index()
     {
      var Model = Repository.Applications;
        return View(Model);
     }
     public IActionResult Apply()
     {
        return View();
     }
     [HttpPost]
     [ValidateAntiForgeryToken]
      public IActionResult Apply([FromForm]CandiDate model)
      {
         if(Repository.Applications.Any(c=>c.Eamil.Equals(model.Eamil))){
            ModelState.AddModelError("","Bu Kullanıcı zaten kayıtlı" );
         }
        if(ModelState.IsValid)
        {
           Repository.Add(model);

         return View("Feedback",model);

        }
        return  View();
      }

    }
}