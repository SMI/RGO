var dataTable;
$(document).ready(function () {

    loadDataTable();
    $("#createColumnTemplateAnchor").attr("href", generateUpsertURL())
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


function generateUpsertURL() {
    var href =`/config/rgo_column_template/upsert?id=0${getParentIdIfExists()}`
    return href;

}

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/config/rgo_column_template/getall' + mapURLParameters() },
        "columns": [
            { data: 'rgO_Dataset_Template.name', "width": "10%" },
            { data: 'name', "width": "10%" },
            { data: 'description', "width": "15%" },
            { data: 'pK_Column_Order', "width": "10%" },
            { data: 'type', "width": "5%" },
            { data: 'potentially_Disclosive', "width": "5%" },
            { data: 'rgO_Release_Status.name', "width": "10%" },
            { data: 'created_By', "width": "5%" },
            { data: 'created_Date', "width": "5%" },
            { data: 'updated_By', "width": "5%" },
            { data: 'updated_Date', "width": "5%" },
            { data: 'notes', "width": "5%" },
            { 
                data: 'id', "render": function (data) {
                    return `<div class="w-75 btn-group" role="group">
                     <a href="/config/rgo_column_template/upsert?id=${data}${getParentIdIfExists()}" class="btn btn-primary mx-2"> <i class="bi bi-pencil-square"></i> Edit</a>               
                     <a onClick=Delete('/config/rgo_column_template/delete/${data}') class="btn btn-danger mx-2"> <i class="bi bi-trash-fill"></i> Delete</a>
                     </div>`
                },
                "width": "20%"
            }
        ],
        "columnDefs": [
            { "visible": false, "targets": [7, 8, 9, 10, 11] }]

    });

}

function Delete(url) {
    Swal.fire({
        title: 'Are you sure?',
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
                    if (data.success) {
                        toastr.success(data.message);
                    } else {
                        toastr.error(data.message);
                    }
                }
            })
        }
    })
}


