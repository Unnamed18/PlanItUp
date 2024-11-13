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