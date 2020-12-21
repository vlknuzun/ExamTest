using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SinavOlusturma.Core.Service;
using SinavOlusturma.Model.Context;
using SinavOlusturma.Model.Entities;
using SinavOlusturma.Service.Option;
using System;
using System.Collections.Generic;
using System.Text;

namespace SinavOlusturma.Service.Tools
{
    public static class DependecyService
    {
        public static IServiceCollection AddDependecyService(this IServiceCollection services)
        {
            services.AddTransient<ICoreService<Exam>>(x => new ExamService());
            services.AddTransient<ICoreService<Question>>(x => new QuestionService());
            services.AddTransient<ICoreService<Selection>>(x => new SelectionService());
            services.AddTransient<ICoreService<User>>(x => new UserSevice());
            services.AddTransient<ICoreService<UserExamAnswer>>(x => new UserExamAnswerService());
            return services;
        }
    }
}
