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

function changeFontSize(action) {
    const textPara = document.getElementById("textPara");
    const currentSize = window.getComputedStyle(textPara, null).getPropertyValue('font-size');
    const newSize = parseFloat(currentSize);
    const unit = currentSize.slice(-2);

    if (action === "increase") {
        textPara.style.fontSize = (newSize + 2) + unit;
    } else if (action === "decrease") {
        textPara.style.fontSize = (newSize - 2) + unit;
    }
}
