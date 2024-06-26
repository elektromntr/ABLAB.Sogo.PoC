﻿namespace ABLAB.Sogo.PoC.Shared.Dtos;

public class ApartmentDto
{
    public int Id { get; set; }
    public string Symbol { get; set; } = default!;
    public InvestmentDto Investment { get; set; } = default!;
    public decimal Price { get; set; }
    public decimal Area { get; set; }
    public decimal? Garden { get; set; }
    public int Rooms { get; set; }
    public int Level { get; set; }
    public DateTime FinaleDate { get; set; }
    public StatusDto Status { get; set; } = default!;
    public string Headlite { get; set; } = default!;
}
