function validateForm() {
    const login = document.getElementById("login").value;
    const password = document.getElementById("password").value;
    const confirmPassword = document.getElementById("confirmPassword").value;
    const errorText = document.getElementById("errorText");

    errorText.textContent = ""; // Limpa mensagens de erro

    if (login.trim() === "" || password.trim() === "" || confirmPassword.trim() === "") {
        errorText.textContent = "Por favor, preencha todos os campos.";
        errorText.classList.remove("hidden");
        return false;
    }

    if (password !== confirmPassword) {
        errorText.textContent = "Senhas diferentes. Digite novamente!";
        errorText.classList.remove("hidden");
        return false;
    }

    if (password.length < 6 || password.length > 10) {
        errorText.textContent = "A senha deve ter entre 6 a 10 caracteres!";
        errorText.classList.remove("hidden");
        return false;
    }

    // Se o formulário foi preenchido corretamente, abre uma nova página com a mensagem
    const successMessage = "Cadastro realizado com sucesso!";
    const newWindow = window.open('', '_blank');
    newWindow.document.write("<h1>" + successMessage + "</h1>");
    newWindow.document.close();

    return false; // Não permite a submissão do formulário
}
