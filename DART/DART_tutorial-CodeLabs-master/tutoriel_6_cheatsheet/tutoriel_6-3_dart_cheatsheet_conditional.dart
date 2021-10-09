main(List<String> args) {
  doConditionalPropertyAccess();
}


/// [Conditional property access]

class MyObject {
  String someProperty;
  MyObject someObject;
  MyObject(this.someProperty, this.someObject);
}

doConditionalPropertyAccess(){
  print('doConditionalPropertyAccess'.toUpperCase());
  MyObject myObject_1 = MyObject(null, null);

  MyObject myObject_2;

  print(myObject_1?.someProperty);
  print(myObject_2?.someProperty);

  // The preceding code is equivalent to the following
  print((myObject_2 != null) ? myObject_2.someProperty : null);

  MyObject myObject_3 = MyObject("aa", MyObject("bb", null));
  print(myObject_3?.someObject?.someProperty);
}
