/* Custom JavaScript */
$(document).ready(function () {
    console.log("Function started..");
    $("a.btn.btn-danger.btn-sm").click(function () {
        console.log("Delete button clicked");
        return confirm("Are you sure you want to delete this record?");
    });
});