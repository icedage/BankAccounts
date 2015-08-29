using BankAccounts.Presentation.Models;
using BankAccounts.Presentation.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankAccounts.Presentation.Controllers
{
    public class BankAccountController : Controller
    {
        private readonly IBankAccountPresenter _bankAccountPresenter;
        public BankAccountController(IBankAccountPresenter bankAccountPresenter)
        {
            _bankAccountPresenter = bankAccountPresenter;
        }

        // GET: BankAccount
        public ActionResult Index()
        {
            return View();
        }

        // GET: BankAccount/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BankAccount/Create
        public ActionResult Create()
        {
            var account = new BankAccountModel();
            return View(account);
        }

        // POST: BankAccount/Create
        [HttpPost]
        public ActionResult Create(BankAccountModel bankAccountModel)
        {
            try
            {
                // TODO: Add insert logic here
                var account = _bankAccountPresenter.ApplyForAccount(bankAccountModel);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BankAccount/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BankAccount/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BankAccount/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BankAccount/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
