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
const missing = [];

// A szavak 23%-át hagyjuk ki (feladványnak).
// "alma,<br>" => "<input> " || "alma "
function transformWord(word) {
    const cleanWord = word.replace("<br>", ""); // "alma,"
    if (word !== "<br>" && Math.random() < 0.23) {
        const correct = cleanWord.replaceAll(/\p{P}/gu, ""); // "alma"
        missing.push(correct);
        return `<input type="text" size="${correct.length}" maxlength="${correct.length}"> `;
    } else {
        return cleanWord + " ";
    }
}

function createPoem() {
    let s = "";
    for (const word of words) {
        s += transformWord(word);
        if (word.indexOf("<br>") >= 0) {
            s += "<br>";
        }
    }
    return s;
}

function checkAnswer(answers, i) {
    return answers[i].value.toLowerCase() === missing[i].toLowerCase();
}

const checkBtn = document.querySelector("#check");
const solveBtn = document.querySelector("#solve");
function checkPoem(event) {
    if (event.key !== "Enter" && event.type !== "click") return;
    const answers = document.querySelectorAll("input[type='text']");
    for (let i = 0; i < answers.length; i++) {
        answers[i].style.backgroundColor = checkAnswer(answers, i) ? "lightgreen" : "pink";
    }
}

function solvePoem() {
    const answers = document.querySelectorAll("input[type='text']");
    for (let i = 0; i < answers.length; i++) {
        answers[i].value = missing[i];
    }
}

const startBtn = document.querySelector("#start");
function startGame() {
    poemDiv.innerHTML = createPoem();
    // poemDiv.className = "";
    poemDiv.classList.remove("d-none");
    startBtn.removeEventListener("click", startGame);
    startBtn.disabled = true;
    checkBtn.addEventListener("click", checkPoem);
    checkBtn.disabled = false;
    poemDiv.addEventListener("keyup", checkPoem);
    solveBtn.disabled = false;
    solveBtn.addEventListener("click", solvePoem);
}
// startBtn.onclick = startGame;
// startBtn.addEventListener("click", startGame, {once: true});
startBtn.addEventListener("click", startGame);
