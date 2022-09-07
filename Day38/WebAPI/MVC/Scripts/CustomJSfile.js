function FormSubmit() {
    obj = { Name: $("#Name").val(), City: $("#City").val(), Gender: $("#Gender").val(), Salary: $("#Salary").val(), DepartmentId: 1 };
    console.log(obj);
    $.ajax({
        type: "POST",
        url: "https://localhost:44372/AddEmployee",
        dataType: "json",
        headers: { 'Access-Control-Allow-Origin': '*', "Access-Control-Allow-Methods": "GET,POST" },
        data: obj,
        success: function () { Redirect("Employee/Index") },
        failure: function () { alert("Fail"); }
    });
}



function search() {
    var username = $("#search").val();
    console.log(username);
    $.ajax({
        type: "GET",
        url: "https://localhost:44372/getempdetailsname?Name=" + username,
        dataType: "json",
        headers: { 'Access-Control-Allow-Origin': '*', "Access-Control-Allow-Methods": "GET,POST" },
        success: function (data) {
            var row = "<ul>" + "<li>" + data.Name + "</li>" +
                "<li>" + data.City + "</li>" +
                "<li>" + data.Salary + "</li>" +
                "<li>" + data.Gender + "</li>" +
                "<li>" + data.DepartmentId + "</li>"
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
        url: "https://localhost:44372/getempdetailsname?Name=" + username,
        dataType: "json",
        headers: { 'Access-Control-Allow-Origin': '*', "Access-Control-Allow-Methods": "GET,POST" },
        success: function (data) {
            
            $("#EmployeeIdEdit").val(data.EmployeeId);
            $("#NameEdit").val(data.Name);
            $("#CityEdit").val(data.City);
            $("#GenderEdit").val(data.Gender);
            $("#SalaryEdit").val(data.Salary);
            $("#DepartmentIdEdit").val(data.DepartmentId);
        },
        failure: function () { alert("Fail"); }
    });

}


function edit(key) {
    //obj = { EmployeeId: $("#EmployeeId").val(), Name: $("#Name").val(), City: $("#City").val(), Gender: $("#Gender").val(), Salary: $("#Salary").val(), DepartmentId: $("#DepartmentId").val() };
    var sel = $("#" + key + ">td").children();
    var Id = $(sel[0]).val();
    var Name = $(sel[1]).val();
    var City = $(sel[2]).val();
    var Salary = $(sel[3]).val();
    var Gender = $(sel[4]).val();
    var DeptId = $(sel[5]).val();
    obj = { EmployeeId: Id, Name: Name, City: City, Gender: Gender, Salary: Salary, DepartmentId: DeptId };
    console.log(obj);
    $.ajax({
        type: "PUT",
        url: "https://localhost:44372/EditEmployee",
        dataType: "json",
        headers: { 'Access-Control-Allow-Origin': '*', "Access-Control-Allow-Methods": "GET,POST" },
        data: obj,
        success: function () { Redirect("Index"); },
        failure: function () { alert("Fail"); }
    });
}

function editmodal() {
    obj = { EmployeeId: $("#EmployeeIdEdit").val(), Name: $("#NameEdit").val(), City: $("#CityEdit").val(), Gender: $("#GenderEdit").val(), Salary: $("#SalaryEdit").val(), DepartmentId: $("#DepartmentIdEdit").val() };
    console.log(obj);
    $.ajax({
        type: "PUT",
        url: "https://localhost:44372/EditEmployee",
        dataType: "json",
        headers: { 'Access-Control-Allow-Origin': '*', "Access-Control-Allow-Methods": "GET,POST" },
        data: obj,
        success: function () { $("#modalid1").modal('hide'); },
        failure: function () { alert("Fail"); }
    });
}


function searchauto() {

    $("#search").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: "https://localhost:44372/GetEmployee",
                type: "GET",
                dataType: "json",
                success: function (data) {
                    response($.map(data, function (item) {
                        return { label: item.Name, value: item.Name };
                    }))

                }
            })
        }
    });
    
}


