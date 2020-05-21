var elem = document.getElementById("schr1");
function onWheel1(e) {
    e = e || window.event;

    // wheelDelta не даёт возможность узнать количество пикселей
    var delta = e.deltaY || e.detail || e.wheelDelta;
    console.log('123');

    if (delta > 0)
        scrollTo(document.querySelector('.schr2').offsetTop, 10);
    else
        scrollTo(0, 10);
    e.preventDefault ? e.preventDefault() : (e.returnValue = false);
    //alert(delta);
}
function onWheel2(e) {
    e = e || window.event;

    // wheelDelta не даёт возможность узнать количество пикселей
    var delta = e.deltaY || e.detail || e.wheelDelta;
    console.log('123');

    if (delta < 0)
        scrollTo(document.querySelector('.schr1').offsetTop, -10);
    else
        scrollTo(document.querySelector('.contact').offsetTop, 10);
    e.preventDefault ? e.preventDefault() : (e.returnValue = false);
    //alert(delta);
}
function scrollTo(position, step) {
    var beginPosition = window.pageYOffset;
    if (step > 0)
        var scrollInterval = setInterval(function () {
            if (beginPosition <= position) {
                window.scroll(0, beginPosition);
                beginPosition += 1 * step;
            }
            else {
                clearInterval(scrollInterval);
                window.scroll(0, position);
            }
        }, 1);
    else
        var scrollInterval = setInterval(function () {
            if (beginPosition >= position) {
                window.scroll(0, beginPosition);
                beginPosition += 1 * step;
            }
            else {
                clearInterval(scrollInterval);
                window.scroll(0, position);
            }
        }, 1);
}