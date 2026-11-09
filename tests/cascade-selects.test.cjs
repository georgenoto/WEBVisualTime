const assert = require('node:assert/strict');
const fs = require('node:fs');
const vm = require('node:vm');
const path = require('node:path');
const source = fs.readFileSync(path.join(__dirname, '../WEBVisualTime.Web/wwwroot/js/site.js'), 'utf8');
let checks = 0;
function check(value, message) { assert.ok(value, message); checks++; }
class Element {
    constructor(attributes = {}) { this.attributes = attributes; this.dataset = {}; this.value = ''; this.listeners = {}; this.options = []; }
    getAttribute(name) { return this.attributes[name] ?? null; }
    removeAttribute(name) { delete this.attributes[name]; }
    setAttribute(name, value) { this.attributes[name] = value; }
    addEventListener(name, callback) { (this.listeners[name] ??= []).push(callback); }
    dispatchEvent(event) { (this.listeners[event.type] ?? []).forEach(callback => callback()); }
    after(element) { this.error = element; }
    replaceChildren(...options) { this.options = options; this.value = ''; }
    add(option) { this.options.push(option); }
}
async function tick() { await new Promise(resolve => setImmediate(resolve)); }
async function main() {
    const parent = new Element();
    const child = new Element({ 'data-cascade-parent': 'NCOUNTRY', 'data-cascade-parameter': 'NRESIDENCECOUNTRY', 'data-cascade-url': '/CLIENT/GetByNRESIDENCECOUNTRY' });
    let pending = [], calls = [];
    const sandbox = {
        document: { querySelectorAll: () => [child], getElementsByName: () => [parent], createElement: () => new Element() },
        window: { location: { origin: 'https://example.test' } }, URL, AbortController,
        Option: class { constructor(text, value) { this.text = text; this.value = value; } },
        Event: class { constructor(type) { this.type = type; } },
        fetch: (url, options) => { calls.push({ url, options }); return new Promise((resolve,reject) => pending.push({resolve,reject})); }
    };
    vm.createContext(sandbox); vm.runInContext(source, sandbox);
    sandbox.initCascadeSelects(); sandbox.initCascadeSelects();
    check(parent.listeners.change.length === 1, 'Repeated initialization must not duplicate requests');
    parent.value = 'A&B'; parent.dispatchEvent(new sandbox.Event('change'));
    check(calls[0].url.searchParams.get('NRESIDENCECOUNTRY') === 'A&B', 'Use server parameter mapping and URL encoding');
    check(!calls[0].url.searchParams.has('NCOUNTRY'), 'Do not send the UI field as the wrong API parameter');
    check(child.disabled, 'Prevent posting an option while loading');
    pending.shift().resolve({ ok: true, json: async () => [{ value: '1', text: '<img src=x onerror=alert(1)>' }] }); await tick();
    check(child.options[1].text === '<img src=x onerror=alert(1)>', 'Option text must stay literal text');
    check(!child.disabled && child.options[0].value === '', 'Restore enabled state and a valid empty option');
    parent.value = 'error'; parent.dispatchEvent(new sandbox.Event('change'));
    pending.shift().resolve({ ok: false }); await tick();
    check(child.error.textContent.includes('No se pudieron cargar'), 'HTTP failure must be visible');
    check(child.options.length === 1 && !child.disabled, 'Failed lookup must clear stale options');
    parent.value = 'old'; parent.dispatchEvent(new sandbox.Event('change'));
    const old = pending.shift();
    parent.value = 'new'; parent.dispatchEvent(new sandbox.Event('change'));
    const latest = pending.shift();
    check(calls[calls.length-2].options.signal.aborted, 'Cancel superseded requests');
    latest.resolve({ok:true,json:async()=>[{value:'new',text:'New'}]}); await tick();
    old.resolve({ok:true,json:async()=>[{value:'old',text:'Old'}]}); await tick();
    check(child.options[1].value === 'new', 'Old responses must not replace new options');
    parent.value = ''; parent.dispatchEvent(new sandbox.Event('change'));
    check(child.options.length === 1 && !child.disabled, 'Clearing parent must clear child');
    console.log(`PASS: ${checks} cascade lookup assertions.`);
}
main().catch(error => { console.error(error); process.exitCode = 1; });
