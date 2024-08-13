using EncapsulationPractice;

Car car1 = new Car();
car1.Brand = "Ford";
car1.Model = "Focus";
car1.Clour = "Mavi";
car1.DoorCount = 2;
car1.CarResult();

Console.WriteLine("----------------------------------------");

Car car2 = new Car("Ford", "Focus", "Blue", 3);
car2.CarResult();