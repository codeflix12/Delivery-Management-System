using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Data.Entity;
using System.Data.Entity.SqlServer;


namespace DeliveryManagement.Class
{
    public class AdminSiteConfiguration
    {
        //  #region============== Returns the SiteConfiguration Data

        //public static int CategoryLevel
        //{
        //    get
        //    {
        //        DeliveryEntities db = new DeliveryEntities();
        //        return db.SiteConfigurations.Find(1).level.GetValueOrDefault();
        //    }
        //    set { }
        //}

        //public static int Currencydigit
        //{
        //    get
        //    {
        //        DeliveryEntities db = new DeliveryEntities();
        //        return db.SiteConfigurations.Find(1).Currencydigit.GetValueOrDefault();
        //    }
        //    set { }
        //}

        //public static string CurrencySymbol
        //{
        //    get
        //    {
        //        DeliveryEntities db = new DeliveryEntities();
        //        return db.SiteConfigurations.Find(1).Symbol;
        //    }
        //    set { }
        //}

        //#endregion


        //#region============== Image code Start
        //public static bool ThumbnailCallBack()
        //{
        //    return false;
        //}
        //public static bool ImageResize(string pimage, string foldername, int large, int medium, int small)
        //{
        //    int imgwidth = 0;
        //    int imgheight = 0;
        //    int imgthumbwidth = 0;
        //    int imgthumbheight = 0;
        //    int imgiconwidth = 0;
        //    int imgiconheight = 0;

        //    //Panel1.Visible = true;
        //    System.Drawing.Image.GetThumbnailImageAbort callback = new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallBack);
        //    System.Drawing.Image mainImage = System.Drawing.Image.FromFile(HttpContext.Current.Request.PhysicalApplicationPath + "\\userfiles\\" + foldername + "\\" + pimage);

        //    //==resize main image - if image's height or width > 250 px

        //    if (mainImage.Width >= large || mainImage.Height >= large)
        //    {
        //        if (mainImage.Width > mainImage.Height)
        //        {
        //            imgwidth = large;
        //            imgheight = (mainImage.Height * large) / mainImage.Width;

        //            imgthumbwidth = medium;
        //            imgthumbheight = (mainImage.Height * medium) / mainImage.Width;

        //            imgiconwidth = small;
        //            imgiconheight = (mainImage.Height * small) / mainImage.Width;

        //        }
        //        else if (mainImage.Width < mainImage.Height)
        //        {
        //            imgheight = large;
        //            imgwidth = (mainImage.Width * large) / mainImage.Height;

        //            imgthumbheight = medium;
        //            imgthumbwidth = (mainImage.Width * medium) / mainImage.Height;

        //            imgiconheight = small;
        //            imgiconwidth = (mainImage.Width * small) / mainImage.Height;
        //        }
        //        else if (mainImage.Width == mainImage.Height)
        //        {
        //            imgheight = large;
        //            imgwidth = large;
        //            imgthumbwidth = medium;
        //            imgthumbheight = medium;
        //            imgiconheight = small;
        //            imgiconwidth = small;
        //        }

        //        string ProductImageMain = pimage;
        //        Bitmap thumbnail1 = new Bitmap(imgwidth, imgheight, PixelFormat.Format24bppRgb);
        //        thumbnail1.SetResolution(mainImage.HorizontalResolution, mainImage.VerticalResolution);
        //        Graphics grPhoto = Graphics.FromImage(thumbnail1);
        //        grPhoto.InterpolationMode = InterpolationMode.HighQualityBicubic;
        //        grPhoto.SmoothingMode = SmoothingMode.AntiAlias;
        //        grPhoto.PixelOffsetMode = PixelOffsetMode.HighQuality;
        //        grPhoto.CompositingQuality = CompositingQuality.HighQuality;

        //        grPhoto.DrawImage(mainImage,
        //            new Rectangle(-1, -1, imgwidth + 2, imgheight + 2),
        //            new Rectangle(-1, -1, mainImage.Width + 2, mainImage.Height + 2),
        //            GraphicsUnit.Pixel);
        //        grPhoto.Dispose();
        //        thumbnail1.Save(HttpContext.Current.Request.PhysicalApplicationPath + "userfiles\\" + foldername + "\\large\\" + ProductImageMain);
        //        thumbnail1.Dispose();


