#pragma checksum "C:\Users\asepm\source\repos\Hotel\Areas\Reservation\Views\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "482b123cb9b69716cff806b72c58004c275a50ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Reservation_Views_Index), @"mvc.1.0.view", @"/Areas/Reservation/Views/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"482b123cb9b69716cff806b72c58004c275a50ce", @"/Areas/Reservation/Views/Index.cshtml")]
    public class Areas_Reservation_Views_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hotel.Models.Reservation.CreateEditViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\asepm\source\repos\Hotel\Areas\Reservation\Views\Index.cshtml"
  
    Layout = "_Layout";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\asepm\source\repos\Hotel\Areas\Reservation\Views\Index.cshtml"
 using (Html.BeginForm(null, null, FormMethod.Post, new { id = "frm", name = "frm", @style = "width: 100%;", @class = "needs-validation" }))
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <table border=\"0\">\r\n        <tr>\r\n            <td>\r\n                <label for=\"KdReservation\">Kode Reservation</label>\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 16 "C:\Users\asepm\source\repos\Hotel\Areas\Reservation\Views\Index.cshtml"
           Write(Html.TextBoxFor(x => x.KdReservation, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <label for=\"KdKamar\">Kode Kamar</label>\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 22 "C:\Users\asepm\source\repos\Hotel\Areas\Reservation\Views\Index.cshtml"
           Write(Html.DropDownListFor(x => x.KodeKamar, new SelectList(Model.ListKamar, "KdKamar", "TipeKamar"), new { @class = "form-select" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                <label>Tanggal Menginap</label>\r\n            </td>\r\n            <td colspan=\"3\" style=\"display: flex;\">\r\n                <div style=\"flex: 1;\">\r\n                    ");
#nullable restore
#line 31 "C:\Users\asepm\source\repos\Hotel\Areas\Reservation\Views\Index.cshtml"
               Write(Html.TextBoxFor(x => x.StartFrom, "{0:yyyy-MM-dd}", new { @class = "form-control form-control-sm", type = "date", @style = "width:100%" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <span style=\"flex: 0 0 auto;\">-</span>\r\n                <div style=\"flex: 1;\">\r\n                    ");
#nullable restore
#line 35 "C:\Users\asepm\source\repos\Hotel\Areas\Reservation\Views\Index.cshtml"
               Write(Html.TextBoxFor(x => x.EndTo, "{0:yyyy-MM-dd}", new { @class = "form-control form-control-sm", type = "date", @style = "width:100%" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n    <br />\r\n    <br />\r\n");
            WriteLiteral(@"    <div style=""width: 100%;"">
        <ul class=""nav nav-pills flex-column flex-sm-row"" id=""myTab"">
            <li class=""nav-item"" role=""presentation"">
                <button class=""nav-link active"" id=""Identitas-tab"" data-bs-toggle=""tab"" data-bs-target=""#Identitas"" type=""button"" role=""tab"" aria-controls=""home"" aria-selected=""true"">Identitas</button>
            </li>
            <li class=""nav-item"" role=""presentation"">
                <button class=""nav-link"" id=""Payment-tab"" data-bs-toggle=""tab"" data-bs-target=""#Payment"" type=""button"" role=""tab"" aria-controls=""Payment"" aria-selected=""false"">Payment</button>
            </li>
        </ul>
    </div>
    <div class=""tab-content"" id=""myTabContent"" style=""width:100%"">
        <div class=""tab-pane fade show active"" id=""Identitas"" role=""tabpanel"" aria-labelledby=""Identitas-tab"">
            <div class=""row"" style=""width: 100%;"">
                ");
#nullable restore
#line 56 "C:\Users\asepm\source\repos\Hotel\Areas\Reservation\Views\Index.cshtml"
           Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-5\">\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 59 "C:\Users\asepm\source\repos\Hotel\Areas\Reservation\Views\Index.cshtml"
                   Write(Html.LabelFor(x => x.Nik, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-md-10\">\r\n                            ");
#nullable restore
#line 61 "C:\Users\asepm\source\repos\Hotel\Areas\Reservation\Views\Index.cshtml"
                       Write(Html.TextBoxFor(x => x.Nik, new { @class = "form-control",@required = "required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 65 "C:\Users\asepm\source\repos\Hotel\Areas\Reservation\Views\Index.cshtml"
                   Write(Html.LabelFor(x => x.KartuPelajar, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-md-10\">\r\n                            ");
#nullable restore
#line 67 "C:\Users\asepm\source\repos\Hotel\Areas\Reservation\Views\Index.cshtml"
                       Write(Html.TextBoxFor(x => x.KartuPelajar, new { @class = "form-control", @required = "required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 71 "C:\Users\asepm\source\repos\Hotel\Areas\Reservation\Views\Index.cshtml"
                   Write(Html.LabelFor(x => x.Nama, new { @class = "col-md-2 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-md-10\">\r\n                            ");
#nullable restore
#line 73 "C:\Users\asepm\source\repos\Hotel\Areas\Reservation\Views\Index.cshtml"
                       Write(Html.TextBoxFor(x => x.Nama, new { @class = "form-control", @required = "required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <div class=\"invalid-feedback\">\r\n                                ");
#nullable restore
#line 75 "C:\Users\asepm\source\repos\Hotel\Areas\Reservation\Views\Index.cshtml"
                           Write(Html.ValidationMessageFor(m => m.Nama, message:"", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 80 "C:\Users\asepm\source\repos\Hotel\Areas\Reservation\Views\Index.cshtml"
                   Write(Html.LabelFor(x => x.KewargaNegaraan, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-md-10\">\r\n                            ");
#nullable restore
#line 82 "C:\Users\asepm\source\repos\Hotel\Areas\Reservation\Views\Index.cshtml"
                       Write(Html.DropDownListFor(x => x.KewargaNegaraan, new SelectList(Model.ListKamar, "KdKamar", "TipeKamar"), new { @class = "form-select", @required = "required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 86 "C:\Users\asepm\source\repos\Hotel\Areas\Reservation\Views\Index.cshtml"
                   Write(Html.LabelFor(x => x.Alamat, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-md-10\">\r\n                            ");
#nullable restore
#line 88 "C:\Users\asepm\source\repos\Hotel\Areas\Reservation\Views\Index.cshtml"
                       Write(Html.TextAreaFor(x => x.Alamat,new {@class = "form-control",@style="height:150px;", @required = "required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""form-group"">
                        <button type=""submit"" class=""btn btn-primary"" id=""SaveReservation"">Save</button>
                    </div>
                </div>
                <div class=""col-md-5"">
                    <div class=""form-group"">
                        ");
#nullable restore
#line 97 "C:\Users\asepm\source\repos\Hotel\Areas\Reservation\Views\Index.cshtml"
                   Write(Html.LabelFor(x => x.Agama, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-md-10\">\r\n                            ");
#nullable restore
#line 99 "C:\Users\asepm\source\repos\Hotel\Areas\Reservation\Views\Index.cshtml"
                       Write(Html.DropDownListFor(x => x.Agama, new SelectList(Model.ListKamar, "KdKamar", "TipeKamar"), new { @class = "form-select", @required = "required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 104 "C:\Users\asepm\source\repos\Hotel\Areas\Reservation\Views\Index.cshtml"
                   Write(Html.LabelFor(x => x.StatusPribadi, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-md-10\">\r\n                            ");
#nullable restore
#line 106 "C:\Users\asepm\source\repos\Hotel\Areas\Reservation\Views\Index.cshtml"
                       Write(Html.TextBoxFor(x => x.StatusPribadi, new { @class = "form-control", @required = "required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 110 "C:\Users\asepm\source\repos\Hotel\Areas\Reservation\Views\Index.cshtml"
                   Write(Html.LabelFor(x => x.JenisKelamin, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-md-10\">\r\n                            ");
#nullable restore
#line 112 "C:\Users\asepm\source\repos\Hotel\Areas\Reservation\Views\Index.cshtml"
                       Write(Html.TextBoxFor(x => x.JenisKelamin, new { @class = "form-control", @required = "required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 116 "C:\Users\asepm\source\repos\Hotel\Areas\Reservation\Views\Index.cshtml"
                   Write(Html.LabelFor(x => x.Pekerjaan, new { @class = "control-label", @required = "required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-md-10\">\r\n                            ");
#nullable restore
#line 118 "C:\Users\asepm\source\repos\Hotel\Areas\Reservation\Views\Index.cshtml"
                       Write(Html.DropDownListFor(x => x.Pekerjaan, new SelectList(Model.ListKamar, "KdKamar", "TipeKamar"), new { @class = "form-select", @required = "required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 126 "C:\Users\asepm\source\repos\Hotel\Areas\Reservation\Views\Index.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <partial name=\"_ValidationScriptsPartial\" />\r\n    <script>\r\n\r\n        // Example starter JavaScript for disabling form submissions if there are invalid fields\r\n");
                WriteLiteral(@"        $(document).ready(function () {
            $(""#SaveReservation"").click(function (event) {
                event.preventDefault();
                var form = $(this).closest('form');
                console.log(form[0]);

                if (!form[0].checkValidity()) {
                    event.stopPropagation();

                }

                form.addClass('was-validated');
            });
        });
    </script>

");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hotel.Models.Reservation.CreateEditViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591