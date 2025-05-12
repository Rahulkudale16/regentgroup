var Region = '';
var Country = '';
var Location1 = '';
$(document).ready(function () {
    //------------------------------------------------- IT Asset Grid Starts -----------------------------------------------------------//
    DashboardGrid = $('#DashboardGrid').jqGrid({
        mtype: 'Get',
        url: 'GetITAssetdata',
        //editurl: '',
        datatype: 'json',
        colNames: ['ID', 'ID', '', 'ID', 'IDLocation', 'Host Name', 'Asset Type', 'Brand', 'Model', 'Serial Number', 'Purchase Year', 'EmailID', 'Designation', 'FullName', 'LastUser', 'Location', 'Region', 'Country', 'Unit', 'CPU', 'Memory', 'HDD', 'OS', 'Software', 'Remark','Domain', 'Status', 'ActivityLog', 'CreatedBy', 'CreatedOn', 'ModifiedBy', 'ModifiedOn', 'Monitor', 'Keyboard', 'Mouse', 'MS-Office', 'HeadPhone', 'Department', 'Status', 'View'],
        colModel: [
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
                hidden: true,
                name: 'SerialNumber',
                editable: false,
                width: '130px',
            },
            {
                key: false,
                hidden: true,
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
                name: 'viewStatus',
                editable: false,
                width: '105px',
            },
            {
                key: false,
                hidden: true,
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
        pager: '#DashboardPager',
        rowNum: 5,
        rowList: [5, 10, 15, 20],
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
            $("#DashboardPager_left").hide();
        },
        gridComplete: function () {  //Active-Deactive Toggle in Table grid
            //var selectedRowIds = myGrid1.jqGrid('getGridParam', 'selarrrow');
            var selectedRowIds = DashboardGrid.jqGrid('getGridParam', 'data');
            //var selectedRowData = [];
            for (selectedRowIndex = 0; selectedRowIndex < selectedRowIds.length; selectedRowIndex++) {
                var temp_var = selectedRowIds[selectedRowIndex]['_id_'];
                var idAsset = selectedRowIds[selectedRowIndex]['IDAsset'];
                var idAssetDis = selectedRowIds[selectedRowIndex]['IDAssetDis'];
                var ITAssetstatus = selectedRowIds[selectedRowIndex]['Status'];

                if (ITAssetstatus.toUpperCase() == "AVAILABLE") {
                    selectedRowIds[selectedRowIndex]['viewStatus'] = "<span class='badge bg-success bg-gradient'>AVAILABLE</span>";
                }
                else if (ITAssetstatus.toUpperCase() == "ASSIGNED") {
                    selectedRowIds[selectedRowIndex]['viewStatus'] = "<span class='badge bg-warning bg-gradient'>ASSIGNED</span>";
                }
                else if (ITAssetstatus.toUpperCase() == "REPAIR") {
                    selectedRowIds[selectedRowIndex]['viewStatus'] = "<span class='badge bg-danger bg-gradient'>REPAIR</span>";
                }
                else if (ITAssetstatus.toUpperCase() == "SCRAPPED") {
                    selectedRowIds[selectedRowIndex]['viewStatus'] = "<span class='badge bg-secondary bg-gradient'>SCRAPPED</span>";
                }

                selectedRowIds[selectedRowIndex]['view'] = "<button style='border:none; background:transparent;'>" + idAssetDis + "</button>"

                DashboardGrid.jqGrid('setRowData', temp_var, selectedRowIds[selectedRowIndex]);
            }
        }
    });
    //------------------------------------------------- IT Asset Grid Ends -----------------------------------------------------------//

    //------------------------------------------------- Infrastructure Grid Starts -----------------------------------------------------------//
    DashboardInfraGrid = $('#DashboardInfraGrid').jqGrid({
        mtype: 'Get',
        url: 'GetInfrastructuredata',
        datatype: 'json',
        colNames: ['IDInfra', 'IDInfra', 'ID', 'IDLocation', 'AssetType', 'Brand', 'Model', 'SerialNumber', 'PurchaseYear', 'Remark','Unit','Location', 'Status', 'CreatedBy', 'CreatedOn', 'ModifiedBy', 'ModifiedOn', 'Status', 'View'],
        colModel: [
            {
                key: true,
                hidden: true,
                name: 'IDInfra',
                width: '90px',
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
                width: '200px',
            },
            {
                key: false,
                name: 'Brand',
                editable: false,
                width: '130px',
            },
            {
                key: false,
                hidden: true,
                name: 'Model',
                editable: false,
                width: '200px',
            },
            {
                key: false,
                hidden: true,
                name: 'SerialNumber',
                editable: false,
                width: '200px',
            },
            {
                key: false,
                hidden: true,
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
                name: 'viewStatus',
                editable: false,
                width: '125px',
            },
            {
                key: false,
                hidden: true,
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
        pager: '#DashboardInfraPager',
        rowNum: 5,
        rowList: [5, 10, 15, 20],
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
            $("#DashboardInfraPager_left").hide();
        },

        gridComplete: function () {  //Active-Deactive Toggle in Table grid
            var selectedRowIds = DashboardInfraGrid.jqGrid('getGridParam', 'data');
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
                DashboardInfraGrid.jqGrid('setRowData', temp_var, selectedRowIds[selectedRowIndex]);
            }
        }

    });
   
    //------------------------------------------------- Infrastructure Grid Ends -----------------------------------------------------------//

    //------------------------------------------------- Infrastructure Status Starts -----------------------------------------------------------//
    $(document).on('change', '#InfraStatus', function () {
        var idRecords = $('#InfraID').val();
        if ($('#InfraStatus').is(":checked")) {
            ChangeStatusActiveDeactiveInfra("AVAILABLE", idRecords);
        }
        else {
            ChangeStatusActiveDeactiveInfra("UNAVAILABLE", idRecords);
        }
    });
    //------------------------------------------------- Infrastructure Status Ends -----------------------------------------------------------//

    //------------------------------------------------- IT Asset Status Starts -----------------------------------------------------------//
    $(document).on('change', '#ITAssetstatus', function () {
        var idRecords = $('#AssetID').val();
        if ($('#ITAssetstatus').is(":checked")) {
            ChangeStatusActiveDeactive("ACTIVE", idRecords);
        }
        else {
            ChangeStatusActiveDeactive("DEACTIVE", idRecords);
        }
    });
    //------------------------------------------------- IT Asset Status Ends -----------------------------------------------------------//

    //--------------------------------------------------Badges Logic Starts ------------------------------------------------------------//
    var regions = document.querySelectorAll('.regions');
    for (var i = 0; i < regions.length; i++) {
        $(regions[i]).find('.fa-solid').hide();
    }
    AddCountries('ASIA');
             Manipulation('ASIA', '', '');
       //$('#locationData').show();

    $(document).on('click', '.countries', function () {
        var countries = document.querySelectorAll('.countries');
        for (var i = 0; i < countries.length; i++) {
            if (countries[i].classList.contains("text-bg-success")) {
                $(countries[i]).removeClass('text-bg-success');
                $(countries[i]).addClass('text-bg-secondary');
                $(countries[i]).find('.fa-solid').hide();
            }
        }
        $(this).removeClass('text-bg-secondary');
        $(this).addClass('text-bg-success');
        $(this).find('.fa-solid').show();
        Country = $(this).attr('value');
        AddLocation(Country);
        Manipulation(Region, Country, '');
    


    });

    $(document).on('click', '.location', function () {
        var location = document.querySelectorAll('.location');
        for (var i = 0; i < location.length; i++) {
            if (location[i].classList.contains("text-bg-success")) {
                $(location[i]).removeClass('text-bg-success');
                $(location[i]).addClass('text-bg-secondary');
                $(location[i]).find('.fa-solid').hide();
            }
        }
        $(this).removeClass('text-bg-secondary');
        $(this).addClass('text-bg-success');
        $(this).find('.fa-solid').show();
        Location1 = $(this).attr('value');
        Manipulation(Region, Country, Location1);
    });

    //--------------------------------------------------Badges Logic Ends ------------------------------------------------------------//

    //--------------------------------------------------Laptop & Desktop Chart Logic Starts ------------------------------------------------------------//
    Apex.dataLabels = {
        enabled: false
    }

    // the default colorPalette for this dashboard
    var colorPalette = ['#702cf980', '#6f42c1', '#FEB019', '#FF4560', '#775DD0']

    var optionsBar = {
        chart: {
            type: 'bar',
            height: 380,
            width: '100%',
            stacked: true,
        },
        plotOptions: {
            bar: {
                columnWidth: '45%',
            }
        },
        colors: colorPalette,
        series: [{
            name: "Laptops",
            data: LaptopList,
        }, {
            name: "Desktops",
            data: DeskTopList,
        }],
        labels: ['ASIA', 'EUROPE', 'SOUTH AMERICA', 'NORTH AMERICA', 'OCEANIA'],
        xaxis: {
            labels: {
                show: true
            },
            axisBorder: {
                show: false
            },
            axisTicks: {
                show: false
            },
        },
        yaxis: {
            axisBorder: {
                show: false
            },
            axisTicks: {
                show: false
            },
            labels: {
                style: {
                    color: '#78909c'
                }
            }
        },
        title: {
            text: 'Asset Data',
            align: 'left',
            style: {
                fontSize: '18px'
            }
        }
    }

    var chartBar = new ApexCharts(document.querySelector('#bar'), optionsBar);
    chartBar.render()
    //--------------------------------------------------Laptop & Desktop Chart Logic Starts ------------------------------------------------------------//
})

