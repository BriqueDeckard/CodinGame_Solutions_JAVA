class Bicycle {
  int cadence;
  int _speed =0;
  /// speed getter
  int get speed => _speed;
  int gear;
  
  /// Constructor
  Bicycle(this.cadence, this.gear);

  @override
  String toString() => 'Bicycle : $_speed mph';

  void applyBrake(int decrement){
    _speed -= decrement;
  }

  void speedUp(int increment){
    _speed += increment;
  }
}

///  Entry point
main() {
  var bike = Bicycle(2, 1);
  print(bike);
}
