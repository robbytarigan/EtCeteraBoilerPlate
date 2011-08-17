function GetUrlQueryString(name) {
    name = name.replace(/[\[]/, "\\\[").replace(/[\]]/, "\\\]");
    var regexS = "[\\?&]" + name + "=([^&#]*)";
    var regex = new RegExp(regexS);

    var location;
    if (document.URL)
        location = document.URL
    else if (document.location.href)
        location = document.location.href;
    else
        location = window.location.href;

    var results = regex.exec(location);
    if (results == null)
        return "";
    else
        return results[1];
}
