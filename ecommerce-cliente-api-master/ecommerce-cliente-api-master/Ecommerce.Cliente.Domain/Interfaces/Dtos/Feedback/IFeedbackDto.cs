namespace Ecommerce.Feedback.Domain.Interfaces.Dtos
{
    public interface IFeedbackDto
    {
         string Nota { get; set; } 
         string Positivo { get; set; }
         string Negativo { get; set; }
    }
}
