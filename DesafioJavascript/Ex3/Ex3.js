document.addEventListener("DOMContentLoaded", function () {
    const dropdown = document.getElementById("colorDropdown");

    dropdown.addEventListener("change", function () {
        const selectedColor = dropdown.value;
        document.body.style.backgroundColor = selectedColor;
    });
});
