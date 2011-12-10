using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PersonalControl {
    public class PromptContainer : Control, INamingContainer {
        public string Text { get; set; }

        public PromptContainer(string text) {
            this.Text = text;
        }
    }

    [ParseChildren(true)]
    public class LabeledTextBox : Control  {

        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TemplateContainer(typeof(PromptContainer))]
        public ITemplate PromptTemplate { get; set; }

        public string Text { get; set; }

        protected override void CreateChildControls() {
            // If a template has been specified, use it to create children.
            // Otherwise, create a single LiteralControl with the message value.

            if (PromptTemplate != null) {
                Controls.Clear();
                PlaceHolder plh = new PlaceHolder() { ID = "plh" };
                //TextBox txt = new TextBox() { Text = this.Text };

                PromptContainer container = new PromptContainer(this.Text);
                PromptTemplate.InstantiateIn(container);
                plh.Controls.Add(container);
                //plh.Controls.Add(txt);
                Controls.Add(plh);                
            } else {
                this.Controls.Add(new Label { Text = String.Format("Put the template for {0}" ,this.Text) });
            }
        }

        public override void DataBind() {
            base.EnsureChildControls();
            base.DataBind();
            
        }
    }


}



//namespace TemplateControlSamples {

//    public class TemplateItem : Control, INamingContainer {
//        private String     _message         = null;

//        public TemplateItem(String message) {
//            _message = message;
//        }

//        public String Message {

//           get {
//              return _message;
//           }
//           set {
//              _message = value;
//           }
//        }
//    }

//    [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name="FullTrust")]
//    [ParseChildren(true)]
//    public class Template1 : Control, INamingContainer {

//        private ITemplate  _messageTemplate = null;
//        private String     _message         = null;

//        public String Message {

//           get {
//              return _message;
//           }
//           set {
//              _message = value;
//           }
//        }

//        [
//            PersistenceMode(PersistenceMode.InnerProperty),
//            TemplateContainer(typeof(TemplateItem))
//        ]
//        public ITemplate MessageTemplate {
//           get {
//              return _messageTemplate;
//           }
//           set {
//              _messageTemplate = value;
//           }
//        }

//        protected override void CreateChildControls() {

//           // If a template has been specified, use it to create children.
//           // Otherwise, create a single LiteralControl with the message value.

//           if (MessageTemplate != null) {
//              Controls.Clear();
//              TemplateItem i = new TemplateItem(this.Message);
//              MessageTemplate.InstantiateIn(i);
//              Controls.Add(i);
//           }
//           else {
//              this.Controls.Add(new LiteralControl(this.Message));
//           }
//        }
//    }
//}