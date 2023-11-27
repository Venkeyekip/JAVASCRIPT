let isFulfilled = false;

let myPromise = new Promise((resolve, reject) => {
 setTimeout(() => {
    isFulfilled = true;
    resolve('Promise is fulfilled');
 }, 2000);
});

myPromise.then((result) => {
 console.log(result);
}).catch((error) => {
 console.log(error);
});

setTimeout(() => {
 if (isFulfilled) {
    console.log('Promise is fulfilled after 2 seconds');
 } else {
    console.log('Promise is not fulfilled after 2 seconds');
 }
}, 2000);