#pragma checksum "D:\Університет\4 курс\Платформи інформаційних корпоративних систем\L6\RatingStudents\RatingStudents\Pages\Rating\ChangeRating.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6dadb8e4386321cfa8d539699dc9e055f6510b57"
// <auto-generated/>
#pragma warning disable 1591
namespace RatingStudents.Pages.Rating
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
#line 2 "D:\Університет\4 курс\Платформи інформаційних корпоративних систем\L6\RatingStudents\RatingStudents\Pages\Rating\ChangeRating.razor"
using RatingStudents.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editRating/{CurrentId}")]
    public partial class ChangeRating : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Edit rating</h2>\r\n<hr>\r\n\r\n");
            __builder.OpenElement(1, "form");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-8");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "type", "number");
            __builder.AddAttribute(8, "class", "form-control");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "D:\Університет\4 курс\Платформи інформаційних корпоративних систем\L6\RatingStudents\RatingStudents\Pages\Rating\ChangeRating.razor"
                                                          rating.StudentId

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => rating.StudentId = __value, rating.StudentId, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "type", "number");
            __builder.AddAttribute(14, "class", "form-control");
            __builder.AddAttribute(15, "placeholder", "Subject id");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "D:\Університет\4 курс\Платформи інформаційних корпоративних систем\L6\RatingStudents\RatingStudents\Pages\Rating\ChangeRating.razor"
                                                                                   rating.SubjectId

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => rating.SubjectId = __value, rating.SubjectId, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "type", "number");
            __builder.AddAttribute(21, "class", "form-control");
            __builder.AddAttribute(22, "placeholder", "Mark");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "D:\Університет\4 курс\Платформи інформаційних корпоративних систем\L6\RatingStudents\RatingStudents\Pages\Rating\ChangeRating.razor"
                                                                             rating.Mark

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => rating.Mark = __value, rating.Mark, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "type", "date");
            __builder.AddAttribute(28, "class", "form-control");
            __builder.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "D:\Університет\4 курс\Платформи інформаційних корпоративних систем\L6\RatingStudents\RatingStudents\Pages\Rating\ChangeRating.razor"
                                                        rating.DateRating

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => rating.DateRating = __value, rating.DateRating, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "row");
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "col-4");
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.OpenElement(39, "input");
            __builder.AddAttribute(40, "type", "button");
            __builder.AddAttribute(41, "class", "btn btn-dark");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "D:\Університет\4 курс\Платформи інформаційних корпоративних систем\L6\RatingStudents\RatingStudents\Pages\Rating\ChangeRating.razor"
                                                                 UpdateRating

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "value", "Update");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.OpenElement(45, "input");
            __builder.AddAttribute(46, "type", "button");
            __builder.AddAttribute(47, "class", "btn btn-dark");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "D:\Університет\4 курс\Платформи інформаційних корпоративних систем\L6\RatingStudents\RatingStudents\Pages\Rating\ChangeRating.razor"
                                                                 Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "value", "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "D:\Університет\4 курс\Платформи інформаційних корпоративних систем\L6\RatingStudents\RatingStudents\Pages\Rating\ChangeRating.razor"
       
    [Parameter]
    public string CurrentId { get; set; }
    RatingStudents.Data.Rating rating = new Data.Rating();

    protected override async Task OnInitializedAsync()
    {
        rating = await Task.Run(() => ratService.GetRating(Convert.ToInt32(CurrentId)));
    }

    protected void UpdateRating()
    {
        ratService.Edit(rating);
        NavMan.NavigateTo("rating");
    }
    void Cancel()
    {
        NavMan.NavigateTo("Rating");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavMan { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RatingService ratService { get; set; }
    }
}
#pragma warning restore 1591
