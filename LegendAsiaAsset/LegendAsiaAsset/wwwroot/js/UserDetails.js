var modelOpen = 0;
$(document).ready(function () {

    if (RoleUser == 'ADMIN') {

        $("#CreateButton").show();
    }
    else if (RoleUser == 'HR') {

        $("#CreateButton").hide();
    }
    else if (RoleUser == "SUPERUSER") {

        $("#CreateButton").show();
    }

    var currentPage;
    UserDetailsGrid = $('#UserDetailsGrid').jqGrid({
        mtype: 'Get',
        url: 'GetUserData',
        datatype: 'json',
        colNames: ['ID', 'ID', 'ID', 'IDLocation', 'FullName', 'Role', 'Department', 'Designation', 'UserName', 'Password', 'Location', 'Unit', 'Email', 'Domain', 'Status', 'CreatedBy', 'CreatedOn', 'ModifiedBy', 'ModifiedOn', 'Status', 'View'],
        colModel: [
            {
                key: true,
                hidden: true,
                name: 'IDUser',
                width: '100px',
            },
            {
                key: false,
                name: 'view',
                editable: false,
                width: '130px',
            },
            {
                key: false,
                hidden: true,
                name: 'IDUserDis',
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
                name: 'FullName',
                editable: false,
                width: '250px',
            },
            {
                key: false,
                hidden: true,
                name: 'Role',
                editable: false,
                width: '120px',
            },
            {
                key: false,
                name: 'Department',
                editable: false,
                width: '150px',
            },
            {
                key: false,
                name: 'Designation',
                editable: false,
                width: '250px',
            },
            {
                key: false,
                hidden: true,
                name: 'UserName',
                editable: false,
                width: '120px',
            },
            {
                key: false,
                hidden: true,
                name: 'Password',
                editable: false,
                width: '150px',
            },
            {
                key: false,
                hidden: false,
                name: 'Location',
                editable: false,
                width: '120px',
            },
            {
                key: false,
                hidden: true,
                name: 'Unit',
                editable: false,
                width: '100px',
            },
            {
                key: false,
                name: 'EmailID',
                editable: false,
                width: '200px',
            },
            {
                key: false,
                hidden: true,
                name: 'Domain',
                editable: false,
                width: '200px',
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
            }, {
                key: false,
                hidden: false,
                name: 'viewStatus',
                editable: false,
                width: '125px',
            },
            {
                key: false,
                editable: false,
                name: 'UpdateUser',
                width: '65px',
            },
        ],
        loadonce: true,
        responsive: true,
        gridview: true,
        autoencode: false,
        shrinkToFit: true,
        autowidth: false,
        pager: '#UserDetailsPager',
        rowNum: 10,
        rowList: [10, 20, 30, 40],
        height: 'auto',
        viewrecords: true,
        altRows: true,
        loadtext: 'Loading Data please wait ...',
        emptyrecords: 'No records to display',
        multiselect: false,
        rownumbers: false,
        ajaxRowOptions: { async: false },

        loadComplete: function () {
            //$('#loading').show();
            $(this).jqGrid('resizeGrid');
        },

        gridComplete: function () {  //Active-Deactive Toggle in Table grid
            var selectedRowIds = UserDetailsGrid.jqGrid('getGridParam', 'data');
            //var selectedRowData = [];
            for (selectedRowIndex = 0; selectedRowIndex < selectedRowIds.length; selectedRowIndex++) {
                var temp_var = selectedRowIds[selectedRowIndex]['_id_'];
                var iduser = selectedRowIds[selectedRowIndex]['IDUser'];
                var iduserDis = selectedRowIds[selectedRowIndex]['IDUserDis'];
                var userstatus = selectedRowIds[selectedRowIndex]['Status'];
                var updateuser = selectedRowIds[selectedRowIndex]['UpdateUser'];

                if (userstatus.toUpperCase() == "ACTIVE") {
                    selectedRowIds[selectedRowIndex]['viewStatus'] = "<span class='badge bg-success bg-gradient'>ACTIVE</span>";
                    //UserDetailsGrid.jqGrid('setRowData', temp_var, selectedRowIds[selectedRowIndex]);
                }
                else if (userstatus.toUpperCase() == "DEACTIVE") {
                    selectedRowIds[selectedRowIndex]['viewStatus'] = "<span class='badge bg-secondary bg-gradient'>DEACTIVE</span>";
                    //UserDetailsGrid.jqGrid('setRowData', temp_var, selectedRowIds[selectedRowIndex]);
                }
                selectedRowIds[selectedRowIndex]['view'] = "<button style='border:none; background:transparent;cursor:auto'>" + iduserDis + "</button>"
                selectedRowIds[selectedRowIndex]['UpdateUser'] = "<button class='fw-bold GetDataUser' style='border:none; background:transparent;color:purple;' data-rowid='" + iduser + "'><i class='fa-solid fa-eye'></i></button>"; //
                UserDetailsGrid.jqGrid('setRowData', temp_var, selectedRowIds[selectedRowIndex]);

            }
        }
    });

    AssignGrid = $('#AssignGrid').jqGrid({
        mtype: 'Get',
        url: 'GetAssigndata',
        datatype: 'json',
        colNames: ['ID', 'ID', 'ID', 'HostName', 'AssetType', 'Brand', 'Model', 'SerialNumber', 'CreatedBy', 'CreatedOn', 'ModifiedBy', 'ModifiedOn'],
        colModel: [
            {
                key: false,
                hidden: true,
                name: 'IDAssign',
                width: '100px',
            },
            {
                key: false,
                hidden: true,
                name: 'UserID',
                editable: false,
                width: '130px',

            },
            {
                key: false,
                hidden: true,
                name: 'LocationID',
                editable: false,
                width: '120px',
            },
            {
                key: false,
                hidden: true,
                editable: 'true',
                name: 'HostName',
                width: '250px',
            },
            {
                key: false,
                hidden: true,
                name: 'AssetType',
                editable: false,
                width: '200px',
            },
            {
                key: false,
                hidden: true,
                name: 'Brand',
                editable: false,
                width: '120px',
            },
            {
                key: false,
                hidden: true,
                name: 'Model',
                editable: false,
                width: '200px',
            },
            {
                key: true,
                name: 'SerialNumber',
                editable: false,
                width: '200px',
            },
            {
                key: false,
                hidden: false,
                name: 'CreatedBy',
                editable: false,
                width: '125px',
            },
            {
                key: false,
                hidden: false,
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
        ],
        loadonce: true,
        responsive: true,
        gridview: true,
        autoencode: false,
        shrinkToFit: true,
        autowidth: false,
        pager: '#AssignPager',
        rowNum: 2,
        rowList: [10, 20, 30, 40],
        height: 'auto',
        viewrecords: true,
        altRows: true,
        loadtext: 'Loading Data please wait ...',
        emptyrecords: 'No records to display',
        multiselect: true,
        rownumbers: true,
        ajaxRowOptions: { async: false },

        loadComplete: function () {
            $(this).jqGrid('resizeGrid');
        },

        gridComplete: function () {  //Active-Deactive Toggle in Table grid
            var selectedRowIds = AssignGrid.jqGrid('getGridParam', 'data');
            for (selectedRowIndex = 0; selectedRowIndex < selectedRowIds.length; selectedRowIndex++) {
                var temp_var = selectedRowIds[selectedRowIndex]['_id_'];
                var iduser = selectedRowIds[selectedRowIndex]['IDUser'];
                var iduserDis = selectedRowIds[selectedRowIndex]['IDUserDis'];
                var userstatus = selectedRowIds[selectedRowIndex]['Status'];

                //if (userstatus.toUpperCase() == "ACTIVE") {
                //    selectedRowIds[selectedRowIndex]['viewStatus'] = "<span class='badge bg-success bg-gradient'>ACTIVE</span>";
                //    //UserDetailsGrid.jqGrid('setRowData', temp_var, selectedRowIds[selectedRowIndex]);
                //}
                //else if (userstatus.toUpperCase() == "DEACTIVE") {
                //    selectedRowIds[selectedRowIndex]['viewStatus'] = "<span class='badge bg-secondary bg-gradient'>DEACTIVE</span>";
                //    //UserDetailsGrid.jqGrid('setRowData', temp_var, selectedRowIds[selectedRowIndex]);
                //}
                selectedRowIds[selectedRowIndex]['view'] = "<button style='border:none; background:transparent;text-decoration: underline;color:blue;' onclick = 'GetDataUser(\"" + iduser + "\")'>" + iduserDis + "</button>"

                AssignGrid.jqGrid('setRowData', temp_var, selectedRowIds[selectedRowIndex]);

            }
        }
    });

    fileuploadGrid = $('#fileuploadGrid').jqGrid({
        mtype: 'Get',
        url: 'GetFileData',
        editurl: 'SaveDocType',
        datatype: 'json',
        colNames: ['IDDoc', 'IDUser', 'DocType', 'DocName', 'DocSize', 'ContentType', 'Uploaded By', 'Uploaded On', 'Modified By', 'Modified On', 'View'],
        colModel: [
            {
                key: true,
                editable: false,
                hidden: true,
                name: 'IDDoc',
                width: '100px',
            },
            {
                key: false,
                editable: false,
                hidden: true,
                name: 'IDUser',
                width: '100px',
            },
            {
                key: false,
                editable: true,
                name: 'DocType',
                width: '100px',
            },
            {
                key: false,
                editable: false,
                name: 'DocName',
                width: '100px',
            },
            {
                key: false,
                editable: false,
                name: 'DocSize',
                width: '100px',
            },
            {
                key: false,
                hidden: true,
                editable: false,
                name: 'ContentType',
                width: '100px',
            },
            {
                key: false,
                name: 'Uploaded By',
                editable: false,
                width: '100px',
            },
            {
                key: false,
                name: 'Uploaded On',
                editable: false,
                width: '100px',
            },
            {
                key: false,
                editable: false,
                hidden: true,
                name: 'Modified By',
                width: '100px',
            },
            {
                key: false,
                hidden: true,
                name: 'Modified On',
                editable: false,
                width: '100px',
            },
            {
                key: false,
                editable: false,
                name: 'View',
                //width: '80px',
                width: '100px',
            },
        ],
        loadonce: true,
        responsive: true,
        gridview: true,
        autoencode: false,
        shrinkToFit: true,
        autowidth: false,
        pager: '#fileuploadPager',
        rowNum: 2,
        rowList: [10, 20, 30, 40],
        height: 'auto',
        viewrecords: true,
        altRows: true,
        loadtext: 'Loading Data please wait ...',
        emptyrecords: 'No records to display',
        multiselect: true,
        rownumbers: true,
        ajaxRowOptions: { async: false },
        loadComplete: function () {
            if (this.p.datatype === 'json') {
                setTimeout(function () {
                    fileuploadGrid.trigger("reloadGrid", [{ page: 1 }]);
                }, 50);
            }
            $('#loading').hide();
        },
        ondblClickRow: function (rowid) {
            data = $(this).jqGrid("getLocalRow", rowid);
        },
        errorTextFormat: function (data) {
            $("#errorToastMessage").text('Error occurred');
            $('#errorToast').toast("show");
            if (data.status == 500)
                return data.responseText;
        },
        gridComplete: function () {
            var selectedRowIds = fileuploadGrid.jqGrid('getGridParam', 'data');
            documentValue = ' ';
            for (selectedRowIndex = 0; selectedRowIndex < selectedRowIds.length; selectedRowIndex++) {
                var IDDoc = selectedRowIds[selectedRowIndex]['IDDoc'];
                var DocName = selectedRowIds[selectedRowIndex]['DocName'];
                var ContentType = selectedRowIds[selectedRowIndex]['ContentType'];
                var DocType = selectedRowIds[selectedRowIndex]['DocType'];
                var temp_var = selectedRowIds[selectedRowIndex]['_id_'];
                var IDUser = selectedRowIds[selectedRowIndex]['IDUser'];
                if (ContentType == "application/pdf") {
                    selectedRowIds[selectedRowIndex]['View'] = "<button type='button' class='btn btn-outline-primary' name='view' data-iduser='" + IDUser + "' value='" + DocName + "' id='viewDocFile'><i class='fa-solid fa-eye'></i></button>";
                }
                else {
                    selectedRowIds[selectedRowIndex]['View'] = "<button type='button' class='btn btn-outline-primary' name='view' data-iduser='" + IDUser + "' value='" + DocName + "' id='downloadDocFile'><i class='fa-solid fa-download'></i></button>";

                }
                var document = selectedRowIds[selectedRowIndex]['DocName'];
                if (document == "") {
                    documentValue = "YES";
                }
                fileuploadGrid.jqGrid('setRowData', temp_var, selectedRowIds[selectedRowIndex]);
            }
        }
    });

    $(document).on('change', '#userStatus', function () {
        var idRecords = $('#UserID').val();
        if ($('#userStatus').is(":checked")) {
            ChangeStatusActiveDeactive1("ACTIVE", idRecords);
        }
        else {
            ChangeStatusActiveDeactive1("DEACTIVE", idRecords);
        }
    });

    $("#SearchUserDetails").click(function () {
        var Role = $('#RoleUserDetails').val();
        var Department = $('#DepartmentUserDetails').val();
        var Designation = $('#DesignationUserDetails').val();
        var UserName = $('#UserNameUserDetails').val();
        var Location = $('#LocationUserDetails').val();
        var EmailID = $('#EmaillIDUserDetails').val();
        var Domain = $('#DomainUserDetails').val();
        var Status = $('#StatusUserDetails').val();

        if (Role != "" || Department != "" || Designation != "" || UserName != "" || Location != "" || EmailID != "" || Domain != "" || Status != "") {
            $.ajax({
                type: "POST",
                url: 'SearchButtonUD',
                data: {
                    Role,
                    Department,
                    Designation,
                    UserName,
                    Location,
                    EmailID,
                    Domain,
                    Status
                },
                dataType: "json",
                success: function (result) {
                    if (result.success) {
                        reload('UserDetailsGrid');
                        $('#successToastMessage').text('Search successfully');
                        $('#successToast').toast("show");
                    }
                }
            });
        }
        else {
            $('#warningToastMessage').text('No search parameter selected.');
            $('#warningToast').toast("show");
        }
    })

    $("#ResetUserDetails").click(function () {
        $('#RoleUserDetails').selectpicker('val', '');
        $('#DepartmentUserDetails').selectpicker('val', '');
        $('#DesignationUserDetails').selectpicker('val', '');
        $('#UserNameUserDetails').selectpicker('val', '');
        $('#LocationUserDetails').selectpicker('val', '');
        $('#EmaillIDUserDetails').selectpicker('val', '');
        $('#DomainUserDetails').selectpicker('val', '');
        $.ajax({
            type: "POST",
            url: 'ResetButtonUD',
            dataType: "json",
            success: function (result) {
                reload('UserDetailsGrid');
                $('#successToastMessage').text('Reset successfully');
                $('#successToast').toast("show");
            }
        });
    });

    $("#ResetPassword").click(function () {
        $('#loading').show();
        var IDUser = $("#UserID").val();
        $.ajax({
            type: "POST",
            url: "ResetPasswordDetails",
            data: {
                IDUser
            },
            datatype: "json",
            success: function (data) {
                if (data.success == false) {
                    $("#errorToastMessage").text("Reset password failed");
                    $('#errorToast').toast("show");
                    $('#tempDataSuccess').hide();
                    $('#tempDataError').hide();

                }
                else if (data.success == true) {
                    $('#successToastMessage').text("Password reset successfully");
                    $('#successToast').toast("show");
                    $('#loading').hide();
                }
            }
        });
    });

    $("#SaveUserDetails").click(function () {
        $('#loading').show();
        var FullName = $('#FullNameUD').val().toUpperCase();
        var Role = $('#RoleUD').val().toUpperCase();
        var Department = $('#DepartmentUD').val().toUpperCase();
        var Designation = $('#DesignationUD').val().toUpperCase();
        var UserName = $('#UserNameUD').val().toUpperCase();
        var Unit = $('#UnitUD').val();
        var EmailID = $('#EmailIDUD').val();
        var IDLocation = $('#LocationUD').val();
        var Location = $('#LocationUD').val();
        var Domain = $('#DomainUD').val();
        if (FullName == '' || Role == '' || Department == '' || Designation == '' || UserName == '' || EmailID == '' || IDLocation == '' || Domain == '') {
            $('#warningToastMessage').text('Please fill mandatory fields.');
            $('#warningToast').toast("show");
            $('#loading').hide();
        }
        else {
            if (EmailID.includes('@') && EmailID.includes('.')) {
                $.ajax({
                    type: "POST",
                    url: 'SaveUserDetails',
                    data: {
                        FullName,
                        Role,
                        Department,
                        Designation,
                        UserName,
                        Unit,
                        EmailID,
                        IDLocation,
                        Domain
                    },
                    dataType: "json",
                    success: function (data) {
                        if (data.success) {
                            reload('UserDetailsGrid');
                            $('#loading').hide();
                            $('#successToastMessage').text('User Created Successfully');
                            $('#successToast').toast("show");
                            $('#CreateUserDetails').modal("hide");
                            $("#FullNameUpdate").val(data.userData.fullName);
                            $('#RoleUpdate').selectpicker('val', data.userData.role);
                            $('#DepartmentUpdate').val(data.userData.department);
                            $('#DesignationUpdate').val(data.userData.designation);
                            $('#UserNameUpdate').val(data.userData.userName);
                            $('#DomainUD').val(data.userData.domain);
                            $('#IDUserLatest').html(data.userData.idUserDis);
                            $('#LocationUpdate').selectpicker('val', data.userData.location);
                            $('#UnitUpdate').val(data.userData.unit);
                            $('#EmailIDUpdate').val(data.userData.emailID);
                            $('#UserID').val(data.userData.idUser);
                            //$('#UpdateAllDetails').modal("show");
                            reload('fileuploadGrid');
                            DestroyRenderUDDropdowns();
                            var creationdet = "Created by " + data.userData.createdBy + " on " + data.userData.creationTimeStamp;
                            if (data.userData.status == "ACTIVE") {
                                document.getElementById('userStatus').checked = true;
                            }
                            else {
                                document.getElementById('userStatus').checked = false;
                            }

                            $('#CreationLatest').html(creationdet);
                            // searchIDWisedocGrid(data.IDUser);
                            $('#CreationUD').html(creationdet);
                            $("#UserStatus").show();
                            $("#statusShow").show();
                            reload('AssignGrid');
                            window.location.reload();
                        }
                        else {
                            if (data.duplicate == true) {
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
            else {
                $('#warningToastMessage').text('Please insert Valid EmailID.');
                $('#warningToast').toast("show");
                $('#loading').hide();
            }
        }
    })

    $("#UpdateUserDetails").click(function () {
        $('#loading').show();
        var IDUser = $('#UserID').val();
        var FullName = $('#FullNameUpdate').val().toUpperCase();
        var Role = $('#RoleUpdate').val();
        var Department = $('#DepartmentUpdate').val();
        var Designation = $('#DesignationUpdate').val();
        var UserName = $('#UserNameUpdate').val().toUpperCase();
        var Unit = $('#UnitUpdate').val();
        var EmailID = $('#EmailIDUpdate').val();
        var Domain = $('#DomainUpdate').val();
        var IDLocation = $('#LocationUpdate').val();
        var Location = $('#LocationUpdate').val();
        if (FullName == "" || Role == "" || Department == "" || Designation == "" || UserName == "" || EmailID == "" || IDLocation == "" || Domain == "") {
            $('#warningToastMessage').text('Please fill mandatory fields.');
            $('#warningToast').toast("show");
            $('#loading').hide();
        }
        else {
            $.ajax({
                type: "POST",
                url: 'SaveUserDetails',
                data: {
                    IDUser,
                    FullName,
                    Role,
                    Department,
                    Designation,
                    UserName,
                    Unit,
                    EmailID,
                    Domain,
                    IDLocation
                },
                dataType: "json",
                success: function (result) {
                    if (result.success) {
                        reload('UserDetailsGrid');
                        $('#loading').hide();
                        $('#successToastMessage').text('User Updated Successfully');
                        $('#successToast').toast("show");
                        $('#UpdateAllDetails').modal("hide");
                        DestroyRenderUDDropdowns();
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

    $("#TransferUserDetails").click(function () {
        $('#loading').show();
        var IDUser = $('#UserID').val();
        var FullName = $('#FullNameUpdate').val().toUpperCase();
        var Role = $('#RoleUpdate').val();
        var Department = $('#DepartmentUpdate').val();
        var Designation = $('#DesignationUpdate').val();
        var UserName = $('#UserNameUpdate').val().toUpperCase();
        var Unit = $('#UnitUpdate').val();
        var EmailID = $('#EmailIDUpdate').val();
        var IDLocation = $('#LocationUpdate').val();
        if (document.getElementById('userStatus').checked = true) {
            var Status = "ACTIVE"
        }
        else {
            var Status = "DEACTIVE"
        }
        $.ajax({
            type: "POST",
            url: 'TransferUserDetails',
            data: {
                IDUser,
                FullName,
                Role,
                Department,
                Designation,
                UserName,
                Unit,
                EmailID,
                IDLocation,
                Status
            },
            dataType: "json",
            success: function (data) {
                if (data.success) {
                    reload('UserDetailsGrid');
                    $('#loading').hide();
                    $('#successToastMessage').text('User Transfered Successfully');
                    $('#successToast').toast("show");
                    $('#CreateUserDetails').modal("hide");
                    reload('AssignGrid');
                    window.location.reload();
                }
                else {
                    if (data.duplicate == true) {
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

    $("#DeleteUserDetails").click(function () {
        $('#loading').show();
        var IDUser = $('#UserID').val();
        {
            $.ajax({
                type: "POST",
                url: 'DeleteUserDetails',
                data: {
                    IDUser
                },
                dataType: "json",
                success: function (result) {
                    if (result.response) {
                        reload('UserDetailsGrid');
                        $('#loading').hide();
                        $('#successToastMessage').text('User Deleted Successfully');
                        $('#successToast').toast("show");
                        $('#UpdateAllDetails').modal("hide");
                        DestroyRenderUDDropdowns();
                    }

                }
            });
        }
    })

    $('#CreateButton').click(function () {
        $('#UpdateUserDetails').hide();
        $('#DeleteUserDetails').hide();
        $('#UpdateText').hide();
        $('#UpdateText').hide();
        $('#ResetPassword').hide();
        $('#SaveUserDetails').show();
        $('#CreateText').show();
        $('#FullNameUD').val('');
        $('#EmailIDUD').val('');
        $('#UnitUD').val('');
        $('#UserNameUD').val('');
        $('#UserNameUD').val('');
        $('#RoleUD').selectpicker('val', '');
        $('#DepartmentUD').val('');
        $('#DesignationUD').val('');
        $('#LocationUD').selectpicker('val', '');
        $("#IDUserDis").html("New User");
        $("#statusShow").hide();
        $('#CreationUD').html("");
    });

    $('#ExportExcelUser').click(function () {

        var Role = $("#RoleUserDetails").val();
        var Department = $("#DepartmentUserDetails").val();
        var Designation = $("#DesignationUserDetails").val();
        var UserName = $("#UserNameUserDetails").val();
        var Location = $("#LocationUserDetails").val();
        var Status = $("#StatusUserDetails").val();
        var Domain = $("#DomainUserDetails").val();

        //'../Home/DownloadDocFile?IDUser=' + IDUser + '&&DocName=' + DocName;
        var url = '../Home/ExportUserData?Role=' + Role + '&&Department=' + Department + '&&Designation=' + Designation + '&&UserName=' + UserName + '&&Location=' + Location + '&&Status=' + Status + '&&Domain=' + Domain;
        //var url = "ExportUserData" ;
        window.open(url);
    });

    /*upload button click*/
    $('#UploadFile').click(function () {
        $('#FileUpload').modal("show");
    });

    //click close button on fileupload modal 
    $('#CloseButtonFileUpload').click(function () {
        $('#FileUpload').modal('hide');
    })

    $(document).on('click', '.GetDataUser', function () {

        if (RoleUser == 'ADMIN') {
            $("#ButtonsFieldset").show();
            $("#UpdateUserDetails").show();
            $("#DeleteUserDetails").show();
            $("#TransferUserDetails").show();
            $("#statusShow").show();
            $("#SaveFile").show();
            $("#DeleteFile").show();
            $("#EditfileuploadGrid").show();
            $("#SavefileuploadGrid").show();
            $("#CancelfileuploadGrid").show();
        }
        else if (RoleUser == 'HR') {

            $("#ButtonsFieldset").hide();
            $("#statusShow").hide();
            $("#UpdateUserDetails").hide();
            $("#DeleteUserDetails").hide();
            $("#TransferUserDetails").hide();
            $("#SaveFile").hide();
            $("#DeleteFile").hide();
            $("#EditfileuploadGrid").hide();
            $("#SavefileuploadGrid").hide();
            $("#CancelfileuploadGrid").hide();
        }
        else if (RoleUser == "SUPERUSER") {
            $("#ButtonsFieldset").show();
            $("#UpdateUserDetails").show();
            $("#DeleteUserDetails").show();
            $("#TransferUserDetails").show();
            $("#statusShow").show();
            $("#SaveFile").show();
            $("#DeleteFile").show();
            $("#EditfileuploadGrid").show();
            $("#SavefileuploadGrid").show();
            $("#CancelfileuploadGrid").show();
        }

        var rowId = $(this).data('rowid');
        var data = UserDetailsGrid.jqGrid('getRowData', rowId);
        reloadGridsByID(rowId);
        $('#UpdateAllDetails').modal("show");
        $('#FullNameUpdate').val(data.FullName);
        $('#RoleUpdate').selectpicker('val', data.Role);
        $('#DepartmentUpdate').val(data.Department);
        $('#DesignationUpdate').val(data.Designation);
        $('#UserNameUpdate').val(data.UserName);
        $('#EmailIDUpdate').val(data.EmailID);
        $('#DomainUpdate').val(data.Domain);
        $('#UnitUpdate').val(data.Unit);
        $('#UserID').val(data.IDUser);
        $('#LocationUpdate').selectpicker('val', data.IDLocation);
        $('#ResetPassword').show();
        $('#IDUserLatest').html(data.IDUserDis);
        var CreatedBy = data.CreatedBy;
        var CreatedOn = data.CreatedOn;
        var creationdet = "Created by " + CreatedBy + " on " + CreatedOn;
        if (data.Status == "ACTIVE") {
            document.getElementById('userStatus').checked = true;
        }
        else {
            document.getElementById('userStatus').checked = false;
        }
        //$("#UserStatus").show();
        //$("#statusShow").show();
        $('#CreationLatest').html(creationdet);
        // searchIDWisedocGrid(data.IDUser);
        $('#CreationUD').html(creationdet);
    });

    $("#SaveUserDetails").click(function () {
        modelOpen = 1;
        checkValidationUD("SAVE");
    });

    $(".checkValidUD").change(function () {
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

    $(".checkvalidud").focus(function () {
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

    $(".checkvalidud").blur(function () {
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

    $('#CloseUD').click(function () {
        modelOpen = 0;
        var mydivs = $(".checkvalidud");
        for (var i = 0; i < mydivs.length; i++) {
            if ($(mydivs[i]).hasClass('is-valid') == true) {
                $(mydivs[i]).removeClass('is-valid');
            }
            else if ($(mydivs[i]).hasClass('is-invalid') == true) {
                $(mydivs[i]).removeClass('is-invalid');
            }
        }
        var mydivs1 = $(".checkvalidUD").closest('select');
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

    $('#SaveFile').click(function () {
        var formData = new FormData();
        var fileInput = $('#DocFileName').prop("files");
        /* var filecount = fileInput.length;*/
        for (i = 0; i < fileInput.length; i++) {
            formData.append("File", fileInput[i])
        }
        formData.append("IDUser", $('#UserID').val());
        formData.append("UserName", $('#UserNameUpdate').val());
        if (fileInput.length == 0) {
            $("#warningToastMessage").text('Please select Files !!!');
            $('#warningToast').toast("show");
        }
        else {
            $('#loading').show();
            $.ajax({
                type: 'POST',
                url: 'UploadFiles',
                data: formData,
                contentType: false,
                processData: false,
                success: function (result) {
                    var htmlAppend = "<thead><tr><th class='col-lg-6'>File Name </th><th class='col-lg-2' style='text-align: center;'> Status </th><th class='col-lg-4'> Message</th></tr></thead><tbody>";
                    for (i = 0; i < result.messages.length; i++) {
                        if (result.messages[i].protocolVersion == 1) {
                            htmlAppend += "<tr> <td>" + result.messages[i].hostId + "</td><td style='text-align: center;'><i class='fa-solid fa-circle-check' style='color:green;'></i></td><td> " + result.messages[i].messageType + " </td></tr>";
                        }
                        else if (result.messages[i].protocolVersion == 0) {
                            htmlAppend += "<tr> <td>" + result.messages[i].hostId + "</td><td style='padding:15px; text-align: center;'><i class='fa-solid fa-circle-exclamation' style='color:red;'></i></td><td>" + result.messages[i].messageType + "</td></tr>";
                        }
                    }
                    htmlAppend += "</tbody>";

                    $('#filestatus').html(htmlAppend);
                    reload('fileuploadGrid');
                    $('#loading').hide();
                    $('#DocFileName').val('');
                    $('#errorFileUpload').modal('show');

                },
            });
        }
    });

    $(document).on('click', '#downloadDocFile', function () {
        DocName = encodeURIComponent($(this).attr('value'));
        IDUser = encodeURIComponent($(this).attr('data-IDUser'));
        var url = '../Home/DownloadDocFile?IDUser=' + IDUser + '&&DocName=' + DocName;
        //var url = 'C:\\ITAsset\\' + IDUser + '\\' + 'fileName=' + DocName;
        window.open(url);
    });

    $(document).on('click', '#viewDocFile', function () {
        DocName = encodeURIComponent($(this).attr('value'));
        IDUser = encodeURIComponent($(this).attr('data-IDUser'));
        var url = '../Home/DownloadDocFile?IDUser=' + IDUser + '&&DocName=' + DocName;
        $('#msdsPdfObject').attr('src', url);
        $("#msdsPdfViewer").modal('show');
    });

    $('#DeleteFile').click(function () {
        var AllData = [];
        var myGrid = $('#fileuploadGrid');
        var GridData = myGrid.jqGrid('getGridParam', 'selarrrow');
        var noOfFiles = GridData.length;
        for (i = 0; i < GridData.length; i++) {
            var tmp2 = myGrid.getRowData(GridData[i]).IDDoc;
            AllData.push(tmp2);
        }
        var userName = $('#UserNameUpdate').val();
        var IDUser = $('#UserID').val();
        if (AllData.length != 0) {
            $('#loading').show();
            if (confirm("Do you want to Delete?")) {
                $.ajax({
                    type: "POST",
                    url: "DeleteFiles",
                    data: {
                        AllData,
                        userName,
                        IDUser
                    },
                    dataType: 'json',
                    async: true,
                    success: function (result) {
                        reload('fileuploadGrid');
                        var filecount = "";
                        if (noOfFiles > 1) {
                            filecount = noOfFiles + " files are";
                        }
                        else {
                            filecount = noOfFiles + " file is";

                        }
                        reload('fileuploadGrid');
                        $('#loading').hide();
                        $("#successToastMessage").text(filecount + ' deleted successfully..!');
                        $('#successToast').toast("show");
                    }
                });
            }
        }
        else {
            $("#warningToastMessage").text('Please select row.');
            $('#warningToast').toast("show");
        }

    })

    // $("#RevokeButton1").click(function () {
    //    $("#loading").show();
    //    var SelectedRows = AssignGrid.jqGrid('getGridParam', 'selarrrow');
    //    UpdateAssestStatus2("AVAILABLE");
    //    reload('ITAssetDetailsGrid');
    //    reload('AssignGrid');
    //    $("#loading").hide();
    //});

    //$("#RepairButton1").click(function () {
    //    $("#loading").show();
    //    //var SelectedRows = AssignGrid.jqGrid('getGridParam', 'selarrrow');
    //    UpdateAssestStatus2("REPAIR");
    //    reload('ITAssetDetailsGrid');
    //    reload('AssignGrid');
    //    $("#loading").hide();
    //});

    //$("#ScrappedITAsset1").click(function () {
    //    $("#loading").show();
    //    //var SelectedRows = AssignGrid.jqGrid('getGridParam', 'selarrrow');
    //    UpdateAssestStatus2("SCRAPPED");
    //    reload('ITAssetDetailsGrid');
    //    reload('AssignGrid');
    //    $("#loading").hide();
    //});
});

//function UpdateAssestStatus2(Status) {
//    var UserID = $('#UserID').val();
//    var SerialNr = $('#SerialNumberText').val();
//    $.ajax({
//        type: "POST",
//        url: 'UpdateAssetStatus',
//        data: {
//            Status,
//            UserID,
//            SerialNr
//        },
//        dataType: "json",
//        success: function (data) {
//            if (data) {
//                $('#CreateITAssetDetails').modal('hide');
//                reload('ITAssetDetailsGrid');
//                $('#successToastMessage').text('Asset Updated Successfully');
//                $('#successToast').toast("show");
//            }
//            else {
//                $('#warningToastMessage').text('No search parameter selected.');
//                $('#warningToast').toast("show");
//            }
//        }
//    });
//}
function searchIDWisedocGrid(IDUser) {

    $.ajax({
        type: "post",
        url: "ReloadGridsByID",
        data: {
            IDUser
        },
        DataType: "json",
        success: function (success) {
            if (success) {
                reload('fileuploadGrid');
                /*   reload(depotWiseTankGrid);*/


                $("#loading").hide();
            }
            else {
                $("#errorToastMessage").text('Error while searching grid record.');
                $("#errorToast").toast("show");
            }
        }
    });
}

function checkValidationUD(type) {
    var mydivs = $(".checkvalidud")
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
    var mydivs1 = $(".checkvalidUD").closest('select')
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

//function UpdateAssestStatus(SelectedRows, Status) {
//    var UserId = $('#UserID').val();
//    $.ajax({
//        type: "POST",
//        url: 'UpdateAssetStatus',
//        data: {
//            Status,
//            FullName,
//            SelectedRows,
//            UserId
//        },
//        dataType: "json",
//        success: function (data) {
//            if (data) {
//                reload('AssignGrid');
//                $('#successToastMessage').text('Asset Updated Successfully');
//                $('#successToast').toast("show");
//            }
//            else {
//                $('#warningToastMessage').text('No search parameter selected.');
//                $('#warningToast').toast("show");
//            }
//        }
//    });
//}

function reloadGridsByID(rowId) {
    var UserID = rowId;
    $.ajax({
        type: "POST",
        url: 'ReloadGridsByID',
        data: {
            UserID
        },
        dataType: 'json',
        success: function (result) {
            reload('AssignGrid');
            reload('fileuploadGrid');

        }
    });
}

function reload(tableName) {
    currentPage = $('#' + tableName).getGridParam('page');
    $('#' + tableName).setGridParam({ datatype: "json" }).trigger('reloadGrid');
}

function ChangeStatusActiveDeactive1(status, iduser) {
    $.ajax({
        type: "POST",
        url: 'GetStatusUD',
        data: {
            status,
            iduser
        },
        dataType: 'json',
        success: function (result) {
            reload('UserDetailsGrid');
            window.location.reload();
            $('#successToastMessage').text('Status Updated successfully');
            $('#successToast').toast("show");
        }
    });
}

function DestroyRenderUDDropdowns() {

    var EXRole = $("#RoleUserDetails");
    var EXDepartment = $("#DepartmentUserDetails");
    var EXDesignation = $("#DesignationUserDetails");
    var EXUserName = $("#UserNameUserDetails");

    $.ajax({
        type: "GET",
        url: 'DestroyRenderUDDropdowns',
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


            if (data.roleList.length > 0) {
                EXRole.find('option').remove();
                EXRole.selectpicker('destroy');

                EXRole.append('<option value>Select HostName</option>');
                for (var i = 0; i < data.roleList.length; i++) {
                    EXRole.append("<option value='" + data.roleList[i].text + "'>" + data.roleList[i].text + "</option>");
                }
                renderDropdown(EXRole);
                //EXChargePartyCompany.selectpicker('val', EXChargePartyCompany);
            }
            if (data.departmentList.length > 0) {
                EXDepartment.find('option').remove();
                EXDepartment.selectpicker('destroy');

                EXDepartment.append('<option value>Select AssetType</option>');
                for (var i = 0; i < data.departmentList.length; i++) {
                    EXDepartment.append("<option value='" + data.departmentList[i].text + "'>" + data.departmentList[i].text + "</option>");
                }
                renderDropdown(EXDepartment);
                //EXChargePartyCompany.selectpicker('val', EXChargePartyCompany);
            }
            if (data.designationList.length > 0) {
                EXDesignation.find('option').remove();
                EXDesignation.selectpicker('destroy');

                EXDesignation.append('<option value>Select Brand</option>');
                for (var i = 0; i < data.designationList.length; i++) {
                    EXDesignation.append("<option value='" + data.designationList[i].text + "'>" + data.designationList[i].text + "</option>");
                }
                renderDropdown(EXDesignation);
                //EXChargePartyCompany.selectpicker('val', EXChargePartyCompany);
            }
            if (data.userNameList.length > 0) {
                EXUserName.find('option').remove();
                EXUserName.selectpicker('destroy');

                EXUserName.append('<option value>Select Model</option>');
                for (var i = 0; i < data.userNameList.length; i++) {
                    EXUserName.append("<option value='" + data.userNameList[i].text + "'>" + data.userNameList[i].text + "</option>");
                }
                renderDropdown(EXUserName);
                //EXChargePartyCompany.selectpicker('val', EXChargePartyCompany);
            }
        },
        error: function (xhr, ajaxOptions, thrownError) {
            $("#errorToastMessage").text('Failed to retrieve data');
            $("#errorToast").toast("show");
        }
    });
}