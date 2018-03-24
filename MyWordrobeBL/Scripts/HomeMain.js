//when user selects login (NOT yet logged-in)
function Swap(div1, div2) {
    d1 = document.getElementById(div1);
    d2 = document.getElementById(div2);
    if (d2.style.display == "none") {
        d1.style.display = "none";
        d2.style.display = "flex";
    }
    else {
        d1.style.display = "flex";
        d2.style.display = "none";
    }
}


//displays users name when LOGGED IN on submit
function DisplayUser(div1, div2) {
    // var d1, goes to the DOC and get the div element that was passed through at sets it to d1 and d2. 
    d1 = document.getElementById(div1);
    d2 = document.getElementById(div2);
    //if the 2nd div passed through is diplay none is true...then, change d2 to display flex and d1 to display none....else do the opposite. 
    if (d2.style.display == "none") {
        d1.style.display = "none";
        d2.style.display = "flex";
        //calling function below. to show user name when logged in. 
        LName(d2);
    }
    else {
        d1.style.display = "flex";
        d2.style.display = "none";
    }
    console.log(username);
}


//function to get the logged in Name. and set the inner text
function LName(name) {
    //goes to the DOC and get the "loginName" element by ID and sets the text to Welcome username.
    name = document.getElementById('loginName').innerText = 'Welcome' + name;
}

//on mouseover change color
function omouseon(x) {
    x.style.backgroundColor = "white";
    x.style.color = "black";
}


//on mouse off change color
function mouseoff(x) {
    x.style.backgroundColor = "#474e5d";
    x.style.color = "white";
}



//search function 
function Search() {
    //creates and populates array
    var myArr = ["Tops", "Bottoms", "Accessories", "Shoes"];
    //goes into document. get the 'pgh' p element by ID and sets the inner HTML to the display all the list of items in array
    document.getElementById('pgh').innerHTML = myArr;
    //creates a variable sets it euqaul to the value typed in the input box, grabs input box by ID
    var txt = document.getElementById('txt').value;
    //creates another variable that stores the txt as a index spot in the array
    var index = myArr.indexOf(txt);
    //if the index is NOT eqaul than index spot -1 then its a match!
    if (index !== -1) {
        //If user enters Tops thsn...
        if (txt == 'Tops') {
            //store url into w variable
            var w = 'Tops/Index';
            //go to the Tops index page...stored as w
            window.location = w;

        }
        //if user types in Pnats
        else if (txt == 'Pants') {

            //go to pants index page
            var w = 'Bottoms/Index';
            window.location = w;
        }
            //if user types in Shoes
        else if (txt == 'Shoes') {

            //go to Shoes index page
            var w = 'Shoes/Index';
            window.location = w;
        }

            //if user txt is Accesories
        else if (txt == 'Accesories') {
            //go to Accesories page
            var w = 'Accesories/Index';
            window.location = w;
        }
            //if none, try again
        else {
            alert('try again');
        }
    }
    else
    //not a match..item cannot be found..not in array
    {
        alert("cannot be searched. Try a different item.");
    }
}


//add element function 
function addElement() {
    var myArr = ["Tops", "Pants", "Accessories", "Shoes"];
    //creates txt variable, goes to document, gets the txt element byID and changes the value
    var txt = document.getElementById('txt').value;
    //adds or pushes this item to the beginning of array...top down..pancake style
    myArr.push(txt);
    //this displays it
    document.getElementById('pgh').innerHTML = myArr;
}

//search and replace/delete
function searchandDelete() {
    //creates array
    var myArr = ["Tops", "Pants", "Accessories"];
    //goes to the 'txt' input id element
    var txt = document.getElementById('txt').value;
    //passes the input element in the array though the method 'indexOf' 
    var index = myArr.indexOf(txt);

    if (index !== -1) {
        //if index is in the array
        //go to the array, does to the index spot, then takes away one item
        myArr.splice(index, 1);
        //displays valules
        document.getElementById('pgh').innerHTML = myArr;
    }
        else
        {
            alert("not");
        }
    }