        //        string ProudctImageThumb = pimage;
        //        Bitmap thumbnail2 = new Bitmap(imgthumbwidth, imgthumbheight, PixelFormat.Format24bppRgb);
        //        thumbnail2.SetResolution(mainImage.HorizontalResolution, mainImage.VerticalResolution);
        //        Graphics grPhoto2 = Graphics.FromImage(thumbnail2);
        //        grPhoto2.InterpolationMode = InterpolationMode.HighQualityBicubic;
        //        grPhoto2.SmoothingMode = SmoothingMode.AntiAlias;
        //        grPhoto2.PixelOffsetMode = PixelOffsetMode.HighQuality;
        //        grPhoto2.CompositingQuality = CompositingQuality.HighQuality;

        //        grPhoto2.DrawImage(mainImage,
        //            new Rectangle(-1, -1, imgthumbwidth + 2, imgthumbheight + 2),
        //            new Rectangle(-1, -1, mainImage.Width + 2, mainImage.Height + 2),
        //            GraphicsUnit.Pixel);
        //        grPhoto2.Dispose();
        //        thumbnail2.Save(HttpContext.Current.Request.PhysicalApplicationPath + "userfiles\\" + foldername + "\\medium\\" + ProudctImageThumb);
        //        thumbnail2.Dispose();


        //        //==create icon of the image
        //        string ProductImageIcon = pimage;
        //        Bitmap thumbnail3 = new Bitmap(imgiconwidth, imgiconheight, PixelFormat.Format24bppRgb);
        //        thumbnail3.SetResolution(mainImage.HorizontalResolution, mainImage.VerticalResolution);
        //        Graphics grPhoto3 = Graphics.FromImage(thumbnail3);
        //        grPhoto3.InterpolationMode = InterpolationMode.HighQualityBicubic;
        //        grPhoto3.SmoothingMode = SmoothingMode.AntiAlias;
        //        grPhoto3.PixelOffsetMode = PixelOffsetMode.HighQuality;
        //        grPhoto3.CompositingQuality = CompositingQuality.HighQuality;

        //        grPhoto3.DrawImage(mainImage,
        //            new Rectangle(-1, -1, imgiconwidth + 2, imgiconheight + 2),
        //            new Rectangle(-1, -1, mainImage.Width + 2, mainImage.Height + 2),
        //            GraphicsUnit.Pixel);
        //        grPhoto3.Dispose();
        //        thumbnail3.Save(HttpContext.Current.Request.PhysicalApplicationPath + "userfiles\\" + foldername + "\\small\\" + ProductImageIcon);
        //        thumbnail3.Dispose();

        //    }
        //    else
        //    {
        //        mainImage.Save(HttpContext.Current.Request.PhysicalApplicationPath + "userfiles\\" + foldername + "\\large\\" + pimage);


        //        if ((mainImage.Width >= medium & mainImage.Width < large) | (mainImage.Height >= medium & mainImage.Width < large))
        //        {
        //            if (mainImage.Width > mainImage.Height)
        //            {

        //                imgthumbwidth = medium;
        //                imgthumbheight = (mainImage.Height * medium) / mainImage.Width;

        //                imgiconwidth = small;
        //                imgiconheight = (mainImage.Height * small) / mainImage.Width;

        //            }
        //            else if (mainImage.Width < mainImage.Height)
        //            {

        //                imgthumbheight = medium;
        //                imgthumbwidth = (mainImage.Width * medium) / mainImage.Height;

        //                imgiconheight = small;
        //                imgiconwidth = (mainImage.Width * small) / mainImage.Height;
        //            }
        //            else if (mainImage.Width == mainImage.Height)
        //            {
        //                imgthumbwidth = medium;
        //                imgthumbheight = medium;
        //                imgiconheight = small;
        //                imgiconwidth = small;
        //            }
        //            //==create thumbnail of the image
        //            string ProudctImageThumb = pimage;
        //            Bitmap thumbnail2 = new Bitmap(imgthumbwidth, imgthumbheight, PixelFormat.Format24bppRgb);
        //            thumbnail2.SetResolution(mainImage.HorizontalResolution, mainImage.VerticalResolution);
        //            Graphics grPhoto2 = Graphics.FromImage(thumbnail2);
        //            grPhoto2.InterpolationMode = InterpolationMode.HighQualityBicubic;
        //            grPhoto2.SmoothingMode = SmoothingMode.AntiAlias;
        //            grPhoto2.PixelOffsetMode = PixelOffsetMode.HighQuality;
        //            grPhoto2.CompositingQuality = CompositingQuality.HighQuality;

