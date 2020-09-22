// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

// Create a border around a clicked gear image
function outlineClickedSlot(elem) {

    let selectedElement = elem;

    if (document.getElementsByClassName("selected-item").length > 0) {
        // If the length of the collection is higher than 0 remove all the active classes
        // While the list should always be at max 1 long, let it loop through it regardless just in case.
        let activeElements = document.getElementsByClassName("selected-item");

        for (let ii = 0; ii < activeElements.length; ii++) {
            activeElements[ii].classList.remove("selected-item");
        }
    }


    selectedElement.classList.add("selected-item");

    return true;
}