/// [ Null-aware operators ]
///Entry point
main(List<String> args) {
  doNullAwareOperators_1();
  doNullAwareOperators_2();
}

/// Dart offers some handy operators for dealing with values 
/// that might be null. One is the ??= assignment operator, 
/// which assigns a value to a variable only if that variable is currently null:
doNullAwareOperators_1(){
  int a; // the initial value of 'a' is null.
  a ??= 3;
  print(a); // <-- Prints 3.
  a ??= 5;
  print(a); // <-- Still prints 3.
}

/// Another null-aware operator is ??, which returns the expression
/// on its left unless that expression’s value is null, in which 
/// case it evaluates and returns the expression on its right:
doNullAwareOperators_2(){
  print(1 ?? 3); // <-- prints 1
  print(null ?? 12); // <-- prints 12
}