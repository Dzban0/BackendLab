using BackendLab01.DTO;
using Microsoft.AspNetCore.Mvc;

namespace BackendLab01.Controllers
{
    public class ApiQuizUserController : Controller
    {
        private IQuizUserService _service;

        public ApiQuizUserController(IQuizUserService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route(template:"{id}")]
        public ActionResult<QuizDTO> FindQuizById(int id)
        {
            var quiz = _service.FindQuizById(id);
            return quiz is null ? NotFound() : QuizDTO.Of(quiz);
        }

        [HttpGet]
        [Route(template:"{quizId/items/itemId}/answers")]
        public ActionResult SaveAnswer(int quizId, int ItemId, AnswersDTO dto)
        {
            _service.SaveUserAnswerForQuiz(quizId, userId: 1, ItemId, dto.Answer);
            return Created();
        }
    }
}
