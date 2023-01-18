using System.Numerics;
using System.Xml.Linq;

namespace MVC1.Models
{
    public class InvitationsDetails
    {
        private static List<Invitation> invitations= new List<Invitation>()
        {
            new Invitation() { name= "Ahmed",email= "ahmed@gmail.com",phone="0111112"},
            new Invitation() { name= "Rawan",email= "rawan @gmail.com",phone="01111123365"}
        };
        public static List<Invitation> Invitations{ get => invitations; }


        public static void AddInvitation(Invitation I)
        {
            Invitations.Add(I);
        }
        public static void RemoveInvitation(Invitation I)
        {
            Invitations.Remove(I);
        }
    }
}
