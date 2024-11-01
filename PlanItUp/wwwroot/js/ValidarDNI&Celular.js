document.getElementById("dni").addEventListener("input", function () {
    if (this.value.length > 8) {
        this.value = this.value.slice(0, 8); // Limitar a 8 caracteres
    }
});

document.getElementById("celular").addEventListener("input", function () {
    if (this.value.length > 10) {
        this.value = this.value.slice(0, 9); // Limitar a 11 caracteres
    }
});