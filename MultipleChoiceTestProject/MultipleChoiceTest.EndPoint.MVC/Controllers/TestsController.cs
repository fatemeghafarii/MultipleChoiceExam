using Microsoft.AspNetCore.Mvc;
using MultipleChoiceTest.Application.Contract.Dtos;
using MultipleChoiceTest.Application.Contract.IServices;
using MultipleChoiceTest.Application.Contract.ViewModels;
using MultipleChoiceTest.Model.Exceptions;

namespace MultipleChoiceTest.EndPoint.MVC.Controllers;

public class TestsController(ITestService testService) : Controller
{
    private readonly ITestService _testService = testService;

    [HttpGet]
    public IActionResult GetInputs()
    {
        return View("GetInputsForShowTest");
    }

    [HttpPost]
    public async Task<IActionResult> ShowTest([FromForm] RequestDto request)
    {

        if (request.UserId <= 0 || request.TestId <= 0)
        {
            ModelState.Clear();
            ModelState.AddModelError(string.Empty, "مقادیر وارد شده معتبر نیستند");
            return View("GetInputsForShowTest", request);
        }

        if (!await _testService.CheckInputsForShowTest(request))
        {
            ModelState.AddModelError(string.Empty, "مقادیر وارد شده یافت نشد");
            return View("GetInputsForShowTest", request);
        }

        return RedirectToAction("Test", "Tests", new { testId = request.TestId, userId = request.UserId });
    }
    [HttpGet]
    public async Task<IActionResult> Test(RequestDto request)
    {
        var test = await _testService.GetTestWithQuestionsAsync(request.TestId);
        ViewBag.UserId = request.UserId;
        return View(test);
    }

    [HttpPost]
    public async Task<IActionResult> Test([FromForm] TestDto dto, int userId)
    {
        try
        {
            //if (!ModelState.IsValid)
            //{
            //    var test = await _testService.GetTestWithQuestionsAsync(dto.Id);
            //    ViewBag.UserId = userId;
            //    return View(test);
            //}

            await _testService.SubmitAnswerAsync(dto, userId);

            var testAfterSubmit = await _testService.GetTestWithQuestionsAsync(dto.Id);
            ViewBag.UserId = userId;
            ViewBag.SuccessMessage = "آزمون با موفقیت ثبت شد";
            return View(testAfterSubmit);
        }
        catch (OutOfTestTimeRangeException ex)
        {
            var test = await _testService.GetTestWithQuestionsAsync(dto.Id);
            ViewBag.UserId = userId;
            ModelState.AddModelError(string.Empty, ex.Message); // نمایش خطا در View
            return View(test);
        }
    }
}
