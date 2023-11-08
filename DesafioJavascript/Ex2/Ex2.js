document.addEventListener("DOMContentLoaded", function () {
    const links = document.querySelectorAll(".color-link");

    links.forEach(link => {
        link.addEventListener("mouseover", function () {
            const color = link.getAttribute("data-color");
            document.body.style.backgroundColor = color;
        });

        link.addEventListener("mouseout", function () {
            document.body.style.backgroundColor = "";
        });
    });
});
