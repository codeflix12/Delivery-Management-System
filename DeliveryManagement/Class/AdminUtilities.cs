using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace DeliveryManagement.Class
{
    public class AdminUtilities
    {
        #region============== Returns the Utilities Data

        public static string sitename
        {
            get
            { 
               DeliveryEntities1 db = new DeliveryEntities1();
                return db.Utilities.Find(1).sitename;
            }
            set { }
        }
        public static string sitelogo
        {
            get
            {
                DeliveryEntities1 db = new DeliveryEntities1();
                return db.Utilities.Find(1).sitelogo;
            }
            set { }
        }
        public static string siteurl
        {
            get
            {
                DeliveryEntities1 db = new DeliveryEntities1();
                return db.Utilities.Find(1).siteurl;
            }
            set { }
        }
        public static string MailServer
        {
            get
            {
                DeliveryEntities1 db = new DeliveryEntities1();
                return db.Utilities.Find(1).MailServer;
            }
            set { }
        }
        public static string from
        {
            get
            {
                DeliveryEntities1 db = new DeliveryEntities1();
                return db.Utilities.Find(1).from;
            }
            set { }
        }
        public static string cc
        {
            get
            {
                DeliveryEntities1 db = new DeliveryEntities1();
                return db.Utilities.Find(1).cc;
            }
            set { }
        }
        public static string username
        {
            get
            {
                DeliveryEntities1 db = new DeliveryEntities1();
                return db.Utilities.Find(1).username;
            }
            set { }
        }
        public static string Password
        {
            get
            {
                DeliveryEntities1 db = new DeliveryEntities1();
                return db.Utilities.Find(1).Password;
            }
            set { }
        }
        public static int Authenticate
        {
            get
            {
                DeliveryEntities1 db = new DeliveryEntities1();
                return db.Utilities.Find(1).Authenticate.GetValueOrDefault();
            }
            set { }
        }
        public static string emailtop
        {
            get
            {
                DeliveryEntities1 db = new DeliveryEntities1();
                return db.Utilities.Find(1).emailtop;
            }
            set { }
        }
        public static int port
        {
            get
            {
                DeliveryEntities1 db = new DeliveryEntities1();
                return db.Utilities.Find(1).port.GetValueOrDefault();
            }
            set { }
        }
        public static int pagination
        {
            get
            {
                DeliveryEntities1 db = new DeliveryEntities1();
                return db.Utilities.Find(1).pagination.GetValueOrDefault();
            }
            set { }
        }
        public static string sitebyname
        {
            get
            {
                DeliveryEntities1 db = new DeliveryEntities1();
                return db.Utilities.Find(1).sitebyname;
            }
            set { }
        }
        public static string sitebyurl
        {
            get
            {
                DeliveryEntities1 db = new DeliveryEntities1();
                return db.Utilities.Find(1).sitebyurl;
            }
            set { }
        }


        #endregion


        public static void SendMail(string from, string to, string subject, string Message)
        {
            var body = "{0}";
            var message = new MailMessage();
            message.To.Add(new MailAddress(to));
            message.From = new MailAddress(from);
            message.Subject = subject;
            message.Body = string.Format(body, Message);
            message.IsBodyHtml = true;

            using (var smtp = new SmtpClient())
            {

                if (AdminSiteConfiguration.MailServerAuthenticate > 0)
                {
                    var credential = new NetworkCredential
                    {
                        UserName = AdminSiteConfiguration.MailServerUsername,
                        Password = AdminSiteConfiguration.MailServerPassword
                    };
                    smtp.Credentials = credential;
                }

                smtp.Host = AdminSiteConfiguration.MailServer;
                smtp.Port = AdminSiteConfiguration.MailServerPort;
                smtp.EnableSsl = false;
                smtp.UseDefaultCredentials = false;
                smtp.Send(message);
            }
        }


        //public static void SendMail(string from, string to, string subject, string Message)
        //{
        //    var body = "{0}";
        //    var message = new MailMessage();
        //    message.To.Add(new MailAddress(to));
        //    message.From = new MailAddress(from);
        //    message.Subject = subject;
        //    message.Body = string.Format(body, Message);
        //    message.IsBodyHtml = true;

        //    using (var smtp = new SmtpClient())
        //    {

        //        if (AdminSiteConfiguration.MailServerAuthenticate > 0)
        //        {
        //            var credential = new NetworkCredential
        //            {
        //                UserName = AdminSiteConfiguration.MailServerUsername,
        //                Password = AdminSiteConfiguration.MailServerPassword
        //            };
        //            smtp.Credentials = credential;
        //        }

        //        smtp.Host = AdminSiteConfiguration.MailServer;
        //        smtp.Port = AdminSiteConfiguration.MailServerPort;
        //        smtp.EnableSsl = false;
        //        smtp.UseDefaultCredentials = false;
        //        smtp.Send(message);
        //    }
        //}

        //public static void SendMail(string from, string to, string subject, string Message)
        //{
        //    var body = "{0}";
        //    var message = new MailMessage();
        //    message.To.Add(new MailAddress(to));
        //    MailAddress Reply = new MailAddress(from, "", System.Text.Encoding.UTF8);
        //    message.ReplyTo = Reply;
        //    message.From = new MailAddress(from, "Ceramica");
        //    message.Subject = subject;
        //    message.Body = string.Format(body, Message);
        //    message.IsBodyHtml = true;

        //    using (var smtp = new SmtpClient())
        //    {

        //        if (AdminSiteConfiguration.MailServerAuthenticate > 0)
        //        {
        //            var credential = new NetworkCredential
        //            {
        //                UserName = AdminSiteConfiguration.MailServerUsername,
        //                Password = AdminSiteConfiguration.MailServerPassword
        //            };
        //            smtp.Credentials = credential;
        //        }

        //        smtp.Host = AdminSiteConfiguration.MailServer;
        //        smtp.Port = AdminSiteConfiguration.MailServerPort;
        //        smtp.EnableSsl = false;
        //        smtp.UseDefaultCredentials = false;
        //        smtp.Send(message);
        //    }
        //}

        public static string GetPageName(string URL)
        {
            string url = URL;

            char[] patt = { '/' };
            char[] p = { '.' };
            string[] arr = url.Split(patt);
            url = arr[arr.Length - 1];

            url = url.Remove(url.IndexOf('.'));

            return url;
        }

        public static string GetFileName(string URL)
        {
            string url = URL;
            try
            {
                char[] patt = { '/' };
                char[] p = { '.' };
                string[] arr = url.Split(patt);
                url = arr[arr.Length - 1];
                //url = url.Remove(url.IndexOf('.'));
            }
            catch
            {
            }
            return url;
        }

        public static string[] GetFileExtensions()
        {
            string[] filenames = { ".zip", ".rar", ".exe", ".jpeg", ".png", ".jpg", ".mp3", ".swf", ".flv", ".wmv", ".mov" };
            return filenames;
        }

        public static string[] GetFileExtensionsForJukebox()//add video file extensions
        {
            string[] filenames = { ".mp3" };
            return filenames;
        }

        public static string[] GetFileExtensionsForGallery()//add video file extensions
        {
            string[] filenames = { ".jpg", ".png", "gif", "jpeg" };
            return filenames;
        }


        public static string ProperCase(string stringInput)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            bool fEmptyBefore = true;
            foreach (char ch in stringInput)
            {
                char chThis = ch;
                if (Char.IsWhiteSpace(chThis))
                    fEmptyBefore = true;
                else
                {
                    if (Char.IsLetter(chThis) && fEmptyBefore)
                        chThis = Char.ToUpper(chThis);
                    else
                        chThis = Char.ToLower(chThis);
                    fEmptyBefore = false;
                }
                sb.Append(chThis);
            }
            return sb.ToString();
        }


        //public static void SendMail_old(string from, string to, string subject, string Message)
        //{
        //    var body = "{0}";
        //    var message = new MailMessage();
        //    message.To.Add(new MailAddress(to));

        //    message.From = new MailAddress(from, "Ceramica");
        //    message.Subject = subject;
        //    message.Body = string.Format(body, Message);
        //    message.IsBodyHtml = true;

        //    using (var smtp = new SmtpClient())
        //    {

        //        if (AdminSiteConfiguration.MailServerAuthenticate > 0)
        //        {
        //            var credential = new NetworkCredential
        //            {
        //                UserName = AdminSiteConfiguration.MailServerUsername,
        //                Password = AdminSiteConfiguration.MailServerPassword
        //            };
        //            smtp.Credentials = credential;
        //        }

        //        smtp.Host = AdminSiteConfiguration.MailServer;
        //        smtp.Port = AdminSiteConfiguration.MailServerPort;
        //        smtp.EnableSsl = true;
        //        smtp.Send(message);
        //    }
        //}
    }
}