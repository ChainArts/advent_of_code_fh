const fs = require("fs");
var text = fs.readFileSync("./input.txt", "utf-8");
var textByLine = text.split("\n");
var max = 0;
var maxArr = [];
var sum = 0;
textByLine.forEach((element) => {
  if (element > 0) {
    sum = sum + parseInt(element);
  } else {
    maxArr.push(sum);
    sum = 0;
  }
  if (sum > max) {
    max = sum;
  }
});

var max3 = 0;
maxArr.sort((a, b) => b - a);
for (let i = 0; i < 3; i++) {
    console.log(maxArr[i])
     max3 += maxArr[i];
}
console.log("Maximum: " + max);
console.log("MaxThree: " + max3);