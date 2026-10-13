using System.ComponentModel.DataAnnotations;

namespace NexusCommerce.Orders.API.DTOs;

public record CreateOrderItemRequest(
    Guid ProductId,
    [Required] string ProductName,
    [Range(1, int.MaxValue)] int Quantity,
    [Range(0.01, double.MaxValue)] decimal UnitPrice);

public record CreateOrderRequest(
    [Required, EmailAddress] string CustomerEmail,
    [MinLength(1)] List<CreateOrderItemRequest> Items);