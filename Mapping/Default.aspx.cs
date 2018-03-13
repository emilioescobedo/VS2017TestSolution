using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Employee;
using Person;
using AutoMapper;

namespace Mapping
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PersonInfo per = new PersonInfo();
            per.FirstName = "Emilio";
            per.LastName = "Escobedo";
            
            //Create Map for AutoMapper.
            Mapper.CreateMap<PersonInfo, EmployeePersonal>();

            //Use the create map.
            EmployeePersonal emp = Mapper.Map<EmployeePersonal>(per);

        }

        public void Testing()
        {
            
        }
    }
}