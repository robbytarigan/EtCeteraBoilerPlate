/// <reference name="MicrosoftAjax.js" />

Type.registerNamespace("AjaxEnabled");

// create constructor
AjaxEnabled.PasswordStrengthComponent = function () {
    AjaxEnabled.PasswordStrengthComponent.initializeBase(this);
}

// define class
AjaxEnabled.PasswordStrengthComponent.prototype = {
    initialize: function () {
        // add custom initialization here
        AjaxEnabled.PasswordStrengthComponent.callBaseMethod(this, 'initialize');
    },

    returnPasswordStrength: function (password) {
        var strPass = new String(password.toString());

        if (strPass.length < 5) {
            return "Weak";
        } else if (strPass.length < 8) {
            return "Medium";
        } else {
            return "Strong";
        }
    },

    dispose: function () {
        // add custom dispose actions here
        AjaxEnabled.PasswordStrengthComponent.callBaseMethod(this, 'dispose');
    }
}

// register class as a Sys.Component
AjaxEnabled.PasswordStrengthComponent.registerClass('AjaxEnabled.PasswordStrengthComponent', Sys.Component);

// notify script loaded
if (typeof(Sys) !== 'undefined') Sys.Application.notifyScriptLoaded();