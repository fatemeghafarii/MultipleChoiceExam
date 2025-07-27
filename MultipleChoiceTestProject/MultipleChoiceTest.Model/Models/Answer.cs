namespace MultipleChoiceTest.Model.Models;
public class Answer : Entity<int>
{
    public DateTime SubmittedAt { get; set; } // برای بررسی بازه زمانی مجاز) زمان ارسال پاسخ)
    public int? SelectedOption { get; set; }
    public int UserId { get; set; }
    public User? User { get; set; }
    public int QuestionId { get; set; }
    public Question? Question { get; set; }
    public int TestId { get; set; }
    public Test? Test { get; set; }
}
