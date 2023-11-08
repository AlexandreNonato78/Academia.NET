function changeFontColor(color) {
    const textPara = document.getElementById("textPara");
    textPara.style.color = color;
}

function changeBackgroundColor(color) {
    const textPara = document.getElementById("textPara");
    textPara.style.backgroundColor = color;
}

function transformText(transformType) {
    const textPara = document.getElementById("textPara");
    if (transformType === "uppercase") {
        textPara.textContent = textPara.textContent.toUpperCase();
    } else if (transformType === "lowercase") {
        textPara.textContent = textPara.textContent.toLowerCase();
    }
}
