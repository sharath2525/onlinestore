document.getElementById('loginForm').addEventListener('submit', function (event) {
    event.preventDefault(); // Prevent the default form submission
    // Add your form validation and submission logic here
    window.location.href = 'index.html'; // Redirect to the home page
});