#pragma checksum "D:\Університет\4 курс\Платформи інформаційних корпоративних систем\L6\RatingStudents\RatingStudents\Pages\Subject\Subject.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd3de09737e723c0403bd4e590569d45ecda3a20"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace RatingStudents.Pages.Subject
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Університет\4 курс\Платформи інформаційних корпоративних систем\L6\RatingStudents\RatingStudents\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Університет\4 курс\Платформи інформаційних корпоративних систем\L6\RatingStudents\RatingStudents\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Університет\4 курс\Платформи інформаційних корпоративних систем\L6\RatingStudents\RatingStudents\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Університет\4 курс\Платформи інформаційних корпоративних систем\L6\RatingStudents\RatingStudents\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Університет\4 курс\Платформи інформаційних корпоративних систем\L6\RatingStudents\RatingStudents\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Університет\4 курс\Платформи інформаційних корпоративних систем\L6\RatingStudents\RatingStudents\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Університет\4 курс\Платформи інформаційних корпоративних систем\L6\RatingStudents\RatingStudents\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Університет\4 курс\Платформи інформаційних корпоративних систем\L6\RatingStudents\RatingStudents\_Imports.razor"
using RatingStudents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Університет\4 курс\Платформи інформаційних корпоративних систем\L6\RatingStudents\RatingStudents\_Imports.razor"
using RatingStudents.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Університет\4 курс\Платформи інформаційних корпоративних систем\L6\RatingStudents\RatingStudents\Pages\Subject\Subject.razor"
using RatingStudents.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/subject")]
    public partial class Subject : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "D:\Університет\4 курс\Платформи інформаційних корпоративних систем\L6\RatingStudents\RatingStudents\Pages\Subject\Subject.razor"
       
    List<RatingStudents.Data.Subject> subjects;
    protected override async Task OnInitializedAsync()
    {
        subjects = await Task.Run(() => subjectService.GetSubjects());
    }
    /*protected override async Task OnInitializedAsync()
{
    subjects = await Task.Run(() => subjectService.GetSubjects());
}*/

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SubjectService subjectService { get; set; }
    }
}
#pragma warning restore 1591
