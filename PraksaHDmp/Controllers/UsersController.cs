using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PraksaHDmp.Data;
using PraksaHDmp.Models;

namespace PraksaHDmp.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public UsersController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<IActionResult> InactiveUsers()
        { 

                List<User> allUsers = await _context.User.ToListAsync();

                List<User> inactiveUsers = allUsers.Where(u => !u.Active).ToList();

                UserInactiveVM viewModel = new UserInactiveVM
                {
                    InactiveUsers = inactiveUsers
                };

                return View(viewModel);
            
        }


        // GET: Users
        public async Task<IActionResult> Index()
        {
            var users = await _context.User
                .Include(u => u.UserCreated)
                .Include(u => u.UserModified)
                .Where(u => u.Active)
                .ToListAsync();

            var userVMs = _mapper.Map<List<UserVM>>(users);

            return View(userVMs);
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.User == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .Include(u => u.UserCreated)
                .Include(u => u.UserModified)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
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
            try
            {
                if (ModelState.IsValid)
                {
                    var user = _mapper.Map<User>(userVM);
                    user.DateCreated = DateTime.Now;
                    user.Active = true;
                    user.UserCreatedId = null;
                    user.UserModifiedId = null;
                    _context.Add(user);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error: {ex.Message}");
                throw;
            }

            return View(userVM);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.User == null)
            {
                return NotFound();
            }

            var user = await _context.User.FindAsync(id);
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
                try
                {
                    var user = await _context.User.FindAsync(id);
                    if (user == null)
                    {
                        return NotFound();
                    }

                    _mapper.Map(userVM, user);
                    user.DateModified = DateTime.Now;

                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(userVM.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            return View(userVM);
        }


        // GET: Users/Deactivate/5
        public async Task<IActionResult> DeactivateConfirm(int? id)
        {
            if (id == null || _context.User == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .Include(u => u.UserCreated)
                .Include(u => u.UserModified)
                .FirstOrDefaultAsync(m => m.Id == id);
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
            var user = await _context.User.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.User.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(InactiveUsers));
        }

        private bool UserExists(int id)
        {
            return (_context.User?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        // POST: Users/Deactivate/5
        [HttpPost, ActionName("Deactivate")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Deactivate(int id)
        {
            var user = await _context.User.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            user.Active = false;
            _context.Update(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}