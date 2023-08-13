namespace BubberBreakfast.Contracts.BreakfastResponse;
public record CreateBreakfastResponse(
    Guid Id,
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    DateTime LastModified,
    List<string> Savory,
    List<string> Sweet
);