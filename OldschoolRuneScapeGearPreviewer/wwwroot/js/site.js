﻿// Create a border around a clicked gear image
function outlineClickedSlot(elem) {

    let selectedElement = elem;

    if (document.getElementsByClassName("selected-item").length > 0) {
        // If the length of the collection is higher than 0 remove all the active classes
        // While the list should always be at max 1 long, let it loop through it regardless just in case.
        let activeElements = document.getElementsByClassName("selected-item");

        // Remove the class from the classlist of the element
        for (let ii = 0; ii < activeElements.length; ii++) {
            activeElements[ii].classList.remove("selected-item");
        }
    }

    // Add the class to the elements classlist
    selectedElement.classList.add("selected-item");

    return true;
}

// Retrieve all the items with that type
function getItems(type) {

    var dataValue = { "type": type };

    $.ajax({
        type: "GET",
        url: "/Index?handler=Items",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        data: { "Type": type },
        headers: {
            RequestVerificationToken:
                $('input:hidden[name="__RequestVerificationToken"]').val()
        },
        error: function (error) {
            console.log(error);
        },
        success: function (result) {
            console.log("We returned: " + result);
        }
    });
}