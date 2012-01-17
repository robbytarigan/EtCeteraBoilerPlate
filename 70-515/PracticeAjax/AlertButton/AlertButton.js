/// <reference name="MicrosoftAjax.js" />

Type.registerNamespace("AjaxButton");

AjaxButton.AlertButton = function (element) {
    AjaxButton.AlertButton.initializeBase(this, [element]);

    this._message = null;
};

AjaxButton.AlertButton.prototype = {
    initialize: function () {
        AjaxButton.AlertButton.callBaseMethod(this, 'initialize');

        //this._onClickHandler = Function.createDelegate(this, this._onClick);  // It seems this line is unused
        $addHandlers(this.get_element(), { 'click': this._onClick }, this);
    },

    dispose: function () {
        $clearHandlers(this.get_element());
        AjaxButton.AlertButton.callBaseMethod(this, 'dispose');
    },

    _onClick: function () {
        window.alert(this._message);        
    },

    get_message: function () {
        return this._message;
    },

    set_message: function (value) {
        this._message = value;
    }
};

AjaxButton.AlertButton.registerClass('AjaxButton.AlertButton', Sys.UI.Control);

if (typeof(Sys) !== 'undefined') Sys.Application.notifyScriptLoaded();