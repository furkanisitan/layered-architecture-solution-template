# LayeredArchitectureSolutionTemplate
This repo offers a multi-layered architectural template for C#.
This template includes the sample implementations of the following technologies.
- EntityFramework for database operations
- FluentValidation for model validation
- Postsharp for Aspect Oriented Programming
- Ninject for Dependency Injection
- .Net System.Security.Principal for Role Based Authorization

To include the template in visual studio, zipping files in the
[TemplateFiles](https://github.com/furkanisitan/LayeredArchitectureSolutionTemplate/tree/master/TemplateFiles) folder and 
move them to "%USERPROFILE%\Documents\Visual Studio 2019\Templates\ProjectTemplates".

## Notes
- Check the "place solution and project in the same directory" checkbox when creating a new project from this template, 
for package references to specify the correct path.
- After creating the project, right click on the solution and click on 'restore nuget packages'. Then restart Visual Studio.
