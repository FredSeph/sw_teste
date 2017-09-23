$(document).ready(function () {

});

$("#AddButton").on("click", function () {
    $("#ItemForm").attr("method", "post").attr("action", "/Items/Create");
});

$(".editButton").on("click", function () {
    $("#ItemForm").attr("method", "post").attr("action", "/Items/Update");

    $("#Id").val($(this).data("itemid"));
    $("#Name").val($(this).data("itemname"));
    $("#Price").val($(this).data("itemprice"));
    $("#Promotion").val($(this).data("itempromotion"));
});

$("#AddEditModal").on('hidden.bs.modal', function () {
    $("#ItemForm .form-control").val("");
});

$("#ItemSave").on("click", function () {
    if ($("#Name").val() != "" && $("#Price").val() != "") {
        $("#ItemForm").submit();
    }
    else {
        alert("Produtos devem ter nome e preço.");
    }
});