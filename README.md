# Csharp RentCar 🚗

This Console application performs various tasks related to a car rental system, including managing different types of vehicles, monitoring rental statuses, and facilitating the processes of renting a vehicle or canceling a rental.

Tested Skills:
- Applying object-oriented programming
- Developing classes
- Instantiating objects and using classes correctly
- Utilizing advanced types.

Deadline: Nov 24, 2023 at 2:00 pm

<details>
  <summary><strong>🏗 Project structure</strong></summary><br />

The `Rent Cars` is divided into organized parts. In the `Model` section, you will find the base classes that must follow the following hierarchy:

- `Vehicle.cs` describes an **abstract** base class for vehicles.

  - `Car.cs` describes a derived class for **cars**.

  - `Truck.cs` describes a derived class for **trucks**.

  - `Motorcycle.cs` describes a derived class for **motorcycles**.

- `Person.cs` describes an **abstract** base class for people who are clients of the system.

  - `PhysicalPerson.cs` describes a derived class for **individuals**.

  - `LegalPerson.cs` describes a derived class for **legal entities**.

- `Rent.cs` describes the class for a rental between a **person** and a **vehicle**.

What has been implemented?

<strong>1. Creation of a `Struct` for **Colors**</strong>

Logic in src/RentCars/Types/Structs/Color.cs

- The struct should contain the <code>Name</code> field of type <code>string</code>.

- The struct should contain the <code>Hex</code> field of type <code>string</code>.

- The attributes should be public.

<strong>2. Creation of an enum `FuelType`</strong>

Logic in src/RentCars/Types/Enums/FuelType.cs

- The enum should contain the <code>Alcohol</code> field with a value of 10.

- The enum should contain the <code>Gasoline</code> field with a value of 20.

- The enum should contain the <code>Flex</code> field with a value of 30.

- The enum should contain the <code>Diesel</code> field with a value of 40.

- The enum should contain the <code>Electric</code> field with a value of 50.

- The enum should contain the <code>Hybrid</code> field with a value of 60.

<strong>3. Creation of the `Vehicle` class</strong>

Logic in src/RentCars/Models/Vehicle.cs

The class should contain fields common to a vehicle.

- The class should have the following properties:

  - <code>Brand</code> which should be of type <code>string</code>, with a default value of "", and should have get and set.

  - <code>Model</code> which should be of type <code>string</code>, with a default value of "", and should have get and set.

  - <code>Price</code> which should be of type <code>decimal</code>, and should have get and set.

  - <code>Fuel</code> which should be of type <code>FuelType</code>, and should have get and set.

  - <code>EngineCapacity</code> which should be of type <code>int</code>, and should have get and set.

  - <code>MainColor</code> which should be of type <code>Color</code>, and should have get and set.

  - <code>Year</code> which should be of type <code>int</code>, and should have get and set.

  - <code>PricePerDay</code> which should be of type <code>double</code>, and should have get and set.

  - <code>IsRented</code> which should be of type <code>bool</code>, with a default value of false, and should have get and set.

<strong>4. Creation of an enum `BrakeType`</strong>

Logic in src/RentCars/Types/Enums/BrakeType.cs

- The enum should contain the <code>Chamber</code> field with a value of 1.

- The enum should contain the <code>Disc</code> field with a value of 2.

- The enum should contain the <code>Drum</code> field with a value of 3.

<strong>5. Creation of an enum `TractionType`</strong>

Logic in src/RentCars/Types/Enums/TractionType.cs

- The enum should contain the <code>FrontWheelDrive</code> field with a value of 0.

- The enum should contain the <code>RearWheelDrive</code> field with a value of 1.

- The enum should contain the <code>AllWheelDrive</code> field with a value of 2.

<strong>6. Making the `Car` class inherit from `Vehicle`</strong>

Logic in src/RentCars/Models/Car.cs

Add the inheritance of the Vehicle class.

Add new fields specific to Car.

- The class should have the following properties:

  - <code>Seats</code> which should be of type <code>Int</code>.

  - <code>Doors</code> which should be of type <code>Int</code>.

  - <code>Traction</code> which should be of type <code>TractionType</code>.

  - <code>FrontBrake</code> which should be of type <code>BrakeType</code>.

  - <code>RearBrake</code> which should be of type <code>BrakeType</code>.

<strong>7. Making the `Motorcycle` class inherit from `Vehicle`</strong>

Logic in src/RentCars/Models/Motorcycle.cs

Add the inheritance of the Vehicle class.

Add new fields specific to Motorcycle.

- The class should have the following properties:

  - <code>SeatHeight</code> which should be of type <code>double</code>.

  - <code>FrontBrake</code> which should be of type <code>BrakeType</code>.

  - <code>RearBrake</code> which should be of type <code>BrakeType</code>.

<strong>8. Making the `PickupTruck` class inherit from `Car`</strong>

Logic in src/RentCars/Models/PickupTruck.cs

Add the inheritance of the Vehicle class.

Add new fields specific to PickupTruck.

- The class should have the following properties:

  - <code>LoadCapacity</code> which should be of type <code>double</code>.

<strong>9. Create an enum `RentStatus`</strong>

Logic in src/RentCars/Types/Enums/RentStatus.cs

- The enum should contain the <code>Confirmed</code> field with a value of 0.

- The enum should contain the <code>Finished</code> field with a value of 1.

- The enum should contain the <code>Canceled</code> field with a value equal to <code>Finished</code>.

<strong>10. Creation of the `Rent` constructor following business rules</strong>

Logic in src/RentCars/Models/Rent.cs

The constructor should receive an instance of <code>Vehicle</code>, one of <code>Person</code>, and an <code>integer</code> value with the rented days.

- To calculate the <code>Price</code> attribute, follow these rules:

- For individuals, the price should be the vehicle's daily price * the rented days.

- For legal entities, the price should be the vehicle's daily price * the rented days with a <code>10% discount</code>.

- The initial status should be <code>RentStatus.Confirmed</code>.

- The constructor should change the <code>IsRented</code> attribute of the vehicle to

</details>

<details>
  <summary><strong>🖥️ To access</strong></summary><br />

1 - Clone the repository:
`git clone git@github.com:VicSales28/project-csharp-rentcar.git`

2 - Go to the repository folder you just cloned:
`cd csharp-029-csharp-projeto-aluguel-de-carros`

3 - Install dependencies:
- Go to the src/ folder.
- Run the command: `dotnet restore`

</details>

<details>
  <summary><strong>🧪 Running all tests</strong></summary><br />
  
To run the tests with .NET, run the command inside your project directory src/:

`dotnet test`

</details>

<details>
  <summary><strong>🗣 Feedbacks</strong></summary><br />
  
_Give me feedbacks, I'm open to new ideas_ 😉

</details>

