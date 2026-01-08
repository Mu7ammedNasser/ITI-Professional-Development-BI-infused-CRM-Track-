export class Shape {
  constructor(name) {
    this.name = name;
  }

  area() {
    throw new Error("not implemnted");
  }
  perimeter() {
    throw new Error("not implemented");
  }

  toString() {
    return `
    ${this.name}
    Area: ${this.area()}
    Perimeter: ${this.perimeter()}
`;
  }
}
