$(document).ready(function () {
    $.ajax({
        url: "/config/rgo_dataset_template/getall",
        type: 'GET',
        dataType: 'json', // added data type
        success: function (res) {
            var options = res.data;
            var selectList = $("#dataset_template_select_list");
            selectList.empty();
            selectList = selectList[0];
            var opt = document.createElement('option');
            opt.text = "--Select Dataset Template--";
            opt.value = null;
            selectList.add(opt, null);
            options.forEach(option => {
                opt = document.createElement('option');
                opt.text = option.name;
                opt.value = option.id;
                selectList.add(opt, null);
            });
        }
    });
});

function doUpload() {
    var form = new FormData();
    var e = document.getElementById("dataset_template_select_list");
    var value = e.value;
    form.append("datasetTemplateID", value)

    var reader = new FileReader(),
        file = $('#csv_picker')[0];

    //form.append("file", document.getElementById("csv_picker").files[0])
    //console.log(form);
    //$.ajax({
    //    type: "POST",
    //    url: "/config/upload/upload",
    //    data: form, // serializes the form's elements.
    //    contentType: false,
    //    processData: false,
    //    success: function (data) {
    //        alert(data); // show response from the php script.
    //    }
    //});
}