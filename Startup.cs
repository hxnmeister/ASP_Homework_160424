using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Text;

namespace ASP_Homework_160424
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStaticFiles();

            const string response = @"
                <!DOCTYPE html>
                <html>
                    <head>
                        <link rel='stylesheet' href='/css/styles.css'>
                    </head>
                    <body>
                        <div class='container'>
                            <div class='name'>
                                <p class='title'><b>Name:</b></p>
                                <p class='info'>Valerii Stronskyi</p>
                            </div>
                            <div class='birth-date'>
                                <p class='title'><b>Birthday:</b></p>
                                <p class='info'>21 January 2000</p>
                            </div>
                            <div class='study'>
                                <p class='title'><b>Place of study:</b></p>
                                <p class='info'> - School No. 15</p>
                                <p class='info'> - State Vocational and Technical Educational Institution ""Sumy Center of Vocational and Technical Education No. 2""</p>
                                <p class='info'> - (currently) Computer Academy ""IT Step""</p>
                            </div>
                            <div class='languages'>
                                <p class='title'><b>Languages:</b></p>
                                <p class='info'> - German (A2)</p>
                                <p class='info'> - English (A2)</p>
                                <p class='info'> - Italian (A1)</p>
                                <p class='info'> - Ukrainian (native)</p>
                            </div>
                            <div class='about-myself'>
                                <p class='title'><b>About myself:</b></p>
                                <p class='info'>
                                   I have a great desire for new knowledge and discoveries in the field of programming and beyond. 
                                   After graduation, I will continue to develop and learn new things both in C# and in other programming languages
                                </p>
                            </div>
                        </div>
                    </body>
                </html>
            ";

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync(response);
            });
        }
    }
}
