
const API_LINK = 'http://localhost:56191/api';
var currentStudent;

function renderMenuLeft(items) {
    var ul = document.querySelector('#left-menu ul');

    for (var i = 0; i < items.length; i++) {
        // Preparation for each <li> 
        var li = document.createElement('li');
        li.id = items[i].Id;
        li.className = 'list-group-item';
        li.textContent = items[i].Id + " post";

        // Bind click event to li element
        li.onclick = function () {
            var liPreviousActive = document.getElementsByClassName('active');
            if (liPreviousActive.length > 0) {
                liPreviousActive[0].className = 'list-group-item';
            }
            this.className = 'list-group-item active';
            var hardwareIndex = document.getElementById(this.id);
            var foundHardware = items.find(function (hardware) {
                return hardware.Id == hardwareIndex.id;
            });
            renderDetail(foundHardware);
        };

        // Li finally created is rendering in HTML
        ul.appendChild(li);
    }

}

function renderDetail(item) {
    document.querySelector('.card-title').textContent = item.FirstName;
    var ul = document.querySelector('#detail ul');
    var ulTextContent = '';
    // For each key-value pair in object create new li
    ulTextContent = item.LastName;

    //Replace old values with new properties
    ul.innerHTML = ulTextContent;
    currentStudent = item;
}

$(document).ready(function () {
    console.log('Hello! Your document is ready');

    var students = [
        { FirstName: 'John', LastName: 'Smith', City: 'London', Id: 10 },
        { FirstName: 'Anne', LastName: 'Smith', City: 'Wrocław', Id: 13 },
    ];

    $('.dropdown-item').click(function (event) {
        $('input[name="city"]').val(event.target.textContent);
    })
    // Asynchronous Javascript for obtaining list of students    
    var request = $.ajax({
        url: API_LINK + '/students',
        method: "GET",
        dataType: "json"
    });

    //When server responds:
    request.done(function (response) {
        students = response;
        renderMenuLeft(students);
        renderDetail(students[1]);

    });
    $('#saveButton').click(function () {
        $('#modal').modal('close');
        // Creating new student collecting values from form
        var newStudent = {
            FirstName: $('input[name = "firstname"]').val(),
            LastName: $('input[name = "lastname"]').val(),
        };

        var requestPOST = $.ajax({
            url: API_LINK + '/students',
            method: "POST",
            dataType: "json",
            data: newStudent,
        });

        //When server responds:
        requestPOST.done(function (response) {
            students.push(response);
            renderMenuLeft(students);
        });
    });

});



//funkcja dodająca i usuwajaca odpowiednie klasy w trakcie trwania preloadera
var preloaderEl = document.querySelector('.preloader');
setTimeout(function () {

    preloaderEl.classList.add('preloader-hiding');

    preloaderEl.addEventListener('transitionend', function () {

        this.classList.add('preloader-hidden');
        this.classList.remove('preloader-hiding');
    });

}, 2000);


// Scroll to specific values
// scrollTo is the same
window.scroll({
    // top: 2500, 
    left: 0,
    behavior: 'smooth'
});

// Scroll certain amounts from current position 
window.scrollBy({
    //top: 100, // could be negative value
    left: 0,
    behavior: 'smooth'
});

// Scroll to a certain element
document.querySelector('.hello').scrollIntoView({
    behavior: 'smooth'
});
