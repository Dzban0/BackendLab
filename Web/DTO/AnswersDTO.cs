namespace BackendLab01.DTO
{
    public class AnswersDTO
    {
        public int Id { get; set; }
        public string Answer { get; set; }
        public ISet<QuizItem> QuizItems { get; set; } = new HashSet<QuizItem>();
    }
}
