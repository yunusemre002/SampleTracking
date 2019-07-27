using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.WebUI.ViewComponents
{
    public class AdminLeftMenuViewComponent:ViewComponent
    {
        /*
         
          dependency injection ile repositoryden data alıp view'a gönderebiliriz
             
             */

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
