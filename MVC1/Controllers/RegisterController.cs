using Microsoft.AspNetCore.Mvc;
using MVC1.Models;

namespace MVC1.Controllers
{
    public class RegisterController : Controller
    {
      
        public IActionResult register()
        {
            return View();
        }

 
        public IActionResult GetAll()
        {
            List<Invitation> invitations = InvitationsDetails.Invitations;
            return View("GetAll", invitations);
        }

        public IActionResult AddData(Invitation invitation)
        {
            InvitationsDetails.AddInvitation(invitation);


            //Invitation invite =InvitationsDetails.Invitations.Where(p => p.WillAttend).ToList();
            if (invitation.WillAttend)
            {
                return View("Thanks");
            }
            else
            {
                InvitationsDetails.RemoveInvitation(invitation);    
                return Content("See You Later");
            }
        }

    }
}

