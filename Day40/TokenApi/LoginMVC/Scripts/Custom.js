

var token;
function Login() {
    var username = $("#UserName").val();
    var password = $("#Password").val();
    $.ajax({
            type: "POST",
            url: "https://localhost:44347/token",
            data: { Username: username, Password: password, grant_type: "password" },
            success: function (data) {
                token = data.access_token;
                sessionStorage.setItem("token", token);
                postlogin();
            },
            statusCode: {
                400: function (message) {
                    alert(message.responseJSON.error);
                }
            },
        });
}

function postlogin() {
    var token = sessionStorage.getItem('token');
    $.ajax({
        type: "GET",
        url: "https://localhost:44347/GetDetails",
        dataType: "json",
        beforeSend: function (xhr) {
            xhr.setRequestHeader('Authorization', 'Bearer ' + token);
        },
        success: function (data) {
            sessionStorage.setItem("UserName", data.UserName);
            sessionStorage.setItem("Role", data.Role);
            sessionStorage.setItem("Email", data.EmailId);
            if (data.Role == "Admin") {
                window.location.replace("Admin/Index");
            }
            else if (data.Role == "Student") {
                window.location.replace("Student/Index");
            }
        },
        statusCode: {
            401: function (message) {
                alert("Not Authorized");
            }
        },
        failure: function () {
            alert("Hi");
        }
    });
}

function Logout() {
    sessionStorage.clear();
    window.location.replace("https://localhost:44332/");
}

$(document).ready(function () {
    
    
    $("#NameLbl").text(sessionStorage.getItem("UserName"));
    $("#EmailLbl").text(sessionStorage.getItem("Email"));
    $("#RoleLbl").text(sessionStorage.getItem("Role"));

    const forms = $(".needs-validation");
    $.each(forms, function (item, form) {
        form.addEventListener('submit', function (event) {
            if (!form.checkValidity()) {
                event.preventDefault();
                event.stopPropagation();
            }
            form.classList.add('was-validated');
        }, false);

    });
    
    

    
})