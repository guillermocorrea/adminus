using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Credentials.Entities;
using Credentials.DataAccess;
using Credentials.DataAccess.Interfaces;
using Credentials.DataAccess.Repositories;

namespace Credentials.Web.Controllers
{
    public class UsersController : Controller
    {
        /// <summary>
        /// The users repository
        /// </summary>
        private IUserRepository _userRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersController"/> class.
        /// </summary>
        public UsersController()
        {
            this._userRepository = new UserRepository();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersController"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        public UsersController(IUserRepository repository)
        {
            this._userRepository = repository;
        }

        // GET: /Users/
        public ActionResult Index()
        {
            return View(this._userRepository.GetAll());
        }

        // GET: /Users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Username,Password")] User user)
        {
            if (ModelState.IsValid)
            {
                var foundUser = this._userRepository.GetUser(user.Username);
                if (foundUser != null)
                {
                    ViewBag.error = "Username or password are invalids.";
                    return View(new User());
                }

                this._userRepository.Add(user);
                this._userRepository.Save();

                ViewBag.error = "Credentials inserted correctly.";
                user = new User();
            }

            return View(user);
        }

        /// <summary>
        /// Releases unmanaged resources and optionally releases managed resources.
        /// </summary>
        /// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && this._userRepository != null)
            {
                this._userRepository.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
