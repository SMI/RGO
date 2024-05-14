$(document).ready(function () {

    var options = $("#columnTemplateParentSelect option")
    if (options.length == 2) {

        $("#columnTemplateParentSelect").val(options[1].value).trigger("change")
        console.log("selected parent")
        console.log(options)
    }

});