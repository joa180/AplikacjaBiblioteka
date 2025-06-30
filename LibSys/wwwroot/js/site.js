// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Initialize DataTables on all tables with the `.datatable` class
$(document).ready(function () {
    $('.datatable').DataTable({
        language: {
            url: '//cdn.datatables.net/plug-ins/1.13.7/i18n/pl.json'
        },
        pageLength: 10,
        lengthMenu: [5, 10, 20]
    });
});
