#pragma checksum "D:\Університет\4 курс\Платформи інформаційних корпоративних систем\L6\RatingStudents\RatingStudents\Pages\Subject\EditSubject.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b936c3e37edff86a325076696f7400dc50732b4"
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
#line 2 "D:\Університет\4 курс\Платформи інформаційних корпоративних систем\L6\RatingStudents\RatingStudents\Pages\Subject\EditSubject.razor"
using RatingStudents.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editSubject/{CurrentId}")]
    public partial class EditSubject : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "D:\Університет\4 курс\Платформи інформаційних корпоративних систем\L6\RatingStudents\RatingStudents\Pages\Subject\EditSubject.razor"
       
    [Parameter]
    public string CurrentId { get; set; }
    Data.Subject subject = new Data.Subject();

    protected override async Task OnInitializedAsync()
    {
        subject = await Task.Run(() => subService.GetSubject(Convert.ToInt32(CurrentId)));
    }

    protected void UpdateSubject()
    {
        subService.Edit(subject);
        NavMan.NavigateTo("subject");
    }
    void Cancel()
    {
        NavMan.NavigateTo("subject");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavMan { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SubjectService subService { get; set; }
    }
}
#pragma warning restore 1591
