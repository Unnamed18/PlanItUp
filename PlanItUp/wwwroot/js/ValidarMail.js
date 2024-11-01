function validarCorreo(email) {
    // Expresión regular para validar correos de dominios específicos y variantes como .com.ar
    const regex = /^[a-zA-Z0-9._%+-]+@(hotmail|outlook|gmail|yahoo)\.(com|com\.ar)$/;
    return regex.test(email);
}

const correo = document.getElementById("email");

correo.addEventListener("input", function () {
    if (!validarCorreo(correo.value)) {
        correo.setCustomValidity("Por favor, ingrese un correo válido de Hotmail, Outlook, Gmail o Yahoo.");
    } else {
        correo.setCustomValidity(""); // Restablecer el mensaje de validación si es válido
    }
});