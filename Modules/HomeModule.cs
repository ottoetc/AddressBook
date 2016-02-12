using Nancy;
using System.Collections.Generic;
using Address.Objects;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/contacts"] = _ => {
        var allContacts = Contact.GetAll();
        return View["contacts.cshtml", allContacts];
      };
      Get["/contacts/new"] = _ => {
        return View["contact_form.cshtml"];
      };
      Post["/contact_created"] = _ => {
        var newContact = new Contact(Request.Form["new-firstName"], Request.Form["new-lastName"], Request.Form["new-phoneNumber"], Request.Form["new-streetAddress"], Request.Form["new-city"], Request.Form["new-state"], Request.Form["new-zipCode"]);
        newContact.Save();
        var allContacts = Contact.GetAll();
        return View["contact_created.cshtml", newContact];
      };
      Post["/contacts_deleted"] = _ => {
        Contact.DeleteAll();
        return View["contacts_deleted.cshtml"];
      };
    }
  }
}
