$(document).ready(function () {
    //$('#ScrappedFieldset').hide();
    //$('#ScrappedGrid').css('display', 'none');

    if (RoleUser == 'ADMIN') {

        $("#CreateButtonITAsset").show();
        $("#AssignITAssetDetails").show();
    }
    else if (RoleUser == 'HR') {

        $("#CreateButtonITAsset").hide();
        $("#AssignITAssetDetails").hide();
    }
    else if (RoleUser == "SUPERUSER") {

        $("#CreateButtonITAsset").show();
        $("#AssignITAssetDetails").show();
    }
    else if (RoleUser == "USER") {GetITAssetdata
        $("#CreateButtonITAsset").hide();
        $("#AssignITAssetDetails").hide();
        $("#RevokeButton").hide();
        $("#RepairButton").hide();
        $("#ScrappedITAsset").hide();
        $("#UpdateITAssetDetails").hide();
    }

    var currentPage;
    ITAssetDetailsGrid = $('#ITAssetDetailsGrid').jqGrid({
        mtype: 'Get',
        url: 'GetITAssetdata',
        //editurl: '',
        datatype: 'json',
        colNames: ['AssetID', 'ID', 'ID', '', 'ID', 'IDLocation', 'Host Name', 'Asset Type', 'Brand', 'Model', 'Serial Number', 'Purchase Year', 'EmailID', 'Designation', 'FullName', 'LastUser', 'Location', 'Region', 'Country', 'Unit', 'CPU', 'Memory', 'HDD', 'OS', 'Software', 'Remark', 'Domain', 'Status', 'ActivityLog', 'CreatedBy', 'CreatedOn', 'ModifiedBy', 'ModifiedOn', 'Monitor', 'Keyboard', 'Mouse', 'MS-Office', 'HeadPhone', 'Department','LastAssetLocation', 'Status', 'View'],
        colModel: [
            {
                key: false,
                hidden: false,
                editable: false,
                name: 'AssetID',
                width: '65px',
            },
            {
                key: true,
                hidden: true,
                name: 'IDAsset',
                width: '70px',
            },
            {
                key: false,
                hidden: true,
                name: 'view',
                width: '100px',
            },
            {
                key: false,
                hidden: true,
                name: 'IDAssetDis',
                editable: false,
                width: '120px',
            },
            {
                key: false,
                hidden: true,
                name: 'UserID',
                editable: false,
                width: '120px',
            },
            {
                key: false,
                hidden: true,
                name: 'IDLocation',
                width: '90px',
            },
            {
                key: false,
                hidden: true,
                name: 'HostName',
                width: '105px',
            },
            {
                key: false,
                name: 'AssetType',
                width: '105px',
            },
            {
                key: false,
                name: 'Brand',
                editable: false,
                width: '100px',
            },
            {
                key: false,
                hidden: true,
                name: 'Model',
                editable: false,
                width: '130px',
            },
            {
                key: false,
                name: 'SerialNumber',
                editable: false,
                width: '130px',
            },
            {
                key: false,
                name: 'PurchaseYear',
                editable: false,
                width: '135px',
            },
            {
                key: false,
                hidden: true,
                name: 'EmailID',
                editable: false,
                width: '235px',
            },
            {
                key: false,
                hidden: true,
                name: 'Designation',
                hidden: true,
                editable: false,
                width: '135px',
            },
            {
                key: false,
                name: 'FullName',
                editable: false,
                hidden: true,
                width: '110px',
            },
            {
                key: false,
                hidden: true,
                name: 'LastUser',
                editable: false,
                width: '100px',
            },
            {
                key: false,
                hidden:true,
                name: 'Location',
                editable: false,
                width: '125px',
            },
            {
                key: false,
                hidden: true,
                name: 'Region',
                editable: false,
                width: '95px',
            },
            {
                key: false,
                hidden: true,
                name: 'Country',
                editable: false,
                width: '95px',
            },
            {
                key: false,
                hidden: true,
                name: 'Unit',
                editable: false,
                width: '85px',
            },
            {
                key: false,
                hidden: true,
                name: 'CPU',
                editable: false,
                width: '80px',
            },
            {
                key: false,
                hidden: true,
                name: 'Memory',
                editable: false,
                width: '100px',
            },
            {
                key: false,
                hidden: true,
                name: 'HDD',
                editable: false,
                width: '60px',
            },
            {
                key: false,
                hidden: true,
                name: 'OS',
                editable: false,
                width: '100px',
            },
            {
                key: false,
                hidden: true,
                name: 'Software',
                editable: false,
                width: '100px',
            },
            {
                key: false,
                hidden: true,
                name: 'Remark',
                editable: false,
                width: '70px',
            },
            {
                key: false,
                hidden: true,
                name: 'Domain',
                editable: false,
                width: '70px',
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
                editable: false,
                name: 'ActivityLog',
                width: '65px',
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
                editable: false,
                name: 'Monitor',
                width: '65px',
            },
            {
                key: false,
                hidden: true,
                editable: false,
                name: 'Keyboard',
                width: '65px',
            },
            {
                key: false,
                hidden: true,
                editable: false,
                name: 'Mouse',
                width: '65px',
            },
            {
                key: false,
                hidden: true,
                editable: false,
                name: 'MSOffice',
                width: '65px',
            },
            {
                key: false,
                hidden: true,
                editable: false,
                name: 'HeadPhone',
                width: '65px',
            },
            {
                key: false,
                hidden: true,
                editable: false,
                name: 'Department',
                width: '65px',
            },
            {
                key: false,
                hidden: true,
                editable: false,
                name: 'LastAssetLocation',
                width: '65px',
            },
            {
                key: false,
                hidden: false,
                name: 'viewStatus',
                editable: false,
                width: '105px',
            },
            {
                key: false,
                editable: false,
                name: 'UpdateAsset',
                width: '65px',
            },

        ],
        loadonce: true,
        responsive: true,
        gridview: true,
        autoencode: false,
        shrinkToFit: true,
        autowidth: '',
        pager: '#ITAssetDetailsPager',
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
            var selectedRowIds = ITAssetDetailsGrid.jqGrid('getGridParam', 'data');
            //var selectedRowData = [];
            for (selectedRowIndex = 0; selectedRowIndex < selectedRowIds.length; selectedRowIndex++) {
                var temp_var = selectedRowIds[selectedRowIndex]['_id_'];
                var idAsset = selectedRowIds[selectedRowIndex]['IDAsset'];
                var idAssetDis = selectedRowIds[selectedRowIndex]['IDAssetDis'];
                var iTAssetstatus = selectedRowIds[selectedRowIndex]['Status'];
                var AssetUpdate = selectedRowIds[selectedRowIndex]['UpdateAsset']; //

                if (iTAssetstatus.toUpperCase() == "AVAILABLE") {
                    selectedRowIds[selectedRowIndex]['viewStatus'] = "<span class='badge bg-success bg-gradient'>AVAILABLE</span>";
                }
                else if (iTAssetstatus.toUpperCase() == "ASSIGNED") {
                    selectedRowIds[selectedRowIndex]['viewStatus'] = "<span class='badge bg-warning bg-gradient'>ASSIGNED</span>";
                }
                else if (iTAssetstatus.toUpperCase() == "REPAIR") {
                    selectedRowIds[selectedRowIndex]['viewStatus'] = "<span class='badge bg-danger bg-gradient'>REPAIR</span>";
                }
                else if (iTAssetstatus.toUpperCase() == "SCRAPPED") {
                    selectedRowIds[selectedRowIndex]['viewStatus'] = "<span class='badge bg-secondary bg-gradient'>SCRAPPED</span>";
                }
                else if (iTAssetstatus.toUpperCase() == "DEACTIVE") {
                    selectedRowIds[selectedRowIndex]['viewStatus'] = "<span class='badge bg-secondary bg-gradient'>DEACTIVE</span>";
                }

                selectedRowIds[selectedRowIndex]['view'] = "<button style='border:none; background:transparent;cursor:auto;'>" + idAssetDis + "</button>"
                selectedRowIds[selectedRowIndex]['UpdateAsset'] = "<button class='fw-bold getITAssetUpdate' style='border:none; background:transparent;color:purple;' data-rowid='" + idAsset + "'><i class='fa-solid fa-eye'></i></button>"; //
                //selectedRowIds[selectedRowIndex]['UpdateAsset']= "<button type='button' class='btn btn-outline-success btnChkInfo' value='" + idAsset +  "'><i class='fa-solid fa-eye'></i></button>";

                ITAssetDetailsGrid.jqGrid('setRowData', temp_var, selectedRowIds[selectedRowIndex]);
            }
        }
    });

    var currentPage;
    AssignedGrid = $('#AssignedGrid').jqGrid({
        mtype: 'Get',
        url: 'GetAssignedAssetdata',
        //editurl: '',
        datatype: 'json',
        colNames: ['AssetID', 'ID', 'ID', '', 'ID', 'IDLocation', 'Host Name', 'Asset Type', 'Brand', 'Model', 'Serial Number', 'Purchase Year', 'EmailID', 'Designation', 'FullName', 'LastUser', 'Location', 'Region', 'Country', 'Unit', 'CPU', 'Memory', 'HDD', 'OS', 'Software', 'Remark', 'Domain', 'Status', 'ActivityLog', 'CreatedBy', 'CreatedOn', 'ModifiedBy', 'ModifiedOn', 'Monitor', 'Keyboard', 'Mouse', 'MS-Office', 'HeadPhone', 'Department','LastAssetLocation','Status', 'View'],
        colModel: [
            {
                key: false,
                hidden: false,
                editable: false,
                name: 'AssetID',
                width: '65px',
            },
            {
                key: true,
                hidden: true,
                name: 'IDAsset',
                width: '70px',
            },
            {
                key: false,
                hidden: true,
                name: 'view',
                width: '100px',
            },
            {
                key: false,
                hidden: true,
                name: 'IDAssetDis',
                editable: false,
                width: '120px',
            },
            {
                key: false,
                hidden: true,
                name: 'UserID',
                editable: false,
                width: '120px',
            },
            {
                key: false,
                hidden: true,
                name: 'IDLocation',
                width: '90px',
            },
            {
                key: false,
                hidden: true,
                name: 'HostName',
                width: '105px',
            },
            {
                key: false,
                name: 'AssetType',
                width: '105px',
            },
            {
                key: false,
                name: 'Brand',
                editable: false,
                width: '100px',
            },
            {
                key: false,
                hidden: true,
                name: 'Model',
                editable: false,
                width: '130px',
            },
            {
                key: false,
                name: 'SerialNumber',
                editable: false,
                width: '130px',
            },
            {
                key: false,
                name: 'PurchaseYear',
                editable: false,
                width: '135px',
            },
            {
                key: false,
                hidden: true,
                name: 'EmailID',
                editable: false,
                width: '235px',
            },
            {
                key: false,
                hidden: true,
                name: 'Designation',
                editable: false,
                width: '135px',
            },
            {
                key: false,
                name: 'FullName',
                editable: false,
                width: '140px',
            },
            {
                key: false,
                hidden: true,
                name: 'LastUser',
                editable: false,
                width: '100px',
            },
            {
                key: false,
                hidden:true,
                name: 'Location',
                editable: false,
                width: '140px',
            },
            {
                key: false,
                hidden: true,
                name: 'Region',
                editable: false,
                width: '95px',
            },
            {
                key: false,
                hidden: true,
                name: 'Country',
                editable: false,
                width: '95px',
            },
            {
                key: false,
                hidden: true,
                name: 'Unit',
                editable: false,
                width: '85px',
            },
            {
                key: false,
                hidden: true,
                name: 'CPU',
                editable: false,
                width: '80px',
            },
            {
                key: false,
                hidden: true,
                name: 'Memory',
                editable: false,
                width: '100px',
            },
            {
                key: false,
                hidden: true,
                name: 'HDD',
                editable: false,
                width: '60px',
            },
            {
                key: false,
                hidden: true,
                name: 'OS',
                editable: false,
                width: '100px',
            },
            {
                key: false,
                hidden: true,
                name: 'Software',
                editable: false,
                width: '100px',
            },
            {
                key: false,
                hidden: true,
                name: 'Remark',
                editable: false,
                width: '70px',
            },
            {
                key: false,
                hidden: true,
                name: 'Domain',
                editable: false,
                width: '70px',
            },
            {
                key: false,
                hidden: true,
                name: 'Status',
                editable: false,
                width: '60px',
            },
            {
                key: false,
                hidden: true,
                editable: false,
                name: 'ActivityLog',
                width: '65px',
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
                editable: false,
                name: 'Monitor',
                width: '65px',
            },
            {
                key: false,
                hidden: true,
                editable: false,
                name: 'Keyboard',
                width: '65px',
            },
            {
                key: false,
                hidden: true,
                editable: false,
                name: 'Mouse',
                width: '65px',
            },
            {
                key: false,
                hidden: true,
                editable: false,
                name: 'MSOffice',
                width: '65px',
            },
            {
                key: false,
                hidden: true,
                editable: false,
                name: 'HeadPhone',
                width: '65px',
            },
            {
                key: false,
                hidden: true,
                editable: false,
                name: 'Department',
                width: '65px',
            },
            {
                key: false,
                hidden: true,
                editable: false,
                name: 'LastAssetLocation',
                width: '65px',
            },
            {
                key: false,
                hidden: false,
                name: 'viewStatus',
                editable: false,
                width: '105px',
            },
            {
                key: false,
                editable: false,
                name: 'UpdateAsset',
                width: '65px',
            },

        ],
        loadonce: true,
        responsive: false,
        gridview: true,
        autoencode: false,
        shrinkToFit: true,
        autowidth: '',
        pager: '#AssignedPager',
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
            var selectedRowIds = AssignedGrid.jqGrid('getGridParam', 'data');
            //var selectedRowData = [];
            for (selectedRowIndex = 0; selectedRowIndex < selectedRowIds.length; selectedRowIndex++) {
                var temp_var = selectedRowIds[selectedRowIndex]['_id_'];
                var idAsset = selectedRowIds[selectedRowIndex]['IDAsset'];
                var idAssetDis = selectedRowIds[selectedRowIndex]['IDAssetDis'];
                var iTAssetstatus = selectedRowIds[selectedRowIndex]['Status'];
                var AssetUpdate = selectedRowIds[selectedRowIndex]['UpdateAsset']; //

                if (iTAssetstatus.toUpperCase() == "AVAILABLE") {
                    selectedRowIds[selectedRowIndex]['viewStatus'] = "<span class='badge bg-success bg-gradient'>AVAILABLE</span>";
                }
                else if (iTAssetstatus.toUpperCase() == "ASSIGNED") {
                    selectedRowIds[selectedRowIndex]['viewStatus'] = "<span class='badge bg-warning bg-gradient'>ASSIGNED</span>";
                }
                else if (iTAssetstatus.toUpperCase() == "REPAIR") {
                    selectedRowIds[selectedRowIndex]['viewStatus'] = "<span class='badge bg-danger bg-gradient'>REPAIR</span>";
                }
                else if (iTAssetstatus.toUpperCase() == "SCRAPPED") {
                    selectedRowIds[selectedRowIndex]['viewStatus'] = "<span class='badge bg-secondary bg-gradient'>SCRAPPED</span>";
                }
                else if (iTAssetstatus.toUpperCase() == "DEACTIVE") {
                    selectedRowIds[selectedRowIndex]['viewStatus'] = "<span class='badge bg-secondary bg-gradient'>DEACTIVE</span>";
                }

                selectedRowIds[selectedRowIndex]['view'] = "<button style='border:none; background:transparent;cursor:auto;'>" + idAssetDis + "</button>"
                selectedRowIds[selectedRowIndex]['UpdateAsset'] = "<button class='fw-bold getAssignedUpdate' style='border:none; background:transparent;color:purple;' data-rowid2='" + idAsset + "'><i class='fa-solid fa-eye'></i></button>"; //
                //selectedRowIds[selectedRowIndex]['UpdateAsset']= "<button type='button' class='btn btn-outline-success btnChkInfo' value='" + idAsset +  "'><i class='fa-solid fa-eye'></i></button>";

                AssignedGrid.jqGrid('setRowData', temp_var, selectedRowIds[selectedRowIndex]);
            }
        }
    });

    var currentPage;
    ScrappedGrid = $('#ScrappedGrid').jqGrid({
        mtype: 'Get',
        url: 'GetScrappedAssetdata',
        //editurl: '',
        datatype: 'json',
        colNames: ['AssetID', 'ID', 'ID', '', 'ID', 'IDLocation', 'Host Name', 'Asset Type', 'Brand', 'Model', 'Serial Number', 'Purchase Year', 'EmailID', 'Designation', 'FullName', 'LastUser', 'Location', 'Region', 'Country', 'Unit', 'CPU', 'Memory', 'HDD', 'OS', 'Software', 'Remark', 'Domain', 'Status', 'ActivityLog', 'CreatedBy', 'CreatedOn', 'ModifiedBy', 'ModifiedOn', 'Monitor', 'Keyboard', 'Mouse', 'MS-Office', 'HeadPhone', 'Department','LastAssetLocation', 'Status', 'View'],
        colModel: [
            {
                key: false,
                hidden: false,
                editable: false,
                name: 'AssetID',
                width: '65px',
            },
            {
                key: true,
                hidden: true,
                name: 'IDAsset',
                width: '70px',
            },
            {
                key: false,
                hidden: true,
                name: 'view',
                width: '100px',
            },
            {
                key: false,
                hidden: true,
                name: 'IDAssetDis',
                editable: false,
                width: '120px',
            },
            {
                key: false,
                hidden: true,
                name: 'UserID',
                editable: false,
                width: '120px',
            },
            {
                key: false,
                hidden: true,
                name: 'IDLocation',
                width: '90px',
            },
            {
                key: false,
                hidden: true,
                name: 'HostName',
                width: '105px',
            },
            {
                key: false,
                name: 'AssetType',
                width: '105px',
            },
            {
                key: false,
                name: 'Brand',
                editable: false,
                width: '100px',
            },
            {
                key: false,
                hidden: true,
                name: 'Model',
                editable: false,
                width: '130px',
            },
            {
                key: false,
                name: 'SerialNumber',
                editable: false,
                width: '130px',
            },
            {
                key: false,
                name: 'PurchaseYear',
                editable: false,
                width: '135px',
            },
            {
                key: false,
                hidden: true,
                name: 'EmailID',
                editable: false,
                width: '235px',
            },
            {
                key: false,
                hidden: true,
                name: 'Designation',
                editable: false,
                width: '135px',
            },
            {
                key: false,
                hidden: true,
                name: 'FullName',
                editable: false,
                width: '110px',
            },
            {
                key: false,
                hidden: true,
                name: 'LastUser',
                editable: false,
                width: '100px',
            },
            {
                key: false,
                hidden:true,
                name: 'Location',
                editable: false,
                width: '95px',
            },
            {
                key: false,
                hidden: true,
                name: 'Region',
                editable: false,
                width: '95px',
            },
            {
                key: false,
                hidden: true,
                name: 'Country',
                editable: false,
                width: '95px',
            },
            {
                key: false,
                hidden: true,
                name: 'Unit',
                editable: false,
                width: '85px',
            },
            {
                key: false,
                hidden: true,
                name: 'CPU',
                editable: false,
                width: '80px',
            },
            {
                key: false,
                hidden: true,
                name: 'Memory',
                editable: false,
                width: '100px',
            },
            {
                key: false,
                hidden: true,
                name: 'HDD',
                editable: false,
                width: '60px',
            },
            {
                key: false,
                hidden: true,
                name: 'OS',
                editable: false,
                width: '100px',
            },
            {
                key: false,
                hidden: true,
                name: 'Software',
                editable: false,
                width: '100px',
            },
            {
                key: false,
                hidden: true,
                name: 'Remark',
                editable: false,
                width: '70px',
            },
            {
                key: false,
                hidden: true,
                name: 'Domain',
                editable: false,
                width: '70px',
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
                editable: false,
                name: 'ActivityLog',
                width: '65px',
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
                editable: false,
                name: 'Monitor',
                width: '65px',
            },
            {
                key: false,
                hidden: true,
                editable: false,
                name: 'Keyboard',
                width: '65px',
            },
            {
                key: false,
                hidden: true,
                editable: false,
                name: 'Mouse',
                width: '65px',
            },
            {
                key: false,
                hidden: true,
                editable: false,
                name: 'MSOffice',
                width: '65px',
            },
            {
                key: false,
                hidden: true,
                editable: false,
                name: 'HeadPhone',
                width: '65px',
            },
            {
                key: false,
                hidden: true,
                editable: false,
                name: 'Department',
                width: '65px',
            },
            {
                key: false,
                hidden: true,
                editable: false,
                name: 'LastAssetLocation',
                width: '65px',
            },
            {
                key: false,
                hidden: false,
                name: 'viewStatus',
                editable: false,
                width: '105px',
            },
            {
                key: false,
                editable: false,
                name: 'UpdateAsset',
                width: '65px',
            },

        ],
        loadonce: true,
        responsive: false,
        gridview: true,
        autoencode: false,
        shrinkToFit: true,
        autowidth: '',
        pager: '#ScrappedPager',
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
            var selectedRowIds = ScrappedGrid.jqGrid('getGridParam', 'data');
            //var selectedRowData = [];
            for (selectedRowIndex = 0; selectedRowIndex < selectedRowIds.length; selectedRowIndex++) {
                var temp_var = selectedRowIds[selectedRowIndex]['_id_'];
                var idAsset = selectedRowIds[selectedRowIndex]['IDAsset'];
                var idAssetDis = selectedRowIds[selectedRowIndex]['IDAssetDis'];
                var iTAssetstatus = selectedRowIds[selectedRowIndex]['Status'];
                var AssetUpdate = selectedRowIds[selectedRowIndex]['UpdateAsset']; //

                if (iTAssetstatus.toUpperCase() == "AVAILABLE") {
                    selectedRowIds[selectedRowIndex]['viewStatus'] = "<span class='badge bg-success bg-gradient'>AVAILABLE</span>";
                }
                else if (iTAssetstatus.toUpperCase() == "ASSIGNED") {
                    selectedRowIds[selectedRowIndex]['viewStatus'] = "<span class='badge bg-warning bg-gradient'>ASSIGNED</span>";
                }
                else if (iTAssetstatus.toUpperCase() == "REPAIR") {
                    selectedRowIds[selectedRowIndex]['viewStatus'] = "<span class='badge bg-danger bg-gradient'>REPAIR</span>";
                }
                else if (iTAssetstatus.toUpperCase() == "SCRAPPED") {
                    selectedRowIds[selectedRowIndex]['viewStatus'] = "<span class='badge bg-secondary bg-gradient'>SCRAPPED</span>";
                }
                else if (iTAssetstatus.toUpperCase() == "DEACTIVE") {
                    selectedRowIds[selectedRowIndex]['viewStatus'] = "<span class='badge bg-secondary bg-gradient'>DEACTIVE</span>";
                }

                selectedRowIds[selectedRowIndex]['view'] = "<button style='border:none; background:transparent;cursor:auto;'>" + idAssetDis + "</button>"
                selectedRowIds[selectedRowIndex]['UpdateAsset'] = "<button class='fw-bold getScrappedUpdate' style='border:none; background:transparent;color:purple;' data-rowid1='" + idAsset + "'><i class='fa-solid fa-eye'></i></button>"; //
                //selectedRowIds[selectedRowIndex]['UpdateAsset']= "<button type='button' class='btn btn-outline-success btnChkInfo' value='" + idAsset +  "'><i class='fa-solid fa-eye'></i></button>";

                ScrappedGrid.jqGrid('setRowData', temp_var, selectedRowIds[selectedRowIndex]);
            }
        }
    });

    $(document).on('click', '.getITAssetUpdate', function () {

        if (RoleUser == 'ADMIN') {

            $("#CreateButtonITAsset").show();
            $("#RevokeButton").show();
            $("#RepairButton").show();
            $("#ScrappedITAsset").show();
            $("#TransferITAssetDetails").show();
            $("#UpdateITAssetDetails").show();
            $("#DeleteITAssetDetails").show();
        }
        else if (RoleUser == 'HR') {

            // ITAssetDetails
            $("#CreateButtonITAsset").hide();
            $("#RevokeButton").hide();
            $("#RepairButton").hide();
            $("#ScrappedITAsset").hide();
            $("#TransferITAssetDetails").hide();
            $("#UpdateITAssetDetails").hide();
            $("#DeleteITAssetDetails").hide();
        }
        else if (RoleUser == "SUPERUSER") {

            // ITAssetDetails
            $("#CreateButtonITAsset").show();
            $("#RevokeButton").show();
            $("#RepairButton").show();
            $("#ScrappedITAsset").show();
            $("#TransferITAssetDetails").show();
            $("#UpdateITAssetDetails").show();
            $("#DeleteITAssetDetails").show();
        }
        else if (RoleUser == "USER") {
            $("#CreateButtonITAsset").hide();
            $("#AssignITAssetDetails").hide();
            $("#RevokeButton").hide();
            $("#RepairButton").hide();
            $("#ScrappedITAsset").hide();
            $("#UpdateITAssetDetails").hide();
        }

        var rowId = $(this).data('rowid');
        var data = ITAssetDetailsGrid.jqGrid('getRowData', rowId);
        var purchaseYear = moment(data.PurchaseYear, 'DD-MM-YYYY').format('yyyy-MM-DD');
        //$('#RevokeButton').show();
        //$('#RepairButton').show();
        //$('#ScrappedITAsset').show();
        $('.ActivityData').hide();
        $('.ActivityData1').show();
        $('.ActivityData2').show();
        $('#CreateITAssetDetails').modal("show");
        $('.LastUserField').show();
        $('#SaveITAssetDetails').hide();
        $('#CreateAssetITText').hide();


        //$('#TransferITAssetDetails').show();
        //$('#UpdateITAssetDetails').show();
        //$('#DeleteITAssetDetails').show();
        $('#UpdateAssetITText').show();
        $('#AssetID').val(data.IDAsset);
        $('#IDAssetDisText').val(data.IDAssetDis);
        $('#UserID').val(data.UserID);
        $('#HostNameText').val(data.HostName);
        $('#AssetTypeText').selectpicker('val', data.AssetType);
        $('#BrandText').val(data.Brand);
        $('#FullNameText').val(data.FullName);
        $('#DomainITAsset').val(data.Domain);
        $('#ModelText').val(data.Model);
        $('#SerialNumberText').val(data.SerialNumber);
        $('#PurchaseYearText').val(purchaseYear);
        $('#OfficeText').val(data.Location);
        $('#UnitText').val(data.Unit);
        $('#CPUText').val(data.CPU);
        $('#MemoryText').val(data.Memory);
        $('#HDDText').val(data.HDD);
        $('#OSText').val(data.OS);
        //$('#LastUserText').val(data.LastUser);
        $('#SoftwareText').val(data.Software);
        $('#MonitorITAsset').val(data.Monitor);
        $('#KeyboardITAsset').val(data.Keyboard);
        $('#MouseITAsset').val(data.Mouse);
        $('#MSOfficeITAsset').val(data.MSOffice);
        $('#EmailIDITAsset').val(data.EmailID);
        $('#DesignationITAsset').val(data.Designation);
        $('#IDAssetDis').html(data.IDAssetDis);
        $('#DepartmentITAsset').val(data.Department);
        $('#RemarkText').val(data.Remark);
        $('#LastAssetLocation').val(data.LastAssetLocation);
        var value = data.ActivityLog;
        var value1 = data.LastUser;
        value = value.replaceAll('\\n', '\n');
        value1 = value1.replaceAll('\\n', '\n');
        // value = value.substring(2);
        $('#ActivityLog').val(value);
        $('#LastUserText').val(value1);
        //var CreatedBy = data.CreatedBy;
        //var CreatedOn = data.CreatedOn;
        //var creationdetITAsset = "Created by " + CreatedBy + " on " + CreatedOn;
        //$('#CreationITAS').html(creationdetITAsset);
        var ModfiedBy = data.ModifiedBy;
        var ModifiedOn = data.ModifiedOn;
        var creationdetITAsset = "Modified by " + ModfiedBy + " on " + ModifiedOn;
        $('#CreationITAS').html(creationdetITAsset);
        $('#AssetIDText').val(data.AssetID);

        if (data.Status == 'DEACTIVE' || data.Status == 'SCRAPPED') {
            $("#UpdateITAssetDetails").hide();
            $("#ScrappedITAsset").hide();
            $("#RepairButton").hide();
            $("#DeactiveButton").hide();
        }
        else {
            if (RoleUser == "SUPERUSER") {
                $("#UpdateITAssetDetails").show();
                $("#ScrappedITAsset").show();
                $("#RepairButton").show();
                $("#DeactiveButton").show();
            }
            else if (RoleUser == "USER") {

                $("#RevokeButton").hide();
                $("#RepairButton").hide();
                $("#ScrappedITAsset").hide();
                $("#UpdateITAssetDetails").hide();
            }
        }
    });

    $(document).on('click', '.getAssignedUpdate', function () {

        if (RoleUser == 'ADMIN') {

            $("#CreateButtonITAsset").show();
            $("#RevokeButton").show();
            $("#RepairButton").show();
            $("#ScrappedITAsset").show();
            $("#TransferITAssetDetails").show();
            $("#UpdateITAssetDetails").show();
            $("#DeleteITAssetDetails").show();
        }
        else if (RoleUser == 'HR') {

            // ITAssetDetails
            $("#CreateButtonITAsset").hide();
            $("#RevokeButton").hide();
            $("#RepairButton").hide();
            $("#ScrappedITAsset").hide();
            $("#TransferITAssetDetails").hide();
            $("#UpdateITAssetDetails").hide();
            $("#DeleteITAssetDetails").hide();
        }
        else if (RoleUser == "SUPERUSER") {

            // ITAssetDetails
            $("#CreateButtonITAsset").show();
            $("#RevokeButton").show();
            $("#RepairButton").show();
            $("#ScrappedITAsset").show();
            $("#TransferITAssetDetails").show();
            $("#UpdateITAssetDetails").show();
            $("#DeleteITAssetDetails").show();
        }
        else if (RoleUser == "USER") {
            $("#CreateButtonITAsset").hide();
            $("#AssignITAssetDetails").hide();
            $("#RevokeButton").hide();
            $("#RepairButton").hide();
            $("#ScrappedITAsset").hide();
            $("#UpdateITAssetDetails").hide();
        }

        var rowId = $(this).data('rowid2');
        var data = AssignedGrid.jqGrid('getRowData', rowId);
        var purchaseYear = moment(data.PurchaseYear, 'DD-MM-YYYY').format('yyyy-MM-DD');
        //$('#RevokeButton').show();
        //$('#RepairButton').show();
        //$('#ScrappedITAsset').show();
        $('.ActivityData').show();
        $('.ActivityData1').show();
        $('.ActivityData2').hide();
        $('#CreateITAssetDetails').modal("show");
        $('.LastUserField').show();
        $('#SaveITAssetDetails').hide();
        $('#CreateAssetITText').hide();
        //$('#TransferITAssetDetails').show();
        //$('#UpdateITAssetDetails').show();
        //$('#DeleteITAssetDetails').show();
        $('#UpdateAssetITText').show();
        $('#AssetID').val(data.IDAsset);
        $('#UserID').val(data.UserID);
        $('#HostNameText').val(data.HostName);
        $('#IDAssetDisText').val(data.IDAssetDis);
        $('#AssetTypeText').selectpicker('val', data.AssetType);
        $('#BrandText').val(data.Brand);
        $('#FullNameText').val(data.FullName);
        $('#DomainITAsset').val(data.Domain);
        $('#ModelText').val(data.Model);
        $('#SerialNumberText').val(data.SerialNumber);
        $('#PurchaseYearText').val(purchaseYear);
        $('#OfficeText').val(data.LastAssetLocation);
        $('#UnitText').val(data.Unit);
        $('#CPUText').val(data.CPU);
        $('#MemoryText').val(data.Memory);
        $('#HDDText').val(data.HDD);
        $('#OSText').val(data.OS);
        // $('#LastUserText').val(data.LastUser);
        $('#SoftwareText').val(data.Software);
        $('#MonitorITAsset').val(data.Monitor);
        $('#KeyboardITAsset').val(data.Keyboard);
        $('#MouseITAsset').val(data.Mouse);
        $('#MSOfficeITAsset').val(data.MSOffice);
        $('#EmailIDITAsset').val(data.EmailID);
        $('#DesignationITAsset').val(data.Designation);
        $('#IDAssetDis').html(data.IDAssetDis);
        $('#DepartmentITAsset').val(data.Department);
        $('#RemarkText').val(data.Remark);
        $('#LastAssetLocation').val(data.LastAssetLocation);
        var value = data.ActivityLog;
        var value1 = data.LastUser;
        value = value.replaceAll('\\n', '\n');
        value1 = value1.replaceAll('\\n', '\n');
        // value = value.substring(2);
        $('#ActivityLog').val(value);
        $('#LastUserText').val(value1);
        //var CreatedBy = data.CreatedBy;
        //var CreatedOn = data.CreatedOn;
        //var creationdetITAsset = "Created by " + CreatedBy + " on " + CreatedOn;
        //$('#CreationITAS').html(creationdetITAsset);
        var ModfiedBy = data.ModifiedBy;
        var ModifiedOn = data.ModifiedOn;
        var creationdetITAsset = "Modified by " + ModfiedBy + " on " + ModifiedOn;
        $('#CreationITAS').html(creationdetITAsset);
        $('#AssetIDText').val(data.AssetID);

        if (data.Status == 'DEACTIVE' || data.Status == 'SCRAPPED') {
            $("#UpdateITAssetDetails").hide();
            $("#ScrappedITAsset").hide();
            $("#RepairButton").hide();
            $("#DeactiveButton").hide();
        }
        else {
            $("#UpdateITAssetDetails").show();
            $("#ScrappedITAsset").show();
            $("#RepairButton").show();
            $("#DeactiveButton").show();
        }
    });

    $(document).on('click', '.getScrappedUpdate', function () {

        if (RoleUser == 'ADMIN') {

            $("#CreateButtonITAsset").show();
            $("#RevokeButton").show();
            $("#RepairButton").show();
            $("#ScrappedITAsset").show();
            $("#TransferITAssetDetails").show();
            $("#UpdateITAssetDetails").show();
            $("#DeleteITAssetDetails").show();
        }
        else if (RoleUser == 'HR') {

            // ITAssetDetails
            $("#CreateButtonITAsset").hide();
            $("#RevokeButton").hide();
            $("#RepairButton").hide();
            $("#ScrappedITAsset").hide();
            $("#TransferITAssetDetails").hide();
            $("#UpdateITAssetDetails").hide();
            $("#DeleteITAssetDetails").hide();
        }
        else if (RoleUser == "SUPERUSER") {

            // ITAssetDetails
            $("#CreateButtonITAsset").show();
            $("#RevokeButton").show();
            $("#RepairButton").show();
            $("#ScrappedITAsset").show();
            $("#TransferITAssetDetails").show();
            $("#UpdateITAssetDetails").show();
            $("#DeleteITAssetDetails").show();
        }
        else if (RoleUser == "USER") {
            $("#CreateButtonITAsset").hide();
            $("#AssignITAssetDetails").hide();
            $("#RevokeButton").hide();
            $("#RepairButton").hide();
            $("#ScrappedITAsset").hide();
            $("#UpdateITAssetDetails").hide();
        }

        var rowId = $(this).data('rowid1');
        var data = ScrappedGrid.jqGrid('getRowData', rowId);
        var purchaseYear = moment(data.PurchaseYear, 'DD-MM-YYYY').format('yyyy-MM-DD');
        //$('#RevokeButton').show();
        //$('#RepairButton').show();
        //$('#ScrappedITAsset').show();
        $('.ActivityData').hide();
        $('.ActivityData1').show();
        $('.ActivityData2').show();
        $('#CreateITAssetDetails').modal("show");
        $('.LastUserField').show();
        $('#SaveITAssetDetails').hide();
        $('#CreateAssetITText').hide();
        //$('#TransferITAssetDetails').show();
        //$('#UpdateITAssetDetails').show();
        //$('#DeleteITAssetDetails').show();
        $('#UpdateAssetITText').show();
        $('#AssetID').val(data.IDAsset);
        $('#UserID').val(data.UserID);
        $('#HostNameText').val(data.HostName);
        $('#IDAssetDisText').val(data.IDAssetDis);
        $('#AssetTypeText').selectpicker('val', data.AssetType);
        $('#BrandText').val(data.Brand);
        $('#FullNameText').val(data.FullName);
        $('#DomainITAsset').val(data.Domain);
        $('#ModelText').val(data.Model);
        $('#SerialNumberText').val(data.SerialNumber);
        $('#PurchaseYearText').val(purchaseYear);
        $('#OfficeText').val(data.Location);
        $('#UnitText').val(data.Unit);
        $('#CPUText').val(data.CPU);
        $('#MemoryText').val(data.Memory);
        $('#HDDText').val(data.HDD);
        $('#OSText').val(data.OS);
        // $('#LastUserText').val(data.LastUser);
        $('#SoftwareText').val(data.Software);
        $('#MonitorITAsset').val(data.Monitor);
        $('#KeyboardITAsset').val(data.Keyboard);
        $('#MouseITAsset').val(data.Mouse);
        $('#MSOfficeITAsset').val(data.MSOffice);
        $('#EmailIDITAsset').val(data.EmailID);
        $('#DesignationITAsset').val(data.Designation);
        $('#IDAssetDis').html(data.IDAssetDis);
        $('#DepartmentITAsset').val(data.Department);
        $('#LastAssetLocation').val(data.LastAssetLocation);
        var value = data.ActivityLog;
        var value1 = data.LastUser;
        value = value.replaceAll('\\n', '\n');
        value1 = value1.replaceAll('\\n', '\n');
        // value = value.substring(2);
        $('#ActivityLog').val(value);
        $('#LastUserText').val(value1);
        //var CreatedBy = data.CreatedBy;
        //var CreatedOn = data.CreatedOn;
        //var creationdetITAsset = "Created by " + CreatedBy + " on " + CreatedOn;
        //$('#CreationITAS').html(creationdetITAsset);
        var ModfiedBy = data.ModifiedBy;
        var ModifiedOn = data.ModifiedOn;
        var creationdetITAsset = "Modified by " + ModfiedBy + " on " + ModifiedOn;
        $('#CreationITAS').html(creationdetITAsset);
        $('#AssetIDText').val(data.AssetID);

        if (data.Status == 'DEACTIVE' || data.Status == 'SCRAPPED') {
            $("#UpdateITAssetDetails").hide();
            $("#ScrappedITAsset").hide();
            $("#RepairButton").hide();
            $("#DeactiveButton").hide();
        }
        else {
            $("#UpdateITAssetDetails").show();
            $("#ScrappedITAsset").show();
            $("#RepairButton").show();
            $("#DeactiveButton").show();
        }
    });

    $(document).on('click', '.getScrappedUpdate', function () {

        if (RoleUser == 'ADMIN') {

            $("#CreateButtonITAsset").show();
            $("#RevokeButton").show();
            $("#RepairButton").show();
            $("#ScrappedITAsset").show();
            $("#TransferITAssetDetails").show();
            $("#UpdateITAssetDetails").show();
            $("#DeleteITAssetDetails").show();
        }
        else if (RoleUser == 'HR') {

            // ITAssetDetails
            $("#CreateButtonITAsset").hide();
            $("#RevokeButton").hide();
            $("#RepairButton").hide();
            $("#ScrappedITAsset").hide();
            $("#TransferITAssetDetails").hide();
            $("#UpdateITAssetDetails").hide();
            $("#DeleteITAssetDetails").hide();
        }
        else if (RoleUser == "SUPERUSER") {

            // ITAssetDetails
            $("#CreateButtonITAsset").show();
            $("#RevokeButton").show();
            $("#RepairButton").show();
            $("#ScrappedITAsset").show();
            $("#TransferITAssetDetails").show();
            $("#UpdateITAssetDetails").show();
            $("#DeleteITAssetDetails").show();
        }
        else if (RoleUser == "USER") {
            $("#CreateButtonITAsset").hide();
            $("#AssignITAssetDetails").hide();
            $("#RevokeButton").hide();
            $("#RepairButton").hide();
            $("#ScrappedITAsset").hide();
            $("#UpdateITAssetDetails").hide();
        }

        var rowId = $(this).data('rowid1');
        var data = ScrappedGrid.jqGrid('getRowData', rowId);
        var purchaseYear = moment(data.PurchaseYear, 'DD-MM-YYYY').format('yyyy-MM-DD');
        //$('#RevokeButton').show();
        //$('#RepairButton').show();
        //$('#ScrappedITAsset').show();
        $('.ActivityData').hide();
        $('.ActivityData1').show();
        $('.ActivityData2').show();
        $('#CreateITAssetDetails').modal("show");
        $('.LastUserField').show();
        $('#SaveITAssetDetails').hide();
        $('#CreateAssetITText').hide();
        //$('#TransferITAssetDetails').show();
        //$('#UpdateITAssetDetails').show();
        //$('#DeleteITAssetDetails').show();
        $('#UpdateAssetITText').show();
        $('#AssetID').val(data.IDAsset);
        $('#UserID').val(data.UserID);
        $('#HostNameText').val(data.HostName);
        $('#AssetTypeText').selectpicker('val', data.AssetType);
        $('#BrandText').val(data.Brand);
        $('#FullNameText').val(data.FullName);
        $('#DomainITAsset').val(data.Domain);
        $('#ModelText').val(data.Model);
        $('#SerialNumberText').val(data.SerialNumber);
        $('#PurchaseYearText').val(purchaseYear);
        $('#OfficeText').val(data.Location);
        $('#UnitText').val(data.Unit);
        $('#CPUText').val(data.CPU);
        $('#MemoryText').val(data.Memory);
        $('#HDDText').val(data.HDD);
        $('#OSText').val(data.OS);
        // $('#LastUserText').val(data.LastUser);
        $('#SoftwareText').val(data.Software);
        $('#MonitorITAsset').val(data.Monitor);
        $('#KeyboardITAsset').val(data.Keyboard);
        $('#MouseITAsset').val(data.Mouse);
        $('#MSOfficeITAsset').val(data.MSOffice);
        $('#EmailIDITAsset').val(data.EmailID);
        $('#DesignationITAsset').val(data.Designation);
        $('#IDAssetDis').html(data.IDAssetDis);
        $('#DepartmentITAsset').val(data.Department);
        $('#LastAssetLocation').val(data.LastAssetLocation);
        var value = data.ActivityLog;
        var value1 = data.LastUser;
        value = value.replaceAll('\\n', '\n');
        value1 = value1.replaceAll('\\n', '\n');
        // value = value.substring(2);
        $('#ActivityLog').val(value);
        $('#LastUserText').val(value1);
        //var CreatedBy = data.CreatedBy;
        //var CreatedOn = data.CreatedOn;
        //var creationdetITAsset = "Created by " + CreatedBy + " on " + CreatedOn;
        //$('#CreationITAS').html(creationdetITAsset);
        var ModfiedBy = data.ModifiedBy;
        var ModifiedOn = data.ModifiedOn;
        var creationdetITAsset = "Modified by " + ModfiedBy + " on " + ModifiedOn;
        $('#CreationITAS').html(creationdetITAsset);
        $('#AssetIDText').val(data.AssetID);

        if (data.Status == 'DEACTIVE' || data.Status == 'SCRAPPED') {
            $("#UpdateITAssetDetails").hide();
            $("#ScrappedITAsset").hide();
            $("#RepairButton").hide();
            $("#DeactiveButton").hide();
        }
        else {
            $("#UpdateITAssetDetails").show();
            $("#ScrappedITAsset").show();
            $("#RepairButton").show();
            $("#DeactiveButton").show();
        }
    });

    $("#ActivityLog").attr('readonly', 'readonly');
    $("#FullNameText").attr('readonly', 'readonly');
    $("#IDAssetDisText").attr('readonly', 'readonly');
    $("#EmailIDITAsset").attr('readonly', 'readonly');
    $("#DesignationITAsset").attr('readonly', 'readonly');
    $("#DepartmentITAsset").attr('readonly', 'readonly');
    $("#LastUserText").attr('readonly', 'readonly'); 
    $("#OfficeText").attr('readonly', 'readonly');
    $("#DomainITAsset").attr('readonly', 'readonly');
    $("#LastAssetLocation").attr('readonly', 'readonly');

    $('#ExportExcelITAsset').click(function () {
        var HostName = $("#HostNameITAsset").val();
        var AssetType = $("#AssetTypeITAsset").val();
        var Brand = $("#BrandITAsset").val();
        var Model = $("#ModelITAsset").val();
        var Status = $("#StatusITAsset").val();
        var FullName = $("#FullNameITAsset").val();
        var Location = $("#LocationITAssetDetails").val();
        var SerialNumber = $("#SerialNrITAssetDetails").val();
        var Country = $("#CountryITAsset").val();
        var Domain = $("#DomainDRITAsset").val();
        var IDAssetDis = $("#AssetIDITAsset").val();
        var AssetID = $('#AssetIDAsset').val();
        var url = '../Home/ExportITAssetData?HostName=' + HostName + '&&AssetType=' + AssetType + '&&Brand=' + Brand + '&&Model=' + Model + '&&Status=' + Status + '&&FullName=' + FullName + '&&Location=' + Location + '&&SerialNumber=' + SerialNumber + '&&Country=' + Country + '&&Domain=' + Domain + '&&IDAssetDis=' + IDAssetDis + '&&AssetID=' + AssetID;
        window.open(url);
    });

    $('#ExportExcelITAsset1').click(function () {
        var HostName = $("#HostNameITAsset").val();
        var AssetType = $("#AssetTypeITAsset").val();
        var Brand = $("#BrandITAsset").val();
        var Model = $("#ModelITAsset").val();
        var Status = $("#StatusITAsset").val();
        var FullName = $("#FullNameITAsset").val();
        var Location = $("#LocationITAssetDetails").val();
        var SerialNumber = $("#SerialNrITAssetDetails").val();
        var Country = $("#CountryITAsset").val();
        var Domain = $("#DomainDRITAsset").val();
        var IDAssetDis = $("#AssetIDITAsset").val();
        var AssetID = $('#AssetIDAsset').val();
        var url = '../Home/ExportITAssetData1?HostName=' + HostName + '&&AssetType=' + AssetType + '&&Brand=' + Brand + '&&Model=' + Model + '&&Status=' + Status + '&&FullName=' + FullName + '&&Location=' + Location + '&&SerialNumber=' + SerialNumber + '&&Country=' + Country + '&&Domain=' + Domain + '&&IDAssetDis=' + IDAssetDis + '&&AssetID=' + AssetID;
        window.open(url);
    });

    $('#ExportExcelITAsset2').click(function () {
        var HostName = $("#HostNameITAsset").val();
        var AssetType = $("#AssetTypeITAsset").val();
        var Brand = $("#BrandITAsset").val();
        var Model = $("#ModelITAsset").val();
        var Status = $("#StatusITAsset").val();
        var FullName = $("#FullNameITAsset").val();
        var Location = $("#LocationITAssetDetails").val();
        var SerialNumber = $("#SerialNrITAssetDetails").val();
        var Country = $("#CountryITAsset").val();
        var Domain = $("#DomainDRITAsset").val();
        var IDAssetDis = $("#AssetIDITAsset").val();
        var AssetID = $('#AssetIDAsset').val();
        var url = '../Home/ExportITAssetData2?HostName=' + HostName + '&&AssetType=' + AssetType + '&&Brand=' + Brand + '&&Model=' + Model + '&&Status=' + Status + '&&FullName=' + FullName + '&&Location=' + Location + '&&SerialNumber=' + SerialNumber + '&&Country=' + Country + '&&Domain=' + Domain + '&&IDAssetDis=' + IDAssetDis + '&&AssetID=' + AssetID;
        window.open(url);
    });

    $(document).on('change', '#ITAssetStatus', function () {
        var idRecords = $('#AssetID').val();
        if ($('#ITAssetstatus').is(":checked")) {
            ChangeStatusActiveDeactiveITAsset("ACTIVE", idRecords);
        }
        else {
            ChangeStatusActiveDeactiveITAsset("DEACTIVE", idRecords);
        }
    });

    $("#SearchITAssetDetails").click(function () {
        $("#loading").show();
        var HostName = $('#HostNameITAsset').val();
        var AssetType = $('#AssetTypeITAsset').val();
        var Brand = $('#BrandITAsset').val();
        var Model = $('#ModelITAsset').val();
        var Office = $('#OfficeITAsset').val();
        var FullName = $('#FullNameITAsset').val();
        var Location = $('#LocationITAssetDetails').val();
        var SerialNumber = $('#SerialNrITAssetDetails').val();
        var LastUser = $('#LastUserITAsset').val();
        var Country = $('#CountryITAsset').val();
        var Domain = $('#DomainDRITAsset').val();
        var IDAssetDis = $('#AssetIDITAsset').val();
        var AssetID = $('#AssetIDAsset').val();
        if (HostName != "" || AssetType != "" || Brand != "" || Model != "" || Office != "" || FullName != "" || Location != "" || SerialNumber != "" || Country != "" || LastUser != "" || Domain != "") {
            $.ajax({
                type: "POST",
                url: 'SearchButtonITAsset',
                data: {
                    IDAssetDis,
                    HostName,
                    AssetType,
                    Brand,
                    Model,
                    Office,
                    FullName,
                    Location,
                    SerialNumber,
                    Country,
                    LastUser,
                    Domain,
                    AssetID
                },

                datatype: "json",
                success: function (result) {
                    if (result.success) {
                        //$('#ScrappedFieldset').show();
                        reload('ITAssetDetailsGrid');
                        reload('AssignedGrid');
                        reload('ScrappedGrid')
                        $('#successToastMessage').text('Search successfully');
                        $('#successToast').toast("show");
                        $("#loading").hide();
                    }

                }
            });
        }
        else {
            $('#warningToastMessage').text('No search parameter selected.');
            $('#warningToast').toast("show");
            $('#loading').hide();
        }
    });

    $("#SaveITAssetDetails").click(function () {
        modelOpen = 1;
        checkValidationITA("SAVE");
    });

    $("#SaveITAssetDetails").click(function () {
        $("#loading").show();
        var HostName = $('#HostNameText').val().toUpperCase();
        var AssetType = $('#AssetTypeText').val().toUpperCase();
        var Brand = $('#BrandText').val().toUpperCase();
        var Model = $('#ModelText').val().toUpperCase();
        var SerialNumber = $('#SerialNumberText').val().toUpperCase();
        var PurchaseYear = $('#PurchaseYearText').val();
        var Location = $('#OfficeText').val();
        var Unit = $('#UnitText').val();
        var CPU = $('#CPUText').val().toUpperCase();
        var Memory = $('#MemoryText').val().toUpperCase();
        var HDD = $('#HDDText').val().toUpperCase();
        var OS = $('#OSText').val().toUpperCase();
        var Software = $('#SoftwareText').val().toUpperCase();
        var Remark = $('#RemarkText').val().toUpperCase();
        var LastUser = $('#LastUserText').val().toUpperCase();
        var Monitor = $('#MonitorITAsset').val().toUpperCase();
        var Keyboard = $('#KeyboardITAsset').val().toUpperCase();
        var Mouse = $('#MouseITAsset').val().toUpperCase();
        var MSOffice = $('#MSOfficeITAsset').val().toUpperCase();
        var Domain = $('#DomainITAsset').val().toUpperCase();
        var AssetID = $('#AssetIDText').val().toUpperCase();

        if (AssetType == '' || Brand == '' || Model == '' || SerialNumber == '' || PurchaseYear == "") {
            $('#warningToastMessage').text('Please fill mandatory fields.');
            $('#warningToast').toast("show");
            $("#loading").hide();
        }
        else {
            $.ajax({
                type: "POST",
                url: 'SaveITAssetDetails2',
                //url: '../Home/SaveITAssetDetails2',
                data: {
                    HostName,
                    AssetType,
                    Brand,
                    Model,
                    SerialNumber,
                    PurchaseYear,
                    Location,
                    Unit,
                    CPU,
                    Memory,
                    HDD,
                    Memory,
                    HDD,
                    OS,
                    Software,
                    Remark,
                    LastUser,
                    Monitor,
                    Keyboard,
                    Mouse,
                    MSOffice,
                    Domain,
                    AssetID
                },
                dataType: "json",
                success: function (result) {
                    if (result.success) {
                        reload('ITAssetDetailsGrid');
                        $('#successToastMessage').text('Asset Created Successfully');
                        $('#successToast').toast("show");
                        $('#CreateITAssetDetails').modal("hide");
                        $("#loading").hide();
                        window.location.reload();
                        DestroyRenderITAssetDropdowns();
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

    $("#UpdateITAssetDetails").click(function () {
        modelOpen = 1;
        checkValidationITA("UPDATE");
    });

    $("#UpdateITAssetDetails").click(function () {
        $("#loading").show();
        var IDAsset = $('#AssetID').val();
        var HostName = $('#HostNameText').val().toUpperCase();
        var AssetType = $('#AssetTypeText').val().toUpperCase();
        var Brand = $('#BrandText').val().toUpperCase();
        var Model = $('#ModelText').val().toUpperCase();
        var SerialNumber = $('#SerialNumberText').val().toUpperCase();
        var PurchaseYear = $('#PurchaseYearText').val();
        var Location = $('#OfficeText').val();
        var Unit = $('#UnitText').val();
        var CPU = $('#CPUText').val().toUpperCase();
        var Memory = $('#MemoryText').val().toUpperCase();
        var HDD = $('#HDDText').val().toUpperCase();
        var OS = $('#OSText').val().toUpperCase();
        var Software = $('#SoftwareText').val().toUpperCase();
        var Remark = $('#RemarkText').val().toUpperCase();
        var LastUser = $('#LastUserText').val().toUpperCase();
        var Monitor = $('#MonitorITAsset').val().toUpperCase();
        var Keyboard = $('#KeyboardITAsset').val().toUpperCase();
        var Mouse = $('#MouseITAsset').val().toUpperCase();
        var MSOffice = $('#MSOfficeITAsset').val().toUpperCase();
        var EmailID = $('#EmailIDITAsset').val();
        var Designation = $('#DesignationITAsset').val();
        var Domain = $('#DomainITAsset').val();
        var Department = $('#DepartmentITAsset').val();
        var AssetID = $('#AssetIDText').val().toUpperCase();

        if (AssetType == "" || Brand == "" || Model == "" || SerialNumber == "" || PurchaseYear == "") {
            $('#warningToastMessage').text('Please fill mandatory fields.');
            $('#warningToast').toast("show");
            $("#loading").hide();
        }
        else {

            $.ajax({
                type: "POST",
                url: 'SaveITAssetDetails2',
                //url: '../Home/SaveITAssetDetails2',
                data: {
                    IDAsset,
                    HostName,
                    AssetType,
                    Brand,
                    Model,
                    SerialNumber,
                    PurchaseYear,
                    Location,
                    Unit,
                    CPU,
                    Memory,
                    HDD,
                    Memory,
                    HDD,
                    OS,
                    Software,
                    Remark,
                    LastUser,
                    Monitor,
                    Keyboard,
                    Mouse,
                    MSOffice,
                    EmailID,
                    Designation,
                    Department,
                    Domain,
                    AssetID
                },
                dataType: "json",
                success: function (result) {
                    if (result.success) {
                        reload('ITAssetDetailsGrid');
                        $('#successToastMessage').text('Asset Updated Successfully');
                        $('#successToast').toast("show");
                        $('#CreateITAssetDetails').modal("hide");
                        $("#loading").hide();
                        DestroyRenderITAssetDropdowns();
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
        }
    })

    $("#DeleteITAssetDetails").click(function () {
        $('#loading').show();
        var IDAsset = $('#AssetID').val();
        {
            $.ajax({
                type: "POST",
                url: 'DeleteITAssetDetails',
                data: {
                    IDAsset
                },
                dataType: "json",
                success: function (result) {
                    if (result.response) {
                        reload('ITAssetDetailsGrid');
                        $('#loading').hide();
                        $('#successToastMessage').text('Asset Deleted Successfully');
                        $('#successToast').toast("show");
                        $('#CreateITAssetDetails').modal("hide");
                        DestroyRenderUDDropdowns();
                    }

                }
            });
        }
    })

    $("#TransferITAssetDetails").click(function () {
        $("#loading").show();
        var IDAsset = $('#AssetID').val();
        var HostName = $('#HostNameText').val().toUpperCase();
        var AssetType = $('#AssetTypeText').val().toUpperCase();
        var Brand = $('#BrandText').val().toUpperCase();
        var Model = $('#ModelText').val().toUpperCase();
        var SerialNumber = $('#SerialNumberText').val().toUpperCase();
        var PurchaseYear = $('#PurchaseYearText').val();
        var Location = $('#OfficeText').val();
        var Unit = $('#UnitText').val();
        var CPU = $('#CPUText').val().toUpperCase();
        var Memory = $('#MemoryText').val().toUpperCase();
        var HDD = $('#HDDText').val().toUpperCase();
        var OS = $('#OSText').val().toUpperCase();
        var Software = $('#SoftwareText').val().toUpperCase();
        var Remark = $('#RemarkText').val().toUpperCase();
        var LastUser = $('#LastUserText').val().toUpperCase();
        var Monitor = $('#MonitorITAsset').val().toUpperCase();
        var Keyboard = $('#KeyboardITAsset').val().toUpperCase();
        var Mouse = $('#MouseITAsset').val().toUpperCase();
        var MSOffice = $('#MSOfficeITAsset').val().toUpperCase();
        if (AssetType == '' || Brand == '' || Model == '' || SerialNumber == '' || Location == '') {
            $('#warningToastMessage').text('Please fill mandatory fields.');
            $('#warningToast').toast("show");
            $("#loading").hide();
        }
        else {
            $.ajax({
                type: "POST",
                url: 'TransferITAssetDetails',
                data: {
                    IDAsset,
                    HostName,
                    AssetType,
                    Brand,
                    Model,
                    SerialNumber,
                    PurchaseYear,
                    Location,
                    Unit,
                    CPU,
                    Memory,
                    HDD,
                    Memory,
                    HDD,
                    OS,
                    Software,
                    Remark,
                    LastUser,
                    Monitor,
                    Keyboard,
                    Mouse,
                    MSOffice
                },
                dataType: "json",
                success: function (result) {
                    if (result.success) {
                        reload('ITAssetDetailsGrid');
                        $('#successToastMessage').text('Asset Transfered Successfully');
                        $('#successToast').toast("show");
                        $('#CreateITAssetDetails').modal("hide");
                        $("#loading").hide();
                        DestroyRenderITAssetDropdowns();
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
        }
    })

    $("#ResetITAssetDetails").click(function () {
        $('#loading').show();
        $('#HostNameITAsset').selectpicker('val', '');
        $('#AssetTypeITAsset').selectpicker('val', '');
        $('#BrandITAsset').selectpicker('val', '');
        $('#ModelITAsset').selectpicker('val', '');
        $('#StatusITAsset').selectpicker('val', '');
        $('#FullNameITAsset').selectpicker('val', '');
        $('#LocationITAssetDetails').selectpicker('val', '');
        $('#SerialNrITAssetDetails').selectpicker('val', '');
        $('#CountryITAsset').selectpicker('val', '');
        $('#LastUserITAsset').selectpicker('val', '');
        $('#DomainDRITAsset').selectpicker('val', '');
        $('#AssetIDITAsset').selectpicker('val', '');
        $('#AssetIDAsset').selectpicker('val', '');
        $.ajax({
            type: "POST",
            url: 'ResetButtonITAsset',
            dataType: "json",
            success: function (result) {
                //$('#ScrappedFieldset').hide();
                reload('ITAssetDetailsGrid');
                reload('AssignedGrid');
                reload('ScrappedGrid');
                $('#loading').hide();
                $('#successToastMessage').text('Reset successfully');
                $('#successToast').toast("show");
            }
        });
    });

    $('#CreateButtonITAsset').click(function () {
        $('#UpdateITAssetDetails').hide();
        $('#DeleteITAssetDetails').hide();
        $('#UpdateAssetITText').hide();
        $('#TransferITAssetDetails').hide();
        $('.ActivityData').hide();
        $('.ActivityData1').hide();
        $('.ActivityData2').hide();
        $('#SaveITAssetDetails').show();
        $('#CreateAssetITText').show();
        $('.LastUserField').hide();
        $('#AssetID').val('');
        $('#HostNameText').val('');
        $('#AssetTypeText').selectpicker('val', '');
        $('#BrandText').selectpicker('val', '');
        $('#ModelText').val('');
        $('#SerialNumberText').val('');
        $('#PurchaseYearText').val('');
        $('#OfficeText').selectpicker('val', '');
        $('#UnitText').val('');
        $('#CPUText').val('');
        $('#MemoryText').val('');
        $('#HDDText').val('');
        $('#OSText').val('');
        $('#SoftwareText').val('');
        $('#MSOfficeITAsset').val('');
        $('#MouseITAsset').val('');
        $('#KeyboardITAsset').val('');
        $('#MonitorITAsset').val('');
        $('#EmailIDITAsset').val('');
        $('#DesignationITAsset').val('');
        $('#LastUserText').val('');
        $('#StatusText').val('');
        $('#DomainITAsset').val('');
        $("#IDAssetDis").html("New IT Asset");
        $("#statusITAsset").hide();
        $('#CreationITAS').html("");
        $('#RevokeButton').hide();
        $('#RepairButton').hide();
        $('#DeactiveButton').hide();
        $('#ScrappedITAsset').hide();
        $('#BrandText').val('')
        $('#RemarkText').val('')
    });

    $('#AssignAsset').click(function () {
        $('#AssignAssetModal').modal('show');
        $("#IDAssignAsset").html("Assign User");
    });

    $(".checkValidITA").change(function () {
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

    $(".checkValidita").focus(function () {
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

    $(".checkValidita").blur(function () {
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

    $('#CloseITAsset').click(function () {
        modelOpen = 0;

        var mydivs = $(".checkValidita");
        for (var i = 0; i < mydivs.length; i++) {
            if ($(mydivs[i]).hasClass('is-valid') == true) {
                $(mydivs[i]).removeClass('is-valid');
            }
            else if ($(mydivs[i]).hasClass('is-invalid') == true) {
                $(mydivs[i]).removeClass('is-invalid');
            }
        }
        var mydivs1 = $(".checkValidITA").closest('select');
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

    $(".checkValidASSIGN").change(function () {
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

    $("#AssignDetails").click(function () {
        $("#loading").show();
        var SerialNumber = $('#SerialNumberAssign').val();
        var FullName = $('#FullNameAssign').val();
        if (SerialNumber == '' || FullName == '') {
            $('#warningToastMessage').text('Please Fill Required Fields.');
            $('#warningToast').toast("show");
            $("#loading").hide();
        }
        else {
            $.ajax({
                type: "POST",
                url: 'AssignITAsset',
                data: {
                    SerialNumber,
                    FullName
                },
                dataType: "json",
                success: function (data) {
                    if (data) {
                        $('#AssignModal').modal("hide");
                        //reloadGridsByID(UserID);
                        $('#successToastMessage').text('Asset Assigned Successfully');
                        $('#successToast').toast("show");
                        UpdateAssestStatus("ASSIGNED");
                        reload('AssignGrid');
                        reload('ITAssetDetailsGrid');
                        $("#loading").hide();
                        window.location.reload();
                    }
                    else {
                        $('#warningToastMessage').text('No search parameter selected.');
                        $('#warningToast').toast("show");
                        $("#loading").hide();
                    }
                }
            });
        }
    });

    $('#AssignITAssetDetails').click(function () {
        $('#AssignModal').modal("show");
        $("#IDUserAssign").html("Assign User");
        //$('#RoleUD').selectpicker('val', '');
        //$('#HostNameAssign').selectpicker('val', '');
        //$('#ModelAssign').selectpicker('val', '');
        $('#SerialNumberAssign').selectpicker('val', '');
        //$('#AssetTypeAssign').selectpicker('val', '');
        //$('#BrandAssign').selectpicker('val', '');
        $('#FullNameAssign').selectpicker('val', '');
        DestroyRenderDropdowns();
    });

    $('#CloseAssign').click(function () {
        modelOpen = 0;

        var mydivs = $(".checkValidassign");
        for (var i = 0; i < mydivs.length; i++) {
            if ($(mydivs[i]).hasClass('is-valid') == true) {
                $(mydivs[i]).removeClass('is-valid');
            }
            else if ($(mydivs[i]).hasClass('is-invalid') == true) {
                $(mydivs[i]).removeClass('is-invalid');
            }
        }
        var mydivs1 = $(".checkValidASSIGN").closest('select');
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
        //var HostNameAssign = $("#HostNameAssign");
        //HostNameAssign.find('option').remove();
        //HostNameAssign.selectpicker('destroy');

        //var AssetTypeAssign = $("#AssetTypeAssign");
        //AssetTypeAssign.find('option').remove();
        //AssetTypeAssign.selectpicker('destroy');

        //var BrandAssign = $("#BrandAssign");
        //BrandAssign.find('option').remove();
        //BrandAssign.selectpicker('destroy');

        //var ModelAssign = $("#ModelAssign");
        //ModelAssign.find('option').remove();
        //ModelAssign.selectpicker('destroy');

        //var SerialNumberAssign = $("#SerialNumberAssign");
        //SerialNumberAssign.find('option').remove();
        //SerialNumberAssign.selectpicker('destroy');
    });

    $("#AssignDetails").click(function () {
        modelOpen = 1;
        checkValidationAssign("SAVE");
    });

    $("#RevokeButton").click(function () {
        $("#loading").show();
        //var SelectedRows = AssignGrid.jqGrid('getGridParam', 'selarrrow');
        UpdateAssestStatus1("AVAILABLE");
        reload('ITAssetDetailsGrid');
        reload('AssignGrid');
        $("#loading").hide();
        window.location.reload();
    });

    $("#RepairButton").click(function () {
        $("#loading").show();
        //var SelectedRows = AssignGrid.jqGrid('getGridParam', 'selarrrow');
        UpdateAssestStatus1("REPAIR");
        reload('ITAssetDetailsGrid');
        reload('AssignGrid');
        $("#loading").hide();
        window.location.reload();
    });

    $("#ScrappedITAsset").click(function () {
        $("#loading").show();
        //var SelectedRows = AssignGrid.jqGrid('getGridParam', 'selarrrow');
        UpdateAssestStatus1("SCRAPPED");
        reload('ITAssetDetailsGrid');
        reload('AssignGrid');
        $("#loading").hide();
        window.location.reload();
    });

    $("#DeactiveButton").click(function () {
        $("#loading").show();
        //var SelectedRows = AssignGrid.jqGrid('getGridParam', 'selarrrow');
        UpdateAssestStatus1("DEACTIVE");
        reload('ITAssetDetailsGrid');
        reload('AssignGrid');
        $("#loading").hide();
        window.location.reload();
    });

    $("#user-nav-tabs li").on('click', function (e) {
        var targetLink = $(e.currentTarget.children[0]).attr("href").slice(1);

        var content_map = {
            c1: "#content1",
            c2: "#content2"
        }

        $(e.currentTarget).siblings().removeClass("active");

        $.each(content_map, function (hash, elid) {
            if (hash == targetLink) {
                $(elid).show();
                $(e.currentTarget).addClass("active");
            } else {
                $(elid).hide();
            }
        });
    });

})

function reload(tableName) {
    currentPage = $('#' + tableName).getGridParam('page');
    $('#' + tableName).setGridParam({ datatype: "json" }).trigger('reloadGrid');
}

function ChangeStatusActiveDeactiveITAsset(status, idAsset) {
    $.ajax({
        type: "POST",
        url: 'GetStatusITAsset',
        data: {
            status,
            idAsset
        },
        dataType: 'json',
        success: function (result) {
            reload('ITAssetDetailsGrid');
            $('#successToastMessage').text('Status Updated successfully');
            $('#successToast').toast("show");
            window.location.reload();
        }
    });
}

function checkValidationITA(type) {
    var mydivs = $(".checkValidita")
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
    var mydivs1 = $(".checkValidITA").closest('select')
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

function checkValidationAssign(type) {
    var mydivs = $(".checkValidassign")
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
    var mydivs1 = $(".checkValidASSIGN").closest('select')
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

function UpdateAssestStatus(Status) {
    //var  = $('#UserID').val();
    var UserID = $('#FullNameAssign').val();
    var SerialNr = $('#SerialNumberAssign').val();
    $.ajax({
        type: "POST",
        url: 'UpdateAssetStatus',
        data: {
            Status,
            UserID,
            SerialNr
        },
        dataType: "json",
        success: function (data) {
            if (data) {
                $('#CreateITAssetDetails').modal('hide');
                reload('ITAssetDetailsGrid');
                $('#successToastMessage').text('Asset Updated Successfully');
                $('#successToast').toast("show");
                window.location.reload();
            }
            else {
                $('#warningToastMessage').text('No search parameter selected.');
                $('#warningToast').toast("show");
            }
        }
    });
}

function UpdateAssestStatus1(Status) {
    //var  = $('#UserID').val();
    var UserID = $('#UserID').val();
    var SerialNr = $('#SerialNumberText').val();
    $.ajax({
        type: "POST",
        url: 'UpdateAssetStatus',
        data: {
            Status,
            UserID,
            SerialNr
        },
        dataType: "json",
        success: function (data) {
            if (data) {
                $('#CreateITAssetDetails').modal('hide');
                reload('ITAssetDetailsGrid');
                $('#successToastMessage').text('Asset Updated Successfully');
                $('#successToast').toast("show");
                window.location.reload();
            }
            else {
                $('#warningToastMessage').text('No search parameter selected.');
                $('#warningToast').toast("show");
            }
        }
    });
}

function DestroyRenderDropdowns() {

    var EXSerialnumber = $("#SerialNumberAssign");

    $.ajax({
        type: "GET",
        url: 'DestroyRenderDropdowns',
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

            EXSerialnumber.find('option').remove();
            EXSerialnumber.selectpicker('destroy');
            if (data.serialNoList.length > 0) {
                EXSerialnumber.append('<option value>Select SerialNumber</option>');
                for (var i = 0; i < data.serialNoList.length; i++) {
                    EXSerialnumber.append("<option value='" + data.serialNoList[i].text + "'>" + data.serialNoList[i].text + "</option>");
                }
                renderDropdown(EXSerialnumber);
            }
        },
        error: function (xhr, ajaxOptions, thrownError) {
            $("#errorToastMessage").text('Failed to retrieve data');
            $("#errorToast").toast("show");
        }
    });
}

function DestroyRenderITAssetDropdowns() {

    var EXHostName = $("#HostNameITAsset");
    var EXAssetType = $("#AssetTypeITAsset");
    var EXBrand = $("#BrandITAsset");
    var EXModel = $("#ModelITAsset");
    var EXCountry = $("#CountryITAsset");
    var EXStatus = $("#StatusITAsset");
    var EXFullName = $("#FullNameITAsset");
    var EXLocation = $("#LocationITAssetDetails");
    var EXSerialNr = $("#SerialNrITAssetDetails");

    $.ajax({
        type: "GET",
        url: 'DestroyRenderITAssetDropdowns',
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


            if (data.hostNameList.length > 0) {
                EXHostName.find('option').remove();
                EXHostName.selectpicker('destroy');

                EXHostName.append('<option value>Select HostName</option>');
                for (var i = 0; i < data.hostNameList.length; i++) {
                    EXHostName.append("<option value='" + data.hostNameList[i].text + "'>" + data.hostNameList[i].text + "</option>");
                }
                renderDropdown(EXHostName);
                //EXChargePartyCompany.selectpicker('val', EXChargePartyCompany);
            }
            if (data.assetTypeList.length > 0) {
                EXAssetType.find('option').remove();
                EXAssetType.selectpicker('destroy');

                EXAssetType.append('<option value>Select AssetType</option>');
                for (var i = 0; i < data.assetTypeList.length; i++) {
                    EXAssetType.append("<option value='" + data.assetTypeList[i].text + "'>" + data.assetTypeList[i].text + "</option>");
                }
                renderDropdown(EXAssetType);
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
            if (data.modelList.length > 0) {
                EXModel.find('option').remove();
                EXModel.selectpicker('destroy');

                EXModel.append('<option value>Select Model</option>');
                for (var i = 0; i < data.modelList.length; i++) {
                    EXModel.append("<option value='" + data.modelList[i].text + "'>" + data.modelList[i].text + "</option>");
                }
                renderDropdown(EXModel);
                //EXChargePartyCompany.selectpicker('val', EXChargePartyCompany);
            }
            if (data.CountryList.length > 0) {
                EXCountry.find('option').remove();
                EXCountry.selectpicker('destroy');

                EXCountry.append('<option value>Select Country</option>');
                for (var i = 0; i < data.CountryList.length; i++) {
                    EXCountry.append("<option value='" + data.CountryList[i].text + "'>" + data.CountryList[i].text + "</option>");
                }
                renderDropdown(EXCountry);
                //EXChargePartyCompany.selectpicker('val', EXChargePartyCompany);
            }
            if (data.statusList.length > 0) {
                EXStatus.find('option').remove();
                EXStatus.selectpicker('destroy');

                EXStatus.append('<option value>Select Status</option>');
                for (var i = 0; i < data.statusList.length; i++) {
                    EXStatus.append("<option value='" + data.statusList[i].text + "'>" + data.statusList[i].text + "</option>");
                }
                renderDropdown(EXStatus);
                //EXChargePartyCompany.selectpicker('val', EXChargePartyCompany);
            }
            if (data.fullNameList.length > 0) {
                EXFullName.find('option').remove();
                EXFullName.selectpicker('destroy');

                EXFullName.append('<option value>Select Full Name</option>');
                for (var i = 0; i < data.fullNameList.length; i++) {
                    EXFullName.append("<option value='" + data.fullNameList[i].text + "'>" + data.fullNameList[i].text + "</option>");
                }
                renderDropdown(EXFullName);
                //EXChargePartyCompany.selectpicker('val', EXChargePartyCompany);
            }
            if (data.LocationList.length > 0) {
                EXLocation.find('option').remove();
                EXLocation.selectpicker('destroy');

                EXLocation.append('<option value>Select Location</option>');
                for (var i = 0; i < data.LocationList.length; i++) {
                    EXLocation.append("<option value='" + data.LocationList[i].text + "'>" + data.LocationList[i].text + "</option>");
                }
                renderDropdown(EXLocation);
                //EXChargePartyCompany.selectpicker('val', EXChargePartyCompany);
            }
            if (data.SerialNrList.length > 0) {
                EXSerialNr.find('option').remove();
                EXSerialNr.selectpicker('destroy');

                EXSerialNr.append('<option value>Select Full Name</option>');
                for (var i = 0; i < data.SerialNrList.length; i++) {
                    EXSerialNr.append("<option value='" + data.SerialNrList[i].text + "'>" + data.SerialNrList[i].text + "</option>");
                }
                renderDropdown(EXSerialNr);
                //EXChargePartyCompany.selectpicker('val', EXChargePartyCompany);
            }
        },
        error: function (xhr, ajaxOptions, thrownError) {
            $("#errorToastMessage").text('Failed to retrieve data');
            $("#errorToast").toast("show");
        }
    });
}