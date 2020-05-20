using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BatDongSanService.ViewModels;
using BatDongSan.Models.ViewModels;
using BatDongSanService;
using BatDongSanService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Net.Mail;

namespace BatDongSan.Controllers
{
    public class DangNhapController : Controller
    {
        private readonly BatDongSanContext _dbContext;

        public DangNhapController(BatDongSanContext dbContext)
        {
            _dbContext = dbContext;
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            //var f_password = GetMD5(password);
            if (email != null && password != null)
            {
                var data = _dbContext.TaiKhoan.FirstOrDefault(s => s.Email.Equals(email) && s.MatKhau.Equals(password));
                HttpContext.Session.SetString("username", email);
                return RedirectToAction("Index", "TrangChu");
            }
            else
            {
                ViewBag.error = "Invalid Account";
                return RedirectToAction("Login");
            }
        }


        public IActionResult Details()
        {
            return View();
        }


        public IActionResult Register()
        {
            List<LoaiTaiKhoan> LoaiTaiKhoanList = _dbContext.LoaiTaiKhoan.ToList();
            ViewBag.LoaiTaiKhoanList = new SelectList(LoaiTaiKhoanList, "ID", "Ten");
            return View();
        }

        [HttpPost]
        public IActionResult Register(TaiKhoanViewModel taiKhoanViewModel)
        {
            if (ModelState.IsValid)
            {
                var taiKhoan = new TaiKhoan();
                taiKhoan.MatKhau = taiKhoanViewModel.MatKhau;
                taiKhoan.Ten = taiKhoanViewModel.Ten;
                taiKhoan.GioiTinh = (taiKhoanViewModel.GioiTinh == "Nam") ? true : false;
                taiKhoan.Email = taiKhoanViewModel.Email;
                taiKhoan.SoDienThoai = taiKhoanViewModel.SoDienThoai;
                taiKhoan.DiaChi = taiKhoanViewModel.DiaChi;
                taiKhoan.SoDuVi = 0;
                taiKhoan.LoaiTaiKhoan = int.Parse(taiKhoanViewModel.LoaiTaiKhoan);
                _dbContext.TaiKhoan.Add(taiKhoan);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(Register));
            }
            return View();
        }


        //create a string MD5
        public static string GetMD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = Encoding.UTF8.GetBytes(str);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x2");

            }
            return byte2String;
        }

        //void insertMember()
        //{

        //    try
        //    {
        //        string strString = "abcdefghijklmnopqrstuvwxyz0123456789";
        //        Random random = new Random();
        //        int randomCharIndex = 0;
        //        char randomChar;
        //        string captcha = "";
        //        for (int i = 0; i < 15; i++)
        //        {
        //            randomCharIndex = random.Next(0, strString.Length);
        //            randomChar = strString[randomCharIndex];
        //            captcha += Convert.ToString(randomChar);
        //        }

        //        Session["rdnCode"] = captcha;
        //        string comm;
        //        comm = "insert customers(customer_id,customer_username,customer_password,customer_name,customer_email,customer_address,customer_city,customer_country,customer_home_phone,customer_cell_phone,customer_valid_email_code,customer_valid_email,customer_date_added) values ('" + Session["idMember"].ToString() + "','" + txtTen.Text + "','" + txtMatKhau.Text + "','" + txtHoten.Text + "','" + txtEmail.Text + "','" + txtDiachi.Text + "','" + txtThanhpho.Text + "','VietNam','" + txtSdtDidong.Text + "','" + txtSdtBan.Text + "','" + captcha + "','0',now())";
        //        if (ClassDB.execute(comm, ClassDB.connString) > 0)
        //        {
        //            SendEmailMember();
        //        }
        //    }
        //    catch
        //    {
        //    }
        //}

        //void SendEmailMember()
        //{
        //    try
        //    {
        //        MailMessage message = new MailMessage();
        //        message.From = new MailAddress("abc@abc.com", "abc");
        //        message.To.Add(new MailAddress(txtEmail.Text));
        //        message.CC.Add(new MailAddress("abc@gmail.com"));
        //        message.Subject = "Email xác nhận";
        //        message.Body = "Vui lòng nhấn vào đường dẫn dưới đây để xác nhận đăng ký tại website : \n";
        //        message.Body += "http://www.abc?code=" + Session["rdnCode"].ToString();

        //        SmtpClient client = new SmtpClient("relay-hosting.secureserver.net", 25);

        //        System.Net.NetworkCredential auth = new System.Net.NetworkCredential("abc@abc.com", "abc");
        //        client.EnableSsl = false;
        //        client.Credentials = auth;
        //        //client.Credentials = CredentialCache.DefaultNetworkCredentials; 
        //        client.Send(message);
        //    }
        //    catch { }


        //}
    }
}