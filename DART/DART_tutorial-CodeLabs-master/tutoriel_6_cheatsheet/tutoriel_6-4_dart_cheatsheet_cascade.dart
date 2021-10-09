import 'dart:html';

class MyObject {
  someMethod() => print("object");  
}

main(List<String> args) {
  MyObject object_1 = MyObject();
  print(object_1.someMethod());
  print(object_1..someMethod());

  var button = querySelector('#confirm');
  button.text ='Confirm';
  button.classes.add('important');
  button.onClick.listen((event) => window.alert('Confirmed'));
}