﻿var dataTable;
$(document).ready(function () {
    loadDataTable();

});


function handleReIdentificationOptions(jsonData, selectedValue) {
    var jsonOptions = jsonData.data

    var options = `    <option value="" disabled selected>Select your option</option>
` + jsonOptions.map(o => `<option value=${o.id}>${o.name}</option>`)
    $("#configurationSelection").empty();
    $("#configurationSelection").append(options);
    if (selectedValue) {
        $("#configurationSelection").val(parseInt(selectedValue));
        //if (!$("#reidentifyClick").length) {
        //    $("#reIdentifiyWrapper").append(
        //        `<div class="w-75 btn-group" role="group">
        //             <a id="reidentifyClick" class="btn btn-primary mx-2"> <i class="bi bi-search"  ></i>ReIdentify</a>               
        //             </div>`
        //    )
        //    $("#reidentifyClick").on('click', function () {
        //        var row = dataTable.rows(this.parentNode.parentNode.parentNode).data()[0];
        //        $.ajax({
        //            url: '/config/RGO_ReIdentificationConfiguration/reidentify',
        //            data: {
        //                datasetId: row.id, reidentificationId: row.rgO_ReIdentificationConfigurationId
        //            },
        //            type: 'POST',
        //            success: res => toastr.success(res.success)
        //        })
        //    })
        //}
    }
    $("#configurationSelection").on('change', function () {
        var val = this.value;
        $.ajax({
            url: '/config/datasets/SetReIdentificationConfiguration',
            data: { datasetId: 1, reidentificationId: val },
            type: 'PATCH',
            success: res => console.log(res)
        })
    })
}

function Test(obj) {
    console.log(table.row(obj).index());
}

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            url: '/config/rgo_dataset/getall'
        },
        "columns": [
            { data: 'rgO_Dataset_Template.name', "width": "10%" },
            { data: 'dataset_Name', "width": "10%" },
            { data: 'dataset_Status', "width": "10%" },
            { data: 'doi', "width": "10%" },
            //{ data: 'rgO_ReIdentificationConfiguration.name', "width": "0%" },
            { data: 'rgO_Release_Status.name', "width": "10%" },
            { data: 'created_By', "width": "10%" },
            { data: 'created_Date', "width": "10%" },
            { data: 'updated_By', "width": "5%" },
            { data: 'updated_Date', "width": "10%" },
            { data: 'notes', "width": "5%" },
            //{
            //    data: 'rgO_ReIdentificationConfigurationId', "render": function (data) {
            //        $.ajax({
            //            url: '/config/rgo_reidentificationconfiguration/getall',
            //            type: 'GET',
            //            success: res => {
            //                handleReIdentificationOptions(res, data)
            //            }
            //        })
            //        return `<div id="reIdentifiyWrapper"><select id="configurationSelection"><option>Unknown</option></select></div>`
            //    }, "width": '5%'
            //},
            {
                data: 'id', "render": function (data) {
                    return `<div class="w-75 btn-group" role="group">
                     <a href="/config/datasets/download?id=${data}" class="btn btn-primary mx-2"> <i class="bi bi-box-arrow-down"></i>Download</a>               
                     <a href="/config/rgo_dataset/upsert?id=${data}" class="btn btn-primary mx-2"> <i class="bi bi-pencil-square"></i> Edit</a>
                     <a onClick=Delete('/config/rgo_dataset/delete/${data}') class="btn btn-danger mx-2"> <i class="bi bi-trash-fill"></i> Delete</a>
                     </div>`
                },
                "width": "15%"
            }

        ],
        "columnDefs": [
            { "visible": false, "targets": [5, 6, 7, 8, 9] }]

    });

}

function Delete(url) {
    Swal.fire({
        title: 'Are you sure you want to delete this Dataset and all associated records?',
        text: "You won't be able to revert this!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    dataTable.ajax.reload();
                    toastr.success(data.message);
                },
                error: function (data) {
                    dataTable.ajax.reload();
                    toastr.error(data.message);
                }
            })
        }
    })
}


