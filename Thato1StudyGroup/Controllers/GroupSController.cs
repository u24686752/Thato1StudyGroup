using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Thato1StudyGroup.Controllers
{
    public class GroupSController : Controller
    {
        // GET: Group
        public ActionResult ViewStudy1()
        {
            List<Models.MyStudy> people = new List<Models.MyStudy>();

            people.Add(new Models.MyStudy { FirstName = "Thato", LastName = "Mokgothu", Email = "u24686752@tuks.co.za", StudentNumber = "24686752" });
            people.Add(new Models.MyStudy { FirstName = "Karabo", LastName = "Kaphwiyo", Email = "u24651797@tuks.co.za", StudentNumber = "24651797" });
            people.Add(new Models.MyStudy { FirstName = "Dumo", LastName = "Ngobese", Email = "u24742661@tuks.co.za", StudentNumber = "24742661" });
            people.Add(new Models.MyStudy { FirstName = "Langa", LastName = "Manzini", Email = "u24752038@tuks.co.za", StudentNumber = "24752038" });
            people.Add(new Models.MyStudy { FirstName = "Gontse", LastName = "Khoza", Email = "u24698505@tuks.co.za", StudentNumber = "24698505" });

            return View(people);
        }
    }
}