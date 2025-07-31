// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function abrirModal(modalId) {
    const modal = document.getElementById(modalId);
    if (modal) {
        modal.classList.add('visible');
    }
    const fondo = document.getElementById('modalBackground');
    if (fondo) {
        fondo.style.display = 'block';
    }
}

function cerrarModal(modalId) {
    const modal = document.getElementById(modalId);
    if (modal) {
        modal.classList.remove('visible');
    }
    const fondo = document.getElementById('modalBackground');
    if (fondo) {
        fondo.style.display = 'none';
    }
}

function mostrarAlerta({
    titulo = '¡Alerta!',
    texto = '',
    icono = 'info',
    confirmButtonText = 'Aceptar',
    showCancelButton = false,
    cancelButtonText = 'Cancelar',
    callback = null
}) {
    Swal.fire({
        title: titulo,
        text: texto,
        icon: icono,
        showCancelButton: showCancelButton,
        confirmButtonText: confirmButtonText,
        cancelButtonText: cancelButtonText
    }).then((result) => {
        if (result.isConfirmed && typeof callback === 'function') {
            callback(); // Ejecuta la función si se confirma
        }
    });
}