        //            grPhoto2.DrawImage(mainImage,
        //                new Rectangle(-1, -1, imgthumbwidth + 2, imgthumbheight + 2),
        //                new Rectangle(-1, -1, mainImage.Width + 2, mainImage.Height + 2),
        //                GraphicsUnit.Pixel);
        //            grPhoto2.Dispose();
        //            thumbnail2.Save(HttpContext.Current.Request.PhysicalApplicationPath + "userfiles\\" + foldername + "\\medium\\" + ProudctImageThumb);
        //            thumbnail2.Dispose();

        //            //==create icon of the image
        //            string ProductImageIcon = pimage;
        //            Bitmap thumbnail3 = new Bitmap(imgiconwidth, imgiconheight, PixelFormat.Format24bppRgb);
        //            thumbnail3.SetResolution(mainImage.HorizontalResolution, mainImage.VerticalResolution);
        //            Graphics grPhoto3 = Graphics.FromImage(thumbnail3);
        //            grPhoto3.InterpolationMode = InterpolationMode.HighQualityBicubic;
        //            grPhoto3.SmoothingMode = SmoothingMode.AntiAlias;
        //            grPhoto3.PixelOffsetMode = PixelOffsetMode.HighQuality;
        //            grPhoto3.CompositingQuality = CompositingQuality.HighQuality;

        //            grPhoto3.DrawImage(mainImage,
        //                new Rectangle(-1, -1, imgiconwidth + 2, imgiconheight + 2),
        //                new Rectangle(-1, -1, mainImage.Width + 2, mainImage.Height + 2),
        //                GraphicsUnit.Pixel);
        //            grPhoto3.Dispose();
        //            thumbnail3.Save(HttpContext.Current.Request.PhysicalApplicationPath + "userfiles\\" + foldername + "\\small\\" + ProductImageIcon);
        //            thumbnail3.Dispose();
        //        }
        //        else
        //        {


        //            if (mainImage.Width < medium | mainImage.Height < medium)
        //            {
        //                if (mainImage.Width > mainImage.Height)
        //                {


        //                    imgiconwidth = small;
        //                    imgiconheight = (mainImage.Height * small) / mainImage.Width;

        //                }
        //                else if (mainImage.Width < mainImage.Height)
        //                {

        //                    imgiconheight = small;
        //                    imgiconwidth = (mainImage.Width * small) / mainImage.Height;
        //                }
        //                else if (mainImage.Width == mainImage.Height)
        //                {
        //                    imgiconheight = small;
        //                    imgiconwidth = small;
        //                }
        //                mainImage.Save(HttpContext.Current.Request.PhysicalApplicationPath + "userfiles\\" + foldername + "\\large\\" + pimage);
        //                mainImage.Save(HttpContext.Current.Request.PhysicalApplicationPath + "userfiles\\" + foldername + "\\medium\\" + pimage);

        //                //==create icon of the image
        //                string ProductImageIcon = pimage;
        //                Bitmap thumbnail3 = new Bitmap(imgiconwidth, imgiconheight, PixelFormat.Format24bppRgb);
        //                thumbnail3.SetResolution(mainImage.HorizontalResolution, mainImage.VerticalResolution);
        //                Graphics grPhoto3 = Graphics.FromImage(thumbnail3);
        //                grPhoto3.InterpolationMode = InterpolationMode.HighQualityBicubic;
        //                grPhoto3.SmoothingMode = SmoothingMode.AntiAlias;
        //                grPhoto3.PixelOffsetMode = PixelOffsetMode.HighQuality;
        //                grPhoto3.CompositingQuality = CompositingQuality.HighQuality;

        //                grPhoto3.DrawImage(mainImage,
        //                    new Rectangle(-1, -1, imgiconwidth + 2, imgiconheight + 2),
        //                    new Rectangle(-1, -1, mainImage.Width + 2, mainImage.Height + 2),
        //                    GraphicsUnit.Pixel);
        //                grPhoto3.Dispose();
        //                thumbnail3.Save(HttpContext.Current.Request.PhysicalApplicationPath + "userfiles\\" + foldername + "\\small\\" + ProductImageIcon);
        //                thumbnail3.Dispose();
        //            }
        //        }
        //    }
        //    mainImage.Dispose();
        //    return true;
        //}

