var dataTable;
$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/config/datasets/getall' },
        "columns": [
            { data: 'dataset_Name', "width": "15%" },
            { data: 'dataset_Status', "width": "15%" },
            { data: 'created_By', "width": "10%" },
            { data: 'created_Date', "width": "10%" },
            { data: 'updated_By', "width": "10%" },
            { data: 'updated_Date', "width": "10%" },
            { data: 'notes', "width": "10%" },
            {
                data: 'id', "render": function (data) {
                    return `<div class="w-75 btn-group" role="group">
                     <a href="/config/datasets/download?id=${data}" class="btn btn-primary mx-2"> <i class="bi bi-box-arrow-down"></i>Download</a>               
                     </div>`
                },
                "width": "20%"
            }
        ]

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


