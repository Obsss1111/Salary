using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Salary.Data;
using Salary.Models;
using System.Linq;
using System.Threading.Tasks;


namespace Salary.Controllers
{
    public class UserController : Controller
    {
        private readonly DbService service;

        public UserController(DbService service)
        {
            this.service = service;
        }

        public async Task<IActionResult> Index()
        {
            return View(await service.User.ToListAsync());
        }

        public IActionResult Profile()
        {
            return View();
        }

        // GET: User/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await service.User
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Movies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Login,PasswordHash")] User user)
        {
            if (ModelState.IsValid)
            {
                service.Add(user);
                await service.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Movies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var movie = await service.User.FindAsync(id);
            if (movie == null) return NotFound();
            return View(movie);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Login,PasswordHash")] User user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    service.Update(user);
                    await service.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.Id))
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

            return View(user);
        }

        // GET: User/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await service.User
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var user = await service.User.FindAsync(id);
            service.User.Remove(user);
            await service.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }     

        private bool UserExists(string id)
        {
            return service.User.Any(e => e.Id == id);
        }
    }
}
