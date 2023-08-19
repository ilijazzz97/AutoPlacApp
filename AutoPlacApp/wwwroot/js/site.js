(function ($) {
	"use strict";
	let $window = $(window);
	$window.on('load', function () {
		let $document = $(document);
		let $dom = $('html, body');
		let backToTopButton = $('#back-to-top');

		/* ======= Back to Top Button  ======= */
		$window.on('scroll', function () {
			if ($(this).scrollTop() >= 300) {
				backToTopButton.show(200);
			} else {
				backToTopButton.hide(200);
			}
		});

		$document.on('click', '#back-to-top', function () {
			$($dom).animate({
				scrollTop: 0
			}, 100);
		});

		/*=========== Bootstrap Tooltip ============*/
		$('[data-toggle="tooltip"]').tooltip();
	});
})(jQuery);

function showhide(target) {
	let brandDropdown = document.getElementById("brand");
	let searchNavbar = document.querySelector('.navbar-collapser-search');
	let menuNavbar = document.querySelector('.navbar-collapse');

	if (target === 'search') {
		searchNavbar.classList.toggle('show');
		menuNavbar.classList.remove('show');
		if (searchNavbar.classList.contains('show')) {
			brandDropdown.classList.add("hidden");
		} else {
			brandDropdown.classList.remove("hidden");
		}
	} else if (target === 'menu') {
		menuNavbar.classList.toggle('show');
		searchNavbar.classList.remove('show');
		if (menuNavbar.classList.contains('show')) {
			brandDropdown.classList.add("hidden");
		} else {
			brandDropdown.classList.remove("hidden");
		}
	}
}