        //public static bool DeleteImage(string cimage, string foldername)
        //{

        //    System.IO.FileInfo image = new System.IO.FileInfo(HttpContext.Current.Request.PhysicalApplicationPath + "userfiles\\" + foldername + "\\" + cimage);
        //    bool isfileUploaded = image.Exists;
        //    if (isfileUploaded)
        //    {
        //        GC.Collect();
        //        try
        //        {
        //            image.Delete();
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(" {0}      ", ex);
        //        }
        //    }
        //    System.IO.FileInfo image1 = new System.IO.FileInfo(HttpContext.Current.Request.PhysicalApplicationPath + "userfiles\\" + foldername + "\\large\\" + cimage);
        //    bool isfileUploaded1 = image1.Exists;
        //    if (isfileUploaded1)
        //    {
        //        GC.Collect();
        //        try
        //        {
        //            image1.Delete();
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(" {0}      ", ex);
        //        }
        //    }
        //    System.IO.FileInfo image2 = new System.IO.FileInfo(HttpContext.Current.Request.PhysicalApplicationPath + "userfiles\\" + foldername + "\\medium\\" + cimage);
        //    bool isfileUploaded2 = image2.Exists;
        //    if (isfileUploaded2)
        //    {
        //        GC.Collect();
        //        try
        //        {
        //            image2.Delete();
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(" {0}      ", ex);
        //        }
        //    }
        //    System.IO.FileInfo image3 = new System.IO.FileInfo(HttpContext.Current.Request.PhysicalApplicationPath + "userfiles\\" + foldername + "\\small\\" + cimage);
        //    bool isfileUploaded3 = image3.Exists;
        //    if (isfileUploaded3)
        //    {
        //        GC.Collect();
        //        try
        //        {
        //            image3.Delete();
        //        }
        //        catch (Exception ex)
        //        {
        //              Console.WriteLine(" {0}      ", ex);
        //        }
        //    }


        //    return true;
        //}

        //public static bool ExistsImage(string folder, string imagename)
        //{
        //    bool retvale = false;
        //    try
        //    {
        //        System.IO.FileInfo image = new System.IO.FileInfo(HttpContext.Current.Request.PhysicalApplicationPath + "userfiles\\" + folder + "\\" + imagename);
        //        bool isfileUploaded = image.Exists;

        //        if (isfileUploaded)
        //        {
        //            retvale = true;
        //        }
        //    }
        //    catch { }
        //    return retvale;
        //}
        //#endregion


        //#region============== Change Currency Start

        //public static string ChangeCurrencyWithSymbol(string Price)
        //{
        //    DeliveryEntities db = new DeliveryEntities();
        //    var Data = db.SiteConfigurations.Find(1);

        //    int Currencydigit = AdminSiteConfiguration.Currencydigit;
        //    string CurrencySymbol = AdminSiteConfiguration.CurrencySymbol;
        //    if (Price.Trim() != "")
        //    {
        //        Price = CurrencySymbol + " " + GetPrice(Price);
        //        //Price = "₹" + " " + GetPrice(Price);
        //    }
        //    return Price;
        //}

        //public static string ChangeCurrencyWithoutSymbol(string number)
        //{
        //    string returnval = "";
        //    try
        //    {
        //        returnval = Convert.ToString((double.Parse(number)));
        //    }
        //    catch
        //    {
        //    }
        //    return returnval;
        //}

        //public static string ChangeCurrency(string Price)
        //{
        //    return GetPrice(Price);
        //}

        //public static string GetPrice(string number)
        //{
        //    string returnval = "";
        //    try
        //    {
        //       // returnval = Convert.ToString((double.Parse(number)));
        //         returnval = Convert.ToString(Math.Round(Convert.ToDecimal(number), 2));
        //    }
        //    catch
        //    {
        //    }
        //    return returnval;
        //}

        //public static string ChangeCurrencydecimalpoint(string Price)
        //{
        //    return GetPricedescimal(Price);
        //}
        //public static string ChangeDecimal_Edit(string Price)
        //{
        //    return Convert.ToString((double.Parse(Price)));
        //    // Convert.ToString((double.Parse(Price)));
        //}

