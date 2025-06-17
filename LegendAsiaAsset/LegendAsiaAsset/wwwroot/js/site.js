var rowCounter = 0;

$(document).ready(function () {

    var pageShowWorked;
    $.jgrid.defaults.styleUI = 'Bootstrap5';
    $.jgrid.defaults.iconSet = 'fontAwesome';

    $(".logout").click(function () {
        $("#loading").fadeIn("fast");
    });

    $(document).on('click', '.showLoading,.aLoading > a, .breadCrumbColor, .navbar-brand', function (e) {
        var target = e.target.className;
        $("#loading").fadeIn("fast");
    });

    var ajaxLoadControllerList = [
        "Account",
        "Home",
    ];

    if (!ajaxLoadControllerList.includes(controllerName)) {
        $(window).bind("pageshow", function (event) {
            pageShowWorked = true;
            $("#loading").fadeOut("slow");
            $(".first-intro").fadeOut("slow");
        });
        setTimeout(function () {
            if (!pageShowWorked) {
                $("#loading").fadeOut("slow");
                $(".first-intro").fadeOut("slow");
            }
        }, 5000);
    }
    else {
        $(document).ajaxStop(function () {
            $("#loading").fadeOut("slow");
        });
    }

    $('.back-to-top').on('click', function (event) {
        event.preventDefault();
        $('html, body').scrollTop(0);
    });

    var progressPath = document.querySelector('.progress-wrap path');
    var pathLength = progressPath.getTotalLength();
    progressPath.style.transition = progressPath.style.WebkitTransition = 'none';
    progressPath.style.strokeDasharray = pathLength + ' ' + pathLength;
    progressPath.style.strokeDashoffset = pathLength;
    progressPath.getBoundingClientRect();
    progressPath.style.transition = progressPath.style.WebkitTransition = 'stroke-dashoffset 10ms linear';
    var updateProgress = function () {
        var scroll = $(window).scrollTop();
        var height = $(document).height() - $(window).height();
        var progress = pathLength - (scroll * pathLength / height);
        progressPath.style.strokeDashoffset = progress;
    }
    updateProgress();
    $(window).scroll(updateProgress);
    var offset = 50;
    var duration = 550;
    jQuery(window).on('scroll', function () {
        if (jQuery(this).scrollTop() > offset) {
            jQuery('.progress-wrap').addClass('active-progress');
        } else {
            jQuery('.progress-wrap').removeClass('active-progress');
        }
    });

    jQuery('.progress-wrap').on('click', function (event) {
        event.preventDefault();
        $('html, body').scrollTop(0);
        return false;
    });

    const modalElement = document.querySelectorAll('.modal');

    modalElement.forEach(el => el.addEventListener('shown.bs.modal', event => {
        $('#' + event.target.id).find('.ui-jqgrid').each(function (index) {
            var closestTable = $(this).attr('id');
            var tableID = closestTable.substring(5);
            $("#" + tableID).jqGrid('resizeGrid');
        });
    }));

    $('.nav-link').on('click', function (event) {
        $(this).closest('.col').find('.active').find('.ui-jqgrid').each(function (index) {
            var closestTable = $(this).attr('id');
            var tableID = closestTable.substring(5);
            $("#" + tableID).jqGrid('resizeGrid');
        });
        $(this).closest('.col').find('.ui-jqgrid').each(function (index) {
            var closestTable = $(this).attr('id');
            var tableID = closestTable.substring(5);
            $("#" + tableID).jqGrid('resizeGrid');
        });
        $(this).closest('.row').find('.col').find('.ui-jqgrid').each(function (index) {
            var closestTable = $(this).attr('id');
            var tableID = closestTable.substring(5);
            $("#" + tableID).jqGrid('resizeGrid');
        });
        $(this).closest('.col-lg-6').find('.ui-jqgrid').each(function (index) {
            var closestTable = $(this).attr('id');
            var tableID = closestTable.substring(5);
            $("#" + tableID).jqGrid('resizeGrid');
        });
    });

    $('.accordion-button').on('click', function (event) {
        $(this).closest('.col').find('.active').find('.ui-jqgrid').each(function (index) {
            var closestTable = $(this).attr('id');
            var tableID = closestTable.substring(5);
            $("#" + tableID).jqGrid('resizeGrid');
        });
        $('.accordion-body').find('.ui-jqgrid').each(function (index) {
            var closestTable = $(this).attr('id');
            var tableID = closestTable.substring(5);
            $("#" + tableID).jqGrid('resizeGrid');
        });
    });

    SessionTimer = parseInt($("#hdnSessionTimeout").val());

    ("fnSessionRun()", 60000);
    setInterval(function () {
        SessionTimer -= 1;
        var S = SessionTimer % 60;
        var H = SessionTimer / 60;
        var M = Math.floor(H % 60);
        var displaytext = "";
        if (M > 1) {
            displaytext = M + " mins ";
        }
        if (M == 1) {
            displaytext = M + " min ";
        }
        if (S > 1) {
            displaytext += S + " secs";
        }
        if (S == 1) {
            displaytext += S + " sec";
        }
        $('#timervalue').html(displaytext);
        if (SessionTimer == 3570) {
            $('#DashboardPAPM').load('./Home/DashboardPAPM');
            $('#DashboardBorrower').load('./Home/DashboardBorrower');
            $('#DashboardFinancer').load('./Home/DashboardFinancer');
        }
        if (SessionTimer == 0) {
            location.replace("../Account/Logout");
            // ReloadPage();
        }
        if ($("#hdnSessionExpNotice").val() == SessionTimer) {
            $("#SessionExpNotice").modal('show');
        }
    }, 1000);

    $(document).ajaxStart(function (event, jqxhr, settings) {
        SessionTimer = parseInt($("#hdnSessionTimeout").val());
    });
    $(document).ajaxStop(function (event, jqxhr, settings) {
        SessionTimer = parseInt($("#hdnSessionTimeout").val());
    });

    const tooltipTriggerList = document.querySelectorAll('[data-bs-toggle="tooltip"]')
    const tooltipList = [...tooltipTriggerList].map(tooltipTriggerEl => new bootstrap.Tooltip(tooltipTriggerEl))
    $('[data-bs-toggle="tooltip"]').tooltip({ trigger: "hover" });
    $('[data-bs-toggle="tooltip"]').on('click', function () { $(this).tooltip('hide') });
});

