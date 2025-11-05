var modelOpen = 0;
$(document).ready(function () {

    if (RoleUser == 'ADMIN') {

        $("#CreateButtonLocation").show();
    }
    else if (RoleUser == 'HR') {

        $("#CreateButtonLocation").hide();
    }
    else if (RoleUser == "SUPERUSER") {

        $("#CreateButtonLocation").show();

    }
    else if (RoleUser == "USER") {

        $("#CreateButtonLocation").hide();
        $("#UpdateLocationNEW").hide();
        $("#statusShow1").hide();

    }
    // Location Grid Starts
    var currentPage;
    LocationGrid = $('#LocationGrid').jqGrid({
        mtype: 'Get',
        url: 'GetLocationdata',
        datatype: 'json',
        colNames: ['ID', 'ID', 'ID', 'Region', 'Country', 'Location', 'CreatedBy', 'CreatedOn', 'ModifiedBy', 'ModifiedOn', 'Status', 'Status', 'View'],
        colModel: [
            {
                key: true,
                hidden: true,
                name: 'IDLocation',
                width: '100px',
            },
            {
                key: false,
                name: 'view',
                editable: false,
                width: '100px',
            },
            {
                key: false,
                hidden: true,
                name: 'IDLocationDis',
                editable: false,
                width: '100px',
            },
            {
                key: false,
                name: 'Region',
                width: '200px',
            },
            {
                key: false,
                name: 'Country',
                editable: false,
                width: '125px',
            },
            {
                key: false,
                name: 'Location',
                editable: false,
                width: '200px',
            },
            {
                key: false,
                hidden: true,
                name: 'CreatedBy',
                editable: false,
                width: '125px',
            },
            {
                key: false,
                hidden: true,
                name: 'CreatedOn',
                editable: false,
                width: '125px',
            },
            {
                key: false,
                hidden: true,
                name: 'ModifiedBy',
                editable: false,
                width: '125px',
            },
            {
                key: false,
                hidden: true,
                name: 'ModifiedOn',
                editable: false,
                width: '125px',
            },
            {
                key: false,
                hidden: true,
                name: 'Status',
                editable: false,
                width: '125px',
            },
            {
                key: false,
                hidden: false,
                name: 'StatusLoc',
                editable: false,
                width: '125px',
            },
            {
                key: false,
                editable: false,
                name: 'UpdateLocation',
                width: '65px',
            },
        ],
        loadonce: true,
        responsive: true,
        gridview: true,
        autoencode: false,
        shrinkToFit: true,
        autowidth: false,
        pager: '#LocationPager',
        rowNum: 10,
        rowList: [10, 20, 30, 40],
        height: 'auto',
        viewrecords: true,
        altRows: true,
        loadtext: 'Loading Data please wait ...',
        emptyrecords: 'No records to display',
        multiselect: false,
        rownumbers: false,
        ajaxRowOptions: { async: true },
        loadComplete: function () {
            $(this).jqGrid('resizeGrid');
        },

        gridComplete: function () {
            var selectedRowIds = LocationGrid.jqGrid('getGridParam', 'data');
            for (selectedRowIndex = 0; selectedRowIndex < selectedRowIds.length; selectedRowIndex++) {
                var temp_var = selectedRowIds[selectedRowIndex]['_id_'];
                var idlocation = selectedRowIds[selectedRowIndex]['IDLocation'];
                var idlocationDis = selectedRowIds[selectedRowIndex]['IDLocationDis'];
                var locationstatus = selectedRowIds[selectedRowIndex]['Status'];

                if (locationstatus.toUpperCase() == "ACTIVE") {
                    selectedRowIds[selectedRowIndex]['StatusLoc'] = "<span class='badge bg-success bg-gradient'>ACTIVE</span>";
                    //UserDetailsGrid.jqGrid('setRowData', temp_var, selectedRowIds[selectedRowIndex]);
                }
                else if (locationstatus.toUpperCase() == "DEACTIVE") {
                    selectedRowIds[selectedRowIndex]['StatusLoc'] = "<span class='badge bg-secondary bg-gradient'>DEACTIVE</span>";
                    //UserDetailsGrid.jqGrid('setRowData', temp_var, selectedRowIds[selectedRowIndex]);
                }

                selectedRowIds[selectedRowIndex]['view'] = "<button style='border:none; background:transparent;cursor:auto'>" + idlocationDis + "</button > "
                selectedRowIds[selectedRowIndex]['UpdateLocation'] = "<button class='fw-bold GetLocData' style='border:none; background:transparent;color:purple;' data-rowid='" + idlocation + "'><i class='fa-solid fa-eye'></i></button>"; //

                LocationGrid.jqGrid('setRowData', temp_var, selectedRowIds[selectedRowIndex]);

            }
        }
    });

    $(document).on('change', '#LocStatus', function () {
        var idRecords = $('#LocationID').val();
        if ($('#LocStatus').is(":checked")) {
            ChangeStatusActiveDeactive("ACTIVE", idRecords);
        }
        else {
            ChangeStatusActiveDeactive("DEACTIVE", idRecords);
        }
    });

    $("#SaveLocation").click(function () {
        $("#loading").show();
        var Region = $('#RegionLoc').val().toUpperCase();
        var Country = $('#CountryLoc').val().toUpperCase();
        var Location = $('#LocationLoc').val().toUpperCase();
        if (Region == '' || Country == '' || Location == '') {
            $('#warningToastMessage').text('Please Fill Mandatory Fields.');
            $('#warningToast').toast("show");
            $("#loading").hide();
        }
        else {
            $.ajax({
                type: "POST",
                url: 'SaveLocationNew',
                data: {
                    Region,
                    Country,
                    Location
                },
                dataType: "json",
                success: function (result) {
                    if (result.success) {
                        reload('LocationGrid');
                        $("#CreateLocation").modal("hide");
                        $("#loading").hide();
                        $('#successtoastmessage').text('Location Created successfully');
                        $('#successtoast').toast("show");

                    }
                    else {
                        if (result.duplicate == true) {
                            $('#warningToastMessage').text('Dupliatation of record is not allowed.');
                            $('#warningToast').toast("show");
                            $("#loading").hide();
                        }
                        else {
                            $('#warningToastMessage').text('No search parameter selected.');
                            $('#warningToast').toast("show");
                            $("#loading").hide();
                        }

                    }

                }

            });
        }
    })

    $("#UpdateLocationNEW").click(function () {
        $("#loading").show();
        var IDLocation = $('#LocationID').val();
        var Region = $('#RegionLoc').val();
        var Country = $('#CountryLoc').val();
        var Location = $('#LocationLoc').val();
        if (Region == "" || Country == "" || Location == "") {
            $('#warningToastMessage').text('Please Fill Mandatory Fields.');
            $('#warningToast').toast("show");
            $("#loading").hide();
        }
        else {
            $.ajax({
                type: "POST",
                url: 'SaveLocationNew',
                data: {
                    IDLocation,
                    Region,
                    Country,
                    Location
                },
                dataType: "json",
                success: function (result) {
                    if (result.success) {
                        reload('LocationGrid');
                        $('#CreateLocation').modal("hide");
                        $("#loading").hide();
                        $('#successToastMessage').text('Location Updated successfully');
                        $('#successToast').toast("show");
                        //DestroyRenderLocationDropdowns()
                    }
                    else {
                        if (result.duplicate == true) {
                            $('#warningToastMessage').text('Dupliatation of record is not allowed.');
                            $('#warningToast').toast("show");
                            $("#loading").hide();
                        }
                        else {
                            $('#warningToastMessage').text('No search parameter selected.');
                            $('#warningToast').toast("show");
                            $("#loading").hide();
                        }
                        
                    }
                }
            });
        }
    })

    $('#ExportExcelLocation').click(function () {
        var Region = $("#RegionLocation").val();
        var Country = $("#CountryLocation").val();
        var Location = $("#LocLocation").val();
        //var url = "ExportLocationData";
        var url = '../Home/ExportLocationData?Region=' + Region + '&&Country=' + Country + '&&Location=' + Location;
        window.open(url);
    });

    $("#SearchLocation").click(function () {
        $("#loading").show();
        var Region = $('#RegionLocation').val();
        var Country = $('#CountryLocation').val();
        var Location = $('#LocLocation').val();
        if (Region != "" || Country != "" || Location != "") {
            $.ajax({
                type: "POST",
                url: 'SearchButtonLocation',
                data: {
                    Region,
                    Country,
                    Location
                },
                dataType: "json",
                success: function (result) {
                    if (result.success) {
                        reload('LocationGrid');
                        $("#loading").hide();
                        $('.message1').text('Search successfully');
                        $('#NewToast').toast("show");
                    }

                }
            });
        }
        else {
            $('#warningToastMessage').text('No search parameter selected.');
            $('#warningToast').toast("show");
            $("#loading").hide();
        }
    })

    $("#ResetLocation").click(function () {
        $('#loading').show();
        $('#RegionLocation').selectpicker('val', '');
        $('#CountryLocation').selectpicker('val', '');
        $('#LocLocation').selectpicker('val', '');
        $.ajax({
            type: "POST",
            url: 'ResetButtonLocation',
            dataType: "json",
            success: function (result) {
                reload('LocationGrid');
                $('#loading').hide();
                $('#successToastMessage').text('Reset successfully');
                $('#successToast').toast("show");
            }
        });
    });

    $('#CreateButtonLocation').click(function () {
        $('#UpdateLocationNEW').hide();
        $('#statusShow1').hide();
        $('#SaveLocation').show();
        $('#RegionLoc').selectpicker('val', '');
        $('#CountryLoc').selectpicker('val', '');
        $('#LocationLoc').val('');
        $("#IDLocationDis").html("New Location");
        $('#CreationLOC').html("");
        $("#CreateLocation").find('.dropdown-menu').each(function (index) {
            $(this).css('display', '');
        });

    });

    $("#RegionLocation").change(function () {
        GetDataCountryLocation();
    });

    $("#CountryLocation").change(function () {
        getLocationDropdown();
    });

    $("#SaveLocation").click(function () {
        modelOpen = 1;
        checkValidationLOC("SAVE");
    });

    $(".GetLocData").click(function () {

    });

    $("#UpdateLocation").click(function () {
        modelOpen = 1;
        checkValidationLOC("SAVE");
    });



    $(document).on('click', '.GetLocData', function () {

        if (RoleUser == 'ADMIN') {

            // LocationDetails
            $("#UpdateLocationNEW").show();
            $("#statusShow1").show();
            $("#EditfileuploadGrid").show();
            $("#SavefileuploadGrid").show();
            $("#CancelfileuploadGrid").show();
            $("#SaveFile").show();
            $("#DeleteFile").show();
        }
        else if (RoleUser == 'HR') {
            $("#UpdateLocationNEW").hide();
            $("#statusShow1").hide();
            $("#EditfileuploadGrid").hide();
            $("#SavefileuploadGrid").hide();
            $("#CancelfileuploadGrid").hide();
            $("#SaveFile").hide();
            $("#DeleteFile").hide();
        }
        else if (RoleUser == "SUPERUSER") {

            // LocationDetails
            $("#UpdateLocationNEW").show();
            $("#statusShow1").show();
            $("#EditfileuploadGrid").show();
            $("#SavefileuploadGrid").show();
            $("#CancelfileuploadGrid").show();
            $("#SaveFile").show();
            $("#DeleteFile").show();
        }

        var rowId = $(this).data('rowid');
        var data = LocationGrid.jqGrid('getRowData', rowId);
        //$('#statusShow1').show();
        $('#CreateLocation').modal("show");
        $('#SaveLocation').hide();
        $('#CreateTextLoc').hide();
        //$('#UpdateLocation').show();
        $('#UpdateTextLoc').show();
        $('#RegionLoc').selectpicker('val', data.Region);
        $('#CountryLoc').selectpicker('val', data.Country);
        $('#LocationID').val(data.IDLocation);
        $('#LocationLoc').val(data.Location);
        $('#IDLocationDis').html(data.IDLocationDis);
        $('#LocationID').val(data.IDLocation);
        var CreatedBy = data.CreatedBy;
        var CreatedOn = data.CreatedOn;

        var creationdet = "Created by " + CreatedBy + " on " + CreatedOn;
        $('#CreationLOC').html(creationdet);

        if (data.Status == "ACTIVE") {
            document.getElementById('LocStatus').checked = true;
        }
        else {
            document.getElementById('LocStatus').checked = false;
        }
        $("#CreateLocation").find('.dropdown-menu').each(function (index) {
            $(this).css('display', 'none');
        });

    });

    $(".checkValidLOC").change(function () {
        if (modelOpen == 1) {
            var div = $(this);
            var select = $(div).closest(".dropdown");
            var dropdown = $(div).closest("select");
            var value = $(dropdown).val();
            var classes = $(div).attr("class");
            if (value == "" || value == null || value == 0) {
                if (classes.includes('is-valid') == true) {
                    $(select).removeClass(" is-valid");
                    $(select).addClass(" is-invalid");
                    $(dropdown).removeClass(" is-valid");
                    $(dropdown).addClass(" is-invalid");
                    $(div).closest("col").find(".invalid-feedback").show();
                }
                if (classes.includes('is-invalid') == false && classes.includes('is-valid') == false) {
                    $(select).addClass(" is-invalid");
                    $(dropdown).addClass(" is-invalid");
                    $(div).closest("col").find(".invalid-feedback").show();
                }
            }
            else {
                if (classes.includes("is-invalid") == true) {
                    $(select).removeClass(" is-invalid");
                    $(dropdown).removeClass(" is-invalid");
                    $(select).addClass(" is-valid");
                    $(dropdown).addClass(" is-valid");
                    $(div).closest("col").find(".invalid-feedback").show();
                }
                if (classes.includes('is-valid') == false && classes.includes("is-invalid") == false) {
                    $(select).addClass(" is-valid");
                    $(dropdown).addClass(" is-valid");
                    $(div).closest("col").find(".invalid-feedback").show();
                }
            }
        }
    });

    $(".checkValidloc").focus(function () {
        if (modelOpen == 1) {
            var value = $(this).val();
            if (value == "" || value == null || value == 0) {
                $(this).addClass(" is-invalid");
                $(this).removeClass(" is-valid");
                $(this).closest(".invalid-feedback").show();
            }
            else {
                $(this).addClass(" is-valid");
                $(this).removeClass(" is-invalid");
                $(this).closest(".invalid-feedback").hide();
            }
        }
    });

    $(".checkValidloc").blur(function () {
        if (modelOpen == 1) {
            var value = $(this).val();
            if (value == "" || value == null || value == 0) {
                $(this).addClass(" is-invalid");
                $(this).removeClass(" is-valid");
                $(this).closest(".invalid-feedback").show();
            }
            else {
                $(this).addClass(" is-valid");
                $(this).removeClass(" is-invalid");
                $(this).closest(".invalid-feedback").hide();
            }
        }
    });

    $('#CloseLocation').click(function () {
        modelOpen = 0;

        var mydivs = $(".checkValidloc");
        for (var i = 0; i < mydivs.length; i++) {
            if ($(mydivs[i]).hasClass('is-valid') == true) {
                $(mydivs[i]).removeClass('is-valid');
            }
            else if ($(mydivs[i]).hasClass('is-invalid') == true) {
                $(mydivs[i]).removeClass('is-invalid');
            }
        }
        var mydivs1 = $(".checkValidLOC").closest('select');
        for (var i = 0; i < mydivs1.length; i++) {
            var select = $(mydivs1[i]).closest(".dropdown");
            var dropdown = $(mydivs1[i]).closest("select");

            if ($(select).hasClass('is-valid') == true) {
                $(select).removeClass('is-valid');
                $(dropdown).removeClass('is-valid');
            }
            else if ($(select).hasClass('is-invalid') == true) {
                $(select).removeClass('is-invalid');
                $(dropdown).removeClass('is-invalid');
            }
        }
    });
})

