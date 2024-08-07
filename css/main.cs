/* Reset some default browser styles */
html, body, ul {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

body {
    font-family: 'Inter Tight', sans-serif;
    background-color: white;
}

header {
    display: flex;
    justify-content: space-between;
    padding: 48px;
    align-items: center;
}

.header-left {
    display: flex;
    align-items: center;
}

nav ul {
    list-style: none;
}

nav ul li a {
    text-decoration: none;
    color: black;
    font-size: 15px;
}

.header-right img {
    width: 100px;
    height: 100px;
}

main {
    display: flex;
    flex-wrap: wrap; /* Enable wrapping for smaller screens */
    margin: 30px 88px;
}

.nav-links {
    flex: 2;
    min-width: 200px;
}

.nav-links h1 {
    font-size: 65px;
    margin: .1px 0; /* Close the gaps between the items */
}

.event-planner {
    flex: 1;
    min-width: 200px;
    text-align: left; /* Align text to the left */
}

.event-planner h2 {
    font-size: 20px;
    margin-bottom: 10px;
}

.event-planner p {
    font-size: 18px;
    line-height: 1.2; /* Adjusted line height for better readability */
}

footer {
    padding: 48px;
    position: relative; /* Ensure the footer is relatively positioned */
    display: flex;
    flex-direction: column;
    justify-content: center;
}

footer h1 {
    font-weight: 900; /* Black weight for the text */
    font-size: 14vw; /* Adjust size to fit footer */
    letter-spacing: 0; /* 0 Em */
    line-height: 0.8em; /* Line height 0.8 Em */
    color: #000000; /* Black color */
    margin: 0; /* Remove default margin */
    width: 100%; /* 1fr fill */
    height: auto; /* Height auto */
    opacity: 1; /* Opacity 1 */
    visibility: visible; /* Visible */
    z-index: 1; /* z-index 1 */
    transform: rotate(0deg); /* Rotate 0 degrees 2D */
    position: relative; /* Position relative */
    text-align: left; /* Align text to the left */
    padding-left: 8px; /* 48px padding left */
    padding-right: 48px; /* 48px padding right */
    word-wrap: break-word; /* Ensure text wraps */
    white-space: pre-wrap; /* Preserve white space and wrap text */
}

footer p {
    font-size: 14px;
    margin-top: 5px; /* 5px under H & S EVENTS */
    padding-left: 48px; /* 48px from the left */
}

footer a {
    text-decoration: none;
    color: black;
    font-weight: bold;
}

/* Media query for screens below 1100px */
@media (max-width: 1100px) {
    .event-planner {
        order: 1; /* Move event planner below contact */
    }

    .nav-links {
        order: 0;
    }

    footer h1 {
        font-size: 12vw; /* Adjust the size of H & S EVENTS for smaller screens */
    }
}

/* Media query for screens below 810px */
@media (max-width: 809px) {
    .nav-links h1, .event-planner {
        padding-left: 20px; /* Add padding to the left */
    }

    footer h1 {
        font-size: 15vw; /* Adjust the size of H & S EVENTS for smaller screens */
    }
}
