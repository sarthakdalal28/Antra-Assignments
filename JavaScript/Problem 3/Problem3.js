function checkEmailId(str) {
  let atIndex = str.indexOf('@');
  let dotIndex = str.indexOf('.');
  
  if (atIndex > 0 && dotIndex > atIndex + 1 && dotIndex < str.length - 1){	return true;
  }
  else{
	return false;
  }
}
