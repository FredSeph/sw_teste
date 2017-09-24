$(".addToCartButton").on("click", function () {
    var id = $(this).data("itemid");
    var count = $("#count-" + id).val();

    alert("id: " + id + ", count: " + count);
});