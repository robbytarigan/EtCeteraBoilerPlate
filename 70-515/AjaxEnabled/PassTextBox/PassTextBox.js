/// <reference name="MicrosoftAjax.js" />

Type.registerNamespace("AjaxEnabled");

// create constructor

AjaxEnabled.PassTextBox = function (element) {
    AjaxEnabled.PassTextBox.initializeBase(this, [element]);

    this._weakCssClass = null;
    this._mediumCssClass = null;
    this._strongCssClass = null;
}

// define class
AjaxEnabled.PassTextBox.prototype = {
    //initialize the UI control
    initialize: function () {
        AjaxEnabled.PassTextBox.callBaseMethod(this, 'initialize');        
        this._onKeyupHandler = Function.createDelegate(this, this._onKeyup);
        $addHandlers(this.get_element(), { 'keyup': this._onKeyup }, this);
    },
    dispose: function () {
        $clearHandlers(this.get_element());
        AjaxEnabled.PassTextBox.callBaseMethod(this, 'dispose');
    },
    //define keystroke event
    _onKeyup: function (e) {
        //get password text
        var pass = this.get_element().value;
        var strength = this.returnPasswordStrength(pass);
        switch (strength) {
            case "Weak":
                this.get_element().className = this._weakCssClass;
                break;
            case "Medium":
                this.get_element().className = this._mediumCssClass;
                break;
            case "Strong":
                this.get_element().className = this._strongCssClass;
                break;
        }
    },
    //define properties
    get_weakCssClass: function () {
        return this._weakCssClass;
    },
    set_weakCssClass: function (value) {
        this._weakCssClass = value;
    },
    get_mediumCssClass: function () {
        return this._mediumCssClass;
    },
    set_mediumCssClass: function (value) {
        this._mediumCssClass = value;
    },
    get_strongCssClass: function () {
        return this._strongCssClass;
    },
    set_strongCssClass: function (value) {
        this._strongCssClass = value;
    },
    returnPasswordStrength: function (password) {
        var strPass = new String(password.toString());
        if (strPass.length < 5) {
            return "Weak";
        }
        else {
            if (strPass.length < 8) {
                return "Medium";
            }
            else {
                return "Strong";
            }
        }
    }
}

// register class as a Sys.Control
AjaxEnabled.PassTextBox.registerClass('AjaxEnabled.PassTextBox', Sys.UI.Control);

// notify load
if (typeof (Sys) !== 'undefined') Sys.Application.notifyScriptLoaded();