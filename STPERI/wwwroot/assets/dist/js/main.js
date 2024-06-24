$(document).ready(function () {
 
    $('.owl-carouselsteps').owlCarousel({
        rtl: false,
        autoplay: true,
        stagePadding: 80,
        loop: true,
        smartSpeed: 800,
        autoplayTimeout: 4000,
		margin: 30,
        responsiveClass: true,
        dotsEach: true,
      //  animateOut: 'slideOutUp',
      //  animateIn: 'slideInUp',
        responsive: {
            0: {
                items: 1,
                nav: true,
                margin: 20,
                stagePadding: 40,
            },
            600: {
                items: 1,
                nav: true,
                margin: 20
            },
            1000: {
                items: 2,
                nav: true,
                loop: true,
				margin: 30
            }
        }
    })

    $('.owl-carouselstepsar').owlCarousel({
        rtl: false,
        autoplay: true,
        stagePadding: 80,
        loop: true,
        smartSpeed: 800,
        autoplayTimeout: 4000,
		margin: 30,
        responsiveClass: true,
        dotsEach: true,
      //  animateOut: 'slideOutUp',
      //  animateIn: 'slideInUp',
        responsive: {
            0: {
                items: 1,
                nav: true,
                margin: 20,
                stagePadding: 40,
            },
            600: {
                items: 1,
                nav: true,
                margin: 20
            },
            1000: {
                items: 2,
                nav: true,
                loop: true,
				margin: 30
            }
        }
    })

    $('.owl-carouselpartner').owlCarousel({
        rtl: false,
        autoplay: true,
        loop: true,
        smartSpeed: 800,
        autoplayTimeout: 4000,
		margin: 30,
        responsiveClass: true,
        dotsEach: true,
        responsive: {
            0: {
                items: 1,
                nav: true,
                margin: 20,
            },
            600: {
                items: 2,
                nav: true,
                margin: 20
            },
            1000: {
                items: 6,
                nav: true,
                loop: true,
				margin: 30
            }
        }
    })

    $('.owl-carouselstories').owlCarousel({
        rtl: false,
        autoplay: true,
        loop: true,
        smartSpeed: 800,
        autoplayTimeout: 4000,
		margin: 0,
        responsiveClass: true,
        dotsEach: false,
        responsive: {
            0: {
                items: 1,
                nav: true,
                margin: 0,
            },
            600: {
                items: 1,
                nav: true,
                margin: 0
            },
            1000: {
                items: 2,
                nav: true,
                loop: true,
				margin: 0
            }
        }
    })


	$('.owl-carouselss').owlCarousel({
		rtl: false,
		autoplay: true,
		loop: true,
		smartSpeed: 500,
		autoplayTimeout: 3000,
		margin: 30,
		responsiveClass: true,
		responsive: {
			0: {
				items: 1,
				nav: true
			},
			600: {
				items: 2,
				nav: true
			},
			1000: {
				items: 4,
				nav: true,
				loop: true,
				margin: 30
			}
		}
	})

});