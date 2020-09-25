using System.Collections.Generic;
using System.Reflection;
using emplib;

namespace wcfemplib
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Empservice : IEmpservice
    {
        public void addfield(employee emp)
        {
            AdoConected d = new AdoConected();
            d.addfield(emp);
        }

        public List<employee> GetEmployees()
        {
            AdoConected d = new AdoConected();
          List<employee> lst=  d.GetAllemps();
            return lst;

        }

        public void DeleteEmpById(int ecode)
        {

            AdoConected d = new AdoConected();
            d.DeleteEmpById(ecode);
        }

        public void UpdateEmpById(employee emp)
        {

            AdoConected d = new AdoConected();
            d.UpdateEmpById(emp);
        }

        public employee GetEmpById(int ecode)
        {

            AdoConected d = new AdoConected();
             employee emp= d.GetEmpById(ecode);
            return emp;
        }

        
    }
}

