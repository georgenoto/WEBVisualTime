#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TYPEPERGROUP
{
    public string SSTATREGT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public int NBUSINESSTY { get; set; }

    [ForeignKey("NBUSINESSTY")]
    public Insudb.TABLE9005? TABLE9005 { get; set; }
    public int NCOMMERGRP { get; set; }

    [ForeignKey("NCOMMERGRP")]
    public Insudb.TABLE9000? TABLE9000 { get; set; }
}
