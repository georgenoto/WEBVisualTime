(() => {
    const form = document.getElementById('seleccion-primas');
    const roles = document.getElementById('paso-roles');
    const offices = document.getElementById('paso-regionales');
    const count = name => form.querySelectorAll(`input[name="${name}"]:checked`).length;
    const volume = document.getElementById('volumen');
    const update = () => { volume.textContent = `${Number(volume.dataset.filas).toLocaleString()} filas × ${count('roles')} roles × ${count('regionales')} regionales = ${(Number(volume.dataset.filas) * count('roles') * count('regionales')).toLocaleString()} tarifas`; };
    document.getElementById('siguiente-regionales').addEventListener('click', () => {
        if (!count('roles')) { alert('Seleccione al menos un rol.'); return; }
        roles.hidden = true; offices.hidden = false; update();
    });
    document.getElementById('volver-roles').addEventListener('click', () => { offices.hidden = true; roles.hidden = false; });
    form.addEventListener('change', update);
    form.addEventListener('submit', e => { if (!count('roles') || !count('regionales')) { e.preventDefault(); alert('Seleccione al menos un rol y una regional.'); } });
})();
