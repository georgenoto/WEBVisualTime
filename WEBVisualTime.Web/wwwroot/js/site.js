// Listing paging and search run on the server.
function initCascadeSelects() {
    document.querySelectorAll('.cascade-select').forEach(function (child) {
        if (child.dataset.cascadeInitialized) return;
        child.dataset.cascadeInitialized = 'true';
        var parentName = child.getAttribute('data-cascade-parent');
        var parentSelect = document.getElementsByName(parentName)[0];
        if (!parentSelect) return;
        var pending;
        var version = 0;
        var error = document.createElement('span');
        error.className = 'text-danger';
        error.setAttribute('role', 'alert');
        child.after(error);
        function empty() { child.replaceChildren(new Option('-- Seleccione --', '')); }
        async function loadOptions() {
            var currentVersion = ++version;
            if (pending) pending.abort();
            var parentVal = parentSelect.value;
            var currentVal = child.value || child.getAttribute('data-current-value');
            error.textContent = '';
            if (!parentVal) { empty(); child.disabled = false; child.dispatchEvent(new Event('change')); return; }
            pending = new AbortController();
            child.disabled = true;
            try {
                var url = new URL(child.getAttribute('data-cascade-url'), window.location.origin);
                url.searchParams.set(child.getAttribute('data-cascade-parameter') || parentName, parentVal);
                var response = await fetch(url, { signal: pending.signal });
                if (!response.ok) throw new Error('Lookup request failed');
                var data = await response.json();
                if (!Array.isArray(data)) throw new Error('Invalid lookup response');
                if (currentVersion !== version) return;
                empty();
                data.forEach(function (item) { child.add(new Option(item.text, item.value)); });
                child.value = currentVal || '';
                child.removeAttribute('data-current-value');
                child.dispatchEvent(new Event('change'));
            } catch (failure) {
                if (currentVersion === version && failure.name !== 'AbortError') {
                    empty();
                    error.textContent = 'No se pudieron cargar las opciones. Vuelva a seleccionar el valor anterior para reintentar.';
                    child.dispatchEvent(new Event('change'));
                }
            } finally {
                if (currentVersion === version) child.disabled = false;
            }
        }
        parentSelect.addEventListener('change', loadOptions);
        if (parentSelect.value) loadOptions();
    });
}
