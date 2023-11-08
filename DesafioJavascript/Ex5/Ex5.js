document.addEventListener('DOMContentLoaded', function () {
    const checkboxes = document.querySelectorAll('input[type="checkbox"]');
    const submitButton = document.getElementById('submitButton');

    checkboxes.forEach(checkbox => {
        checkbox.addEventListener('change', checkButton);
    });

    function checkButton() {
        const checkedCheckboxes = document.querySelectorAll('input[type="checkbox"]:checked');

        if (checkedCheckboxes.length >= 2) {
            submitButton.disabled = false;
            submitButton.style.cursor = 'pointer';
        } else {
            submitButton.disabled = true;
            submitButton.style.cursor = 'not-allowed';
        }
    }
});
