//alert("I am alerting you");

//var result = confirm("Are you sure to enter our site?");

//if (result) {

//    var str = prompt("Enter your Name");
//    alert("Welcome" + str);
//}
//else {
//    alert("Go to Hell");
//}


//$(document).ready(function () {
//    alert("document is ready");
//});

//alert("Hihi");
//console.log("Bye");



function myfunction(color) {
    $("#key").css("background-color", color);

    //we can use function inside are jquery
}

function FormSubmit() {
    obj = { Name: $("#Name").val(), City: $("#City").val(), Gender: $("#Gender").val(), Salary: $("#Salary").val(), DepartmentId: 1 };
    console.log(obj);
    $.ajax({
        type: "POST",
        url: "https://localhost:44333/AddEmployee",
        dataType: "json",
        headers: { 'Access-Control-Allow-Origin': '*', "Access-Control-Allow-Methods": "GET,POST" },
        data: obj,
        success: function () { alert("Done"); },
        failure: function () { alert("Fail"); }
    });
}


function search() {
    var username = $("#search").val();
    console.log(username);
    $.ajax({
        type: "GET",
        url: "https://localhost:44333/getempdetailsname?Name="+username,
        dataType: "json",
        headers: { 'Access-Control-Allow-Origin': '*', "Access-Control-Allow-Methods": "GET,POST" },
        success: function (data) {
            var row = "<ul>" + "<li>" + data.Name + "</li>" +
                "<li>" + data.City + "</li>" +
                "<li>" + data.Salary + "</li>" +
                "<li>" + data.Gender + "</li>"
                + "</ul>"

            $("div").append(row);
        },
        failure: function () { alert("Fail"); }
    });

}

function editUi() {
    var username = $("#search").val();
    console.log(username);
    $.ajax({
        type: "GET",
        url: "https://localhost:44333/getempdetailsname?Name=" + username,
        dataType: "json",
        headers: { 'Access-Control-Allow-Origin': '*', "Access-Control-Allow-Methods": "GET,POST" },
        success: function (data) {
            var ip = "<input type=text id=0 value=1 /> <br/><br/>"
            var row1 =
                "<br/><br/><br/><br/><br/><br/>" +
                "<form id = 'editform'>" +
                "<input type='hidden' id=0 value=1 />".replace("0", "EmployeeId").replace("1",data.EmployeeId)+
                ip.replace("0", "Name").replace("1",data.Name) +
                ip.replace("0", "City").replace("1", data.City) +
                ip.replace("0", "Salary").replace("1", data.Salary) +
                ip.replace("0", "Gender").replace("1", data.Gender) +
                ip.replace("0", "DepartmentId").replace("1", data.DepartmentId) +
                "<input type='button' id='editbtn' value='Edit' onclick='edit();' " +
                "</form>"
            $("div").append(row1);
        },
        failure: function () { alert("Fail"); }
    });

}


function edit() {
    obj = { EmployeeId:$("#EmployeeId").val(),Name: $("#Name").val(), City: $("#City").val(), Gender: $("#Gender").val(), Salary: $("#Salary").val(), DepartmentId: $("#DepartmentId").val() };
    console.log(obj);
    $.ajax({
        type: "PUT",
        url: "https://localhost:44333/EditEmployee",
        dataType: "json",
        headers: { 'Access-Control-Allow-Origin': '*', "Access-Control-Allow-Methods": "GET,POST" },
        data: obj,
        success: function () { alert("Done"); },
        failure: function () { alert("Fail"); }
    });
}



function passstrength() {
    var psd = $("#pass").val();
    if (psd.length > 10) {
        $("#lbl").text("Too strong");
        $("#lbl").css("background-color", "Green");
    }
    else if ((psd.length < 10) && (psd.length > 5)) {
        $("#lbl").text("strong");
        $("#lbl").css("background-color", "lightgreen");
    }
    else if ((psd.length < 5) && (psd.length > 3)) {
        $("#lbl").text("Good");
        $("#lbl").css("background-color", "Yellow");
    }
    else if ((psd.length < 3) && (psd.length > 1)) {
        $("#lbl").text("Weak");
        $("#lbl").css("background-color", "Red");
    }
}

$(document).ready(function () {
    $("#abc").click(function () {
        $("div").animate({ left: '200px' });
    })

    $("#username").dblclick(function () {
        //alert("You double clicked on button!")
        var str = prompt("Enter you name");
        $(".classp").text(str);
    })

    //select all label element until we specify its class
    //$("label").text("Hi this is label");

    //it will select label elements who have lbl class
    $("label.lbl").text("Hi this is label by using element and class");

    //$("label:first").text("Hi this is label by using element and first");


    $("#key").keyup(function () {
        myfunction("Red")
    })

    $("#key").keydown(function () {
        myfunction("Green");
    })

    $("#key").keypress(function () {
        myfunction("Yellow");
    })

    
    $("#pass").keyup(function () {
        passstrength();
    });

})