function AddCountries(regionName) {
    $.ajax({
        type: "GET",
        url: 'GetCountriesData',
        data: {
            regionName
        },
        dataType: "json",
        success: function (data) {
            if (data.length > 0) {
                var htmlcss = '<span class="chip primary">Country</span>';
                var countries = document.querySelectorAll('.countries');
                if (countries.length > 0) {
                    for (var i = 0; i < countries.length; i++) {
                        $(countries[i]).remove();
                    }
                }
                for (var i = 0; i < data.length; i++) {
                    htmlcss += "<span class='badge rounded-pill text-bg-secondary countries' value='" + data[i] + "'>" +
                        "<i class='fa-solid fa-check'></i> " + data[i] + "</span>&nbsp; ";
                }
                $("#countryData").html(htmlcss);
                var countries = document.querySelectorAll('.countries');
                for (var i = 0; i < countries.length; i++) {
                    $(countries[i]).find('.fa-solid').hide();
                }
            }
        }
    });
}

function AddLocation(countryName) {
    $.ajax({
        type: "GET",
        url: 'GetLocationcontent',
        data: {
            countryName
        },
        dataType: "json",
        success: function (data) {
            if (data.length > 0) {
                var htmlcss1 = '<span class="chip primary">Location</span>';
                var location = document.querySelectorAll('.location');
                if (location.length > 0) {
                    for (var i = 0; i < location.length; i++) {
                        $(location[i]).remove();
                    }
                }
                for (var i = 0; i < data.length; i++) {
                    htmlcss1 += "<span class='badge rounded-pill text-bg-secondary location' value='" + data[i] + "'>" +
                        "<i class='fa-solid fa-check'></i> " + data[i] + "</span>&nbsp; ";
                }
                $("#locationData").html(htmlcss1);
                var location = document.querySelectorAll('.location');
                for (var i = 0; i < location.length; i++) {
                    $(location[i]).find('.fa-solid').hide();
                }

            }
        }
    });
}

function Manipulation(Region, Country, Location1) {
    $.ajax({
        type: "GET",
        url: 'GetManipulationITAssetGrid',
        data: {
            Region,
            Country,
            Location1
        },
        dataType: "json",
        success: function (data) {
            reload('DashboardGrid');
            reload('DashboardInfraGrid')
        }
    })
}

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
        }
    });
}

function ChangeStatusActiveDeactive(status, idAsset) {
    $.ajax({
        type: "POST",
        url: 'GetStatusITAsset',
        data: {
            status,
            idAsset

        },
        dataType: 'json',
        success: function (result) {

        }
    });
}