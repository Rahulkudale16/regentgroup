$(document).ready(function () {

    $(".name").bind("keyup focusout", function () {
        var item = $(".name").val();
        var alert = $("#nameAlert");
        if ((item == "")) {
            alert.show();
        }
        else {
            alert.hide();
        }
    });

    $(".email").bind("keyup focusout", function () {
        var item = $(".email").val();
        var alert = $("#emailAlert");
        if ((item == "")) {
            alert.show();
        }
        else {
            alert.hide();
        }
    });

    $(".subject").bind("keyup focusout", function () {
        var item = $(".subject").val();
        var alert = $("#subjectAlert");
        if ((item == "")) {
            alert.show();
        }
        else {
            alert.hide();
        }
    });

    $(".message").bind("keyup focusout", function () {
        var item = $(".message").val();
        var alert = $("#messageAlert");
        if ((item == "")) {
            alert.show();
        }
        else {
            alert.hide();
        }
    });

    $(document).on('click', '.btn-submit', function () {
        if (($(".name").val() == "") || ($(".email").val() == "") || ($(".subject").val() == "") || ($(".message").val() == "")) {
            if ($(".name").val() == "") { $("#nameAlert").show() }
            if ($(".email").val() == "") { $("#emailAlert").show() }
            if ($(".subject").val() == "") { $("#subjectAlert").show() }
            if ($(".message").val() == "") { $("#messageAlert").show() }
        }
        else {
            /*if ((".email").includes('@') && (".email").includes('.')) {*/
                SendEmail();
            /*}*/
            //else {
            //    window.alert("Please insert Valid EmailID.");
            //    //$('#warningToastMessage').text('Please insert Valid EmailID.');
            //    //$('#warningToast').toast("show");
            //    $('#loading').hide();
            //}
        }
    });
});


function SendEmail() {
    var name = $(".name").val();
    var email = $(".email").val();
    var subject = $(".subject").val();
    var message = $(".message").val();
    $.ajax({
        type: "POST",
        url: '../Home/MailSend',
        //url: 'MailSend',
        data: {
            name,
            email,
            subject,
            message
        },
        dataType: 'json',
        success: function (result) {
            alert("Mail sent successfully");
            window.location.reload();
        },
    });
}