const increaseBtn = document.getElementById("increase") as HTMLButtonElement;
const decreaseBtn = document.getElementById("decrease") as HTMLButtonElement;
const resetBtn = document.getElementById("reset") as HTMLButtonElement;

const counterField = document.getElementById("counter") as HTMLSpanElement;

class Counter {
  counterValue: number = 0;
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

increaseBtn?.addEventListener("click", () => {
  counter.increase();
  counterField.textContent = counter.counterValue.toString();
});
decreaseBtn?.addEventListener("click", () => {
  counter.decrease();
  counterField.textContent = counter.counterValue.toString();
});
resetBtn?.addEventListener("click", () => {
  counter.reset();
  counterField.textContent = counter.counterValue.toString();
});
