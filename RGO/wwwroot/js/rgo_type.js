﻿var dataTable;
$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/config/rgo_type/getall'},
        "columns": [
            { data: 'name', "width": "10%" },
            { data: 'description', "width": "25%" },
            { data: 'created_By', "width": "10%" },
            { data: 'created_Date', "width": "10%" },
            { data: 'updated_By', "width": "10%" },
            { data: 'updated_Date', "width": "10%" },
            { data: 'notes', "width": "10%" },
            {
                data: 'id', "render": function (data) {
                    return `<div class="w-75 btn-group" role="rgo">
                     <a href="/config/rgo_type/upsert?id=${data}" class="btn btn-primary mx-2"> <i class="bi bi-pencil-square"></i> Edit</a>               
                     <a onClick=Delete('/config/rgo_type/delete/${data}') class="btn btn-danger mx-2"> <i class="bi bi-trash-fill"></i> Delete</a>
                     </div>`
                },
                "width": "15%"
            }
        ],
        "columnDefs": [
            { "visible": false, "targets": [2, 3, 4, 5, 6] }]

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
                },
                error: function (data) {
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


