///  Imperative code
String scream_imperative(int length) => "A${'a' * length}h!";

main(List<String> args) {
  final values = [1,2,3,5,10,50];
  ///  Imperative code
  print('Imperative approch');
  for (var length in values){
    print(scream_imperative(length));
  }

  ///  Functional approch with method chaining
  print('Functional approch');
  values.map(scream_imperative).forEach(print);  

  /// Another functional approch
  print('Another functional approch');
  // Skip(1) : skip the first value --> 1
  // Take(3) : gets the next 3 values --> 2,3 and 5
  values.skip(1).take(3).map(scream_imperative).forEach(print);
}