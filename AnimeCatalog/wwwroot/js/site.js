const themeCheckbox = document.getElementById("theme");
const labelTheme = document.getElementById("label-theme");
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