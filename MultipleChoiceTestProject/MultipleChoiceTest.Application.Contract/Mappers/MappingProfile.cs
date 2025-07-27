using AutoMapper;
using MultipleChoiceTest.Application.Contract.Dtos;
using MultipleChoiceTest.Model.Models;

namespace MultipleChoiceTest.Application.Contract.Mappers;
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Test, TestDto>();
        CreateMap<Question, QuestionDto>();
        CreateMap<Option, OptionDto>();
        CreateMap<Answer, AnswerDto>();
    }

}
