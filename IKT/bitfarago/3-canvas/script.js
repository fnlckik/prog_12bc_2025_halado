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
    for (let i = 0; i < 10; i++) {
        const pos = {
            x: randint(0, 500),
            y: randint(0, 500)
        };
        positions.push(pos);
    }
}

function draw() {
    ctx.reset();
    // const img = document.createElement("img");
    const img = new Image();
    img.src = "asteroid.png";
    img.onload = () => {
        for (const pos of positions) {
            ctx.drawImage(img, pos.x, pos.y, 50, 50);
        }
    }
}

function move() {
    for (let i = 0; i < positions.length; i++) {
        positions[i].x += 10; // sebesség
    }
}

init();
draw();
setInterval(() => {
    move();
    draw();
}, 50);
