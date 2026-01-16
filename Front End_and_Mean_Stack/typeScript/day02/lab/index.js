const increaseBtn = document.getElementById("increase");
const decreaseBtn = document.getElementById("decrease");
const resetBtn = document.getElementById("reset");
const counterField = document.getElementById("counter");
class Counter {
    constructor() {
        this.counterValue = 0;
    }
    increase() {
        this.counterValue++;
    }
    decrease() {
        this.counterValue--;
    }
    reset() {
        this.counterValue = 0;
    }
}
const counter = new Counter();
increaseBtn === null || increaseBtn === void 0 ? void 0 : increaseBtn.addEventListener("click", () => {
    counter.increase();
    counterField.textContent = counter.counterValue.toString();
});
decreaseBtn === null || decreaseBtn === void 0 ? void 0 : decreaseBtn.addEventListener("click", () => {
    counter.decrease();
    counterField.textContent = counter.counterValue.toString();
});
resetBtn === null || resetBtn === void 0 ? void 0 : resetBtn.addEventListener("click", () => {
    counter.reset();
    counterField.textContent = counter.counterValue.toString();
});
