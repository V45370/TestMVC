$(function () {
    //Category multiselect filter
    $("#category-filter").select2();

    //Price slider filter
    $("#price-slider").slider({
        range: true,
        min: 0,
        max: 500,
        values: [75, 300],
        slide: function (event, ui) {
            $("#amount").val(ui.values[0] + " лв. - " + ui.values[1] + " лв.");
        }
    });
    $("#amount").val($("#price-slider").slider("values", 0) +
      " лв. - " + $("#price-slider").slider("values", 1) + " лв.");

    //Filter button submit
    $('#filter-submit').click(function () {
        $.ajax({
            url: "/Home/Products",
            type: "POST",
            dataType: "json",
            traditional: true,
            contentType: "application/json; charset=utf-8",
            data: (function () {
                return JSON.stringify({
                    filterCategories: $("#category-filter").val(),
                    filterPriceRange: [$("#price-slider").slider("values", 0), $("#price-slider").slider("values", 1)]
                });
            })(),
            success: function (data) {
            window.location.reload(true);
            }
        })
    });
});