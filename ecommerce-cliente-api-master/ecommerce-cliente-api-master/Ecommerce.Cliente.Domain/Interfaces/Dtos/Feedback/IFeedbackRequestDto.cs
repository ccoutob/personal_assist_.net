namespace Ecommerce.Feedback.Domain.Interfaces.Dtos
{
    public interface IFeedbackRequestDto : IFeedbackDto
    {
        string Id { get; set; }
    }
}
