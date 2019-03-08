using Lab3_Montenegro_1229918.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Linq;
using System.Web.Mvc;

namespace Lab3_Montenegro_1229918.Controllers
{
    public class PedidosController : Controller
    {
        // GET: Pedidos
        public ActionResult Index()
        {
            return View(new List<Inventario>());
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase postedFile)
        {
            List<Inventario> inventario = new List<Inventario>();
            string filePath = string.Empty;
            if (postedFile != null)
            {
                string path = Server.MapPath("~/archivo/");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                filePath = path + Path.GetFileName(postedFile.FileName);
                string extension = Path.GetExtension(postedFile.FileName);
                postedFile.SaveAs(filePath);
                int contador = 0;
                string csvData = System.IO.File.ReadAllText(filePath);
                foreach (string row in csvData.Split('\n'))
                {
                    if ((!string.IsNullOrEmpty(row)) && (contador != 0))
                    {
                        Inventario inventarios = new Inventario();
                        inventarios.ID = Convert.ToInt32(row.Split(';')[0]);
                        inventarios.nombre = row.Split(';')[1];
                        inventarios.descripción = row.Split(';')[2];
                        inventarios.casaproductora = row.Split(';')[3];
                        if(row.Split(';')[4].Contains("$"))
                        {
                            row.Split(';')[4] = row.Split(';')[4].Trim(new Char[] { '$' });
                        }
                        inventarios.precio =/*Convert.ToDouble(*/row.Split(';')[4]/*)*/;
                        inventarios.existencia = Convert.ToInt32(row.Split(';')[5]);
                        inventario.Add(inventarios);
                    }
                    else
                    {
                        contador++;
                    }
                }
            }
            return View(inventario);
        }

        public ActionResult arbol()
        {

            return View();
        }
    }
}