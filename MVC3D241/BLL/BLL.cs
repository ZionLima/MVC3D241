using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MVC3D241.BLL
{
    public class BLL
    {
        DAL daoBanco = new DAL();

        string sql = string.Format($@"select * from tbl_produto where " + condicao);
        return daoBanco.ExecutarConsulta(sql);
    }
}
