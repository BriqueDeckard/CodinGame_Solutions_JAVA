import 'dart:math';

abstract class  Shape{
  ///  Factory constructor
  factory Shape(String type){
    if(type == 'circle') return Circle(2);
    if(type == 'square') return Square(2);
    throw 'Can\'t create $type';
  }
  num get area;
} 

class Circle implements Shape {
  final num radius;
  Circle(this.radius);

  @override
  num get area => pi * pow(radius, 2);  
}

class Square implements Shape{
  final num side;
  Square(this.side);
  @override
  num get area => pow(side, 2);  
}

///  shape factory
Shape shapeFactory(String type){
  if(type == 'circle') return Circle(2);
  if(type == 'square') return Square(2);
  throw 'Can\'t create $type';
}

main(List<String> args) {
  final circle_1 = Circle(2);
  final square_1 = Square(2);
  print(circle_1.area);
  print(square_1.area);

  final circle_2 = shapeFactory('circle');
  final square_2 = shapeFactory('square');
  print(circle_2.area);
  print(square_2.area);

  final triangle_1 = shapeFactory('triangle');

  final circle_3 = Shape('circle');
  final square_3 = Shape('square');
  print(circle_3.area);
  print(square_3.area);

  final trirangle_2 = Shape('triangle');
 

}