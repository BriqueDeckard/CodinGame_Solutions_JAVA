Iterable<int> iterable = [1,2,3,4,5,6];

main(List<String> args) {
    testForIn();
    testFirstAndLast();
    testFirstWhere1();
    testFirstWhere2();
    testSingleWhere();
    testEvery();
        }
    
void testEvery() {
  print("every with 2 :".toUpperCase());
  print(iterable.every((element) => element < 2));
  print("every with 9 :".toUpperCase());
  print(iterable.every((element) => element < 9));
}
    
void testSingleWhere() {
  print("single where :".toUpperCase());
  print(iterable.singleWhere((element) => element == 2));
}
    
void testFirstWhere2() {
  print("first where 2 :".toUpperCase());
  print(iterable.firstWhere((element) {
    return element == 1 ;
  }));
}
    
void testFirstWhere1() {
  print("first where 1 :".toUpperCase());
  print(iterable.firstWhere((element) => element == 1));
}
  
void testFirstAndLast() {
  print("first and last :".toUpperCase());
  print(iterable.first);
  print(iterable.last);
}
  
void testForIn() {
  print("For in :".toUpperCase());
  for(var element in iterable){
    print(element);
  }
}

