(() => {
    const root = document.getElementById('progreso-primas');
    if (!root) return;
    async function poll() {
        try {
            const response = await fetch(root.dataset.url, { headers: { Accept: 'application/json' }, cache: 'no-store' });
            if (!response.ok) throw new Error();
            const s = await response.json();
            for (const k of ['estado', 'preparados', 'total', 'insertados', 'existentes']) document.getElementById(k).textContent = s[k];
            document.getElementById('barra').value = s.preparados;
            document.getElementById('barra').max = Math.max(1, s.total);
            document.getElementById('error').textContent = s.error || '';
            document.getElementById('error').hidden = !s.error;
            document.getElementById('reanudar').hidden = !['ERROR', 'PAUSADO'].includes(s.estado);
            document.getElementById('cambiar-configuracion').hidden = !['ERROR', 'PAUSADO'].includes(s.estado);
            document.getElementById('pausar').hidden = !['EN_COLA', 'PREPARANDO'].includes(s.estado);
            document.getElementById('conexion').textContent = '';
            if (s.estado === 'COMPLETADO' && root.dataset.estado !== 'COMPLETADO') { window.location.reload(); return; }
            if (['COMPLETADO', 'ERROR', 'PAUSADO', 'BORRADOR', 'REVISADO'].includes(s.estado)) return;
        } catch { document.getElementById('conexion').textContent = 'No se pudo actualizar el progreso. Se volverá a consultar automáticamente.'; }
        setTimeout(poll, 3000);
    }
    if (['EN_COLA', 'PREPARANDO'].includes(root.dataset.estado)) setTimeout(poll, 1500);
})();
