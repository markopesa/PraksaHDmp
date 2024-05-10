using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PraksaHDmp.Contracts;
using PraksaHDmp.Data;
using PraksaHDmp.Models;

namespace PraksaHDmp.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper _mapper;

        public UsersController(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<IActionResult> InactiveUsers()
        {

                List<User> inactiveUsers = await userRepository.GetInactiveUsersAsync();

                UserInactiveVM viewModel = new UserInactiveVM
                {
                    InactiveUsers = inactiveUsers
                };

                return View(viewModel);  

        }


        // GET: Users
        public async Task<IActionResult> Index()
        {
            var userVMs = _mapper.Map<List<UserVM>>(await userRepository.GetActiveUsersAsync());
            return View(userVMs);
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(int? id)
        {

            var user = await userRepository.GetAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            var UserVM = _mapper.Map<User>(user);
            return View(UserVM);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UserCreateVM userVM)
        {
            if (ModelState.IsValid)
            {
                var user = _mapper.Map<User>(userVM);
                user.DateCreated = DateTime.Now;
                user.Active = true;
                user.UserCreatedId = null;
                user.UserModifiedId = null;
                await userRepository.AddAsync(user);
                return RedirectToAction(nameof(Index));
            }

            return View(userVM);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var user = await userRepository.GetAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            var userVM = _mapper.Map<UserEditVM>(user);
            userVM.DateModified = DateTime.Now;

            return View(userVM);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, UserEditVM userVM)
        {
            if (id != userVM.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var user = await userRepository.GetAsync(id);
                if (user == null)
                {
                    return NotFound();
                }

                _mapper.Map(userVM, user);
                user.DateModified = DateTime.Now;

                await userRepository.UpdateAsync(user);

                return RedirectToAction(nameof(Index));
            }

            return View(userVM);
        }


        // GET: Users/Deactivate/5
        public async Task<IActionResult> DeactivateConfirm(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await userRepository.GetAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await userRepository.DeleteAsync(id);
            return RedirectToAction(nameof(InactiveUsers));
        }

        private async Task<bool> UserExists(int id)
        {
            return await userRepository.Exists(id);
        }

        // POST: Users/Deactivate/5
        [HttpPost, ActionName("Deactivate")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Deactivate(int id)
        {
            var user = await userRepository.GetAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            user.Active = false;
            await userRepository.UpdateAsync(user);
            return RedirectToAction(nameof(Index));
        }
    }
}