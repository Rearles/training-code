'use strict';

// JS does a lot of implicit type conversion
console.log('123' + 456);
console.log(true + 456);
// if you're unsure, just do explicit conversion
console.log(Number('123') + 456);

// in an if-condition, it's converted to
// a boolean

// let result = getObject();

// if (result) {
//   //...
// }

// all values are either truthy or falsy
// the falsy values are:

// null
// undefined
// empty string
// 0    (... and -0)
// NaN
// false

// everything else is truthy
// including [], {}

// the difference between
// == double equals
   // tries to "compare value across types"
   //  or "ignoring the types"
// === triple equals
   // "compares value and type"

function checkEquals(a, b) {
  console.log(`${a} == ${b}: ${a == b}`);
  console.log(`${a} === ${b}: ${a === b}`);
}

checkEquals(3, '3'); // true, false
checkEquals(0, []); // true, false
// https://dorey.github.io/JavaScript-Equality-Table/
