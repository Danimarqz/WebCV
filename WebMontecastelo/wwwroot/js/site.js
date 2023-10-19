// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.getElementById("work").onclick = function () { show("work") }
document.getElementById("education").onclick = function () { show("education") }
document.getElementById("contact").onclick = function () { show("contact") }
document.getElementById("languages").onclick = function () { show("languages") }
document.getElementById("skill").onclick = function () { show("skill") }
document.getElementById("softskills").onclick = function () { show("softskills") }


function show(id) {
    var hidden = document.getElementById(id).nextElementSibling;
    if (hidden.style.display === "none") {
        hidden.style.display = "block";
    } else {
        hidden.style.display = "none";
    }
}