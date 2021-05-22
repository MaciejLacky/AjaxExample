// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(function () {

    $(".customerRadio").change(function () {
        doCustomerUpdate();
    });

    function doCustomerUpdate() {

        $.ajax({
            type: "POST",
            url: "Customer/ShowOnePerson",
            data: $("form").serialize(),
            success: function (data) {
             
                $("#CustomerInformationArea").html(data);
            }
        });
    };

    $("#selectCustomer").click(function () {
        event.preventDefault();
        doCustomerUpdate();

    });
});
