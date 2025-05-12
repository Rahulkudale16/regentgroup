var modelOpen = 0;
$(document).ready(function () {

    if (RoleUser == 'ADMIN') {

        $("#CreateBtnInfra").show();
    }
    else if (RoleUser == 'HR') {

        $("#CreateBtnInfra").hide();
    }
    else if (RoleUser == "SUPERUSER") {

        $("#CreateBtnInfra").show();
    }

    var currentPage;
    InfrastructureGrid = $('#InfrastructureGrid').jqGrid({
        mtype: 'Get',
        url: 'GetInfrastructuredata',
        datatype: 'json',
        colNames: ['IDInfra', 'IDInfra', 'ID', 'IDLocation', 'AssetType', 'Brand', 'Model', 'SerialNumber', 'PurchaseYear', 'Remark', 'Unit', 'Location', 'Status', 'CreatedBy', 'CreatedOn', 'ModifiedBy', 'ModifiedOn', 'Status', 'View'],
        colModel: [
            {
                key: true,
                hidden: true,
                name: 'IDInfra',
                width: '90px',
            },
            {
                key: false,
                name: 'view',
                width: '100px',
            },
            {
                key: false,
                hidden: true,
                name: 'IDInfraDis',
                editable: false,
                width: '120px',
            },
            {
                key: false,
                hidden: true,
                name: 'IDLocation',
                width: '420px',
            },
            {
                key: false,
                name: 'AssetType',
                editable: false,
                width: '125px',
            },
            {
                key: false,
                name: 'Brand',
                editable: false,
                width: '200px',
            },
            {
                key: false,
                name: 'Model',
                editable: false,
                width: '200px',
            },
            {
                key: false,
                name: 'SerialNumber',
                editable: false,
                width: '200px',
            },
            {
                key: false,
                name: 'PurchaseYear',
                editable: false,
                width: '125px',
            },
            {
                key: false,
                hidden: true,
                name: 'Remark',
                editable: false,
                width: '125px',
            },
            {
                key: false,
                hidden: true,
                name: 'Unit',
                editable: false,
                width: '125px',
            },
            {
                key: false,
                //hidden: true,
                name: 'Location',
                editable: false,
                width: '150px',
            },
            {
                key: false,
                hidden: true,
                name: 'Status',
                editable: false,
                width: '100px',
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
                hidden: false,
                name: 'viewStatus',
                editable: false,
                width: '125px',
            },
            {
                key: false,
                editable: false,
                name: 'UpdateInfra',
                width: '65px',
            },
        ],
        loadonce: true,
        responsive: true,
        gridview: true,
        autoencode: false,
        shrinkToFit: true,
        autowidth: false,
        pager: '#InfrastructurePager',
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

        gridComplete: function () {  //Active-Deactive Toggle in Table grid
            var selectedRowIds = InfrastructureGrid.jqGrid('getGridParam', 'data');
            for (selectedRowIndex = 0; selectedRowIndex < selectedRowIds.length; selectedRowIndex++) {
                var temp_var = selectedRowIds[selectedRowIndex]['_id_'];
                var idinfra = selectedRowIds[selectedRowIndex]['IDInfra'];
                var idinfraDis = selectedRowIds[selectedRowIndex]['IDInfraDis'];
                var Infrastatus = selectedRowIds[selectedRowIndex]['Status'];
                var updateInfra = selectedRowIds[selectedRowIndex]['UpdateInfra'];

                if (Infrastatus.toUpperCase() == "AVAILABLE") {
                    selectedRowIds[selectedRowIndex]['viewStatus'] = "<span class='badge bg-success bg-gradient'>AVAILABLE</span>";
                }
                else if (Infrastatus.toUpperCase() == "UNAVAILABLE") {
                    selectedRowIds[selectedRowIndex]['viewStatus'] = "<span class='badge bg-secondary bg-gradient'>UNAVAILABLE</span>";
                }
                selectedRowIds[selectedRowIndex]['view'] = "<button style='border:none; background:transparent;cursor:auto'>" + idinfraDis + "</button>"
                selectedRowIds[selectedRowIndex]['UpdateInfra'] = "<button class='text-danger fw-bold getUpdateInfra' style='border:none; background:transparent;color:purple!important;' data-rowid='" + idinfra + "'><i class='fa-solid fa-eye'></i></button>"; //
                InfrastructureGrid.jqGrid('setRowData', temp_var, selectedRowIds[selectedRowIndex]);
            }
        }

    });

    $(document).on('click', '.getUpdateInfra', function () {

        
        if (RoleUser == 'ADMIN') {
            
            $("#UpdateInfra").show();
            $("#TransferInfra").show();
            $("#DeleteInfra").show();
            $("#InfraStatus").show();
            $("#statusInfra").show();
        }
        else if (RoleUser == 'HR') {
  
            $("#UpdateInfra").hide();
            $("#TransferInfra").hide();
            $("#DeleteInfra").hide();
            $("#InfraStatus").hide();
            $("#statusInfra").hide();
        }
        else if (RoleUser == "SUPERUSER") {
            
            $("#UpdateInfra").show();
            $("#TransferInfra").show();
            $("#DeleteInfra").show();
            $("#InfraStatus").show();
            $("#statusInfra").show();
        }
        
        var rowId = $(this).data('rowid');
        var data = InfrastructureGrid.jqGrid('getRowData', rowId);
        var purchaseYear = moment(data.PurchaseYear, 'DD-MM-YYYY').format('yyyy-MM-DD');
        $('#CreateInfra').modal("show");
        $('#SaveInfra').hide();
        //$('#UpdateInfra').show();
        //$('#TransferInfra').show();

        $('#InfraID').val(data.IDInfra);
        $('#AssetTypeInfra1').val(data.AssetType);
        $('#BrandInfra1').val(data.Brand);
        $('#ModelInfra1').val(data.Model);
        $('#SerialNumberInfra').val(data.SerialNumber);


        $('#PurchaseYearInfra').val(purchaseYear);
        $('#LocationInfra').selectpicker('val', data.IDLocation);
        $('#RemarkInfra').val(data.Remark);
        $('#UnitInfra').val(data.Unit);
        $('#StatusInfra').val(data.Status);
        $('#IDInfraDis').html(data.IDInfraDis);
        var CreatedBy = data.CreatedBy;
        var CreatedOn = data.CreatedOn;
        var creationdet = "Created by " + CreatedBy + " " + "on" + " " + CreatedOn;
        if (data.Status == "AVAILABLE") {
            document.getElementById('InfraStatus').checked = true;
        }
        else {
            document.getElementById('InfraStatus').checked = false;
        }
        //$("#Infrastatus").show();
        //$("#statusInfra").show();
        $("#CreationInfraData").html(creationdet);

    });

    $('#ExportExcelInfra').click(function () {

        var SerialNo = $("#SerialNoInfra").val();
        var Model = $("#ModelInfra").val();
        var Brand = $("#BrandInfra").val();
        var AssetType = $("#AssetTypeInfra").val();
        var Location = $("#LocationInfraDetails").val();
        var url = '../Home/ExportInfraData?SerialNo=' + SerialNo + '&&Model=' + Model + '&&Brand=' + Brand + '&&AssetType=' + AssetType + '&&Location=' + Location;
        //var url = "ExportInfraData";
        window.open(url);
    });

    $('#CreateBtnInfra').click(function () {
        $("#SaveInfra").show();
        $("#UpdateInfra").hide();
        $("#TransferInfra").hide();
        $("#DeleteInfra").hide();
        $('#AssetTypeInfra1').val('');
        $('#BrandInfra1').val('');
        $('#ModelInfra1').val('');
        $('#SerialNumberInfra').val('');
        $('#UnitInfra').val('');

        $('#PurchaseYearInfra').val('');
        $('#LocationInfra').selectpicker('val', '');
        $('#RemarkInfra').val('');
        $('#StatusInfra').val('');
        $("#IDInfraDis").html("New Infrastructure");
        $("#statusInfra").hide();
        $("#CreationInfraData").html("");
    });

    $("#SearchInfra").click(function () {
        $('#loading').show();
        var SerialNumber = $('#SerialNoInfra').val();
        var Model = $('#ModelInfra').val();
        var Brand = $('#BrandInfra').val();
        var AssetType = $('#AssetTypeInfra').val();
        var Location = $('#LocationInfraDetails').val();
        if (SerialNumber != "" || Model != "" || Brand != "" || AssetType != "" || Location != "") {
            $.ajax({
                type: "POST",
                url: 'SearchButtonInfrastructure',
                data: {
                    SerialNumber,
                    Model,
                    Brand,
                    AssetType,
                    Location
                },
                dataType: "json",
                success: function (result) {
                    if (result.success) {
                        reload('InfrastructureGrid');
                        $('#loading').hide();
                        $('#successToastMessage').text('Search successfully');
                        $('#successToast').toast("show");
                    }

                }
            });
        }
        else {
            $('#warningToastMessage').text('No search parameter selected.');
            $('#warningToast').toast("show");
            $('#loading').hide();
        }
    })

    $(document).on('change', '#InfraStatus', function () {
        var idRecords = $('#InfraID').val();
        if ($('#InfraStatus').is(":checked")) {
            ChangeStatusActiveDeactiveInfra("AVAILABLE", idRecords);
        }
        else {
            ChangeStatusActiveDeactiveInfra("UNAVAILABLE", idRecords);
        }
    });

    $("#SaveInfra").click(function () {
        $('#loading').show();
        var AssetType = $('#AssetTypeInfra1').val().toUpperCase();
        var Brand = $('#BrandInfra1').val().toUpperCase();
        var Model = $('#ModelInfra1').val().toUpperCase();
        var SerialNumber = $('#SerialNumberInfra').val().toUpperCase();
        var PurchaseYear = $('#PurchaseYearInfra').val();
        var Location = $('#LocationInfra').val();
        var Remark = $('#RemarkInfra').val().toUpperCase();
        var Unit = $('#UnitInfra').val().toUpperCase();
        var Status = $('#StatusInfra').val();
        if (AssetType == "" || Brand == "" || Model == "" || SerialNumber == "" || Location == "") {
            $('#warningToastMessage').text('Please Fill Mandatory Fields.');
            $('#warningToast').toast("show");
            $('#loading').hide();
        }
        else {
            $.ajax({
                type: "POST",
                url: 'SaveInfraStructure',
                data: {
                    AssetType,
                    Brand,
                    Model,
                    SerialNumber,
                    PurchaseYear,
                    Location,
                    Remark,
                    Unit,
                    Status
                },
                dataType: "json",
                success: function (result) {
                    if (result.success) {
                        reload('InfrastructureGrid');
                        $('#successToastMessage').text('Infrastructure Created successfully');
                        $('#successToast').toast("show");
                        $('#CreateInfra').modal("hide");
                        $('#loading').hide();
                        DestroyRenderInfraDropdowns();
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
                            $('#loading').hide();
                        }
                    }
                }
            });
        }
    })

    $("#SaveInfra").click(function () {
        modelOpen = 1;
        checkValidationINF("SAVE");
    });

    $("#UpdateInfra").click(function () {
        modelOpen = 1;
        checkValidationINF("SAVE");
    });

    $("#UpdateInfra").click(function () {
        $('#loading').show();
        var IDInfra = $('#InfraID').val();
        var AssetType = $('#AssetTypeInfra1').val().toUpperCase();
        var Brand = $('#BrandInfra1').val().toUpperCase();
        var Model = $('#ModelInfra1').val().toUpperCase();
        var SerialNumber = $('#SerialNumberInfra').val().toUpperCase();
        var PurchaseYear = $('#PurchaseYearInfra').val();
        var Location = $('#LocationInfra').val();
        var Remark = $('#RemarkInfra').val().toUpperCase();
        var Unit = $('#UnitInfra').val().toUpperCase();
        var Status = $('#StatusInfra').val();
        if (AssetType == "" || Brand == "" || Model == "" || SerialNumber == "" || Location == "") {
            $('#warningToastMessage').text('Please Fill Mandatory Fields.');
            $('#warningToast').toast("show");
            $('#loading').hide();
        }
        else {
            $.ajax({
                type: "POST",
                url: 'SaveInfraStructure',
                data: {
                    IDInfra,
                    AssetType,
                    Brand,
                    Model,
                    SerialNumber,
                    PurchaseYear,
                    Location,
                    Remark,
                    Unit,
                    Status
                },
                dataType: "json",
                success: function (result) {
                    if (result.success) {
                        reload('InfrastructureGrid');
                        $('#successToastMessage').text('Infrastructure Updated successfully');
                        $('#successToast').toast("show");
                        $('#CreateInfra').modal("hide");
                        $('#loading').hide();
                        DestroyRenderInfraDropdowns();
                    }


                }
            });
        }
    })

    $("#ResetInfra").click(function () {
        $('#loading').show();
        $('#SerialNoInfra').selectpicker('val', '');
        $('#ModelInfra').selectpicker('val', '');
        $('#BrandInfra').selectpicker('val', '');
        $('#AssetTypeInfra').selectpicker('val', '');
        $('#LocationInfraDetails').selectpicker('val', '');
        $.ajax({
            type: "POST",
            url: 'ResetButtonInfrastructure',
            dataType: "json",
            success: function (result) {
                reload('InfrastructureGrid');
                $('#successToastMessage').text('Reset successfully');
                $('#successToast').toast("show");
                $('#loading').hide();
            }
        });
    });

    $(".checkValidINF").change(function () {
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

    $(".checkValidinfra").focus(function () {
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

    $(".checkValidinfra").blur(function () {
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

    $('#CloseInfra').click(function () {
        modelOpen = 0;

        var mydivs = $(".checkValidInfra");
        for (var i = 0; i < mydivs.length; i++) {
            if ($(mydivs[i]).hasClass('is-valid') == true) {
                $(mydivs[i]).removeClass('is-valid');
            }
            else if ($(mydivs[i]).hasClass('is-invalid') == true) {
                $(mydivs[i]).removeClass('is-invalid');
            }
        }
        var mydivs1 = $(".checkValidINF").closest('select');
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

    $("#TransferInfra").click(function () {
        $('#loading').show();
        var IDInfra = $('#InfraID').val();
        var AssetType = $('#AssetTypeInfra1').val();
        var Brand = $('#BrandInfra1').val().toUpperCase();
        var Model = $('#ModelInfra1').val();
        var SerialNumber = $('#SerialNumberInfra').val();
        var PurchaseYear = $('#PurchaseYearInfra').val();
        var Location = $('#LocationInfra').val().toUpperCase();
        var Remark = $('#RemarkInfra').val();
        var Unit = $('#UnitInfra').val();
        if (document.getElementById('InfraStatus').checked = true) {
            var Status = "ACTIVE"
        }
        else {
            var Status = "DEACTIVE"
        }
        $.ajax({
            type: "POST",
            url: 'TransferInfraDetails',
            data: {
                IDInfra,
                AssetType,
                Brand,
                Model,
                SerialNumber,
                PurchaseYear,
                Location,
                Remark,
                Unit,
                Status
            },
            dataType: "json",
            success: function (result) {
                if (result.success == true) {
                    reload('InfrastructureGrid');
                    $('#loading').hide();
                    $('#successToastMessage').text('Infrastructure Transfered Successfully');
                    $('#successToast').toast("show");
                    $('#CreateUserDetails').modal("hide");
                    reload('AssignGrid');
                    window.location.reload();
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
    })

    $("#DeleteInfra").click(function () {
        $('#loading').show();
        var IDInfra = $('#InfraID').val();
        {
            $.ajax({
                type: "POST",
                url: 'DeleteInfra',
                data: {
                    IDInfra
                },
                dataType: "json",
                success: function (result) {
                    if (result.response) {
                        reload('InfrastructureGrid');
                        $('#loading').hide();
                        $('#successToastMessage').text('Asset Deleted Successfully');
                        $('#successToast').toast("show");
                        $('#CreateInfra').modal("hide");
                        DestroyRenderUDDropdowns();
                    }

                }
            });
        }
    })
})

function ChangeStatusActiveDeactiveInfra(status, idinfra) {
    $.ajax({
        type: "POST",
        url: 'GetStatusInfra',
        data: {
            status,
            idinfra
        },
        dataType: 'json',
        success: function (result) {
            reload('InfrastructureGrid')
            $('#successToastMessage').text('Status Updated successfully');
            $('#successToast').toast("show");
        }
    });
}

function reload(tableName) {
    currentPage = $('#' + tableName).getGridParam('page');
    $('#' + tableName).setGridParam({ datatype: "json" }).trigger('reloadGrid');
}

function checkValidationINF(type) {
    var mydivs = $(".checkValidInfra")
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
    var mydivs1 = $(".checkValidINF").closest('select')
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
}

function DestroyRenderInfraDropdowns() {

    var EXSerialNo = $("#SerialNoInfra");
    var EXModel = $("#ModelInfra");
    var EXBrand = $("#BrandInfra");
    var EXAssetType = $("#AssetTypeInfra");


    $.ajax({
        type: "GET",
        url: 'DestroyRenderInfraDropdowns',
        data: {
            //EXHostName,
            //EXAseetType,
            //EXBrand,
            //EXModel,
            //EXSerialnumber
        },
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {


            if (data.serialNoList.length > 0) {
                EXSerialNo.find('option').remove();
                EXSerialNo.selectpicker('destroy');

                EXSerialNo.append('<option value>Select HostName</option>');
                for (var i = 0; i < data.serialNoList.length; i++) {
                    EXSerialNo.append("<option value='" + data.serialNoList[i].text + "'>" + data.serialNoList[i].text + "</option>");
                }
                renderDropdown(EXSerialNo);
                //EXChargePartyCompany.selectpicker('val', EXChargePartyCompany);
            }
            if (data.modelList.length > 0) {
                EXModel.find('option').remove();
                EXModel.selectpicker('destroy');

                EXModel.append('<option value>Select AssetType</option>');
                for (var i = 0; i < data.modelList.length; i++) {
                    EXModel.append("<option value='" + data.modelList[i].text + "'>" + data.modelList[i].text + "</option>");
                }
                renderDropdown(EXModel);
                //EXChargePartyCompany.selectpicker('val', EXChargePartyCompany);
            }
            if (data.brandList.length > 0) {
                EXBrand.find('option').remove();
                EXBrand.selectpicker('destroy');

                EXBrand.append('<option value>Select Brand</option>');
                for (var i = 0; i < data.brandList.length; i++) {
                    EXBrand.append("<option value='" + data.brandList[i].text + "'>" + data.brandList[i].text + "</option>");
                }
                renderDropdown(EXBrand);
                //EXChargePartyCompany.selectpicker('val', EXChargePartyCompany);
            }
            if (data.assetTypeList.length > 0) {
                EXAssetType.find('option').remove();
                EXAssetType.selectpicker('destroy');

                EXAssetType.append('<option value>Select Model</option>');
                for (var i = 0; i < data.assetTypeList.length; i++) {
                    EXAssetType.append("<option value='" + data.assetTypeList[i].text + "'>" + data.assetTypeList[i].text + "</option>");
                }
                renderDropdown(EXAssetType);
                //EXChargePartyCompany.selectpicker('val', EXChargePartyCompany);
            }

        },
        error: function (xhr, ajaxOptions, thrownError) {
            $("#errorToastMessage").text('Failed to retrieve data');
            $("#errorToast").toast("show");
        }
    });
}
