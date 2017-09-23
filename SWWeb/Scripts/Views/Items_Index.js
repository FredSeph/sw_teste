$(document).ready(function () {

});

$("#AddButton").on("click", function () {
    $("#ItemForm").attr("method", "post").attr("action", "/Items/Create");
});

$("#EditButton").on("click", function () {
    $("#ItemForm").attr("method", "put").attr("action", "/Items/Edit");

    $("#Id").val($(this).data("itemid"));
    $("#Name").val($(this).data("itemname"));
    $("#Price").val($(this).data("itemprice"));
    $("#Promotion").val($(this).data("itempromotion"));
});

$("#ItemSave").on("click", function () {
    if ($("#Name").val() != "" && $("#Price").val() != "") {
        $("#ItemForm").submit();
    }
    else {
        alert("Produtos devem ter nome e preço.");
    }
});