function click(e) {
    let target = e.target;
    if (target.nodeName === 'SPAN') target = e.target.parentNode;

    if (target.nodeName !== 'LI') return;

    items.forEach(item => item.classList.remove('active'));
    target.classList.add('active');

}

function renderDropdown(dropdownID) {
    dropdownID.selectpicker({
        liveSearch: true,
        liveSearchNormalize: true,
        liveSearchPlaceholder: 'Search',
        liveSearchStyle: 'contains',
        /*styleBase: 'btn',*/
        style: 'btn-outline-success form-control',
        size: '5',
        width: '100%',
    });
}

function ReloadPage() {
    setTimeout(function () {
        window.location.reload(1);
    }, 1000);
}

function startEdit(tableName) {
    var grid = $("#" + tableName);
    var ids = grid.jqGrid('getDataIDs');
    for (var i = 0; i < ids.length; i++) {
        grid.jqGrid('editRow', ids[i]);
    }
    $('#Add' + tableName).prop('disabled', true);
    $('#Edit' + tableName).prop('disabled', true);
    $('#Save' + tableName).prop('disabled', false);
    $('#Cancel' + tableName).prop('disabled', false);
};

async function saveRows(tableName) {
    $("#loading").show();
    $('#Add' + tableName).prop('disabled', false);
    $('#Edit' + tableName).prop('disabled', false);
    $('#Save' + tableName).prop('disabled', true);
    $('#Cancel' + tableName).prop('disabled', true);

    var grid = $("#" + tableName);
    var ids = grid.jqGrid('getDataIDs');

    for (var i = 0; i < ids.length; i++) {
        await grid.jqGrid('saveRow', ids[i]);
        rowCounter++;
    }
    reloadJQGrid(tableName);
}

function cancelRows(tableName) {
    var grid = $("#" + tableName);
    var ids = grid.jqGrid('getDataIDs');

    for (var i = 0; i < ids.length; i++) {
        grid.jqGrid('restoreRow', ids[i]);
    }

    $('#Add' + tableName).prop('disabled', false);
    $('#Edit' + tableName).prop('disabled', false);
    $('#Save' + tableName).prop('disabled', true);
    $('#Cancel' + tableName).prop('disabled', true);
}

function reloadJQGrid(tableName) {
    currentPage = $('#' + tableName).getGridParam('page');
    $('#' + tableName).setGridParam({ datatype: "json" }).trigger('reloadGrid');
}

function reload(tableName) {
    currentPage = tableName.getGridParam('page');
    tableName.setGridParam({ datatype: "json" }).trigger('reloadGrid');
}

function checkForCaching(event) {
    if (event.persisted) {
        $("#loading").fadeOut("slow");
    }
}

function resizeIframe(obj) {
    obj.style.height = ($(window.top).height() - 150) + 'px';
}

function readOnlyElement(value, options) {
    return $('<span></span>', { text: value });
}

function readOnlyValue(elem, operation, value) {
    if (operation === 'get') {
        return $(elem).text();
    } else if (operation === 'set') {
        $('span', elem).text(value);
    }
}

function SessionOKClick() {
    //ajax call to reset session    
    $.ajax({
        url: '../Home/ResetSession/',
        contentType: 'application/json',
        dataType: 'json',
        data: {},
        success: function (data) {
            $("#hdnSessionTimeout").val(parseInt(data));
        }
    });
}

function checkForCaching(event) {
    if (event.persisted) {
        $("#loading").fadeOut("slow");
    }
}