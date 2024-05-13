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