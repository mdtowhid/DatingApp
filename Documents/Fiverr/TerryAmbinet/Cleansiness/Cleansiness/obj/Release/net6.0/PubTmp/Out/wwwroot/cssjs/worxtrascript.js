/* function to display tool tip */
$(document).ready(function () {
    $('[data-toggle="tooltip"]').tooltip();
});

/* function to toggle between hide and show */
function darkmode() {
    var element = document.body;
    element.classList.toggle("dark-mode-plus")
}

/* function to initialise multi select jquery plugin */
$(function () {
    $('.selectpicker').selectpicker();
});

// the following code puts the name of the file in the upload file box
$(".custom-file-input").on("change", function() {
    var fileName = $(this).val().split("\\").pop();
    $(this).siblings(".custom-file-label").addClass("selected").html(fileName);
  });


  // function to print modal window
document.getElementById("btnPrint").onclick = function () {
    printElement(document.getElementById("printThis"));
}

function printElement(elem) {
    var domClone = elem.cloneNode(true);
    
    var $printSection = document.getElementById("printSection");
    
    if (!$printSection) {
        var $printSection = document.createElement("div");
        $printSection.id = "printSection";
        document.body.appendChild($printSection);
    }
    
    $printSection.innerHTML = "";
    $printSection.appendChild(domClone);
    window.print();
}

/*
$(document).ready(function(){
    activaTab('addpayment');
});

function activaTab(){
    $('.nav-tabs a[href="#addpayment"]').tab('show');
};
*/
