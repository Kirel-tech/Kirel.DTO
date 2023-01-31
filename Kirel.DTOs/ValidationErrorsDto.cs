namespace Kirel.DTOs;

public class ValidationErrorsDto
{
    public Dictionary<string, string[]> Errors { get; set; } = new ();
}