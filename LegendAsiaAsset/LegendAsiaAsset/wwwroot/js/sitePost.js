$(document).ready(function () {
    $('select').selectpicker({
        liveSearch: true,
        liveSearchNormalize: true,
        liveSearchPlaceholder: 'Search',
        liveSearchStyle: 'contains',
        /*styleBase: 'btn',*/
        style: 'btn-outline-violet form-control',
        size: '5',
        width: '100%',
    });

    $('.ui-pg-selbox').selectpicker('destroy');


    $("#FirstCurrency").selectpicker('val', 'SGD');
    $("#SecondCurrency").selectpicker('val', 'USD');



    $("#FirstCurrency").change(function () {
        var firstCurrency = $('#FirstCurrency').val();
        var secondCurrency = $('#SecondCurrency').val();
        var firstUR = $('#FirstUR').val();
        if (firstCurrency != "" && secondCurrency != "" && firstUR != "") {
            SecondCurrencyUnitRate(firstUR, firstCurrency, secondCurrency);
        }

    });

    $("#FirstUR").change(function () {     //Calculates 2nd UR
        var firstCurrency = $('#FirstCurrency').val();
        var secondCurrency = $('#SecondCurrency').val();
        var firstUR = $('#FirstUR').val();
        if (firstCurrency != "" && secondCurrency != "" && firstUR != "") {
            SecondCurrencyUnitRate(firstUR, firstCurrency, secondCurrency);
        }
    });

    $("#SecondCurrency").change(function () {
        var firstCurrency = $('#FirstCurrency').val();
        var secondCurrency = $('#SecondCurrency').val();
        var secondUR = $('#SecondUR').val();
        if (secondUR != "" && secondCurrency != "" && firstCurrency != "") {
            FirstCurrencyUnitRate(secondUR, secondCurrency, firstCurrency);
        }
    });

    $("#SecondUR").change(function () {     //Calculate 1st UR
        var firstCurrency = $('#FirstCurrency').val();
        var secondCurrency = $('#SecondCurrency').val();
        var secondUR = $('#SecondUR').val();
        if (secondUR != "" && secondCurrency != "" && firstCurrency != "") {
            FirstCurrencyUnitRate(secondUR, secondCurrency, firstCurrency);
        }
    });

    function FirstCurrencyUnitRate(enteredUnitRate, enteredCurrency, resultCurrency) {
        $.ajax({
            type: "GET",
            url: '../Home/GetCurrencyURDetails',
            data: {
                enteredUnitRate,
                enteredCurrency,
                resultCurrency
            },
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                $('#FirstUR').val(data.resultRate.toFixed(2));
                $('#unitCurrency').html("1 " + enteredCurrency + " = " + data.resultUnitRate + " " + resultCurrency);
            },
            error: (error) => {
                console.log(JSON.stringify(error));
            },
        });
    }
    function SecondCurrencyUnitRate(enteredUnitRate, enteredCurrency, resultCurrency) {
        $.ajax({
            type: "GET",
            url: '../Home/GetCurrencyURDetails',
            data: {
                enteredUnitRate,
                enteredCurrency,
                resultCurrency
            },
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                $('#SecondUR').val(data.resultRate.toFixed(2));
                $('#unitCurrency').html("1 " + enteredCurrency + " = " + data.resultUnitRate + " " + resultCurrency);

            },
            error: (error) => {
                console.log(JSON.stringify(error));
            },
        });
    }

    $(document).on('keydown', '.inline-edit-cell', function (event) {
        var keyCode = (event.keyCode ? event.keyCode : event.which);
        if (keyCode == 13) {
            event.preventDefault();
        }
    });

});