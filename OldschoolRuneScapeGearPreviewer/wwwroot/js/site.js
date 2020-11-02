// Global JavaScript variable so we can access the retrieves items always
let itemList = [];
let selectedItems = {
    "helmet": {},
    "cape": {},
    "neck": {},
    "ammo": {},
    "weapon": {},
    "body": {},
    "shield": {},
    "legs": {},
    "hands": {},
    "feet": {},
    "ring": {}
};

// Create a border around a clicked gear image
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
            let selectDropdown = document.getElementById("selectDropdown");

            // Clear the dropdownlist options first
            let i, L = selectDropdown.options.length - 1;
            for (i = L; i >= 0; i--) {
                selectDropdown.remove(i);
            }

            console.log(JSON.parse(result));

            // Fill the global variable so we can access the results later too
            itemList = JSON.parse(result);

            for (let ii = 0; ii < itemList.length; ii++) {
                var option = document.createElement('option');
                option.text = itemList[ii].name;
                option.value = itemList[ii].name;
                option.setAttribute("onclick", "selectItem('" + itemList[ii].name +"')");

                selectDropdown.add(option, 0);
            }
        }
    });
}

// Select an item from the dropdown menu
function selectItem(name) {
    // Only 1 selected-item class can be active
    let selectedSlot = document.getElementsByClassName("selected-item")[0];

    // We NEED to have the old item that was selected in order to correctly calculate the new stats
    let oldItem = selectedItems[selectedSlot];
    let newItem = itemList.find(i => i.name === name);

    // Call the updateBonusses method which will update all the bonusses on its own
    updateBonusses(oldItem, newItem);

    // Update the selectedItems object to instead use the newly selected item
    selectedItems[selectedSlot] = newItem;

    // We don't retrieve the price and icon when we retrieve the initial list (because a list of 20 items would take 10 seconds to load)
    // Instead we retrieve them when they are needed
    $.ajax({
        type: "GET",
        url: "/Index?handler=Item",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        data: { "name": name },
        headers: {
            RequestVerificationToken:
                $('input:hidden[name="__RequestVerificationToken"]').val()
        },
        error: function (error) {
            console.log(error);
        },
        success: function (result) {
            let JSONResult = JSON.parse(result);

            selectedSlot.setAttribute("src", JSONResult.Icon);
        }
    });
}

