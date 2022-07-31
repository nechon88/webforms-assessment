using assessment.DataAccess;
using assessment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace assessment.Carriers
{
    public partial class ViewList : System.Web.UI.Page
    {
        private readonly ICarrierRepo _repo;

        public ViewList(ICarrierRepo repo)
        {
            _repo = repo;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<assessment.Models.Carrier> CarrierListView_GetData()
        {
            List<Carrier> list = _repo.GetAll();
            EnumerableQuery<Carrier> ret = new EnumerableQuery<Carrier>(list);
            return ret;
        }

    }
}