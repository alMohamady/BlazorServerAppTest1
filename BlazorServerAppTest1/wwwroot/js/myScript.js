function successMessage(studentname, grade) {
    //alert(studentname + ' in ' + grade + ' has been saved successfully');

    document.getElementById('validationSection').innerHTML =
        studentname + ' in ' + grade + ' has been saved successfully !';
}

function setFocus(element) {
    element.focus();
}

function getSchools() {
    var schools = ["new School", "international School", "my School", "town School"];
    return schools;
}