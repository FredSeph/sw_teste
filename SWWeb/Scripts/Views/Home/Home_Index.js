// Inserir o botão do Checkout no menu principal
$(document).ready(function () {
    var menuItemCheckout = "<li id=\"CheckoutMenuItem\"><a href=\"#\" data-toggle=\"modal\" data-target=\"#ShoppingCartModal\"><i class=\"glyphicon glyphicon-shopping-cart\"></i> Checkout <span id=\"CheckoutCount\"></span></a></li>";
    $("#MainMenu").append(menuItemCheckout);
    LoadCart();
});

// Botões Comprar
$(".addToCartButton").on("click", function () {
    var id = $(this).data("itemid");
    var count = $("#count-" + id).val();

    AddItemToCart(id, count);
});

// Botão Finalizar compra
$("#CheckoutFinish").on("click", function () {
    Checkout();
});

function LoadCart() {
    $.ajax({
        type: "Get",
        url: "/Home/LoadCart",
        success: function (result) {
            UpdateCart(result);
        }
    });
}

function AddItemToCart(id, count) {
    $.ajax({
        type: "Get",
        url: "/Home/AddItemToCart",
        contentType: 'application/json; charset=utf-8',
        datatype: "json",
        data: { id: id, count: count },
        success: function (result) {
            UpdateCart(result);
            alert((count > 1 ? "Itens adicionados" : "Item adicionado") + " ao carrinho");
        }
    });
}

function Checkout() {
    $.ajax({
        type: "Get",
        url: "/Home/Checkout",
        success: function (result) {
            alert("Compra realizada com sucesso!");
            $("#ShoppingCartModal").modal("toggle");
            UpdateCart(result);
        }
    });
}

function UpdateCart(result) {
    $("#CheckoutCount").html("(" + result.Count + ")");
    $("#ShoppingCartModalBody").html(result.CartHtml);
}