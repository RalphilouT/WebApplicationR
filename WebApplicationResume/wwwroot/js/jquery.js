
$(document).ready(function () {
    $(".introWeb").mouseenter(function () {
        $(".introWeb").hide();
    });
$("input").focus(function () {
    $(this).css("background-color", "yellow");
    });
$("input").blur(function () {
    $(this).css("background-color", "green");
    });
$("textarea").focus(function () {
    $(this).css("background-color", "yellow");
    });
$("textarea").blur(function () {
    $(this).css("background-color", "green");
    });
});




