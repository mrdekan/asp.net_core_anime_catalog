const themeCheckbox = document.getElementById("theme");
const labelTheme = document.getElementById("label-theme");
const sliderPop = document.getElementById("PopularSlider");
let contentWidth = sliderPop.getElementsByClassName("slider_content").item(0).children.length * 248;
//let contentWidth = sliderPop.getElementsByClassName("slider_content").item(0).width;
let popContentTempWidth = contentWidth;
if (localStorage.getItem("dark") == "true") {
    themeCheckbox.checked = true;
    document.body.classList.toggle("dark-mode");
    labelTheme.textContent = "Light";
}
themeCheckbox.addEventListener('change', (event) => {
    document.body.classList.toggle("animation");
    document.body.classList.toggle("dark-mode");
    if (themeCheckbox.checked) {
        localStorage.setItem("dark", "true");
        labelTheme.textContent = "Light";
    }
    else {
        localStorage.setItem("dark", "false");
        labelTheme.textContent = "Dark";
    }

});
document.addEventListener('DOMContentLoaded', function () {
    // инициализация слайдера
    var slider = new SimpleAdaptiveSlider('.slider', {
        autoplay: false,
        interval: 5000,
        swipe: true,
    });
});
/*sliderPop.getElementsByClassName("forward").onclick = () => console.log("112");
sliderPop.addEventListener('click', (event) => {
    if (event.target == sliderPop.getElementsByClassName("forward").item(0)) {
        let step = getComputedStyle(sliderPop.getElementsByClassName("slider").item(0)).width.replace("px", "");

        step = step * 2 > popContentTempWidth ? popContentTempWidth - step : step;
        popContentTempWidth -= step;
        console.log(step);
        console.log(popContentTempWidth);
        if (sliderPop.getElementsByClassName("slider_content").item(0).style.marginLeft == "")
            sliderPop.getElementsByClassName("slider_content").item(0).style.marginLeft = `-${step}px`;
        else sliderPop.getElementsByClassName("slider_content").item(0).style.marginLeft = sliderPop.getElementsByClassName("slider_content").item(0).style.marginLeft.replace("px", "") - step + "px";
    }
    else if (event.target == sliderPop.getElementsByClassName("back").item(0)) {
        let step = getComputedStyle(sliderPop.getElementsByClassName("slider").item(0)).width.replace("px", "");
        if (sliderPop.getElementsByClassName("slider_content").item(0).style.marginLeft != "")
            sliderPop.getElementsByClassName("slider_content").item(0).style.marginLeft = sliderPop.getElementsByClassName("slider_content").item(0).style.marginLeft.replace("px", "") + step + "px";
    }
});
function slideRight() {
    console.log("112");

}*/