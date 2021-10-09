main(List<String> args) {
  tryCatch();
}

class Exception1 {
  
}

class Exception2 {
  
}

class Exception3 {
  
}

class Exception4 {
  
}

throwException(){
  throw Exception('Something bas happened');
}

throwE(){
  throw 'Something bad happened';
}

throwException1(){
  throw Exception1();
}

throwException2(){
  throw Exception2();
}

tryCatch(){
  try{
    throwException2();
  } // On specific exception
  on Exception1{
    print("Exception 1 detected".toUpperCase());
  } // Anything elese that is an exception
  on Exception catch (e){
    print('Unknown exception : $e');
  }catch (e){
    // No specified type
    print('Really unknown exception : $e');
    rethrow;
  } finally{
    print('Omg, wtf happened today ?');
  }
  
}

