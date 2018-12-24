// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {

    $(".nexamind-onselect-bg-color-change").on('click', function () {


        var color = $(this).css("background-color");

        if (color==="transparent") {
            $(this).css("background-color", "#8561c5");
        }
        else {
            $(this).css("background-color", "transparent");
        }
    });

    $(".nexamind-toggleswitch-nightmode").change(function () {

        var color = $("body").css("background-color");
        debugger;
        console.log(color);

        if (color == "rgb(255, 255, 255)") {
            $("body").css("background-color", "black");
            $(".nexamind-text-color").css("color", "white");
            $(".nexamind-hr-color").css("color","#C0C0C0");
        }
        else {
            $("body").css("background-color", "white");
            $(".nexamind-text-color").css("color", "black");
            $(".nexamind-hr-color").css("color", "grey");
        }
    });

    $(".nexamind-signout").click(function () {
            var auth2 = gapi.auth2.getAuthInstance();
            auth2.signOut().then(function () {
                console.log('User signed out.');
            });
        
    });

    //$(".nexamind-onselect-bg-color-change").hover(function () {

    //    var color = $(this).css("background-color");

    //    if (color === "transparent") {
    //        $(this).css("background-color", "#8561c5");
    //    }
    //    else {
    //        $(this).css("background-color", "transparent");
    //    }
    //});
});
