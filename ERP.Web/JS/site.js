$(document).ready(function () {

    $(".nav-link").click(function () {

        $("li.nav-item").each(function (index) {
            $(this).removeClass("active");
        });

        var menuItem = $(this).closest("li");
        menuItem.addClass("active");

    });
    $(".dropdown-item").click(function () {

        $("li.nav-item").each(function (index) {
            $(this).removeClass("active");
        });

        var menuItem = $(this).closest("li");
        menuItem.addClass("active");
    });

});