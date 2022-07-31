using assessment.DataAccess;
using assessment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace assessment.Carriers
{
    public partial class Details : System.Web.UI.Page
    {
        private readonly ICarrierRepo _repo;

        public Details(ICarrierRepo repo)
        {
            _repo = repo;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
                return;
            if (!string.IsNullOrEmpty(Request.QueryString["mode"]))
            {
                string mode = Request.QueryString["mode"];
                if (mode == "insert")
                {
                    CarrierDetail.ChangeMode(FormViewMode.Insert);
                }
            }
        }

        public Carrier CarrierDetail_GetItem([QueryString("id")] int? id)
        {
            if (id.HasValue) return _repo.GetByID(id.Value);
            return null;
        }

        public void CarrierDetail_UpdateItem(int CarrierID)
        {
            Carrier item = null;
            item = _repo.GetByID(CarrierID);
            if (item == null)
            {
                ModelState.AddModelError("", String.Format("Item with id {0} was not found", CarrierID));
                return;
            }
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                _repo.Update(item);
            }
        }

        public void CarrierDetail_DeleteItem(int CarrierID)
        {
            _repo.Delete(CarrierID);
            Response.Redirect("~/Carriers/ViewList");
        }

        public void CarrierDetail_InsertItem()
        {
            var item = new Carrier();
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                _repo.Create(item);
                Response.Redirect("~/Carriers/ViewList");
            }
        }
    }
}