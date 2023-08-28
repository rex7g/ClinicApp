using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using API_CLINICA.Data;

namespace API_CLINICA.Controllers
{
    public class usuariosController : Controller
    {
        private readonly CLINICAContext _context;

        public usuariosController(CLINICAContext context)
        {
            _context = context;
        }

       
      
    }
}
