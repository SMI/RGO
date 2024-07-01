var dataTable;
$(document).ready(function () {
    $('#tblData').hide();
    loadDataTable();
});

function loadDataTable() {

    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/config/group/getall'},
        "columns": [
            { data: 'reference_number', "width": "10%" },
            { data: 'name', "width": "10%" },
            { data: 'group_Type.name', "width": "10%" },
            { data: 'contactInfo', "width": "10%" },
            { data: 'created_By', "width": "10%" },
            { data: 'created_Date', "width": "10%" },
            { data: 'updated_By', "width": "10%" },
            { data: 'updated_Date', "width": "10%" },
            { data: 'notes', "width": "10%" },
            {
                data: 'id', "render": function (data) {
                    return `<div class="w-75 btn-group" role="group">
                     <a href="/config/group/upsert?id=${data}" class="btn btn-primary mx-2"> <i class="bi bi-pencil-square"></i> Edit</a>               
                     <a onClick=Delete('/config/group/delete/${data}') class="btn btn-danger mx-2"> <i class="bi bi-trash-fill"></i> Delete</a>
                     </div>`
                },
                "width": "20%"
            }
        ]

    });

    dataTable.column(4).visible(false);
    dataTable.column(5).visible(false);
    dataTable.column(6).visible(false);
    dataTable.column(7).visible(false);
    dataTable.column(8).visible(false);
    $('#tblData').show();
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


