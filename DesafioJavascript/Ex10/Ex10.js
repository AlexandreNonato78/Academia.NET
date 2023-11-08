const individualRadio = document.getElementById("individual");
const legalRadio = document.getElementById("legal");
const cpfLabel = document.getElementById("cpfLabel");
const cnpjLabel = document.getElementById("cnpjLabel");
const birthLabel = document.getElementById("birthLabel");
const nameInput = document.getElementById("name");
const cpfInput = document.getElementById("cpf");
const cnpjInput = document.getElementById("cnpj");
const birthInput = document.getElementById("birth");
const addressInput = document.getElementById("address");
const cepInput = document.getElementById("cep");
const phoneInput = document.getElementById("phone");
const emailInput = document.getElementById("email");
const errorText = document.getElementById("errorText");
const submitButton = document.getElementById("submitButton");

// Adicione eventos de mudança nos radio buttons
individualRadio.addEventListener("change", function () {
    if (individualRadio.checked) {
        cpfLabel.style.display = "block";
        cpfInput.style.display = "block";
        birthLabel.style.display = "block";
        birthInput.style.display = "block";
        cnpjLabel.style.display = "none";
        cnpjInput.style.display = "none";
    }
});

legalRadio.addEventListener("change", function () {
    if (legalRadio.checked) {
        cpfLabel.style.display = "none";
        cpfInput.style.display = "none";
        birthLabel.style.display = "none";
        birthInput.style.display = "none";
        cnpjLabel.style.display = "block";
        cnpjInput.style.display = "block";
    }
});

// Adicione manipuladores de eventos de entrada para verificar o preenchimento dos campos
const inputFields = document.querySelectorAll("input");
inputFields.forEach((input) => {
    input.addEventListener("input", function () {
        if (isFormValid()) {
            submitButton.removeAttribute("disabled");
        } else {
            submitButton.setAttribute("disabled", "disabled");
        }
    });
});

function isFormValid() {
    if (nameInput.value.trim() === "") return false;
    if (individualRadio.checked) {
        if (cpfInput.style.display !== "none" && cpfInput.value.trim() === "") return false;
        if (birthInput.style.display !== "none" && birthInput.value.trim() === "") return false;
    } else if (legalRadio.checked) {
        if (cnpjInput.style.display !== "none" && cnpjInput.value.trim() === "") return false;
    }
    if (addressInput.value.trim() === "") return false;
    if (cepInput.value.trim() === "") return false;
    if (phoneInput.value.trim() === "") return false;
    if (emailInput.value.trim() === "") return false;
    return true;
}

function validateForm() {
    errorText.textContent = ""; // Limpa mensagens de erro

    if (!isFormValid()) {
        errorText.textContent = "Por favor, preencha todos os campos corretamente.";
        return false;
    }

    // Se o formulário foi preenchido corretamente, abre uma nova página com a mensagem
    const successMessage = "Cadastro realizado com sucesso!";
    const newWindow = window.open("", "_blank");
    newWindow.document.write("<h1>" + successMessage + "</h1>");
    newWindow.document.close();

    return true; // Permite a submissão do formulário
}