// Updates ALL the bonusses in case of an item change
// This is a VERY large method and it only does 1 thing.
// If the bonusses get properly updated you have no reason to change this method.
function updateBonusses(oldItem, newItem) {

    // Because we need the elements multiple times in the next bit we declare them here
    let RegExDigits = /(\d+)/;
    let stabAcc = document.getElementById("stab-accuracy-bonus");
    let slashAcc = document.getElementById("slash-accuracy-bonus");
    let crushAcc = document.getElementById("crush-accuracy-bonus");
    let magicAcc = document.getElementById("magic-accuracy-bonus");
    let rangedAcc = document.getElementById("ranged-accuracy-bonus");
    let stabDef = document.getElementById("stab-defence-bonus");
    let slashDef = document.getElementById("slash-defence-bonus");
    let crushDef = document.getElementById("crush-defence-bonus");
    let magicDef = document.getElementById("magic-defence-bonus");
    let rangedDef = document.getElementById("ranged-defence-bonus");
    let meleeStrength = document.getElementById("melee-strength-bonus");
    let rangedStrength = document.getElementById("ranged-strength-bonus");
    let magicDamage = document.getElementById("magic-damage-bonus");
    let prayerBonus = document.getElementById("prayer-bonus");

    // Change the stats!
    if (!oldItem) {
        // Stats can be increased by the new item stats without any other calculations
        // Replace the HTML by what was already there + the new stats
        stabAcc.innerHTML = parseInt(stabAcc.innerHTML.match(RegExDigits)) + newItem.stabAcc;
        slashAcc.innerHTML = parseInt(slashAcc.innerHTML.match(RegExDigits)) + newItem.slashAcc;
        crushAcc.innerHTML = parseInt(crushAcc.innerHTML.match(RegExDigits)) + newItem.crushAcc;
        magicAcc.innerHTML = parseInt(magicAcc.innerHTML.match(RegExDigits)) + newItem.magicAcc;
        rangedAcc.innerHTML = parseInt(rangedAcc.innerHTML.match(RegExDigits)) + newItem.rangedAcc;
        stabDef.innerHTML = parseInt(stabDef.innerHTML.match(RegExDigits)) + newItem.stabDef;
        slashDef.innerHTML = parseInt(slashDef.innerHTML.match(RegExDigits)) + newItem.slashDef;
        crushDef.innerHTML = parseInt(crushDef.innerHTML.match(RegExDigits)) + newItem.crushDef;
        magicDef.innerHTML = parseInt(magicDef.innerHTML.match(RegExDigits)) + newItem.magicDef;
        rangedDef.innerHTML = parseInt(rangedDef.innerHTML.match(RegExDigits)) + newItem.rangedDef;
        meleeStrength.innerHTML = parseInt(meleeStrength.innerHTML.match(RegExDigits)) + newItem.strengthBonus;
        rangedStrength.innerHTML = parseInt(rangedStrength.innerHTML.match(RegExDigits)) + newItem.rangedStrength;
        magicDamage.innerHTML = parseInt(magicDamage.innerHTML.match(RegExDigits)) + newItem.magicStrength;
        prayerBonus.innerHTML = parseInt(prayerBonus.innerHTML.match(RegExDigits)) + newItem.prayerBonus;

    } else {
        // There was an old item in the slot so have to remove those stats
        // Replace the HTML by what was already there - the old stats + the new stats

        // Look I won't be oblivious to the fact that this is a strange block of code, I will explain what one block does. The rest are all the same.
        // Because we try to update the stats to match what it would be with the new item. Therefore we need to remove the old item stats.
        // This can easily be done by doing a "+ -" because if the old item stabAcc was -5 and the new one is 0 the calculation would be "-5 + - -5 + 0" which results in 0
        // If the old stabAcc was instead 5 and the new one 0 the calculation would be "5 + - 5 + 0" which again would result in 0
        // This calculation works for both ends of the spectrum.

        // Accuracy
        stabAcc.innerHTML = parseInt(stabAcc.innerHTML) + - oldItem.stabAcc + newItem.stabAcc;

        slashAcc.innerHTML = parseInt(slashAcc.innerHTML) + - oldItem.slashAcc + newItem.slashAcc;

        crushAcc.innerHTML = parseInt(crushAcc.innerHTML) + - oldItem.crushAcc + newItem.crushAcc;

        magicAcc.innerHTML = parseInt(magicAcc.innerHTML) + - oldItem.magicAcc + newItem.magicAcc;

        rangedAcc.innerHTML = parseInt(rangedAcc.innerHTML) + - oldItem.rangedAcc + newItem.rangedAcc;

        // Defence 
        stabDef.innerHTML = parseInt(stabDef.innerHTML) + - oldItem.stabDef + newItem.stabDef;

        slashDef.innerHTML = parseInt(slashDef.innerHTML) + - oldItem.slashDef + newItem.slashDef;

        crushDef.innerHTML = parseInt(crushDef.innerHTML) + - oldItem.crushDef + newItem.crushDef;

        magicDef.innerHTML = parseInt(magicDef.innerHTML) + - oldItem.magicDef + newItem.magicDef;

        rangedDef.innerHTML = parseInt(rangedDef.innerHTML) + - oldItem.rangedDef + newItem.rangedDef;

        // Strength
        meleeStrength.innerHTML = parseInt(meleeStrength.innerHTML) + - oldItem.strengthBonus + newItem.strengthBonus;

        rangedStrength.innerHTML = parseInt(rangedStrength.innerHTML) + - oldItem.rangedStrength + newItem.rangedStrength;

        magicDamage.innerHTML = parseInt(magicDamage.innerHTML) + - oldItem.magicStrength + newItem.magicStrength;

        prayerBonus.innerHTML = parseInt(prayerBonus.innerHTML) + - oldItem.prayerBonus + newItem.prayerBonus;
    }
}