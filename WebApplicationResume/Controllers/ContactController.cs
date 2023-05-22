using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;

using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using WebApplicationResume.Data;
using WebApplicationResume.Models;

namespace WebApplicationResume.Controllers
{
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ContactController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Contact> objCategoryList = _db.Contact;
            return View(objCategoryList);
        }
        public IActionResult Submit()
        {
            return View();
        }
        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Submit(Contact obj)
        {
            if (obj.name == obj.email.ToString())
            {
                ModelState.AddModelError("name", "The email cannot exactly match the name"); //Custom validation
            }
            if (ModelState.IsValid)
            {
                _db.Contact.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Contact created successfully";
                /*MailMessage mail = new MailMessage();
                mail.From = new System.Net.Mail.MailAddress("ralphilou24@gmail.com");

                SmtpClient smtp= new SmtpClient();

               
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network; // [2] Added this
                smtp.UseDefaultCredentials = false; // [3] Changed this
                smtp.Credentials = new NetworkCredential("ralphilou24@Gmail.com", pass);  // [4] Added this. Note, first parameter is NOT string.
                smtp.Host = "smtp.gmail.com";
                mail.To.Add(new MailAddress("ralphilou24@gmail.com"));
                mail.IsBodyHtml= true;
                string sending = "This person is trying to contact you:" + obj.name + "\n Email:" + obj.email + "\n This person would like to talk about:" + obj.message;
                mail.Subject = obj.subject;
                mail.Body = sending;
                try
                {
                    smtp.Send(mail);
                }
                catch(Exception ex)
                {
                    return RedirectToAction("Submit");
                }*/
                var email = new MimeMessage();
                email.From.Add(new MailboxAddress(obj.name, obj.email.ToString()));
                email.To.Add(new MailboxAddress("Ralphilou Tatoy", "ralphilou24@gmail.com"));
                email.Subject = obj.subject;
                email.Body = new TextPart(MimeKit.Text.TextFormat.Html)
                {
                    Text = "<b>" + obj.message + "</b> <br>" + "<b> Their email is " + obj.email + "</b>"
                };
                using (var smtp = new SmtpClient())
                {
                    smtp.Connect("smtp.gmail.com", 587, false);
                    smtp.Authenticate("ralphilou24@gmail.com", pass);
                    smtp.Send(email);
                    smtp.Disconnect(true);

                }

            return RedirectToAction("Submit");
            }
            
            return View(obj);
        }


    }
}


