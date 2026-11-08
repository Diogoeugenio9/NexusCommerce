using System.ComponentModel.DataAnnotations;

namespace NexusCommerce.Inventory.API.DTOs;


public record CreateProductRequest(
    [Required] string Name,
    [Range(0.01, double.MaxValue)] decimal Price,
    [Range(0, int.MaxValue)] int StockQuantity);

        


