// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function fnChange() {
    var eleSel = document.getElementById('select1').value;
    var eleLbl = document.getElementById('lbl1');
    var eleTxt = document.getElementById('txt1');
    var eleBtn = document.getElementById('btn1');
    
    if (eleSel == "0") {
        eleLbl.textContent = "";
        eleTxt.placeholder = "";

        eleLbl.style.display = "none";
        eleTxt.style.display = "none";
        eleBtn.style.display = "none";
    }

    //Credit Card
    else if (eleSel == "1") {
        eleLbl.textContent = "Credit Card No";
        eleTxt.placeholder = "Enter Credit Card No";

        eleLbl.style.display = "";
        eleTxt.style.display = "";
        eleBtn.style.display = "";
    }

    //UPI
    else if (eleSel == "2") {
        eleLbl.textContent = "UPI Id";
        eleTxt.placeholder = "Enter UPI Id";

        eleLbl.style.display = "";
        eleTxt.style.display = "";
        eleBtn.style.display = "";
    }
}

function fnValidate() {

    var eleLbl = document.getElementById('lbl2');

    if (document.getElementById('select1').value == "1") {

        var regexPattern = /^(?:4[0-9]{12}(?:[0-9]{3})?)$/;

        if (document.getElementById('txt1').value.match(regexPattern)) {
            eleLbl.textContent = "Validated Successfully";
            eleLbl.style.color = "green";
            eleLbl.style.display = "";
        }
        else {
            document.getElementById('txt1').value = "";
            eleLbl.textContent = "Validation Failed";
            eleLbl.style.color = "red";
            eleLbl.style.display = "";
        }
    }
    else if (document.getElementById('select1').value == "2") {
        alert('##  No Validation set for this option  ##');
    }
}