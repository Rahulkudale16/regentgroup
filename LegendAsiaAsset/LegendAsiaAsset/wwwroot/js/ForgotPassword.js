$(document).ready(function () {
    $("#EmailIDLogin").show();
    $("#NewPassLogin").hide();
    $("#RetypeNewPassLogin").hide();
    $("#OTP").show();
    $("#OTP1").hide();
    $("#Otpview").hide();
    $(".Verifybtn").hide();
    $(".Enterbtn").hide();
    $("#EmailIDW").hide();
    $("#EmailIDW1").hide();
    $("#EmailIDW2").hide();
    $("#OTPW").hide();
    $("#PasswordW").hide();
    $("#PasswordW1").hide();

    //$("#Forgotword").click(function () {
    //    $("#EmailIDLogin").show();
    //    $("#UserNameLogin").hide();
    //    $("#PasswordLogin").hide();
    //    $("#Forgotword").hide();
    //    $("#Login").hide();
    //    $("#OTP").show();
    //});   

    $("#OTP").click(function () {
        $('#loading').show();
        var EmailID = $("#EmailIDOTP").val();
        if (EmailID != "") {
            if (EmailID.includes('@') && EmailID.includes('.')) {
                $("#EmailIDW2").hide();
                $("#OTP").hide();
                $("#OTP1").show();
                $("#EmailIDW").hide();
                $.ajax({
                    type: "POST",
                    url: "NewOTPDetails",
                    data: {
                        EmailID
                    },
                    datatype: "json",
                    success: function (data) {
                        if (data.success == false) {
                            $("#EmailIDW1").show();
                            //alert("OTP Failed");
                            //$("#errorToastMessage").text("OTP Failed");
                            //$('#errorToast').toast("show");
                        }
                        else if (data.success == true) {
                            //$("#EmailIDW1").show();
                            //alert("OTP Sent successfully");
                            $("#EmailIDLogin").hide()
                            $("#OTP").hide();
                            $("#OTP1").hide();
                            $("#Otpview").show();
                            $(".Verifybtn").show();
                            //$('#successToastMessage').text("OTP Sent successfully");
                        }
                    }
                });
                //checkDuplicationEmail(EmailID,Country,Location,"ADD",UserName);
            }
            else {
                $("#EmailIDW2").hide();
                $("#EmailIDW").show();
                //alert('Enter proper email id!!!');
                //$('#warningToastMessage').text('Enter proper email id.');
                //$('#warningToast').toast("show");
            }
        }
        else {
            $("#EmailIDW2").show();
        }
    });

    $(".Verifybtn").click(function () {
        $('#loading').show();
        var EmailID = $("#EmailIDOTP").val();
        var OTP = $("#OTPField").val();
        $.ajax({
            type: "GET",
            url: "GetOTPDetailsBack",
            data: {
                OTP,
                EmailID
            },
            datatype: "json",
            success: function (data) {

                if (OTP == data.data) {
                    $("#OTPW").hide();
                    //alert("OTP Verified successfully");
                    $("#NewPassLogin").show();
                    $("#RetypeNewPassLogin").show();
                    $("#Otpview").hide();
                    $(".Verifybtn").hide();
                    $(".Enterbtn").show();
                }
                else {
                    //var TOBPort = $('#LoadPort').val();
                    $("#Otpview").val();
                    $("#OTPW").show();
                    //alert('Entered OTP is Incorrect');
                }
            }
        });
    });

    $(".Enterbtn").click(function () {
        $('#loading').show();
        var EmailID = $("#EmailIDOTP").val();
        var PasswordFirst = $("#NewEnterOTP").val();
        var Password = $("#ReEnterOTP").val();
        $.ajax({
            type: "POST",
            url: "GetChangePassword",
            data: {
                PasswordFirst,
                Password,
                EmailID
            },
            datatype: "json",
            success: function (data) {
                if (PasswordFirst != Password) {
                    $("#PasswordW").show();
                    //alert("Both Password Should be Same");
                }
                else {
                    if (data.success == false) {
                        $("#PasswordW1").show();
                        //alert('Error While Resetting the password');
                    }
                    else {
                        $("#PasswordW1").hide();
                        $("#PasswordW").hide();
                        //alert('New Password Set Successfully!!!');
                        window.location.href = 'https://localhost:7148/Account/Login';
                    }
                }
            }
        });
    });
});