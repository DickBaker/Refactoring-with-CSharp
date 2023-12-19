﻿namespace Packt.CloudySkiesAir.Chapter12.Flight.Scheduling.Flights;

public class PassengerFlightInfo : FlightInfoBase {
  int _passengers;
  public int Passengers {
    get => _passengers;
    private set => _passengers = value;
  }

  public void Load(int passengers) =>
    Passengers = passengers;

  public void Unload() =>
    Passengers = 0;

  public override string BuildFlightIdentifier() =>
    base.BuildFlightIdentifier() +
    $" carrying {Passengers} people";
}