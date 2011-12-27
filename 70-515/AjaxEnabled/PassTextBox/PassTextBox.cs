using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using System.Web.UI;
using System.Web;

namespace AjaxEnabled {
    public class PassTextBox : TextBox, IScriptControl {
        private ScriptManager sMgr;

        public string WeakCssClass { get; set; }
        public string MediumCssClass { get; set; }
        public string StrongCssClass { get; set; }

        IEnumerable<ScriptDescriptor> IScriptControl.GetScriptDescriptors() {
            ScriptControlDescriptor descriptor = new ScriptControlDescriptor("AjaxEnabled.PassTextBox", this.ClientID);

            descriptor.AddProperty("weakCssClass", this.WeakCssClass);
            descriptor.AddProperty("mediumCssClass", this.MediumCssClass);
            descriptor.AddProperty("strongCssClass", this.StrongCssClass);

            return new ScriptDescriptor[] { descriptor };
        }

        IEnumerable<ScriptReference> IScriptControl.GetScriptReferences() {
            ScriptReference reference = new ScriptReference();
            reference.Assembly = "AjaxEnabled";
            reference.Name = "AjaxEnabled.PassTextBox.js";

            return new ScriptReference[] { reference };
        }

        protected override void OnPreRender(EventArgs e) {            
            base.OnPreRender(e);

            if (!this.DesignMode) {
                // test for the existence of a Script Manager
                sMgr = ScriptManager.GetCurrent(Page);

                if (sMgr == null)
                    throw new HttpException("A ScriptManager control must exist on the page.");

                sMgr.RegisterScriptControl(this);
            }
        }

        protected override void Render(HtmlTextWriter writer) {
            base.Render(writer);

            if (!this.DesignMode)
                sMgr.RegisterScriptDescriptors(this);
        }
    }
}
