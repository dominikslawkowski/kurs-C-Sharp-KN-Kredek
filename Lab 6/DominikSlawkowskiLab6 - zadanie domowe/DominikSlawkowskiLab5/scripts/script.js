
var preloaderEl = document.querySelector('.preloader');
setTimeout(function () {

    preloaderEl.classList.add('preloader-hiding');

    preloaderEl.addEventListener('transitionend', function () {

        this.classList.add('preloader-hidden');
        this.classList.remove('preloader-hiding');
    });

}, 2000);


// Scroll to specific values
// scrollTo is the same
window.scroll({
    // top: 2500, 
    left: 0,
    behavior: 'smooth'
});

// Scroll certain amounts from current position 
window.scrollBy({
    //top: 100, // could be negative value
    left: 0,
    behavior: 'smooth'
});

// Scroll to a certain element
document.querySelector('.hello').scrollIntoView({
    behavior: 'smooth'
});