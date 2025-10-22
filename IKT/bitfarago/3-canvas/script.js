const canvas = document.querySelector("canvas");
// canvas.width = window.innerWidth;
// canvas.height = window.innerHeight;
const ctx = canvas.getContext("2d");

// ctx.fillRect(0, 0, 100, 200);

// const img = document.createElement("img");
// img.src = "asteroid.png";
// img.onload = () => {
//     ctx.drawImage(img, 100, 200, 50, 50);
//     ctx.drawImage(img, 120, 210, 50, 50);
// }

function randint(a, b) {
    return Math.floor(Math.random() * (b-a+1) + a);
}

// const pos = {
//     x: 100,
//     y: 200
// }
let positions = [];

function init() {
    positions = [];
    for (let i = 0; i < 30; i++) {
        const pos = {
            x: randint(0, 300),
            y: randint(0, 500),
            dx: randint(-1, 1),
            dy: randint(-1, 1) // (dx, dy) az irányvektora
        };
        positions.push(pos);
    }
}

const img = new Image();
img.src = "asteroid.png";

function draw() {
    ctx.reset();
    // const img = document.createElement("img");
    for (const pos of positions) {
        ctx.drawImage(img, pos.x, pos.y, 50, 50);
    }
}

function move() {
    for (let i = 0; i < positions.length; i++) {
        positions[i].x += positions[i].dx; // sebesség
        positions[i].y += positions[i].dy;
    }
}

init();
draw();
setInterval(() => {
    move();
    draw();
}, 20);

function handleClick(e) {
    // Látható kliens területen hol vagyunk?
    // console.log(`${e.clientX}, ${e.clientY}`);
    
    // Oldal tetejéhez képest hol vagyunk?
    // console.log(`${e.pageX}, ${e.pageY}`);
    
    // A kattintott elem bal felső sarkához képest hol vagyunk?
    // console.log(`${e.offsetX}, ${e.offsetY}`); !!!
    
    // Bal oldali monitor bal felső sarkához kélpest hol vagyunk?
    // console.log(`${e.screenX}, ${e.screenY}`);

    const x = e.offsetX;
    const y = e.offsetY;
    console.log(`(${x}, ${y})`);
    const rgb = ctx.getImageData(x, y, 1, 1).data;
    console.log(`(${rgb[0]}, ${rgb[1]}, ${rgb[2]})`);
}
canvas.addEventListener("click", handleClick);