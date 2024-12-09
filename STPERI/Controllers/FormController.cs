//using Microsoft.AspNetCore.Mvc;
//using STPERI.Models;
//using System;
//using System.Linq;
//using Umbraco.Cms.Core.Scoping;
//using Umbraco.Cms.Core.Web;
//using Umbraco.Cms.Web.Common.Controllers;
//using Umbraco.Cms.Web.Website.Controllers;

//public class FormController : SurfaceController
//{
//    private readonly IScopeProvider _scopeProvider;

//    // Constructor with proper dependency injection
//    public FormController(IUmbracoContextAccessor umbracoContextAccessor, IScopeProvider scopeProvider)
//        : base(umbracoContextAccessor)
//    {
//        _scopeProvider = scopeProvider ?? throw new ArgumentNullException(nameof(scopeProvider));
//    }

//    [HttpPost]
//    public IActionResult SubmitForm(NewsletterFormModel model)
//    {
//        if (ModelState.IsValid)
//        {
//            // Check for existing email
//            var emailExists = IsEmailExisting(model.Email, new Guid("1f5bc59d-5752-483b-a903-b8e15d06e1e3"));
//            if (emailExists)
//            {
//                ModelState.AddModelError("Email", "Email already exists.");
//                return Json(new { success = false });
//            }

//            // Save email
//            SaveEmail(model.Email);

//            // Return a success message
//            return Json(new { success = true });
//        }

//        return Json(new { success = false }); // Return the current page with validation messages
//    }

//    private bool IsEmailExisting(string email, Guid formId)
//    {
//        using (var scope = _scopeProvider.CreateScope(autoComplete: true))
//        {
//            var sql = scope.SqlContext.Sql()
//                .Select<UFRecord>()
//                .From<UFRecord>()
//                .Where<UFRecord>(x => x.FormId == formId);

//            var records = scope.Database.Fetch<UFRecord>(sql);

//            return records.Any(record => record.RecordData.Contains(email));
//        }
//    }

//    private void SaveEmail(string email)
//    {
//        using (var scope = _scopeProvider.CreateScope(autoComplete: true))
//        {
//            var newRecord = new UFRecord
//            {
//                FormId = new Guid("1f5bc59d-5752-483b-a903-b8e15d06e1e3"), // Replace with your form ID
//                RecordData = $"{{'7f7529f5-e43f-41cb-c26a-64e385333021':'{email}'}}",
//                Created = DateTime.Now,
//                Updated = null,
//                CurrentPage = "00000000-0000-0000-0000-000000000000",
//                UmbracoPageId = 1064,
//                IP = HttpContext.Connection.RemoteIpAddress?.ToString(),
//                MemberKey = null,
//                UniqueId = Guid.NewGuid(),
//                State = "Approved",
//                Culture = System.Threading.Thread.CurrentThread.CurrentCulture.Name
//            };

//            scope.Database.Insert(newRecord);
//        }
//    }
//}
