var dataTable;
$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/config/rgo_dataset_template/getall' },
        "columns": [
            { data: 'rgOutput.name', "width": "10%" },
            { data: 'name', "width": "10%" },
            { data: 'description', "width": "30%" },
            { data: 'rgO_Release_Status.name', "width": "10%" },
            { data: 'created_By', "width": "10%" },
            { data: 'created_Date', "width": "10%" },
            { data: 'updated_By', "width": "10%" },
            { data: 'updated_Date', "width": "10%" },
            { data: 'notes', "width": "10%" },
            {
                data: 'id', "render": function (data) {
                    return `<div class="w-75 btn-group" role="group">
                     <a href="/config/rgo_column_template/index?parentId=${data}" class="btn btn-primary mx-2"> <i class="bi bi-pencil-square"></i> Columns</a>
                     <a href="/config/rgo_dataset_template/upsert?id=${data}" class="btn btn-primary mx-2"> <i class="bi bi-pencil-square"></i> Edit</a>
                     <a onClick=Delete('/config/rgo_dataset_template/delete/${data}') class="btn btn-danger mx-2"> <i class="bi bi-trash-fill"></i> Delete</a>
                    <a href="/config/rgo_dataset_template/download/${data}" download="proposed_file_name"  class="btn btn-primary mx-2"><i class="bi bi-download"></i>Download Template</a>
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


