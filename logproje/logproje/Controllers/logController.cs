using logproje.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace logproje.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class logController : ControllerBase
    {
        
        [HttpGet]
        public IEnumerable<Logtb> Get()
        {
            using (var context = new testContext())
            {

                //return context.Projes.ToList();
                /*
                Proje pr = new Proje();
                pr.Message = "mesaj4";
                pr.CreateDate = DateTime.Now;
                pr.LogType = "test";
                context.Projes.Add(pr);
                context.SaveChanges();
                */
                //return context.Projes.Where(veri => veri.Int == 3).ToList();
                return context.Logtbs.ToList();


            }
        }
    }
}
