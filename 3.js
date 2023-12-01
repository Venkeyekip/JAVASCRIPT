const number = '+919876543210';
function validateMobile(number) {
   const checking =
      /^(?:(?:\+|0{0,2})91(\s*[\ -]\s*)?|[0]?)?[789]\d{9}|(\d[ -]?){10}\d$/gm;

   if (number.startsWith('998')) return false;
   else return checking.test(number);
}

console.log(`is a valid Indian mobile number: ${validateMobile(number)}`);
