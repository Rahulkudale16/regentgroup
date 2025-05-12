
(function () {

    "use strict";  /* makes it easier to write "secure" JavaScript */

    //---------------------------------------------------------------- Prealoder
    $(window).on('load', function (event) {
        $('.preloader').delay(500).fadeOut(500);
        setTimeout(function () {
            $('#MyModal').modal('show');
        }, 60000);

        //console.info('window loaded')
        var $this = $('.owl-carousel').owlCarousel({ autoWidth: true }).trigger('refresh.owl.carousel');
        var $this = $('.owl-carousel').owlCarousel({ autoWidth: true }).trigger('refresh.owl.carousel');
    });

    //----------------------------------------------------------------- Scroll Top Bar
    $(window).on('scroll', function (event) {
        if ($(this).scrollTop() > 600) {
            $('.back-to-top').fadeIn(200)
        } else {
            $('.back-to-top').fadeOut(200)
        }
    });

    //----------------------------------------------------------------- Email Logic
    $(document).on('click', '.btnSubmit', function () {
        debugger;
        if (($(".name").val() == "") || ($(".email").val() == "") || ($(".subject").val() == "") || ($(".message").val() == "")) {
            if ($(".name").val() == "") { $("#nameAlert").show() }
            if ($(".email").val() == "") { $("#emailAlert").show() }
            if ($(".subject").val() == "") { $("#subjectAlert").show() }
            if ($(".message").val() == "") { $("#messageAlert").show() }
        }
        else {
            SendEmail();
        }
    });

    //------------------------------------------------------------------ Animate the scroll to top
    $('.back-to-top').on('click', function (event) {
        event.preventDefault();
        $('html, body').scrollTop(0);
    });

    /*------------------------------------------ Timeline Starts - History Page ------------------------------------------*/
    $(window).on('scroll', function () {
        function isScrollIntoView(elem, index) {
            var docViewTop = $(window).scrollTop();
            var docViewBottom = docViewTop + $(window).height();
            var elemTop = $(elem).offset().top;
            var elemBottom = elemTop + $(window).height() * .3;
            if (elemBottom <= docViewBottom && elemTop >= docViewTop) {
                $(elem).addClass('active');
            }
            if (!(elemBottom <= docViewBottom)) {
                $(elem).removeClass('active');
            }
            var MainTimelineContainer = $('#vertical-scrollable-timeline')[0];
            var MainTimelineContainerBottom = MainTimelineContainer.getBoundingClientRect().bottom - $(window).height() * .7;
            $(MainTimelineContainer).find('.inner').css('height', MainTimelineContainerBottom + 'px');
        }
        var timeline = $('#vertical-scrollable-timeline li');
        Array.from(timeline).forEach(isScrollIntoView);
    });
    /*---------------------------------------- Timeline Ends - History Page --------------------------------------------------*/

    /*---------------------------------------- Gallery silder starts - index page --------------------------------------------*/
    $(document).ready(function () {
        if ($('.GallerySection').length > 0) {
            $('.GallerySection').owlCarousel({
                center: false,
                items: 1,
                loop: true,
                stagePadding: 0,
                margin: 0,
                autoplay: true,
                nav: true,
                navText: ['<i class="fa-solid fa-3x fa-angle-left"></i>', '<i class="fa-solid fa-3x fa-angle-right"></i>'],
                responsive: {
                    600: {
                        margin: 0,
                        nav: true,
                        items: 2
                    },
                    1000: {
                        margin: 0,
                        stagePadding: 0,
                        nav: true,
                        items: 4
                    },
                    1200: {
                        margin: 0,
                        stagePadding: 0,
                        nav: true,
                        items: 4
                    }
                }
            });
        }
        /*------------------------------------- Gallery silder Ends ----------------------------------------------------------*/

        /*------------------------------------- Certificates silder starts ---------------------------------------------------*/
        $('.CertificatesSection').owlCarousel({
            loop: true,
            margin: 20,
            items: 1,
            autoplay: true,
            autoWidth: true,
            navText: ['<i class="fa-solid fa-angle-left"></i>', '<i class="fa-solid fa-angle-right"></i>'],
            nav: true,
            dots: false,
            slideTransition: 'linear',
            autoplayHoverPause: true,
            autoplayTimeout: 3000,
            autoplaySpeed: 2900,
            responsive: {
                0: {
                    items: 1,
                    nav: false
                },
                767: {
                    items: 3,
                    nav: false
                },
                992: {
                    items: 8,
                },
                1200: {
                    items: 8
                }
            }
        })
        /*--------------------------------------- Certificates silder Ends ---------------------------------------------------*/

        /*----------------------------------- Latest News Silder Starts - index page -----------------------------------------*/
        $("#NewsSection").owlCarousel({
            items: 3,
            //loop: true,
            nav: false,
            dots: false,
            navigation: true,
            navigationText: ["", ""],
            pagination: true,
            slideTransition: 'linear',
            autoplayHoverPause: true,
            autoplayTimeout: 3000,
            autoplaySpeed: 2900,
            responsive: {
                0: {
                    items: 1,
                    nav: false
                },
                767: {
                    items: 2,
                    nav: false
                },
                992: {
                    items: 3,
                },
                1200: {
                    items: 3
                }
            }
        });
        /*-------------------------------- Latest News Silder Ends ---------------------------------------------------------------*/

        /* Code for our news section starts */
        var swiper = new Swiper(".swiper", {
            /*effect: "coverflow",*/
            grabCursor: false,
            centeredSlides: false,
            slidesPerView: "1",
            coverflowEffect: {
                rotate: 0,
                stretch: 0,
                depth: 100,
                modifier: 2,
                slideShadows: true
            },
            spaceBetween: 30,
            loop: false,
            pagination: {
                el: ".swiper-pagination",
                clickable: true
            },
            breakpoints: {
                // when window width is <= 499px
                499: {
                    slidesPerView: 1,
                    spaceBetweenSlides: 30
                },
                // when window width is <= 999px
                999: {
                    slidesPerView: 2,
                    spaceBetweenSlides: 40
                },
                1336: {
                    slidesPerView: 3,
                    spaceBetweenSlides: 40
                },
            }
        });
        /* Code for our news section Ends */

        /* Animate on scroll Starts */
        AOS.init({
            once: false,
            offset: 20,
            duration: 1200
        });
        /* Animate on scroll Ends */
    });

    /* Progress-wrap starts */
    $(document).ready(function () {
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
    });
    
    jQuery('.progress-wrap').on('click', function (event) {
        event.preventDefault();
        $('html, body').scrollTop(0);
        return false;
    })
    /* Progress-wrap ends*/

    // Menu Dropdown Toggle
    if ($('.menu-trigger').length) {
        $(".menu-trigger").on('click', function () {
            $(this).toggleClass('active');
            $('.header-area .nav').slideToggle(200);
        });
    }

    /* Menus Dropdowns */
    (function () {
        const select = (el, all = false) => {
            el = el.trim()
            if (all) {
                return [...document.querySelectorAll(el)]
            } else {
                return document.querySelector(el)
            }
        }

        const on = (type, el, listener, all = false) => {
            let selectEl = select(el, all)
            if (selectEl) {
                if (all) {
                    selectEl.forEach(e => e.addEventListener(type, listener))
                } else {
                    selectEl.addEventListener(type, listener)
                }
            }
        }

        const onscroll = (el, listener) => {
            el.addEventListener('scroll', listener)
        }

        /* Toggle .header-scrolled class to #header when page is scrolled */
        let selectHeader = select('#header')
        if (selectHeader) {
            const headerScrolled = () => {
                if (window.scrollY > 100) {
                    selectHeader.classList.add('header-scrolled')
                } else {
                    selectHeader.classList.remove('header-scrolled')
                }
            }
            window.addEventListener('load', headerScrolled)
            onscroll(document, headerScrolled)
        }

        /* Mobile nav toggle */
        on('click', '.mobile-nav-toggle', function (e) {
            select('#navbar').classList.toggle('navbar-mobile')
            this.classList.toggle('fa-list')
            this.classList.toggle('fa-xmark')
        })

        /* Mobile nav dropdowns activate */
        on('click', '.navbar .dropdown > a', function (e) {
            if (select('#navbar').classList.contains('navbar-mobile')) {
                e.preventDefault()
                this.nextElementSibling.classList.toggle('dropdown-active')
            }
        }, true)

        on('click', '.scrollto', function (e) {
            if (select(this.hash)) {
                e.preventDefault()

                let navbar = select('#navbar')
                if (navbar.classList.contains('navbar-mobile')) {
                    navbar.classList.remove('navbar-mobile')
                    let navbarToggle = select('.mobile-nav-toggle')
                    navbarToggle.classList.toggle('bi-list')
                    navbarToggle.classList.toggle('bi-x')
                }
                scrollto(this.hash)
            }
        }, true)
    })()

    // Mail method
    function animate(obj, initVal, lastVal, duration) {
        let startTime = null;

        //get the current timestamp and assign it to the currentTime variable
        let currentTime = Date.now();

        //pass the current timestamp to the step function
        const step = (currentTime) => {

            //if the start time is null, assign the current time to startTime
            if (!startTime) {
                startTime = currentTime;
            }

            //calculate the value to be used in calculating the number to be displayed
            const progress = Math.min((currentTime - startTime) / duration, 1);

            //calculate what to be displayed using the value gotten above
            obj.innerHTML = Math.floor(progress * (lastVal - initVal) + initVal);

            //checking to make sure the counter does not exceed the last value (lastVal)
            if (progress < 1) {
                window.requestAnimationFrame(step);
            } else {
                window.cancelAnimationFrame(window.requestAnimationFrame(step));
            }
        };
        //start animating
        window.requestAnimationFrame(step);
    }
    let text1 = document.getElementById('0101');
    let text2 = document.getElementById('0102');
    let text3 = document.getElementById('0103');
    const load = () => {
        animate(text1, 0, 511, 7000);
        animate(text2, 0, 232, 7000);
        animate(text3, 100, 25, 7000);
    }
})(window.jQuery);

