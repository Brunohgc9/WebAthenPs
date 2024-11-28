window.triggerFileInput = function (fileInputId) {
    var fileInput = document.getElementById(fileInputId);
    if (fileInput) {
        fileInput.click();
    }
}
