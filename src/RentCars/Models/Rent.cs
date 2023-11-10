using RentCars.Types;

namespace RentCars.Models;

public class Rent
{
    public Vehicle Vehicle { get; set; }
    public Person Person { get; set; }
    public int DaysRented { get; set; }
    public double Price { get; set; }
    public RentStatus Status { get; set; }

    //10 - Crie o construtor de `Rent` seguindo as regras de negócio
    public Rent(Vehicle vehicle, Person person, int daysRented)
    {
        this.Vehicle = vehicle;
        this.Person = person;
        this.DaysRented = daysRented;

        if (person is LegalPerson)
        {
            Price = vehicle.PricePerDay * daysRented * 0.9;
        }
        else
        {
            Price = vehicle.PricePerDay * daysRented;
        }

        Status = RentStatus.Confirmed;
        vehicle.IsRented = true;
        person.Debit += Price;
    }

    //11 - Implemente os métodos de `cancelar` e `finalizar` um aluguel
    public void Cancel()
    {
        if (Status != RentStatus.Canceled)
        {
            Status = RentStatus.Canceled;
            Vehicle.IsRented = false;
            Person.Debit -= Price;
        }
    }

    //11 - Implemente os métodos de `cancelar` e `finalizar` um aluguel
    public void Finish()
    {
        if (Status != RentStatus.Finished)
        {
            Status = RentStatus.Finished;
            Vehicle.IsRented = false;
        }
    }
}