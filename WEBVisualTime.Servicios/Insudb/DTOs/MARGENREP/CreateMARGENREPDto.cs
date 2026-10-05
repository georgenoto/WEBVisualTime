namespace WEBVisualTime.Servicios.Insudb.DTOs.MARGENREP;

public class CreateMARGENREPDto
{
    public string? SLOGO { get; set; }
    public string? SLOG { get; set; }
    public decimal? X1 { get; set; }
    public decimal? Y1 { get; set; }
    public decimal? NIMAGENX { get; set; }
    public decimal? NIMAGENY { get; set; }
    public decimal? NPOSIMGX { get; set; }
    public decimal? NPOSIMGY { get; set; }
    public decimal? NRADIOCURVA { get; set; }
    public decimal? NSPACE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
