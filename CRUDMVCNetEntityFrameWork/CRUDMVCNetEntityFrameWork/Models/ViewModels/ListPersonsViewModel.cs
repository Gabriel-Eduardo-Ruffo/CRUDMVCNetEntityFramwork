using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDMVCNetEntityFrameWork.Models.ViewModels
{
    public class ListPersonsViewModel
    {
        //objeto con las columnas (propiedades) de la tabla
        //Sirve para representar los elementos traidos de la DB en un objeto
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}