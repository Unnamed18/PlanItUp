function goToStep(step) {
    // Ocultar todos los pasos
    document.querySelectorAll('.form-step').forEach(function (stepElement) {
        stepElement.style.display = 'none';
    });

    // Mostrar el paso actual
    document.getElementById('step' + step).style.display = 'block';
}

// Iniciar con el paso 1 visible
document.getElementById('step1').style.display = 'block';


// Manejo del botón "Confirmar" en el modal
document.getElementById("submit-modal").onclick = function () {
    // Verifica si se ha seleccionado un tipo de cuenta
    const accountType = document.querySelector('input[name="accountType"]:checked');
    if (accountType) {
        // Cierra el modal
        document.getElementById("modal").style.display = "none";

        // Avanza al siguiente paso
        goToStep(4);
    } else {
        alert("Por favor selecciona un tipo de cuenta.");
    }
};