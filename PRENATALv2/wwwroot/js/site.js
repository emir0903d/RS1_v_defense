// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function sh_admin_menu() {
    var l = document.getElementsByClassName("admin_menu_item").length;
    for (var i = 0; i < l; i++) {
        if (!document.getElementsByClassName("admin_menu_item")[i].style.display || document.getElementsByClassName("admin_menu_item")[i].style.display == "none") {
            document.getElementsByClassName("admin_menu_item")[i].style.display = "block";
        }
        else {
            document.getElementsByClassName("admin_menu_item")[i].style.display = "none";
        }
    }

}

function sh_emp_menu() {
    var l = document.getElementsByClassName("emp_item").length;
    for (var i = 0; i < l; i++) {
        if (!document.getElementsByClassName("emp_item")[i].style.display || document.getElementsByClassName("emp_item")[i].style.display == "none") {
            document.getElementsByClassName("emp_item")[i].style.display = "block";
        }
        else {
            document.getElementsByClassName("emp_item")[i].style.display = "none";
        }
    }

}
