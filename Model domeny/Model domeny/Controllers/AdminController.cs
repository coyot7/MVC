using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model_domeny.Models;

namespace Model_domeny.Controllers
{
    public class AdminController : Controller 
    {
        IMembersRepository membersRepository;
        public AdminController(IMembersRepository membersRepository)
        {
            this.membersRepository = membersRepository;
        }
        // GET: Admin
        public ActionResult ChangeLoginName(string oldLogin, string newLogin)
        {
            Member member = membersRepository.FetchByLoginName(oldLogin);
            member.LoginName = newLogin;
            membersRepository.SubmitChanges();
            return View();
        }
    }
}