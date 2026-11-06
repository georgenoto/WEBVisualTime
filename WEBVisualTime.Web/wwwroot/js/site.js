// Listing paging and search run on the server.

// Cascade selects
function initCascadeSelects() {
    document.querySelectorAll('.cascade-select').forEach(function (child) {
        var parentName = child.getAttribute('data-cascade-parent');
        var parentSelect = document.querySelector('[name="' + parentName + '"]');
        if (!parentSelect) return;
        var cascadeUrl = child.getAttribute('data-cascade-url');
        function loadOptions() {
            var parentVal = parentSelect.value;
            var currentVal = child.value || child.getAttribute('data-current-value');
            if (!parentVal) {
                child.innerHTML = '<option value=">-- Seleccione --</option>';
                return;
            }
            fetch(cascadeUrl + '?' + parentName + '=' + encodeURIComponent(parentVal))
                .then(function (r) { return r.json(); })
                .then(function (data) {
                    var html = '<option value=">-- Seleccione --</option>';
                    data.forEach(function (item) {
                        html += '<option value="' + item.value + '">' + item.text + '</option>';
                    });
                    child.innerHTML = html;
                    child.value = currentVal;
                    child.removeAttribute('data-current-value');
                });
        }
        parentSelect.addEventListener('change', loadOptions);
        if (parentSelect.value) loadOptions();
    });
}
