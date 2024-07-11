let styles = ["James", "Brennie"];
console.log(styles); 

styles.push("Robert");
console.log(styles); 

let middleIndex = Math.floor(styles.length / 2);
styles[middleIndex] = "Calvin";
console.log(styles); 

let removedValue = styles.shift();
console.log(removedValue);
console.log(styles); 

styles.unshift("Rose", "Regal");
console.log(styles); 
