namespace MultipleChoiceTest.Model.Models;

public class UserTest : Entity<int>
{
    public User? User { get; set; }
    public int UserId { get; set; }
    public Test? Test { get; set; }
    public int TestId { get; set; }
}
