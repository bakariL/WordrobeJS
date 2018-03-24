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


function omouseon(x) {
    x.style.backgroundColor = "white";
    x.style.color = "black";
}

function mouseoff(x) {
    x.style.backgroundColor = "#474e5d";
    x.style.color = "white";
}