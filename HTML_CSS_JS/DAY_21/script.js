//STEP 2: Access DOM Objects (Create references to DOM elements)
//STEP 3: Event Data (JavaScript Object)
//STEP 4: Display Events Dynamically (Add Elements)
//STEP 5: Handle Event Selection (Modify Content)
//STEP 6: Register for Event (Modify DOM Content)
//STEP 7: Unregister from Event (Remove / Modify)
//STEP 8: Add New Event Dynamically (Create + Append)
//STEP 9: Prevent Errors (Client-Side Validation)
   
/*******************************
 STEP 2: Access DOM Objects
********************************/
const eventList = document.getElementById("eventList");
const eventTitle = document.getElementById("eventTitle");
const eventDesc = document.getElementById("eventDesc");
const countSpan = document.getElementById("count");

const registerBtn = document.getElementById("registerBtn");
const unregisterBtn = document.getElementById("unregisterBtn");
const addEventBtn = document.getElementById("addEventBtn");

/*******************************
 STEP 3: Event Data (Objects)
********************************/
let events = [
  {
    id: 1,
    title: "Cleanliness Drive",
    description: "Join us to clean the society surroundings.",
    participants: 0
  },
  {
    id: 2,
    title: "Tree Plantation",
    description: "Plant trees for a greener future.",
    participants: 0
  },
  {
    id: 3,
    title: "Blood Donation Camp",
    description: "Donate blood and save lives.",
    participants: 0
  }
];

let selectedEvent = null;

/*******************************
 STEP 4: Display Events Dynamically
********************************/
function displayEvents() {
  eventList.innerHTML = "";

  events.forEach(event => {
    const li = document.createElement("li");
    li.textContent = event.title;

    li.addEventListener("click", () => selectEvent(event, li));
    eventList.appendChild(li);
  });
}

displayEvents();

/*******************************
 STEP 5: Handle Event Selection
********************************/
function selectEvent(event, element) {
  selectedEvent = event;

  document.querySelectorAll("li").forEach(li => {
    li.classList.remove("selected");
  });

  element.classList.add("selected");

  eventTitle.textContent = event.title;
  eventDesc.textContent = event.description;
  countSpan.textContent = event.participants;
}

/*******************************
 STEP 6: Register for Event
********************************/
registerBtn.addEventListener("click", () => {
  if (!selectedEvent) {
    alert("Please select an event first");
    return;
  }

  selectedEvent.participants++;
  countSpan.textContent = selectedEvent.participants;
});

/*******************************
 STEP 7: Unregister from Event
********************************/
unregisterBtn.addEventListener("click", () => {
  if (!selectedEvent) {
    alert("Please select an event first");
    return;
  }

  if (selectedEvent.participants > 0) {
    selectedEvent.participants--;
    countSpan.textContent = selectedEvent.participants;
  } else {
    alert("No participants to remove");
  }
});

/*******************************
 STEP 8: Add New Event Dynamically
********************************/
addEventBtn.addEventListener("click", () => {
  const title = prompt("Enter event title:");
  const description = prompt("Enter event description:");

  if (!title || !description) {
    alert("Both title and description are required");
    return;
  }

  const newEvent = {
    id: events.length + 1,
    title: title,
    description: description,
    participants: 0
  };

  events.push(newEvent);
  displayEvents();
});

/*******************************
 STEP 9: Client-Side Validation
********************************/
// Validation handled using:
// - checking selectedEvent
// - preventing negative participants
// - checking empty input fields
