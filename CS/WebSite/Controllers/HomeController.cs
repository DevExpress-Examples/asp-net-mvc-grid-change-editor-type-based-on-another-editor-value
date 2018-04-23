using DevExpress.Web.Mvc;
using DXWebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevExpressMvcApplication1.Controllers {
    public class HomeController : Controller {
        PersonsList list = new PersonsList();
        public ActionResult Index() {
            return View(list.GetPersons());
        }

        public ActionResult GridViewPartial() {
            return PartialView(list.GetPersons());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult EditingAddNew([ModelBinder(typeof(DevExpressEditorsBinder))]Person personInfo) {
            if (ModelState.IsValid)
                list.AddPerson(personInfo);
            return PartialView("GridViewPartial", list.GetPersons());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult EditingUpdate([ModelBinder(typeof(DevExpressEditorsBinder))]Person personInfo) {
            if (ModelState.IsValid)
                list.UpdatePerson(personInfo);
            return PartialView("GridViewPartial", list.GetPersons());
        }

        private void UpdateModelLastNameValue(Person personInfo) {
            if (Request.Params["FirstName"].Contains("text"))
                personInfo.LastName = Request.Params["cmb"];
            else
                personInfo.LastName = Request.Params["txt"];
            ModelState.Clear();
            UpdateModel<Person>(personInfo);
        }

        public ActionResult EditingDelete([ModelBinder(typeof(DevExpressEditorsBinder))]int personId) {
            list.DeletePerson(personId);
            return PartialView("GridViewPartial", list.GetPersons());
        }

    }
}
