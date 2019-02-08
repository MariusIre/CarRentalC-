using CarRental.Core.Cars.Makers;
using CarRental.Core.Cars.NewFolder1;
using CarRental.Core.Cars.Parts;
using System;
using System.Collections.Generic;

namespace CarRental.Core.Cars
{
abstract class Car : IComparable<Car>
{
    private GenericMaker _maker { get; set; }
    private Body _body { get; set; }
    private Engine _engine { get; set; }
    private Gearbox _gearbox { get; set; }
    private DateTime _manufacturingYear { get; set; }
    private decimal _price { get; set; }
    private Dictionary<int, Event> _history { get; set; }

    public int CompareTo(Car car) {
        if (this._maker.Equals(car._maker))
            {
            return 0;
                }
        return 1;
    }

    public override bool Equals(object obj)
    {
        var car = obj as Car;
        return car != null &&
                EqualityComparer<GenericMaker>.Default.Equals(_maker, car._maker) &&
                EqualityComparer<Body>.Default.Equals(_body, car._body) &&
                EqualityComparer<Engine>.Default.Equals(_engine, car._engine) &&
                EqualityComparer<Gearbox>.Default.Equals(_gearbox, car._gearbox) &&
                _manufacturingYear == car._manufacturingYear &&
                _price == car._price &&
                EqualityComparer<Dictionary<int, Event>>.Default.Equals(_history, car._history);
    }

    public override int GetHashCode()
    {
        var hashCode = -1214299608;
        hashCode = hashCode * -1521134295 + EqualityComparer<GenericMaker>.Default.GetHashCode(_maker);
        hashCode = hashCode * -1521134295 + EqualityComparer<Body>.Default.GetHashCode(_body);
        hashCode = hashCode * -1521134295 + EqualityComparer<Engine>.Default.GetHashCode(_engine);
        hashCode = hashCode * -1521134295 + EqualityComparer<Gearbox>.Default.GetHashCode(_gearbox);
        hashCode = hashCode * -1521134295 + _manufacturingYear.GetHashCode();
        hashCode = hashCode * -1521134295 + _price.GetHashCode();
        hashCode = hashCode * -1521134295 + EqualityComparer<Dictionary<int, Event>>.Default.GetHashCode(_history);
        return hashCode;
    }
}
}
