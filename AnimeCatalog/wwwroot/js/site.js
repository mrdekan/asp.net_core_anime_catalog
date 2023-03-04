const themeCheckbox = document.getElementById("theme");
const header = document.getElementById("header");
if (localStorage.getItem("dark") == "true") {
    themeCheckbox.checked = true;
    document.body.classList.toggle("dark-mode");
}
themeCheckbox.addEventListener('change', (event) => {
    document.body.classList.toggle("dark-mode");
    if (themeCheckbox.checked)
        localStorage.setItem("dark", "true");
    else
        localStorage.setItem("dark", "false");
});