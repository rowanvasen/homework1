// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function getRandomColor() {
    const r = Math.floor(Math.random() * 256);
    const g = Math.floor(Math.random() * 256);
    const b = Math.floor(Math.random() * 256);
    return `rgb(${r}, ${g}, ${b})`;
}

document.addEventListener("DOMContentLoaded", () => {
    const cards = document.querySelectorAll('.card');
    cards.forEach(card => {
        card.style.backgroundColor = getRandomColor();
    });
});
document.addEventListener("DOMContentLoaded", function() {
    const button = document.querySelector("#Names-Button");
    button.addEventListener("click", assignRandomNames);

    const teamCards = document.querySelectorAll('.card-title');
    teamCards.forEach(card => {
        card.textContent = "Team:";
    });

    async function assignRandomNames() {
        const response = await fetch('../Swift.txt');
        const text = await response.text();
        const names = text.split('\n').map(name => name.trim()).filter(name => name);

        teamCards.forEach(card => {
            const randomName = names[Math.floor(Math.random() * names.length)];
            card.textContent = randomName;
        });
    }
});
/*
Alice Johnson
Bob Smith
Carol Martinez
David Lee
Emily Davis
Frank Wilson
Grace Harris
Henry Clark
Irene Lewis
Jack Walker
Karen Young
Larry Hall
Megan King
Nathan Scott
Olivia Baker
Paul Turner
Quinn Parker
Rachel Morgan
Steve Cooper
Tina Stewart
Ulysses Butler
Vicky Howard
William Adams
Xavier Jenkins
Yolanda Reed
Zachary Mitchell
Brian Hughes
Chloe Peterson
Daniel Edwards
Fiona Bryant
*/

