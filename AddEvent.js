function AddEvent(elmtId, eventName, eventMethod) {
    var elmt = document.getElementById(elmtId);

    if (eventName == "change") {
        // Special case for change event
        AddEvent(elmtId, "focus", function (e) {
            if (!e) var e = window.event

            var eTarget = e.target ? e.target : e.srcElement;

            eTarget.originalValue = eTarget.value;
        });

        AddEvent(elmtId, "blur", function (e) {
            if (!e) var e = window.event

            var eTarget = e.target ? e.target : e.srcElement;

            if (eTarget.value != eTarget.originalValue) {
                eventMethod(e);
            }
        });
    } else {
        // Other event
        if (elmt.addEventListener) {
            elmt.addEventListener(eventName, eventMethod, false);
        } else if (elmt.attachEvent) {
            elmt.attachEvent('on' + eventName, eventMethod);
        }
    }
}