// Methods for Submit and Reset Button
function SendEmail() {
    var name = $(".name").val();
    var email = $(".email").val();
    var subject = $(".subject").val();
    var message = $(".message").val();
    $.ajax({
        type: "POST",
        url: 'MailSend',
        data: {
            name,
            email,
            subject,
            message
        },
        dataType: 'json',
        success: function (result) {
            alert("Mail Request sent successfully");
            window.location.reload();
        },
        //error: (error) => {
        //    console.log(JSON.stringify(error));
        //}
    });
}

// Method to resize pdf modal for full length
function resizeIframe(obj) {
    obj.style.height = ($(window.top).height() - 150) + 'px';
}

function dropdownsearch(id) {
    var location = window.location.href;
    if (location.includes("Integrated")) {
        window.location.href = id;
    }
    else if (location == "http://localhost/LegendALP/") /*"https://v2.legendasia.com"*/  /*"https://www.legendasia.com/"*/ {
        window.location.href = "http://localhost/LegendALP/OurSolutions/SpecialisedLogistics/" + id;
    }
    else {
        window.location.href = "../OurSolutions/SpecialisedLogistics" + id;
    }
}

function dropdownsearchCarrier(id) {
    var location = window.location.href;
    if (location.includes("Carrier")) {
        window.location.href = id;
    }
    else if (location == "http://localhost/LegendALP/") /*"https://v2.legendasia.com"*/  /*"https://www.legendasia.com/"*/ {
        window.location.href = "http://localhost/LegendALP/OurSolutions/BreakbulkandROROServices/" + id;
    }
    else {
        window.location.href = "../OurSolutions/MarineLogistics" + id;
    }
}

function dropdownsearchOS(id) {
    var location = window.location.href;
    if (location.includes("Carrier")) {
        window.location.href = id;
    }
    else if (location == "http://localhost/LegendALP/") /*"https://v2.legendasia.com"*/  /*"https://www.legendasia.com/"*/ {
        window.location.href = "http://localhost/LegendALP/OurSolutions/BreakbulkandROROServices/" + id;
    }
    else {
        window.location.href = "../OurSolutions/RegionalFeederServices" + id;
    }
}

function DoubleData() {
    window.open("https://www.legendlogistics.com.au/");
    window.location.href = "../OurSolutions/HeavyHaulageandLineHaul";
}    
    