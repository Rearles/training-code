'use strict';

// in old JS, we had two possible scopes
// - global scope
// - function scope

// the original way to declare variables
// in JS is "var"

function f1(x) {
  console.log(data);
  if (x == 4) {
    var data2 = true;
  }

  var data = 5;
  var dtaa = 123;
  // ^ assignment to undeclared variables
  //  injects a new variable into global scope
  //  unless in ES5 strict mode
  console.log(data2);
  console.log(dtaa);
}

// variables declared with "var"
//   have their declarations "hoisted" to
//   the top of the function.
// they have "function scope"
//   when declared inside a function

// console.log(dtaa);
f1(4);
// console.log(data);
// console.log(dtaa);
// f1(5);

// ES6 added "let" and "const" variables
// which have block scope.
// "let" is just a block scope version of var
// "const" variables can't be reassigned after initialization
const x = 5;
// x = 6;
