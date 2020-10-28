using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata;


namespace StudentRating
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles();

            app.Map("", Start);
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

        }

        public void Start(IApplicationBuilder app)
        {
            app.Run(
                async context =>
                {
                    var builder = new ConfigurationBuilder();
                    // установка пути к текущему каталогу
                    builder.SetBasePath(Directory.GetCurrentDirectory());
                    // получаем конфигурацию из файла appsettings.json
                    builder.AddJsonFile("appsettings.json");
                    // create configuration
                    var config = builder.Build();
                    // получаем строку подключения
                    string connectionString = config.GetConnectionString("DefaultConnection");

                    var optionsBuilder = new DbContextOptionsBuilder<StudentRatingContext>();
                    var options = optionsBuilder
                        .UseSqlServer(connectionString)
                        .Options;
                    using (StudentRatingContext db = new StudentRatingContext(options))
                    {
                        // select subjects and teacher who teaches them
                        var subjects = from s in db.Subjects.Include(t => t.Teacher)
                                       select s;

                        // select students and subjects they attend
                        var students = from r in db.Rating
                                       join st in db.Students on r.StudentId equals st.Id
                                       join sub in db.Subjects on r.SubjectId equals sub.Id
                                       select new
                                       {
                                           LastName = st.LastName,
                                           FirstName = st.FirstName,
                                           SubjectName = sub.Name,
                                           Mark = r.Mark
                                       };

                        // select students who have ration not less than 2 subjects
                        var studentSubject = from r in db.Rating.Include(s => s.Student)
                                             group r by new
                                             { r.StudentId, r.Student.FirstName, r.Student.LastName } into grp
                                             where grp.Count() >= 2
                                             select grp.Key;
                       
                        context.Response.ContentType = "text/html";
                        await context.Response.WriteAsync("<img src=\"/sr.jpg\" class=\"img\" alt=\"My image\" />");
                        
                        await context.Response.WriteAsync("<h3>Subjects and teachers who teach them</h3>");
                        foreach (var subject in subjects.ToList())
                            await context.Response.WriteAsync($"<br>{subject.Name} {subject.MaxMark} - {subject.Teacher.LastName} {subject.Teacher.FirstName} {subject.Teacher.MiddleName}");

                        await context.Response.WriteAsync("<h3>Subjects and students who learn them</h3>");
                        foreach (var student in students)
                            await context.Response.WriteAsync($"<br>{student.LastName} {student.FirstName} {student.SubjectName} {student.Mark}");

                        await context.Response.WriteAsync("<h3>Students have ration not less than 2 subjects</h3>");
                        foreach (var stSub in studentSubject.ToList())
                            await context.Response.WriteAsync($"<br>{stSub.LastName} {stSub.FirstName}");
                    }

                });
        }


    }
}
