$(document).ready(function () {

    if (sessionStorage.getItem("ElementID") != null) {

        $("li.nav-item").each(function (index) {
            $(this).removeClass("active");
        });

        var element = $('#' + sessionStorage.getItem("ElementID"));
        element.addClass("active");
    }
    else {
        $('#HomeMenu').addClass("active");
    }


    $(".nav-link").click(function () {
        var menuItem = $(this).closest("li");
        sessionStorage.setItem("ElementID", menuItem.attr("id"));
    });


    $("#AddRoleBtn").click(function() {

        $('.role-request-msg').hide();
        var jsonObject = JSON.stringify({
            UserID: $("#UserModel_ID").val(),
            Role: $("#UserRolesDdl").val()
        });

        var idObject = $("#UserModel_ID").val();
        var currentUrl = '/Administration/Users/Edit/' + idObject + '?handler=AddRole';
        $.ajax({
            url: currentUrl,
            type: 'POST',
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            data: jsonObject,

            beforeSend: function (jqXHR, settings) {

                jqXHR.setRequestHeader("XSRF-TOKEN",
                    $('input:hidden[name="__RequestVerificationToken"]').val());

                $('.spinner').show();
                $('.role-container').hide();
            },
            success: function (result) {


                if (result.hasAddRoleException) {
                    $('.role-request-msg').show();
                    $('.role-request-msg').text(result.message);
                }
                else {
                    var textAreaVal = $('#UserModel_Roles').val();
                    textAreaVal += result.role + '\n';
                    $('#UserModel_Roles').val(textAreaVal);

                }

                $('.spinner').hide();
                $('.role-container').show();
            },
            error: function (result) {
                console.log(result);
            }
        });

    });


    $("#RemoveRoleBtn").click(function () {

        $('.role-request-msg').hide();

        var idObject = $("#UserModel_ID").val();
        var currentUrl = '/Administration/Users/Edit/' + idObject + '?handler=RemoveRole';

        var jsonObject = JSON.stringify({
            UserID: $("#UserModel_ID").val(),
            Role: $("#UserRolesDdl").val()
        });

        console.log(jsonObject);

        $.ajax({
            url: currentUrl,
            type: 'POST',
            dataType: "json",
            contentType: "application/json",
            data: jsonObject,
            beforeSend: function (jqXHR, settings) {

                jqXHR.setRequestHeader("XSRF-TOKEN",
                    $('input:hidden[name="__RequestVerificationToken"]').val());

                $('.spinner').show();
                $('.role-container').hide();
            },
            success: function (result) {

                console.log(result.hasRemoveRoleException);

                if (result.hasRemoveRoleException) {

                    $('.role-request-msg').show();
                    $('.role-request-msg').text(result.message);
                    
                }
                else {
                    var textAreaVal = $('#UserModel_Roles').val();
                    textAreaVal = textAreaVal.replace('\n' + result.role, '');
                    $('#UserModel_Roles').val(textAreaVal);
                }

                $('.spinner').hide();
                $('.role-container').show();

            },
            error: function (result) {
                console.log(result);
            }
        });
    });
});