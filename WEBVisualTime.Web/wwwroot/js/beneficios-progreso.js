(() => {
    const panel = document.getElementById('beneficios-progreso');
    if (!panel) return;
    const poll = async () => {
        try {
            if (!document.hidden) {
                const response = await fetch(panel.dataset.url, { cache: 'no-store' });
                if (response.ok) {
                    const state = await response.json();
                    if (state.estado !== panel.dataset.estado || String(state.preparados) !== panel.dataset.preparados) {
                        window.location.reload();
                        return;
                    }
                }
            }
        } catch { /* Keep the manual refresh link available during connection loss. */ }
        window.setTimeout(poll, 5000);
    };
    window.setTimeout(poll, 5000);
})();
