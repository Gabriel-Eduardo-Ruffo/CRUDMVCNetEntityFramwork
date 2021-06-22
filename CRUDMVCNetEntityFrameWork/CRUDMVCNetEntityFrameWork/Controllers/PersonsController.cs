using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUDMVCNetEntityFrameWork.Models;//para acceder a los models
using CRUDMVCNetEntityFrameWork.Models.ViewModels;//para acceder a los viewModels (objeto que representa una tabla de DB)

namespace CRUDMVCNetEntityFrameWork.Controllers
{
    public class PersonsController : Controller
    {
        // GET: Persons
        public ActionResult Index()//nombre de la pagina o direccion llamada desde el front.
        {
            //Creamos una variable del tipo lista (clase ListPersonsViewModel) que va a contener los datos de la DB pasados a un objeto que tiene sus mismas properties
            List<ListPersonsViewModel> list;
            using (TestCRUDEntities db = new TestCRUDEntities())//el nombre de esta clase es la que seteamos con entityFramework
            {              
                list = (from d in db.Persons
                            select new ListPersonsViewModel()
                            {
                                Id = d.Id,
                                FirstName = d.FirstName,
                                LastName = d.LastName,
                                Age = d.Age
                            }).ToList();
            }
            return View(list);
        }


    }
}