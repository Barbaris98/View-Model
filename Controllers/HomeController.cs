using Microsoft.AspNetCore.Mvc;
using WebApplication14.Models;
using WebApplication14.ViewModels;

namespace WebApplication14.Controllers
{
    public class HomeController : Controller
    {
        List<Person> people;
        List<Company> companies;
        public HomeController()
        {
            Company microsoft = new Company(1, "Microsoft", "USA");
            Company google = new Company(2, "Google", "USA");
            Company jetbrains = new Company(3, "JetBrains", "Czech Respublic");
            companies = new List<Company> { microsoft, google, jetbrains };

            people = new List<Person>
            {
                new Person(1, "Tom", 37, microsoft),
                new Person(2, "Bob", 41, microsoft),
                new Person(3, "Sam", 28, google),
                new Person(4, "Bill", 32, google),
                new Person(5, "Kate", 33, jetbrains),
                new Person(6, "Alex", 25, jetbrains),
            };
        }
        public IActionResult Index(int? companyId)
        {
            // формириуем список компаний для передачи в представление
            List<CompanyModel> compModels = companies
                .Select(c => new CompanyModel(c.Id, c.Name)).ToList();
            // добавляем на первое место
            compModels


        }


    }
}
