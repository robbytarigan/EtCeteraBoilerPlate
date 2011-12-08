using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.Design;
using System.ComponentModel;

namespace PersonalControl {
    class IDDetailDesigner : ControlDesigner {
        private IDDetail _idDetail;

        public override string GetDesignTimeHtml() {
            if (_idDetail.NameLabel == "Name" || _idDetail.NameLabel == String.Empty) {
                return "<div style=\"color:green;\">[Define NameLabel]</div>";
            } else {
                return base.GetDesignTimeHtml();
            }
        }

        public override void Initialize(IComponent component) {
            _idDetail = (IDDetail)component;
            base.Initialize(component);
        }
    }
}