function dynamicedit() {
    $.ajax({
        type: "GET",
        url: "https://localhost:44372/GetEmployee",
        dataType: "json",
        headers: { 'Access-Control-Allow-Origin': '*', "Access-Control-Allow-Methods": "GET,POST" },
        success: function (data) {
            var ip = "<td><input type=text id=0 value='1' /></td>"
            $("#emptable").append(" ");
            $.each(data, function (key, data) {
                var row1 =
                    "<tr id='1' >".replace("1",key)+
                "<td> <input disabled='disabled' id=0 value=1 /> </td>".replace("0", "EmployeeId").replace("1", data.EmployeeId) +
                    ip.replace("0", "Name").replace("1", data.Name) +
                    ip.replace("0", "City").replace("1", data.City) +
                    ip.replace("0", "Salary").replace("1", data.Salary) +
                    ip.replace("0", "Gender").replace("1", data.Gender) +
                    ip.replace("0", "DepartmentId").replace("1", data.DepartmentId) +
                    "<td> <input type='submit' id='editbtn' value='Edit' onclick='edit(" + key + ");'> </td> " +
                    "<td> <input type='submit' id='delbtn' value='Delete' onclick='deleteemp("+data.EmployeeId+");'> </td> "+ "</tr>"
                $("#emptable").append(row1);

            })

        },
        failure: function () { alert("Fail"); }
    });
}

function viewdata() {
    $.ajax({
        type: "GET",
        url: "https://localhost:44372/GetEmployee",
        contentType: "application/json",
        dataType: "json",
        headers: { 'Access-Control-Allow-Origin': '*', "Access-Control-Allow-Methods": "GET,POST" },
        success: function (data) {
            //data = JSON.stringify(data);
            console.log(data);
            var editbtn = '<input id="edit" type="button" value="Edit" onclick="editUi();" />';
            $.each(data, function (index, value) {
                console.log(value.Name);
                $("#emptable").append("<tr><td>" + value.EmployeeId + "</td> <td>" + value.Name + "</td> <td>" + value.City + "</td><td>" + value.Salary + "</td><td>" + value.Gender + "</td> <td>" + value.DepartmentId + "</td> </tr>");
            });

        },
        failure: function (data) { alert(data); },
    });
}

function Redirect(url) {

    window.location.href = url;
    /*window.location.replace(url);*/
}

function GetDepartmentsAuto() {

    $.ajax({
        type: "GET",
        url: "https://localhost:44372/GetDepartment",
        contentType: "application/json",
        dataType: "json",
        headers: { 'Access-Control-Allow-Origin': '*', "Access-Control-Allow-Methods": "GET,POST" },
        success: function (data) {

            for (var i = 0; i < data.length; i++) {
                $("#DepartmentId").append("<option value="+data[i].DeptId+">"+data[i].DeptName +"</option> ")
                $("#DepartmentIdEdit").append("<option value=" + data[i].DeptId + ">" + data[i].DeptName + "</option> ")
            }
        },
    });
}

function deleteemp(id) {
    $.ajax({
        type: "Delete",
        url: "https://localhost:44372/DelEmployee/"+id,
        dataType: "json",
        headers: { 'Access-Control-Allow-Origin': '*', "Access-Control-Allow-Methods": "GET,POST,Delete" },
        success: function () { Redirect("Index"); },
        failure: function () { alert("Fail"); }
    });
} 

$(document).ready(function () {

    searchauto();
    //$("#search").change(function () {
    //    search();
    //})
    GetDepartmentsAuto();
})


///edit ui component
//var ip = "<input type=text id=0 value='1' /> <br/><br/>"
            //var row1 =
            //    "<br/><br/><br/><br/><br/><br/>" +
            //    "<form id = 'editform'>" +
            //    "<input type='hidden' id=0 value=1 />".replace("0", "EmployeeId").replace("1", data.EmployeeId) +
            //    ip.replace("0", "Name").replace("1", data.Name) +
            //    ip.replace("0", "City").replace("1", data.City) +
            //    ip.replace("0", "Salary").replace("1", data.Salary) +
            //    ip.replace("0", "Gender").replace("1", data.Gender) +
            //    ip.replace("0", "DepartmentId").replace("1", data.DepartmentId) +
            //    "<input type='button' id='editbtn' value='Edit' onclick='edit();' " +
            //    "</form>"
            //$("div").append(row1);