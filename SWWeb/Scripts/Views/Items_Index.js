// Botão Adicionar (click)
$("#AddButton").on("click", function () {
    $("#AddUpdateModal .modal-title").html("Adicionar novo produto");
    $("#ItemAddUpdateForm").attr("action", "/Items/Add");
});

// Botões Editar (click)
$(".editButton").on("click", function () {
    $("#AddUpdateModal .modal-title").html("Editar produto");
    $("#ItemAddUpdateForm").attr("action", "/Items/Update");

    $("#Id").val($(this).data("itemid"));
    $("#Name").val($(this).data("itemname"));
    $("#Price").val($(this).data("itemprice"));
    $("#Promotion").val($(this).data("itempromotion"));
});

// Botões Deletar (click)
$(".removeButton").on("click", function () {
    $("#ItemRemoveId").val($(this).data("itemid"));
    $("#ItemRemoveName").html($(this).data("itemname"));
});

// Modal de Criar/Editar (hidden)
$("#AddUpdateModal").on('hidden.bs.modal', function () {
    $(".form-control").val("");
});

// Confirmação de Adicionar/Editar (click)
$("#ItemSave").on("click", function () {
    if ($("#Name").val() != "" && $("#Price").val() != "") {
        $("#ItemAddUpdateForm").submit();
    }
    else {
        alert("Produtos devem ter nome e preço.");
    }
});

// Confirmação de Remover (click)
$("#ItemRemoveConfirm").on("click", function () {
    $("#ItemRemoveForm").submit();
});