        //public static string GetPricedescimal(string number)
        //{
        //    string returnval = "";
        //    try
        //    {
        //        returnval = Convert.ToString(Math.Round(Convert.ToDecimal(number), 2));

        //        //  returnval = Convert.ToString(Math.Round(Convert.ToDecimal(number), 2)).TrimEnd('0').TrimEnd('.');
        //    }
        //    catch
        //    {
        //    }
        //    return returnval;
        //}

        //#endregion


        #region============== Get URL Code Start
        public static string GetURL()
        {
            return HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + "/";

        }
        public static string SiteName
        {
            get
            {
                DeliveryEntities1 db = new DeliveryEntities1();
                return (from data in db.Utilities where data.id == 1 select data.sitename).FirstOrDefault().ToString();
            }
        }
        public static string From
        {
            get
            {
                DeliveryEntities1 db = new DeliveryEntities1();
                DeliveryManagement.Utility u = db.Utilities.Find(1);
                return u.from;
            }
        }
        public static string MailServer
        {
            get
            {
                DeliveryEntities1 db = new DeliveryEntities1();
                return (from data in db.Utilities where data.id == 1 select data.MailServer).FirstOrDefault().ToString();
            }
        }
        public static int MailServerPort
        {
            get
            {
                DeliveryEntities1 db = new DeliveryEntities1();
                return Convert.ToInt32((from data in db.Utilities where data.id == 1 select data.port).FirstOrDefault().ToString());
            }
        }
        public static int MailServerAuthenticate
        {
            get
            {
                DeliveryEntities1 db = new DeliveryEntities1();
                return Convert.ToInt32((from data in db.Utilities where data.id == 1 select data.Authenticate).FirstOrDefault().ToString());
            }
        }
        public static string MailServerUsername
        {
            get
            {
                DeliveryEntities1 db = new DeliveryEntities1();
                return (from data in db.Utilities where data.id == 1 select data.username).FirstOrDefault().ToString();
            }
        }
        public static string MailServerPassword
        {
            get
            {
                DeliveryEntities1 db = new DeliveryEntities1();
                return (from data in db.Utilities where data.id == 1 select data.Password).FirstOrDefault().ToString();
            }
        }
        #endregion

