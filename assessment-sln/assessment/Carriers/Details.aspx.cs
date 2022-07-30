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
        CarrierRepoInMem repo = new CarrierRepoInMem();
        private Carrier _carrier;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
                return;
        }

        // The id parameter should match the DataKeyNames value set on the control
        // or be decorated with a value provider attribute, e.g. [QueryString]int id
        public assessment.Models.Carrier CarrierDetail_GetItem([QueryString("id")] int? id)
        {
            if (id.HasValue) return repo.GetByID(id.Value);
            return null;
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void CarrierDetail_UpdateItem(int CarrierID)
        {
            assessment.Models.Carrier item = null;
            // Load the item here, e.g. item = MyDataLayer.Find(id);
            item = repo.GetByID(CarrierID);
            if (item == null)
            {
                // The item wasn't found
                ModelState.AddModelError("", String.Format("Item with id {0} was not found", CarrierID));
                return;
            }
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                // Save changes here, e.g. MyDataLayer.SaveChanges();
                repo.Update(item);
            }
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void CarrierDetail_DeleteItem(int CarrierID)
        {
            repo.Delete(CarrierID);
        }
    }
}