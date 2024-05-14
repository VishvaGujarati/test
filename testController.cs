using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using test.Data;
using test.Models;
using test.Models.entity;

namespace test.Controllers
{
    public class testController : Controller
    {
        private readonly Appdb ctx;
        public testController(Appdb ctx)
        {
            this.ctx = ctx;
        }
        public IActionResult Index()
        {
            return View();
        }

       public IActionResult Addproperty()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Addproperty(v1model p)
        {
            v1 v = new v1();
            /*if(ModelState.IsValid)
            {
              */  
                v.lid = p.lid;
                v.ptype = p.ptype;
                v.tarea = p.tarea;
                v.location = p.location;
                v.rent=p.rent;

                await ctx.v1s.AddAsync(v);

            /*}*/
            await ctx.SaveChangesAsync();
            return RedirectToAction("pdisplay","test");
        }
        [HttpGet]
        public async Task<IActionResult> pdisplay()
        {
            var res = await ctx.v1s.ToListAsync();
            return View(res);
        }

        [HttpGet]

        public async Task<IActionResult> Edit(int id)
        {
            var res= await ctx.v1s.FindAsync(id);
            return View(res);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(v1 pt)
        {
            var res = await ctx.v1s.FindAsync(pt.pid);
            if(res is not null)
            {
                res.lid = pt.lid;
                res.ptype = pt.ptype;
                res.tarea = pt.tarea;
                res.location = pt.location;
                res.rent=pt.rent;
            }
            await ctx.SaveChangesAsync();
            return RedirectToAction("pdisplay", "test");

        }
    }
}
