//function capturarDatosRegistro() {
//    // Selecciona el formulario
//    const form = document.querySelector("form");
//    const formData = new FormData(form);

//    const nombre = document.getElementById("nombre").value;
//    const apellido = document.getElementById("apellido").value;
//    const dia = document.getElementById("dia").value;
//    const mes = document.getElementById("mes").value;
//    const año = document.getElementById("año").value;
//    const genero = document.getElementById("genero").value;
//    const dni = document.getElementById("dni").value;
//    const celular = document.getElementById("celular").value;
//    const email = document.getElementById("email").value;
//    const accountType = document.querySelector('input[name="accountType"]:checked')?.value;

//    // Crear un objeto con los datos capturados
//    const datosFormulario = {
//        nombre,
//        apellido,
//        dia,
//        mes,
//        año,
//        genero,
//        dni,
//        celular,
//        email,
//        accountType
//    };

//    return datosFormulario;
//}

//// Manejador para el botón "Enviar" en el último paso
//document.querySelector("form").addEventListener("submit", function (e) {
//    e.preventDefault(); // Evita el envío del formulario

//    // Llamada a la función para capturar los datos
//    const datos = capturarDatosRegistro();

//    // Imprimir los datos en la consola
//    console.log("Datos capturados:", datos);
//});

// const signUpFetch = async () => {
//    const user = {
//        name: "alan",
//        lastname: "erriu",
//        password_hash: "alisjhdli",
//        email: "asdijasd@gmail.com",
//        phone_number: "11235689",
//        status: "1",
//        role_id: "1"
//    };
//    console.log("test")
//    try {
//        const response = await fetch("https://localhost:7072/api/auth/signup", {
//            method: "POST",
//            headers: {
//                "Content-Type": "application/json"
//            },
//            body: JSON.stringify(user)
//        });

//        if (!response.ok) {
//            throw new Error("Network response was not ok");
//        }

//        const credentials = await response.json();
//        return credentials;
//    } catch (error) {
//        console.error("There was a problem with the fetch operation:", error);
//    }
//};
const signUpFetch = async () => {
    const user = {
        name: "alan",
        lastname: "erriu",
        password_hash: "alisjhdli",
        email: "asdijasd@gmail.com",
        phone_number: "11235689",
        status: "1",
        role_id: "1"
    };

    try {
        const response = await fetch("https://localhost:7072/api/auth/signup", {
            method: "POST",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify(user)
        });

        if (!response.ok) {
            throw new Error("Network response was not ok");
        }

        const credentials = await response.json();
        return credentials;
    } catch (error) {
        console.error("There was a problem with the fetch operation:", error);
    }
};
