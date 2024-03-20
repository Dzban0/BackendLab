﻿namespace BackendLab01.DTO
{
    public class QuizDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<QuizItemDTO> Options { get; set; }
    }

    public static QuizDTO Of(Quiz quiz)
    {
        return new QuizDTO()
        {
            Id = quiz.Id,
            Title = quiz.Title,

        };
    }
}
