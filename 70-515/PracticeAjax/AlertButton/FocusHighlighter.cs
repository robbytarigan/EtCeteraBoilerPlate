namespace AjaxButton {
    #region Usings
    using System.Collections.Generic;
    using System.Web.UI;
    using System;
    using System.Web;
    using System.Web.UI;
    #endregion Usings
    [TargetControlType(typeof(Control))]
    public class FocusHighlighter : ExtenderControl {

        public string HighlightCssClass;
        public string NoHighlightCssClass;

        protected override IEnumerable<ScriptReference> GetScriptReferences() {
            ScriptReference reference = new ScriptReference();
            reference.Assembly = "AjaxButton";
            reference.Name = "AjaxButton.FocusHighlighter.js";

            return new ScriptReference[] { reference };
        }

        protected override IEnumerable<ScriptDescriptor> GetScriptDescriptors(Control targetControl) {
            ScriptBehaviorDescriptor descriptor = new ScriptBehaviorDescriptor("AjaxButton.FocusHighlighter", targetControl.ClientID);
            descriptor.AddProperty("highlightCssClass", this.HighlightCssClass);
            descriptor.AddProperty("nohighlightCssClass", this.NoHighlightCssClass);

            return new ScriptDescriptor[] { descriptor };
        }

        // The Script Manager region is not used.
        //#region Script Manager
        //private ScriptManager sMgr;
        //protected override void OnPreRender(EventArgs e) {

        //    if (!this.DesignMode) {
        //        // test for existence of a Script Manager
        //        sMgr = ScriptManager.GetCurrent(Page);

        //        if (sMgr == null)
        //            throw new HttpException("A ScriptManager control must exist on the page.");

        //        sMgr.RegisterScriptControl(this);
        //    }

        //    base.OnPreRender(e);
        //}

        //protected override void Render(HtmlTextWriter writer) {
        //    if (!this.DesignMode)
        //        sMgr.RegisterScriptDescriptors(this);

        //    base.Render(writer);

        //} 
        //#endregion Script Manager
    }
}
