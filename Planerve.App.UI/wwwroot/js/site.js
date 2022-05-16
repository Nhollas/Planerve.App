const buttons = document.querySelectorAll(".filter__toggle");

buttons.forEach(button => {
    button.addEventListener('click', function handleClick(event) {
        const slide = document.querySelector(".filter__tab");
        slide.classList.toggle("active");
    });
});