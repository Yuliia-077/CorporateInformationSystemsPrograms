#pragma checksum "D:\Університет\4 курс\Платформи інформаційних корпоративних систем\L6\RatingStudents\RatingStudents\Pages\DeleteSubject.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec0f6873eeb8904882365a29654dee71fea237c0"
// <auto-generated/>
#pragma warning disable 1591
namespace RatingStudents.Pages
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
#line 2 "D:\Університет\4 курс\Платформи інформаційних корпоративних систем\L6\RatingStudents\RatingStudents\Pages\DeleteSubject.razor"
using RatingStudents.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/deleteSubject/{CurrentId}")]
    public partial class DeleteSubject : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Delete Subject</h2>\r\n<hr>\r\n");
            __builder.AddMarkupContent(1, "<h4>Are you sure want to delete this?</h4>\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-8");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<strong>StudentId: </strong>");
            __builder.OpenElement(9, "p");
            __builder.AddContent(10, 
#nullable restore
#line 11 "D:\Університет\4 курс\Платформи інформаційних корпоративних систем\L6\RatingStudents\RatingStudents\Pages\DeleteSubject.razor"
                                        subject.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.AddMarkupContent(12, "<strong>SubjectId: </strong>");
            __builder.OpenElement(13, "p");
            __builder.AddContent(14, 
#nullable restore
#line 12 "D:\Університет\4 курс\Платформи інформаційних корпоративних систем\L6\RatingStudents\RatingStudents\Pages\DeleteSubject.razor"
                                        subject.TeacherId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.AddMarkupContent(16, "<strong>Mark: </strong>");
            __builder.OpenElement(17, "p");
            __builder.AddContent(18, 
#nullable restore
#line 13 "D:\Університет\4 курс\Платформи інформаційних корпоративних систем\L6\RatingStudents\RatingStudents\Pages\DeleteSubject.razor"
                                   subject.MaxMark

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "row");
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "col-4");
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenElement(28, "input");
            __builder.AddAttribute(29, "type", "button");
            __builder.AddAttribute(30, "class", "btn btn-dark");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "D:\Університет\4 курс\Платформи інформаційних корпоративних систем\L6\RatingStudents\RatingStudents\Pages\DeleteSubject.razor"
                                                             RemoveSubject

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "value", "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.OpenElement(34, "input");
            __builder.AddAttribute(35, "type", "button");
            __builder.AddAttribute(36, "class", "btn btn-dark");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "D:\Університет\4 курс\Платформи інформаційних корпоративних систем\L6\RatingStudents\RatingStudents\Pages\DeleteSubject.razor"
                                                             Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "value", "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "D:\Університет\4 курс\Платформи інформаційних корпоративних систем\L6\RatingStudents\RatingStudents\Pages\DeleteSubject.razor"
       

    [Parameter]
    public string CurrentId { get; set; }
    RatingStudents.Data.Subject subject = new Data.Subject();

    protected override async Task OnInitializedAsync()
    {
        subject = await Task.Run(() => subService.GetSubject(Convert.ToInt32(CurrentId)));
    }

    protected void RemoveSubject()
    {
        subService.Delete(subject);
        NavMan.NavigateTo("subject");
    }
    void Cancel()
    {
        NavMan.NavigateTo("Subject");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavMan { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SubjectService subService { get; set; }
    }
}
#pragma warning restore 1591
