$(document).ready(function () {

    var options = $("#columnTemplateParentSelect option")
    if (options.length == 2) {

        $("#columnTemplateParentSelect").val(options[1].value).trigger("change")
    }
    $("#indexColumnsThisParentOnly").attr("href", generateIndexURL())


});

function GetURLParameter(sParam) {
    var sPageURL = window.location.search.substring(1);
    var sURLVariables = sPageURL.split('&');
    for (var i = 0; i < sURLVariables.length; i++) {
        var sParameterName = sURLVariables[i].split('=');
        if (sParameterName[0] == sParam) {
            return sParameterName[1];
        }
    }
}
function mapURLParameters() {
    var parentId = GetURLParameter("parentId");
    if (parentId) {
        return "/" + parentId;
    }

    return "";

}

function getParentIdIfExists() {
    var parentId = GetURLParameter("parentId");
    if (parentId) {
        return "&parentId=" + parentId;
    }
    console.log("HGello")
    return "";

}


function generateIndexURL() {
    var href = `/config/rgo_column_template/index?id=0${getParentIdIfExists()}`
    return href;

}