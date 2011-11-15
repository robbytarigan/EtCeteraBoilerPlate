using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserRegistrationSimulation {
    public partial class userreg : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void PasswordCustomValidator_ServerValidate(object source, ServerValidateEventArgs args) {
            string data = args.Value;

            // Start by setting false
            args.IsValid = false;

            // Check length
            if (data.Length < 6 || data.Length > 14) 
                return;

            // Check for uppercase, lowercase, and numeric
            bool uc = false; bool lc = false; bool num = false;
            foreach (char c in data) {
                if (char.IsUpper(c)) {
                    uc = true;
                } else if (char.IsLower(c)) {
                    lc = true;
                } else if (char.IsNumber(c)) {
                    num = true;
                }
                if (uc && lc && num) {
                    //must be valid
                    args.IsValid = true;
                    break;
                }
            }
        }

    }
}