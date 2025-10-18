$(function () {
    // iOS Safari detection
    function isIOS() {
        return /iPad|iPhone|iPod/.test(navigator.userAgent) && !window.MSStream;
    }

    function isSafari() {
        return /^((?!chrome|android).)*safari/i.test(navigator.userAgent);
    }

    // Header Scroll with iOS compatibility
    $(window).scroll(function () {
        if ($(window).scrollTop() >= 60) {
            $("header").addClass("fixed-header");
        } else {
            $("header").removeClass("fixed-header");
        }
    });


    // Featured Owl Carousel
    $('.featured-projects-slider .owl-carousel').owlCarousel({
        center: true,
        loop: true,
        margin: 30,
        nav: false,
        dots: false,
        autoplay: true,
        autoplayTimeout: 5000,
        autoplayHoverPause: false,
        responsive: {
            0: {
                items: 1
            },
            600: {
                items: 2
            },
            1000: {
                items: 3
            },
            1200: {
                items: 4
            }
        }
    })


    // Count
    $('.count').each(function () {
        $(this).prop('Counter', 0).animate({
            Counter: $(this).text()
        }, {
            duration: 1000,
            easing: 'swing',
            step: function (now) {
                $(this).text(Math.ceil(now));
            }
        });
    });


    // ScrollToTop with iOS compatibility
    function scrollToTop() {
        if (isIOS() || isSafari()) {
            // Use requestAnimationFrame for smoother scrolling on iOS
            const scrollTo = function () {
                const currentScroll = window.pageYOffset || document.documentElement.scrollTop;
                if (currentScroll > 0) {
                    window.scrollTo(0, currentScroll - 50);
                    requestAnimationFrame(scrollTo);
                }
            };
            scrollTo();
        } else {
            window.scrollTo({
                top: 0,
                behavior: 'smooth'
            });
        }
    }

    const btn = document.getElementById("scrollToTopBtn");
    if (btn) {
        btn.addEventListener("click", scrollToTop);
    }

    // Use passive event listener for better performance on iOS
    window.addEventListener('scroll', function () {
        const btn = document.getElementById("scrollToTopBtn");
        if (btn) {
            if (document.documentElement.scrollTop > 100 || document.body.scrollTop > 100) {
                btn.style.display = "flex";
            } else {
                btn.style.display = "none";
            }
        }
    }, { passive: true });


    // Aos
    AOS.init({
        once: true,
    });

});

