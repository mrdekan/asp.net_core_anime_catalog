const themeCheckbox = document.getElementById("theme");
const header = document.getElementById("header");
themeCheckbox.addEventListener('change', (event) => {
        header.classList.toggle("dark-mode");
});