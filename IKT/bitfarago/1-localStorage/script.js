const people = [
    {
        name: "József",
        age: 65
    },
    {
        name: "Béla",
        age: 32
    },
    {
        name: "Kinga",
        age: 14
    }
];

localStorage.setItem("emberek", JSON.stringify(people)); // save
JSON.parse(localStorage.getItem("emberek")); // load
// localStorage.clear();
// localStorage.removeItem("emberek");