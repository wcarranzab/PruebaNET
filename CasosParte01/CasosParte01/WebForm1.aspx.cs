using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CasosParte01
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ChangeString a = new ChangeString();
            //string demo = a.build("a/5*loja");
            List<List<int>> result = new List<List<int>>();
            int[] array1 = new int[] { 58, 60, 55, 48, 57, 73 };
            OrderRange b = new OrderRange();
            result = b.build(array1);
        }
    }
}