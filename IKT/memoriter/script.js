const poem = 
`Isten, áldd meg a magyart
Jó kedvvel, bőséggel,
Nyújts feléje védő kart,
Ha küzd ellenséggel;
Bal sors akit régen tép,
Hozz rá víg esztendőt,
Megbünhödte már e nép
A multat s jövendőt!

Őseinket felhozád
Kárpát szent bércére,
Általad nyert szép hazát
Bendegúznak vére.
S merre zúgnak habjai
Tiszának, Dunának,
Árpád hős magzatjai
Felvirágozának.`;

const poemDiv = document.querySelector("#poem");
const words = poem.replaceAll("\n", "<br> ").split(" ");

// A szavak 23%-át hagyjuk ki (feladványnak).
function createPoem() {
    let s = "";
    for (const word of words) {
        if (word !== "<br>" && Math.random() < 0.23) {
            s += `<input type="text"> `;
        } else {
            s += word + " ";
        }
        if (word.indexOf("<br>") >= 0) {
            s += "<br>";
        }
    }
    return s;
}

const startBtn = document.querySelector("#start");
function startGame() {
    poemDiv.innerHTML = createPoem();
    // poemDiv.className = "";
    poemDiv.classList.remove("d-none");
    startBtn.removeEventListener("click", startGame);
    startBtn.disabled = true;
}
// startBtn.onclick = startGame;
// startBtn.addEventListener("click", startGame, {once: true});
startBtn.addEventListener("click", startGame);