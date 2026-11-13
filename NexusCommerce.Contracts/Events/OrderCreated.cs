namespace NexusCommerce.Contracts.Events;

public record OrderCreated(
    Guid OrderId,
    List<OrderCreatedItem> Items);

public record OrderCreatedItem(
    Guid ProductId,
    int Quantity);
