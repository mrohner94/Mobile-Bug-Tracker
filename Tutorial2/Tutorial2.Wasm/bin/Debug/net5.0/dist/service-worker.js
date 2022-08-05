console.debug("[ServiceWorker] Initializing");

let config = {};

self.addEventListener('install', function (e) {
    console.debug('[ServiceWorker] Installing offline worker');
    e.waitUntil(
        fetch("./package_aa6423c3568f8c28fb5c97683c1d62b469363832/uno-config.js")
            .then(r => r.text()
                .then(configStr => {
                    eval(configStr);
                    caches.open('package_aa6423c3568f8c28fb5c97683c1d62b469363832').then(function (cache) {
                        console.debug('[ServiceWorker] Caching app binaries and content');
                        return cache.addAll(config.offline_files);
                    });
                }
                )
            )
    );
});

self.addEventListener('activate', event => {
    event.waitUntil(self.clients.claim());
});

self.addEventListener('fetch', event => {
    event.respondWith(async function () {
        try {
            // Network first mode to get fresh content every time, then fallback to
            // cache content if needed.
            return await fetch(event.request);
        } catch (err) {
            return caches.match(event.request).then(response => {
                return response || fetch(event.request);
            });
        }
    }());
});


// managed