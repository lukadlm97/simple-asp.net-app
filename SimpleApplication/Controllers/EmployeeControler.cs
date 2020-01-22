using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleApplication.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SimpleApplication.Controllers
{
    public class EmployeeControler : Controller
    {
        private readonly EmployeeContext _context;

        public EmployeeControler(EmployeeContext context)
        {
            _context = context;
        }

        // GET: Employee
        public async Task<IActionResult> Index()
        {
            return View(await _context.Employees.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();
            var employee = await _context.Employees
                .FirstOrDefaultAsync(emp => emp.EmployeeID == id);
            if (employee == null)
                return NotFound();
            return NotFound();
        }
    }
}
