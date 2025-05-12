var modelOpen = 0;
$(document).ready(function () {
    $("#EmailIDLogin").hide();
    $("#NewPassLogin").hide();
    $("#RetypeNewPassLogin").hide();
    $("#OTP").hide();
    $("#Otpview").hide();
    $(".Verifybtn").hide();
    $(".Enterbtn").hide();

    $("#Forgotword").click(function () {
        $("#EmailIDLogin").show();
        $("#UserNameLogin").hide();
        $("#PasswordLogin").hide();
        $("#Forgotword").hide();
        $("#Login").hide();
        $("#OTP").show();
        //renderView('ForgotPassword');
    });

    //document.getElementById('Forgotword').onclick = function() {
    //        renderView('ForgotPassword');
    //    };



    //document.getElementById('OTP').onclick = function () {
    //    alert("Here's a message!");
    //};

    //document.getElementById('b2').onclick = function () {
    //    swal("Here's a message!", "It's pretty, isn't it?")
    //};

    //document.getElementById('b3').onclick = function () {
    //    swal("Good job!", "You clicked the button!", "success");
    //};

    //document.getElementById('b4').onclick = function () {
    //    swal({
    //        title: "Are you sure?",
    //        text: "You will not be able to recover this imaginary file!",
    //        type: "warning",
    //        showCancelButton: true,
    //        confirmButtonColor: '#DD6B55',
    //        confirmButtonText: 'Yes, delete it!',
    //        closeOnConfirm: false,
    //        //closeOnCancel: false
    //    },
    //        function () {
    //            swal("Deleted!", "Your imaginary file has been deleted!", "success");
    //        });
    //};

    //document.getElementById('b5').onclick = function () {
    //    swal({
    //        title: "Are you sure?",
    //        text: "You will not be able to recover this imaginary file!",
    //        type: "warning",
    //        showCancelButton: true,
    //        confirmButtonColor: '#DD6B55',
    //        confirmButtonText: 'Yes, delete it!',
    //        cancelButtonText: "No, cancel plx!",
    //        closeOnConfirm: false,
    //        closeOnCancel: false
    //    },
    //        function (isConfirm) {
    //            if (isConfirm) {
    //                swal("Deleted!", "Your imaginary file has been deleted!", "success");
    //            } else {
    //                swal("Cancelled", "Your imaginary file is safe :)", "error");
    //            }
    //        });
    //};

    //document.getElementById('b6').onclick = function () {
    //    swal({
    //        title: "Sweet!",
    //        text: "Here's a custom image.",
    //        imageUrl: 'https://i.imgur.com/4NZ6uLY.jpg'
    //    });
    //};
});