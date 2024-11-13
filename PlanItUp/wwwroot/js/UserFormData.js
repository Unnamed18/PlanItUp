// Función para capturar los datos del formulario de registro en un objeto FormData
function capturarDatosRegistro() {
    // Selecciona el formulario
    const form = document.querySelector("form");

    // Crear un objeto FormData y agregar todos los campos del formulario
    const formData = new FormData(form);

    // Captura datos del formulario en el objeto FormData
    const nombre = document.getElementById("nombre").value;
    const apellido = document.getElementById("apellido").value;
    const dia = document.getElementById("dia").value;
    const mes = document.getElementById("mes").value;
    const año = document.getElementById("año").value;
    const genero = document.getElementById("genero").value;
    const dni = document.getElementById("dni").value;
    const celular = document.getElementById("celular").value;
    const email = document.getElementById("email").value;
    const accountType = document.querySelector('input[name="accountType"]:checked')?.value;

    // Agregar valores al FormData
    formData.append("nombre", nombre);
    formData.append("apellido", apellido);
    formData.append("dia", dia);
    formData.append("mes", mes);
    formData.append("año", año);
    formData.append("genero", genero);
    formData.append("dni", dni);
    formData.append("celular", celular);
    formData.append("email", email);
    if (accountType) formData.append("accountType", accountType);

    return formData;
}

// Funciones para manejar el flujo de pasos
function goToStep(step) {
    const steps = document.querySelectorAll(".form-step");
    steps.forEach((el, index) => {
        el.style.display = (index === step - 1) ? "block" : "none";
    });
}

//// Manejador para el botón "Enviar" en el último paso
//document.querySelector("form").addEventListener("submit", function (e) {
//    e.preventDefault(); // Evita el envío del formulario

//    // Llamada a la función para capturar los datos
//    const formData = capturarDatosRegistro();

//    // Aquí puedes procesar los datos o enviarlos al servidor usando fetch/axios
//    console.log("Datos capturados:", formData);
//    // Ejemplo de envío:
//    // fetch("/tu-endpoint", { method: "POST", body: formData });
//});

//// Manejadores de eventos para el modal
//document.getElementById("open-modal").onclick = function () {
//    document.getElementById("modal").style.display = "block";
//};
//document.getElementById("close-modal").onclick = function () {
//    document.getElementById("modal").style.display = "none";
//};
//window.onclick = function (event) {
//    if (event.target == document.getElementById("modal")) {
//        document.getElementById("modal").style.display = "none";
//    }
//};