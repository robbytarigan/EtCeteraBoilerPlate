namespace AjaxButton {
    #region Usings
    using System;
    using System.Collections.Generic;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    #endregion Usings
    public class AlertButton: Button, IScriptControl {
        private ScriptManager sMgr;

        public string Message;

        IEnumerable<ScriptDescriptor> IScriptControl.GetScriptDescriptors() {
            ScriptControlDescriptor descriptor = new ScriptControlDescriptor("AjaxButton.AlertButton", this.ClientID);

            descriptor.AddProperty("message", this.Message);

            return new ScriptDescriptor[] { descriptor };
        }

        IEnumerable<ScriptReference> IScriptControl.GetScriptReferences() {
            ScriptReference reference = new ScriptReference();
            reference.Assembly = "AjaxButton";
            reference.Name = "AjaxButton.AlertButton.js";
            return new ScriptReference[] { reference };
        }

        protected override void OnPreRender(EventArgs e) {    

            if (!this.DesignMode) {
                // test for existence of a Script Manager
                sMgr = ScriptManager.GetCurrent(Page);

                if (sMgr == null)
                    throw new HttpException("A ScriptManager control must exist on the page.");

                sMgr.RegisterScriptControl(this);
            }

            base.OnPreRender(e);
        }

        protected override void Render(HtmlTextWriter writer) {
            if (!this.DesignMode)
                sMgr.RegisterScriptDescriptors(this);

            base.Render(writer);
            
        }
    }
}