function GetDataCountryLocation() {
    var regionvalue = $("#RegionLocation").val();
    var countryvalue = '';
    $.ajax({
        type: "GET",
        url: 'GetCountryLocation',
        contentType: "application/json; charset=utf-8",
        data: { regionvalue, countryvalue },
        dataType: "json",
        success: function (data) {
            if (data.success) {

                var CountryDropList = $("#CountryLocation");
                CountryDropList.find('option').remove();
                CountryDropList.selectpicker('destroy');
                if (data.countryDrop.length > 0) {
                    CountryDropList.append('<option value>Select Country</option>');
                    for (var i = 0; i < data.countryDrop.length; i++) {
                        CountryDropList.append("<option value='" + data.countryDrop[i].text + "'>" + data.countryDrop[i].text + "</option>");
                    }
                }
                renderDropdown(CountryDropList);
            }
        }
    });
}
function getLocationDropdown() {
    var countryvalue = $("#CountryLocation").val();
    var regionvalue = '';
    $.ajax({
        type: "GET",
        url: 'GetCountryLocation',
        contentType: "application/json; charset=utf-8",
        data: { regionvalue, countryvalue },
        dataType: "json",
        success: function (data) {
            if (data.success) {


                var LocationDropList = $("#LocLocation");
                LocationDropList.find('option').remove();
                LocationDropList.selectpicker('destroy');
                if (data.locationDrop.length > 0) {
                    LocationDropList.append('<option value>Select Location</option>');
                    for (var i = 0; i < data.locationDrop.length; i++) {
                        LocationDropList.append("<option value='" + data.locationDrop[i].location + "'>" + data.locationDrop[i].location + "</option>");
                    }
                }
                renderDropdown(LocationDropList);

            }
        }
    });
}
function reload(tableName) {
    currentPage = $('#' + tableName).getGridParam('page');
    $('#' + tableName).setGridParam({ datatype: "json" }).trigger('reloadGrid');
}
function checkValidationLOC(type) {
    var mydivs = $(".checkValidloc")
    for (var i = 0; i < mydivs.length; i++) {
        var value = $(mydivs[i]).val();
        if (value == "" || value == null || value == 0) {
            $(mydivs[i]).addClass(" is-invalid");
            $(mydivs[i]).closest(".invalid-feedback").show();
        }
        else {
            $(mydivs[i]).addClass(" is-valid");
            $(mydivs[i]).closest(".invalid-feedback").hide();
        }
    }
    var mydivs1 = $(".checkValidLOC").closest('select')
    for (var i = 0; i < mydivs1.length; i++) {

        var div = $(mydivs1[i]);
        var select = $(div).closest(".dropdown");
        var dropdown = $(div).closest("select");
        var value = $(dropdown).val();
        var classes = $(div).attr("class");
        if (value == "" || value == null || value == 0) {
            if (classes.includes('is-valid') == true) {
                $(select).removeClass(" is-valid");
                $(select).addClass(" is-invalid");
                $(dropdown).removeClass(" is-valid");
                $(dropdown).addClass(" is-invalid");
                $(div).closest(".invalid-feedback").show();
            }
            if (classes.includes('is-invalid') == false && classes.includes('is-valid') == false) {
                $(select).addClass(" is-invalid");
                $(dropdown).addClass(" is-invalid");
                $(div).closest(".invalid-feedback").show();
            }
        }
        else {
            if (classes.includes("is-invalid") == true) {
                $(select).removeClass(" is-invalid");
                $(dropdown).removeClass(" is-invalid");
                $(select).addClass(" is-valid");
                $(dropdown).addClass(" is-valid");
                $(div).closest(".invalid-feedback").hide();
            }
            if (classes.includes('is-valid') == false && classes.includes("is-invalid") == false) {
                $(select).addClass(" is-valid");
                $(dropdown).addClass(" is-valid");
                $(div).closest(".invalid-feedback").hide();
            }
        }
    }
    //if (type == "SAVE") {
    //    $('#SaveLocation').trigger('click');
    //}
}

