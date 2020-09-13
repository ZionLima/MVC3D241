using MVC3D241.BLL;
using MVC3D241.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace ProjetoMVCD32
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            BLL bllProduto = new BLL();
            DTO dtoProduto = new DTO();
        }
    }
}