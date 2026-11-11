(() => {
    const base = document.getElementById('moduloBase');
    if (!base) return;
    const update = () => document.querySelectorAll('input[name="destinos"]').forEach(input => {
        input.disabled = input.value === base.value;
        if (input.disabled) input.checked = false;
    });
    base.addEventListener('change', update);
    update();
})();
