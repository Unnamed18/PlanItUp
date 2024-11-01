// Obtener elementos
const modal = document.getElementById('modal');
const openModalButton = document.getElementById('open-modal');
const closeModalButton = document.getElementById('close-modal');
const submitModalButton = document.getElementById('submit-modal');

// Abrir modal al hacer clic en "Crear cuenta"
openModalButton.addEventListener('click', function (event) {
    event.preventDefault();  // Evitar que siga el enlace
    modal.style.display = 'flex';  // Mostrar modal
});

// Cerrar modal al hacer clic en la "X"
closeModalButton.addEventListener('click', function () {
    modal.style.display = 'none';
});

// Cerrar modal al hacer clic en "Confirmar"
submitModalButton.addEventListener('click', function () {
    const selectedOption = document.querySelector('input[name="accountType"]:checked');
    if (selectedOption) {
        alert(Seleccionaste: ${ selectedOption.value });
        modal.style.display = 'none';
    } else {
        alert('Por favor, selecciona una opción.');
    }
});