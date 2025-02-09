using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Models;

[Table("DimProduct")]
public class DimProduct
{
    [Key]
    public int ProductKey { get; set; }
    public string? ProductLabel { get; set; }
    public string? ProductName { get; set; }
    public string? ProductDescription { get; set; }
    public int? ProductSubcategoryKey { get; set; }
    public string? Manufacturer { get; set; }
    public string? BrandName { get; set; }
    public string? ClassID { get; set; }
    public string? ClassName { get; set; }
    public string? StyleID { get; set; }
    public string? StyleName { get; set; }
    public string? ColorID { get; set; }
    [Required]
    public string ColorName { get; set; } = string.Empty;
    public string? Size { get; set; }
    public string? SizeRange { get; set; }
    public string? SizeUnitMeasureID { get; set; }
    public double? Weight { get; set; }
    public string? WeightUnitMeasureID { get; set; }
    public string? UnitOfMeasureID { get; set; }
    public string? UnitOfMeasureName { get; set; }
    public string? StockTypeID { get; set; }
    public string? StockTypeName { get; set; }
    public decimal? UnitCost { get; set; }
    public decimal? UnitPrice { get; set; }
    public DateTime? AvailableForSaleDate { get; set; }
    public DateTime? StopSaleDate { get; set; }
    public string? Status { get; set; }
    public string? ImageURL { get; set; }
    public string? ProductURL { get; set; }
    public int? ETLLoadID { get; set; }
    public DateTime? LoadDate { get; set; }
    public DateTime? UpdateDate { get; set; }
}
