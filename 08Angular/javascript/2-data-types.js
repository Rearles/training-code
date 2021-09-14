let data = "asdf";

// data types of JS
// - number
//   in JS, integers, doubles, etc - all number ( = double)
data = 5;
data = 1 / 0; // Infinity
data = 'abc' - 12; // NaN
// have arithmetic operators just like
//   other C-based languages + - * /

// - boolean
data = false;
// familiar boolean & comparison operators && ||
data = 3 == 4; // false
data = 3 == 4 || 5 < 7; // true
data = isNaN('abc' - 12); // true

// - string
// can use single quotes or double quotes
data = '| 5 + 5 = ' + (5 + 5) + ' |';
// string interpolation added in ES6
data = `| 5 + 5 = ${5 + 5} |`;
// those backtick strings are also for multiline strings

// - object
data = {}; // "object literal"
data.name = 'Nick';
data['name'] = 'asdf';
data = new Set(); // "constructors", sort of
data.add(5);
data.add(5);

//  (function)
// "function statement":
function add(a, b) {
  // if (typeof a == 'number')
  // if (b == 0) return false;
  return a + b;
}
console.log(typeof add); // says "function"
// but functions really are object type too.
// "function expression":
let multiply = function (a, b) { return a * b; };
let divide = (a, b) => a * b; // "arrow function", added in ES6

function f1(a, b) {
  console.log(a);
  console.log(b);
}
data = f1(1); // 1, undefined; undefined
// - undefined
//  special data type with one value

// - null
// like undefined. for "missing data"
data = null;
// typeof calls it "object"

console.log(data);
console.log(typeof data);

// also, symbol and BigInt