//function DestroyRenderLocationDropdowns() {

//    var EXRegion = $("#RegionLocation");
//    var EXCountry = $("#CountryLocation");
//    var EXLocation = $("#LocLocation");

//    $.ajax({
//        type: "GET",
//        url: 'DestroyRenderLocationDropdowns',
//        data: {
//            //EXHostName,
//            //EXAseetType,
//            //EXBrand,
//            //EXModel,
//            //EXSerialnumber
//        },
//        contentType: "application/json; charset=utf-8",
//        dataType: "json",
//        success: function (data) {


//            if (data.regionList.length > 0) {
//                EXRegion.find('option').remove();
//                EXRegion.selectpicker('destroy');

//                EXRegion.append('<option value>Select HostName</option>');
//                for (var i = 0; i < data.regionList.length; i++) {
//                    EXRegion.append("<option value='" + data.regionList[i].text + "'>" + data.regionList[i].text + "</option>");
//                }
//                renderDropdown(EXRegion);
//                //EXChargePartyCompany.selectpicker('val', EXChargePartyCompany);
//            }
//            if (data.countryList.length > 0) {
//                EXCountry.find('option').remove();
//                EXCountry.selectpicker('destroy');

//                EXDepartment.append('<option value>Select AssetType</option>');
//                for (var i = 0; i < data.countryList.length; i++) {
//                    EXCountry.append("<option value='" + data.countryList[i].text + "'>" + data.countryList[i].text + "</option>");
//                }
//                renderDropdown(EXCountry);
//                //EXChargePartyCompany.selectpicker('val', EXChargePartyCompany);
//            }
//            if (data.locationList.length > 0) {
//                EXLocation.find('option').remove();
//                EXLocation.selectpicker('destroy');

//                EXLocation.append('<option value>Select Brand</option>');
//                for (var i = 0; i < data.locationList.length; i++) {
//                    EXLocation.append("<option value='" + data.locationList[i].text + "'>" + data.locationList[i].text + "</option>");
//                }
//                renderDropdown(EXLocation);
//                //EXChargePartyCompany.selectpicker('val', EXChargePartyCompany);
//            }
//        },
//        error: function (xhr, ajaxOptions, thrownError) {
//            $("#errorToastMessage").text('Failed to retrieve data');
//            $("#errorToast").toast("show");
//        }
//    });
//}

function ChangeStatusActiveDeactive(status, idlocation) {
    $.ajax({
        type: "POST",
        url: 'GetStatusLoc',
        data: {
            status,
            idlocation
        },
        dataType: 'json',
        success: function (result) {
            window.location.reload();
            reload('LocationGrid');
            $('#successToastMessage').text('Status Updated successfully');
            $('#successToast').toast("show");
        }
    });
}