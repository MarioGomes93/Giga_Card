﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function downloadPDF() {
    const item = document.querySelector(".Content");

    var opt = {
        margin: 1,
        filename: "meucard.pdf",
        html2canvas: { scale: 2 },
        jsPDF: { unit: "in", format: "letter", orientation: "portrait" },
    };

    html2pdf().set(opt).from(item).save(src ="~/Área de Trabalho/Teste");
}

/*function onStartedDownload() {
    console.log(`Started downloading: ${id}`);
}

function onFailed(error) {
    console.log(`Download failed: ${error}`);
}

let downloadUrl = ".Content";

let downloading = browser.downloads.download({
    url: downloadUrl,
    filename: 'my-image-again.png',
    conflictAction: 'uniquify'
});*/

/*downloading.then(onStartedDownload, onFailed);*/

/*}*/