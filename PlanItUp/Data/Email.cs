//using System.Net;
//using System.Net.Mail;

//namespace PlanItUp.Data
//{
//    public class Email
//    {
//        public void Enviar(string Email, string token)
//        {
//            Correo(Email, token);
//        }

//        void Correo(string correo_receptor, string token)
//        {
//            string correo_emisor = "";
//            string clave_emisor = "";

//            MailAddress receptor = new(correo_receptor);
//            MailAddress emisor = new(correo_emisor);

//            MailAddress email = new mail(emisor, receptor);
//            email.subject = "PlanItUp - Validación de cuenta";
//            email.body = "Para activar su cuenta, haga click en el siguiente enlace: " + token;

//            SmtpClient smtp = new();
//            smtp.Host = "smtp.gmail.com";
//            smtp.Port = 587;
//            smtp.Credentials = new NetworkCredential(correo_emisor, clave_emisor);
//            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
//            smtp.EnableSsl = true;

//            try
//            {
//                smtp.Send(Email);

//            }
//            catch (System.Exception)
//            {
//                throw;
//            }
//        }
//    }
//}