$(document).ready(function () {
    /* For Showing data on maps for the countries */
    // Starts
    var map = new Datamap({
        element: document.getElementById('regions_div'),
        fills: {
            defaultFill: "#E7E6E6",
            authorHasTraveledTo: "#7BAEF2",
        },
        // Logic for resizing map on mobile devices
        done: function (datamap) {
            if ($(window).width() < 767) {
                datamap.svg.call(d3.behavior.zoom().on("zoom", redraw));

                function redraw() {
                    datamap.svg.selectAll("g").attr("transform", "translate(" + d3.event.translate + ")scale(" + d3.event.scale + ")");
                }
            }
        },
        // Pointers for maps
        data: {
            Europe: { fillKey: "authorHasTraveledTo" },
            UAE: { fillKey: "authorHasTraveledTo" },
            IndianSubcontinent: { fillKey: "authorHasTraveledTo" },
            SoutheastAsia: { fillKey: "authorHasTraveledTo" },
            NorthAsia: { fillKey: "authorHasTraveledTo" },
            Oceania: { fillKey: "authorHasTraveledTo" },
            Headquarters: { fillKey: "authorHasTraveledTo" },
            USA: { fillKey: "authorHasTraveledTo" },
        },
        setProjection: function (element) {
            var projection = d3.geo.equirectangular()
                .center([10, 15])
                .rotate([4.4, 0])
                .scale(190)//zoom
                .translate([element.offsetWidth / 2, element.offsetHeight / 2]);
            var path = d3.geo.path()
                .projection(projection);

            return { path: path, projection: projection };
        }
    });
    // Ends

    // Pins for the all countries on the map for the 15 countries // Start
    // Add the custom markers plugin.
    map.addPlugin('markers', Datamap.customMarkers);

    // Add markers with the icon config. Specify the url, width and height properties.
    var options = {
        fillOpacity: 2,
        popupOnHover: false,
        icon: {
            url: '../Content/images/Legend.png',
            width: 25,
            height: 25
        }
    };
    map.markers([

        { name: 'Europe', radius: 10, latitude: 51.10, longitude: 5.1 },    // Europe - Netherlands

        { name: 'MiddleEast', radius: 10, latitude: 23, longitude: 53.80 },  // Middle East - UAE

        { name: 'IndianSubcontinent', radius: 10, latitude: 23.80, longitude: 78 },  // Indian SubContinent - India

        { name: 'IndianSubcontinent', radius: 10, latitude: 28.80, longitude: 69 }, // Indian SubContinent - Pakistan

        { name: 'NorthAsia', radius: 10, latitude: 32.11, longitude: 115.76 }, // North Asia - China

        { name: 'SoutheastAsia', radius: 10, latitude: 35.50, longitude: 127.90 }, // North Asia - South Korea

        { name: 'Oceania', radius: 10, latitude: -37.40, longitude: 141.30 },  // Oceania - Australia

        { name: 'SoutheastAsia', radius: 10, latitude: 14.11, longitude: 102.76 }, // Southeast Asia - Thailand

        { name: 'SoutheastAsia', radius: 10, latitude: 6, longitude: 100.80 }, // Southeast Asia - Malaysia

        { name: 'SoutheastAsia', radius: 10, latitude: -2.11, longitude: 113.76 }, // Southeast Asia - Indonesia

        { name: 'Headquarters', radius: 10, latitude: 1.11, longitude: 103.50 }, // Southeast Asia - Singapore

        { name: 'USA', radius: 10, latitude: 29.50, longitude: -95.76 }, // North America - USA

    ], options);
    // Ends

    //////////////////////// Europe /////////////////////////////////
    var options = {
        fillOpacity: 1,
        popupOnHover: false,
        icon: {
            url: '../Content/images/UpdatedImages/GlobalLocation/CountriesName/Europe.png',
            width: 50,
            height: 50
        }
    };
    map.markers([
        { name: 'Europe', radius: 10, latitude: 41.50, longitude: 21 },

    ], options);
    //////////////////////// Europe ///////////////////////////////////

    //////////////////////// Middle East //////////////////////////////
    var options = {
        fillOpacity: 1,
        popupOnHover: false,
        icon: {
            url: '../Content/images/UpdatedImages/GlobalLocation/CountriesName/MiddleEast.png',
            width: 65,
            height: 65
        }
    };
    map.markers([
        { name: 'MiddleEast', radius: 10, latitude: 10, longitude: 53.80 },

    ], options);
    //////////////////////// Middle East //////////////////////////////

    //////////////////////// Indian Subcontinent //////////////////////////////
    var options = {
        fillOpacity: 1,
        popupOnHover: false,
        icon: {
            url: '../Content/images/UpdatedImages/GlobalLocation/CountriesName/IndianSubcontinent.png',
            width: 80,
            height: 80
        }
    };
    map.markers([
        { name: 'IndianSubcontinent', radius: 10, latitude: 5.80, longitude: 79.80 },

    ], options);
    //////////////////////// Indian Subcontinent //////////////////////////////

    //////////////////////// Oceania //////////////////////////////////////////
    var options = {
        fillOpacity: 1,
        popupOnHover: false,
        icon: {
            url: '../Content/images/UpdatedImages/GlobalLocation/CountriesName/Oceania.png',
            width: 50,
            height: 50
        }
    };
    map.markers([
        { name: 'Oceania', radius: 10, latitude: -31.80, longitude: 133.76 },

    ], options);
    //////////////////////// Oceania //////////////////////////////////////////

    //////////////////////// North Asia //////////////////////////////////////////
    var options = {
        fillOpacity: 1,
        popupOnHover: false,
        icon: {
            url: '../Content/images/UpdatedImages/GlobalLocation/CountriesName/NorthAsia.png',
            width: 60,
            height: 60
        }
    };
    map.markers([
        { name: 'NorthAsia', radius: 10, latitude: 36.90, longitude: 129.76 },
    ], options);
    //////////////////////// North Asia //////////////////////////////////////////

    /////////////////////// Southeast Asia //////////////////////////////////////
    var options = {
        fillOpacity: 1,
        popupOnHover: false,
        icon: {
            url: '../Content/images/UpdatedImages/GlobalLocation/CountriesName/SoutheastAsia.png',
            width: 83,
            height: 83
        }
    };
    map.markers([
        { name: 'SoutheastAsia', radius: 10, latitude: -16.50, longitude: 115.76 },
    ], options);
    /////////////////////// Southeast Asia //////////////////////////////////////

    ///////////////////////// Africa //////////////////////////////////////
    var options = {
        fillOpacity: 1,
        popupOnHover: false,
        icon: {
            url: '../Content/images/UpdatedImages/GlobalLocation/CountriesName/Africa.png',
            width: 42,
            height: 42
        }
    };
    map.markers([
        { name: 'Africa', radius: 10, latitude: 5.11, longitude: 20.76 },
    ], options);
    /////////////////////// Africa //////////////////////////////////////

    //////////////////////// North America //////////////////////////////////////
    var options = {
        fillOpacity: 1,
        popupOnHover: false,
        icon: {
            url: '../Content/images/UpdatedImages/GlobalLocation/CountriesName/NorthAmerica.png',
            width: 45,
            height: 45
        }
    };
    map.markers([
        { name: 'NorthAmerica', radius: 10, latitude: 41.70, longitude: -100.76 },
    ], options);
    /////////////////////// North America //////////////////////////////////////

    ///////////////////////// South America //////////////////////////////////////
    var options = {
        fillOpacity: 1,
        popupOnHover: false,
        icon: {
            url: '../Content/images/UpdatedImages/GlobalLocation/CountriesName/SouthAmerica.png',
            width: 50,
            height: 50
        }
    };
    map.markers([
        { name: 'SouthAmerica', radius: 10, latitude: -20.11, longitude: -57.76 },
    ], options);
    ////////////////////////// South America //////////////////////////////////////

    // Can show Active Country on the map on the scroll // Starts
    var scrollLink = $('.datamaps-subunit');
    var content = $(".countries");
    $(window).on("scroll", function (e) {

        var el = content.filter(function (i, el) {
            return (el.getBoundingClientRect().bottom - 150) >= parseInt($(el).css("height"))
        })
            , sectionId = el.prev(".countries").is(content)
                ? el.prev(".countries").attr("id")
                : content.eq(-1).attr("id");

        $('.datamaps-subunit').removeClass('currentcountry');
        $('.' + sectionId).addClass('currentcountry');
    }).scroll();
    // Ends

    // Click methods for Regions
    // Starts
    $(".EU").click(function () {
        window.location.replace('Netherlands', 'GlobalLocations');
    });

    $(".Europe").click(function () {
        window.location.replace('Netherlands', 'GlobalLocations');
    });

    $(".Headquarters").click(function () {
        window.location.replace('Headquarters', 'GlobalLocations');
    });

    $(".MiddleEast").click(function () {
        window.location.replace('China', 'GlobalLocations');
    });

    $(".UAE").click(function () {
        window.location.replace('China', 'GlobalLocations');
    });

    $(".ISB").click(function () {
        window.location.replace('China', 'GlobalLocations');
    });

    $(".UAE").click(function () {
        window.location.replace('China', 'GlobalLocations');
    });

    $(".IndianSubcontinent").click(function () {
        window.location.replace('China', 'GlobalLocations');
    });

    $(".ISC").click(function () {
        window.location.replace('China', 'GlobalLocations');
    });

    $(".NorthAsia").click(function () {
        window.location.replace('China', 'GlobalLocations');
    });

    // Southeast Asia 
    $(".SouthEastAsia").click(function () {
        window.location.replace('China', 'GlobalLocations');
    });

    $(".SoutheastAsia").click(function () {
        window.location.replace('China', 'GlobalLocations');
    });

    // Australia
    $(".Oceania").click(function () {
        window.location.replace('Australia', 'GlobalLocations');
    });

    // USA
    $(".USA").click(function () {
        window.location.replace('USA', 'GlobalLocations');
    });
    // Ends
});