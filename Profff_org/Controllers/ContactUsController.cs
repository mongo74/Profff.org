using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Profff_org.Models;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace Profff_org.Controllers
{
    public class ContactUsController : SurfaceController
    {
        /// <summary>
        /// Loads the Contact Us Viewmodel on the page
        /// </summary>
        /// <returns></returns>
        [ChildActionOnly]
        public ActionResult ContactForm()
        {
            var model = new ContactUsViewModel();
            return PartialView("ContactUs", model);
        }

        /// <summary>
        /// Handles the action after submitting the form
        /// </summary>
        /// <param name="viewModel">Content of the Contact Us form</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult HandleContactUs(ContactUsViewModel viewModel)
        {

            ValidateForm(viewModel);

            //return CurrentUmbracoPage();
            if (!ModelState.IsValid)
                return CurrentUmbracoPage();

            Response.Redirect("/");
            return CurrentUmbracoPage();
        }

 

        private void ValidateForm(ContactUsViewModel model)
        {
            if (string.IsNullOrEmpty(model.Fullname))
                ModelState.AddModelError("Fullname", "Vergeet je naam en voornaam niet!");

            if (string.IsNullOrEmpty(model.Email))
                ModelState.AddModelError("Email", "Vergeet je emailadres niet!");

            if (string.IsNullOrEmpty(model.Subject))
                ModelState.AddModelError("Subject", "Vergeet je onderwerp niet!");

            if (string.IsNullOrEmpty(model.Message))
                ModelState.AddModelError("Message", "Vergeet je bericht niet!");

        }
    }
}