     /*   #region ShoppingCartId
       public static string shoppingCartId
        {
            get
            {
                // get the current HttpContext
                HttpContext context = HttpContext.Current;

                // try to retrieve the cart ID from the user session object
                string cartId = "";
                object cartIdSession = context.Session["CartID"];
                //HttpContext.Current.Response.Write("444=" + context.Session["CartID"]);
                if (cartIdSession != null)
                    cartId = cartIdSession.ToString();
                // if the ID exists in the current session...
                if (cartId != "")
                    // return its value
                    return cartId;
                else
                // if the cart ID isn't in the session...
                {
                    // check if the cart ID exists as a cookie
                    if (context.Request.Cookies["CartID"] != null)
                    {
                        // if the cart exists as a cookie, use the cookie to get its value
                        cartId = context.Request.Cookies["CartID"].Value;
                        // save the id to the session, to avoid reading the cookie next time
                        context.Session["CartID"] = cartId;
                        // return the id
                        return cartId;
                    }
                    else
                    // if the cart ID doesn't exist in the cookie as well, generate a new ID
                    {
                        // generate a new GUID
                        cartId = Guid.NewGuid().ToString();

                        // create the cookie object and set its value
                        HttpCookie cookie = new HttpCookie("CartID", cartId.ToString());
                        // set the cookie's expiration date 
                        // int howManyDays = Int32.Parse(ConfigurationManager.AppSettings["CartPersistDays"]);
                        int howManyDays = 2;
                        DateTime currentDate = DateTime.Now;
                        TimeSpan timeSpan = new TimeSpan(howManyDays, 0, 0, 0);
                        DateTime expirationDate = currentDate.Add(timeSpan);
                        cookie.Expires = expirationDate;
                        // set the cookie on client's browser
                        context.Response.Cookies.Add(cookie);
                        // save the ID to the Session as well
                        context.Session["CartID"] = cartId;
                        // return the CartID

                        return cartId.ToString();

                    }
                }
            }
        }
        #endregion

        #region Add to cart
        public static bool AddToCart(int Pid, string Productname, int Qty, int TotalQty, string Shippingcharge, string Price, int cid, int vid, string producturl, string imageurl)
        {
            int pid = Convert.ToInt32(Pid);
            CeramicaEntities db = new CeramicaEntities();

            int ok = 0;

            ok = Convert.ToInt32((from datcart in db.ClientShoppingCartAddItem(shoppingCartId, Convert.ToInt32(Pid), Productname, Convert.ToInt32(Qty), Convert.ToInt32(TotalQty), Convert.ToInt32(vid), Convert.ToInt32(cid), Convert.ToDecimal(Price), Convert.ToDecimal(Shippingcharge)) select datcart).Max());

            ShoppingCartItem order_dataitm = db.ShoppingCartItems.Find(ok);
            order_dataitm.ProductUrl = producturl;
            order_dataitm.ImageUrl = imageurl;
            //order_dataitm.basepricepoly = 0;
            db.Entry(order_dataitm).State = EntityState.Modified;
            db.SaveChanges();
            if (ok > 0)
            { return true; }
            else { return false; }

             //return true;
        }
        #endregion


        #region QuotationCartID
        public static string quotationCartID
        {
            get
            {
                // get the current HttpContext
                HttpContext context = HttpContext.Current;

                // try to retrieve the cart ID from the user session object
                string QuotationID = "";
                object cartIdSession = context.Session["QuotationID"];
                //HttpContext.Current.Response.Write("444=" + context.Session["CartID"]);
                if (cartIdSession != null)
                    QuotationID = cartIdSession.ToString();
                // if the ID exists in the current session...
                if (QuotationID != "")
                    // return its value
                    return QuotationID;
                else
                // if the cart ID isn't in the session...
                {
                    // check if the cart ID exists as a cookie
                    if (context.Request.Cookies["QuotationID"] != null)
                    {
                        // if the cart exists as a cookie, use the cookie to get its value
                        QuotationID = context.Request.Cookies["QuotationID"].Value;
                        // save the id to the session, to avoid reading the cookie next time
                        context.Session["QuotationID"] = QuotationID;
                        // return the id
                        return QuotationID;
                    }
                    else
                    // if the cart ID doesn't exist in the cookie as well, generate a new ID
                    {
                        // generate a new GUID
                        QuotationID = Guid.NewGuid().ToString();

                        // create the cookie object and set its value
                        HttpCookie cookie = new HttpCookie("QuotationID", QuotationID.ToString());
                        // set the cookie's expiration date 
                        // int howManyDays = Int32.Parse(ConfigurationManager.AppSettings["CartPersistDays"]);
                        int howManyDays = 2;
                        DateTime currentDate = DateTime.Now;
                        TimeSpan timeSpan = new TimeSpan(howManyDays, 0, 0, 0);
                        DateTime expirationDate = currentDate.Add(timeSpan);
                        cookie.Expires = expirationDate;
                        // set the cookie on client's browser
                        context.Response.Cookies.Add(cookie);
                        // save the ID to the Session as well
                        context.Session["QuotationID"] = QuotationID;
                        // return the CartID

                        return QuotationID.ToString();

                    }
                }
            }
        }
        #endregion

        #region Add to Quotation
       /* public static bool AddtoQuotation(int Pid, string Productname, int Qty, int TotalQty, int cid, int vid, string producturl, string imageurl)
        {
            int pid = Convert.ToInt32(Pid);
            DeliveryEntities db = new DeliveryEntities();

            int ok = 0;

            ok = Convert.ToInt32((from datcart in db.ClientQuotationCartItemsAddItem(quotationCartID, Convert.ToInt32(Pid), Productname, Convert.ToInt32(Qty), Convert.ToInt32(TotalQty), Convert.ToInt32(vid), Convert.ToInt32(cid)) select datcart).Max());

            QuotationCartItem Quotation_dataitm = db.QuotationCartItems.Find(ok);
            Quotation_dataitm.ImageUrl = imageurl;
            Quotation_dataitm.ProductUrl = producturl;

            db.Entry(Quotation_dataitm).State = EntityState.Modified;
            db.SaveChanges();
            if (ok > 0)
            { return true; }
            else { return false; }

            //return true;
        }/*
        #endregion

        
        */
        #region============== Get Date Code Start
       public static string GetDate(string date)
        {
            string retval = "";
            try
            {
                retval = string.Format("{0:dd/MM/yyyy}", Convert.ToDateTime(date));
            }
            catch
            {
            }

            return retval;
        }

