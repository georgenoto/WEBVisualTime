// DataTable pagination and search
function initDataTables() {
    var wrappers = document.querySelectorAll('.data-table-wrapper');
    wrappers.forEach(function (wrapper) {
        var table = wrapper.querySelector('.data-table');
        if (!table) return;
        var tbody = table.querySelector('tbody');
        if (!tbody) return;

        var allRows = Array.from(tbody.querySelectorAll('tr'));
        if (allRows.length === 0) return;
        if (allRows.length === 1 && allRows[0].querySelector('td[colspan]')) return;

        var pageSize = parseInt(wrapper.getAttribute('data-page-size')) || 20;
        var pagination = wrapper.querySelector('.data-table-pagination');
        var info = wrapper.querySelector('.data-table-info');
        var pageSizeSelect = wrapper.querySelector('.page-size-select');
        var searchInput = wrapper.querySelector('.data-table-search');
        var currentPage = 1;
        var filteredRows = allRows.slice();
        var debounceTimer = null;

        function getFilteredRows() {
            var query = searchInput ? searchInput.value.toLowerCase().trim() : '';
            if (!query) return allRows;
            return allRows.filter(function (row) {
                var cells = row.querySelectorAll('td');
                for (var i = 0; i < cells.length - 1; i++) {
                    if (cells[i].textContent.toLowerCase().includes(query)) {
                        return true;
                    }
                }
                return false;
            });
        }

        function renderPage(page) {
            filteredRows = getFilteredRows();

            var totalPages = Math.ceil(filteredRows.length / pageSize) || 1;
            if (page < 1) page = 1;
            if (page > totalPages) page = totalPages;
            currentPage = page;

            allRows.forEach(function (row) {
                row.style.display = 'none';
            });

            filteredRows.forEach(function (row, index) {
                var pageNum = Math.floor(index / pageSize) + 1;
                row.style.display = pageNum === page ? '' : 'none';
            });

            if (info) {
                if (filteredRows.length === 0) {
                    info.textContent = '0 resultados';
                } else {
                    var start = (page - 1) * pageSize + 1;
                    var end = Math.min(page * pageSize, filteredRows.length);
                    info.textContent = start + '-' + end + ' de ' + filteredRows.length;
                }
            }

            if (!pagination) return;

            var html = '';
            html += '<li class="page-item' + (page === 1 ? ' disabled' : '') + '">';
            html += '<a class="page-link" href="#" data-page="' + (page - 1) + '" tabindex="-1">&laquo;</a></li>';

            var maxVisible = 5;
            var startPage = Math.max(1, page - Math.floor(maxVisible / 2));
            var endPage = Math.min(totalPages, startPage + maxVisible - 1);
            if (endPage - startPage < maxVisible - 1) {
                startPage = Math.max(1, endPage - maxVisible + 1);
            }

            if (startPage > 1) {
                html += '<li class="page-item"><a class="page-link" href="#" data-page="1">1</a></li>';
                if (startPage > 2) html += '<li class="page-item disabled"><span class="page-link">...</span></li>';
            }

            for (var i = startPage; i <= endPage; i++) {
                html += '<li class="page-item' + (i === page ? ' active' : '') + '">';
                html += '<a class="page-link" href="#" data-page="' + i + '">' + i + '</a></li>';
            }

            if (endPage < totalPages) {
                if (endPage < totalPages - 1) html += '<li class="page-item disabled"><span class="page-link">...</span></li>';
                html += '<li class="page-item"><a class="page-link" href="#" data-page="' + totalPages + '">' + totalPages + '</a></li>';
            }

            html += '<li class="page-item' + (page === totalPages ? ' disabled' : '') + '">';
            html += '<a class="page-link" href="#" data-page="' + (page + 1) + '">&raquo;</a></li>';

            pagination.innerHTML = html;

            pagination.querySelectorAll('.page-link[data-page]').forEach(function (link) {
                link.addEventListener('click', function (e) {
                    e.preventDefault();
                    var p = parseInt(this.getAttribute('data-page'));
                    if (!isNaN(p) && p >= 1 && p <= totalPages) renderPage(p);
                });
            });
        }

        if (pageSizeSelect) {
            pageSizeSelect.value = pageSize;
            pageSizeSelect.addEventListener('change', function () {
                pageSize = parseInt(this.value);
                wrapper.setAttribute('data-page-size', pageSize);
                renderPage(1);
            });
        }

        if (searchInput) {
            searchInput.addEventListener('input', function () {
                if (debounceTimer) clearTimeout(debounceTimer);
                debounceTimer = setTimeout(function () {
                    renderPage(1);
                }, 300);
            });
        }

        renderPage(1);
    });
}

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
