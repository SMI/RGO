var dataTable;
$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/config/rgoutput/getall'},
        "columns": [
            
            { data: 'name', "width": "13%" },
            { data: 'rgO_Type.name', "width": "9%" },
            { data: 'description', "width": "14%" },
            { data: 'group.name', "width": "9%" },
            { data: 'doi', "width": "10%" },
            { data: 'standardAcknowledgement', "width": "10%" },
            { data: 'created_By', "width": "9%" },
            { data: 'created_Date', "width": "9%" },
            { data: 'updated_By', "width": "9%" },
            { data: 'updated_Date', "width": "9%" },
            { data: 'notes', "width": "9%" },
            {
                data: 'id', "render": function (data) {
                    return `<div class="w-75 btn-group" role="group">
                     <a href="/config/rgoutput/upsert?id=${data}" class="btn btn-primary mx-2"> <i class="bi bi-pencil-square"></i> Edit</a>
                     <a onClick=Delete('/config/rgoutput/delete/${data}') class="btn btn-danger mx-2"> <i class="bi bi-trash-fill"></i> Delete</a>
                     </div>`
                },
                "width": "10%"
            }
        ],
        "columnDefs": [
            { "visible": false, "targets": [6, 7, 8, 9, 10] }]

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


