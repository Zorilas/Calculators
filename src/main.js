const readline = require('readline');

const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});

let firstnumber = 0;
let secondnumber = 0;
let operator = "";

rl.question("Type in your first number: ", (input1) => {
  firstnumber = Number(input1);
  if (isNaN(firstnumber)) {
    console.log("You have to enter a valid number");
    rl.close();
    return;
  }
  console.log("Your first number is " + firstnumber);

  rl.question("Type in your second number: ", (input2) => {
    secondnumber = Number(input2);
    if (isNaN(secondnumber)) {
      console.log("You have to enter a valid number");
      rl.close();
      return;
    }
    console.log("Your second number is " + secondnumber);

    rl.question("Type in your operator (e.g. +, -, /, *): ", (input3) => {
      operator = input3.trim();
      if (!['+', '-', '*', '/'].includes(operator)) {
        console.log("You have to enter a valid operator (+, -, *, /)");
        rl.close();
        return;
      }
      console.log("Your operator is " + operator);

      let result;
      switch (operator) {
        case '+':
          result = firstnumber + secondnumber;
          break;
        case '-':
          result = firstnumber - secondnumber;
          break;
        case '*':
          result = firstnumber * secondnumber;
          break;
        case '/':
          if (secondnumber === 0) {
            console.log("Cannot divide by zero");
            rl.close();
            return;
          }
          result = firstnumber / secondnumber;
          break;
      }
      console.log(`Result: ${firstnumber} ${operator} ${secondnumber} = ${result}`);
      rl.close();
    });
  });
});