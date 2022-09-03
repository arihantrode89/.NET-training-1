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

    $("label:first").text("Hi this is label by using element and first");


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