using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class Ejercicio5Model : PageModel
    {
        public string Estilo => "EstiloBAMSA";
        
        public void OnGet()
        {
        }
    }
}
