const button = document.getElementById("watched");
const container = document.getElementsByClassName("rating-block").item(0);
button.onclick = () => {
    container.classList.toggle("active");
}
container.onclick = () => {
    container.classList.toggle("active");
}
window.addEventListener('scroll', e => {
    if (container.classList.contains("active"))
        window.scrollTo({ top: 0 })
})