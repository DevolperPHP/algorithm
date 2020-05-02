var bs = require("binary-search");
 
bs([1, 2, 3, 4], 3, function(element, needle) { return element - needle; });
// => 2
 
bs([1, 2, 4, 5], 3, function(element, needle) { return element - needle; });
// => -3