        public static string GetDateDisplay(string date)
        {
            string retval = "";
            try
            {
                retval = string.Format("{0:dd MMM yyyy}", Convert.ToDateTime(date));
            }
            catch
            {
            }

            return retval;
        }


        public static string GetDateAndTime(string date)
        {
            string retval = "";
            try
            {
                retval = string.Format("{0:dd MMM yyyy hh:mm tt}", Convert.ToDateTime(date));
            }
            catch
            {
            }

            return retval;

        }
        #endregion


        #region============== Get Current Language Code Start
        public static string GetCurLan()
        {
            string lang = string.Empty;
            if (HttpContext.Current.Request.Cookies["cookielang"] != null)
            {
                HttpCookie cookie = HttpContext.Current.Request.Cookies.Get("cookielang");
                lang = cookie.Values["lang"].ToString();
            }
            else
            {
                //lang = "ar-KW";
                lang = "en-US";
            }
            return lang;
        }
        #endregion

        #region============== Get Remove Special Character Code Start
        public static string RemoveSpecialCharacter(String name)
        {
            name = name.Trim();

            StringBuilder sb = new StringBuilder();
            foreach (char c in name)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
        public static string RemoveSpecialCharacterURL(String name)
        {
            name = name.Trim();

            StringBuilder sb = new StringBuilder();
            foreach (char c in name)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '-')
                {
                    sb.Append(c);
                }
            }
            string rtnval = sb.ToString();
            if (rtnval.Length == 0)
            {
                rtnval = GenerateRandomCode(10);
            }
            return sb.ToString();
        }

        public static string GenerateRandomCode(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        #endregion

        #region============== Get Random No
        public static int GetRandomNo()
        {
            Random rn = new Random();
            int i = 0;
            i = rn.Next(1, 10000);
            return i;
        }
        public static int GetRandomNo(int noofcount)
        {
            Random rn = new Random();
            int i = 0;
            i = rn.Next(1, noofcount);
            return i;
        }
        #endregion

        #region============== Viewsing Record
        public static string GetArrayForRecord()
        {
            return "10:10,50:50,100:100";//,All:0";
        }
        #endregion

        #region============== Alpha Search
        public static string GetArrayForAlphaRecord()
        {
            return "[0-9]:0,A:A,B:B,C:C,D:D,E:E,F:F,G:G,H:H,I:I,J:J,K:K,L:L,M:M,N:N,O:O,P:P,Q:Q,R:R,S:S,T:T,U:U,V:V,W:W,X:X,Y:Y,Z:Z,ALL:";
        }
        #endregion

        #region============== All Record
        public static string GetArrayForSearchRecord()
        {
            return "All Record:1,Active Record:2,In Active Record:3";
        }

        public static string GetvalueForSearchRecord(string ArrayValue)
        {
            string rtnval = "";
            if (ArrayValue.Trim() == 2.ToString())
            {
                rtnval = true.ToString();
            }
            if (ArrayValue.Trim() == 3.ToString())
            {
                rtnval = false.ToString();
            }
            return rtnval;
        }
        #endregion

        #region============== Get Code Top of Page Start
        public static void ToTopOfPage(Page sender, Type e)
        {

            ScriptManager.RegisterStartupScript(sender, e.GetType(), "ToTheTop", "setTimeout('window.scrollTo(0, 0)', 0);", true);
            sender.Page.MaintainScrollPositionOnPostBack = false;
        }
        #endregion

        #region============== Get Control Index
        public static int GetControlIndex(String controlID)
        {
            try
            {
                Regex regex = new Regex("([0-9.*]{2})",
                           RegexOptions.RightToLeft);
                Match match = regex.Match(controlID);
                return Convert.ToInt32(match.Value);


            }
            catch
            {


                Regex regex = new Regex("([0-9.*])",
                              RegexOptions.RightToLeft);
                Match match = regex.Match(controlID);
                return Convert.ToInt32(match.Value);
            }
        }
        #endregion

        
    }
}
    
