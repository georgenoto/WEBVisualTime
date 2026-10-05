namespace WEBVisualTime.Servicios.Insudb.DTOs.HEALTHCLAIMFORM;

public class CreateHEALTHCLAIMFORMDto
{
    public string? CLIENTE { get; set; }
    public long? IDRECLAMACION { get; set; }
    public long? NCASENUM { get; set; }
    public string? FORMULARIO { get; set; }
    public DateTime? FECHACOMPUTADOR { get; set; }
    public string USERID { get; set; }
    public string? CONTENT { get; set; }
}
