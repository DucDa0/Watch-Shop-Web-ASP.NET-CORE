#pragma checksum "C:\Users\galax\Desktop\WatchShopCore\GraniteHouse\Areas\Customer\Views\ShoppingCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e4e972679dff7fbc44508d838d980c782245858"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_ShoppingCart_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/ShoppingCart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Customer/Views/ShoppingCart/Index.cshtml", typeof(AspNetCore.Areas_Customer_Views_ShoppingCart_Index))]
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
#line 1 "C:\Users\galax\Desktop\WatchShopCore\GraniteHouse\Areas\Customer\Views\_ViewImports.cshtml"
using GraniteHouse;

#line default
#line hidden
#line 2 "C:\Users\galax\Desktop\WatchShopCore\GraniteHouse\Areas\Customer\Views\_ViewImports.cshtml"
using GraniteHouse.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e4e972679dff7fbc44508d838d980c782245858", @"/Areas/Customer/Views/ShoppingCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d53bf185f1e092ca3f9d10ed71965193003c0de5", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_ShoppingCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GraniteHouse.Models.ViewModel.ShoppingCartViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Clear", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FixAmount", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveFromShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Appointments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\galax\Desktop\WatchShopCore\GraniteHouse\Areas\Customer\Views\ShoppingCart\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(6538, 240, true);
            WriteLiteral("\r\n\r\n<div class=\"container body-content\">\r\n    <br />\r\n    <h2 class=\"text-info\">Your Shopping Cart</h2>\r\n\r\n    <div class=\"text-right\" style=\"margin-bottom:20px;position:relative;right:15px;\">\r\n        <div class=\"btn-group \">\r\n            ");
            EndContext();
            BeginContext(6778, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d88d454283964e569348353c96c4e0ec", async() => {
                BeginContext(6867, 10, true);
                WriteLiteral("Clear Bags");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6881, 584, true);
            WriteLiteral(@"
        </div>
    </div>
    <div class=""container"">

        <div class=""row"">

            <div class=""col-sm-12"">

                <div class=""table-responsive"">
                    <table class=""table table-bordered"">
                        <tr class=""table-info"">
                            <th>Image</th>
                            <th>Product Names</th>
                            <th>Amounts</th>
                            <th>Price</th>
                            <th>Total</th>
                            <th></th>
                        </tr>
");
            EndContext();
#line 157 "C:\Users\galax\Desktop\WatchShopCore\GraniteHouse\Areas\Customer\Views\ShoppingCart\Index.cshtml"
                          
                            int i = 0;
                            decimal total = 0;
                        

#line default
#line hidden
            BeginContext(7608, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 162 "C:\Users\galax\Desktop\WatchShopCore\GraniteHouse\Areas\Customer\Views\ShoppingCart\Index.cshtml"
                         foreach (var line in Model.ShoppingCart.ShoppingCartItems)
                        {
                            decimal newPrice = (line.Products.Price - ((line.Products.Price * line.Products.Discount) / 100));

#line default
#line hidden
            BeginContext(7850, 128, true);
            WriteLiteral("                            <tr>\r\n                                <td class=\"text-center\">\r\n                                    ");
            EndContext();
            BeginContext(7978, 256, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1f704db3dce4c8c9b645d52514b22a1", async() => {
                BeginContext(8093, 46, true);
                WriteLiteral("\r\n                                        <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 8139, "\"", 8165, 1);
#line 168 "C:\Users\galax\Desktop\WatchShopCore\GraniteHouse\Areas\Customer\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 8145, line.Products.Image, 8145, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(8166, 64, true);
                WriteLiteral(" width=\"70\" height=\"60\" />\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 167 "C:\Users\galax\Desktop\WatchShopCore\GraniteHouse\Areas\Customer\Views\ShoppingCart\Index.cshtml"
                                                                                                                        WriteLiteral(line.Products.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8234, 77, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>");
            EndContext();
            BeginContext(8312, 18, false);
#line 171 "C:\Users\galax\Desktop\WatchShopCore\GraniteHouse\Areas\Customer\Views\ShoppingCart\Index.cshtml"
                               Write(line.Products.Name);

#line default
#line hidden
            EndContext();
            BeginContext(8330, 107, true);
            WriteLiteral("</td>\r\n                                <td style=\"text-align:center\">\r\n                                    ");
            EndContext();
            BeginContext(8437, 465, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25a68855f9d94df49a6ceeaa90ecb6d2", async() => {
                BeginContext(8549, 79, true);
                WriteLiteral("\r\n                                        <input type=\"hidden\" name=\"productId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 8628, "\"", 8653, 1);
#line 174 "C:\Users\galax\Desktop\WatchShopCore\GraniteHouse\Areas\Customer\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 8636, line.Products.Id, 8636, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(8654, 137, true);
                WriteLiteral(" />\r\n                                        <input class=\"col-lg-4\" style=\"height:30px;\" type=\"number\" min=\"1\" step=\"1\" name=\"newAmount\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 8791, "\"", 8811, 1);
#line 175 "C:\Users\galax\Desktop\WatchShopCore\GraniteHouse\Areas\Customer\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 8799, line.Amount, 8799, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("onchange", " onchange=\"", 8812, "\"", 8853, 3);
                WriteAttributeValue("", 8823, "$(\'#formSoluong_", 8823, 16, true);
#line 175 "C:\Users\galax\Desktop\WatchShopCore\GraniteHouse\Areas\Customer\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 8839, i, 8839, 2, false);

#line default
#line hidden
                WriteAttributeValue("", 8841, "\').submit();", 8841, 12, true);
                EndWriteAttribute();
                BeginContext(8854, 41, true);
                WriteLiteral(" />\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 8447, "formSoluong_", 8447, 12, true);
#line 173 "C:\Users\galax\Desktop\WatchShopCore\GraniteHouse\Areas\Customer\Views\ShoppingCart\Index.cshtml"
AddHtmlAttributeValue("", 8459, i, 8459, 2, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8902, 41, true);
            WriteLiteral("\r\n                                </td>\r\n");
            EndContext();
#line 178 "C:\Users\galax\Desktop\WatchShopCore\GraniteHouse\Areas\Customer\Views\ShoppingCart\Index.cshtml"
                                 if (line.Products.Price > newPrice)
                                {

#line default
#line hidden
            BeginContext(9048, 40, true);
            WriteLiteral("                                    <td>");
            EndContext();
            BeginContext(9089, 26, false);
#line 180 "C:\Users\galax\Desktop\WatchShopCore\GraniteHouse\Areas\Customer\Views\ShoppingCart\Index.cshtml"
                                   Write(newPrice.ToString("#,##0"));

#line default
#line hidden
            EndContext();
            BeginContext(9115, 50, true);
            WriteLiteral(" đ</td>\r\n                                    <td> ");
            EndContext();
            BeginContext(9167, 42, false);
#line 181 "C:\Users\galax\Desktop\WatchShopCore\GraniteHouse\Areas\Customer\Views\ShoppingCart\Index.cshtml"
                                     Write((line.Amount * newPrice).ToString("#,##0"));

#line default
#line hidden
            EndContext();
            BeginContext(9210, 9, true);
            WriteLiteral(" đ</td>\r\n");
            EndContext();
#line 182 "C:\Users\galax\Desktop\WatchShopCore\GraniteHouse\Areas\Customer\Views\ShoppingCart\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(9327, 40, true);
            WriteLiteral("                                    <td>");
            EndContext();
            BeginContext(9368, 37, false);
#line 185 "C:\Users\galax\Desktop\WatchShopCore\GraniteHouse\Areas\Customer\Views\ShoppingCart\Index.cshtml"
                                   Write(line.Products.Price.ToString("#,##0"));

#line default
#line hidden
            EndContext();
            BeginContext(9405, 50, true);
            WriteLiteral(" đ</td>\r\n                                    <td> ");
            EndContext();
            BeginContext(9457, 53, false);
#line 186 "C:\Users\galax\Desktop\WatchShopCore\GraniteHouse\Areas\Customer\Views\ShoppingCart\Index.cshtml"
                                     Write((line.Amount * line.Products.Price).ToString("#,##0"));

#line default
#line hidden
            EndContext();
            BeginContext(9511, 9, true);
            WriteLiteral(" đ</td>\r\n");
            EndContext();
#line 187 "C:\Users\galax\Desktop\WatchShopCore\GraniteHouse\Areas\Customer\Views\ShoppingCart\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(9555, 104, true);
            WriteLiteral("\r\n\r\n                                <td style=\"text-align:center\">\r\n                                    ");
            EndContext();
            BeginContext(9659, 183, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fad9006c7253431aa845564c9a1c8472", async() => {
                BeginContext(9805, 33, true);
                WriteLiteral(" <i class=\"fas fa-trash-alt\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 191 "C:\Users\galax\Desktop\WatchShopCore\GraniteHouse\Areas\Customer\Views\ShoppingCart\Index.cshtml"
                                                                                                                                                       WriteLiteral(line.Products.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9842, 76, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 194 "C:\Users\galax\Desktop\WatchShopCore\GraniteHouse\Areas\Customer\Views\ShoppingCart\Index.cshtml"
                            i++;
                            

#line default
#line hidden
#line 195 "C:\Users\galax\Desktop\WatchShopCore\GraniteHouse\Areas\Customer\Views\ShoppingCart\Index.cshtml"
                             if (line.Products.Price > newPrice)
                            {
                                total += (line.Amount * newPrice);
                            }
                            else
                            {
                                total += (line.Amount * line.Products.Price);
                            }

#line default
#line hidden
#line 202 "C:\Users\galax\Desktop\WatchShopCore\GraniteHouse\Areas\Customer\Views\ShoppingCart\Index.cshtml"
                             

                        }

#line default
#line hidden
            BeginContext(10352, 271, true);
            WriteLiteral(@"                        <tr>
                            <td></td>
                            <td class=""text-right""></td>
                            <td></td>
                            <td>SubTotal:</td>
                            <td style=""font-size:large;"">");
            EndContext();
            BeginContext(10624, 23, false);
#line 210 "C:\Users\galax\Desktop\WatchShopCore\GraniteHouse\Areas\Customer\Views\ShoppingCart\Index.cshtml"
                                                    Write(total.ToString("#,##0"));

#line default
#line hidden
            EndContext();
            BeginContext(10647, 67, true);
            WriteLiteral(" đ</td>\r\n                            <td style=\"text-align:center\">");
            EndContext();
            BeginContext(10714, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4430350a688145d4b5ed68aed2819d0a", async() => {
                BeginContext(10793, 9, true);
                WriteLiteral("Check out");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(10806, 142, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                    </table>\r\n\r\n\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n        ");
            EndContext();
            BeginContext(10948, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "069c1731f10c4a0b980b2ab61c0f7431", async() => {
                BeginContext(11014, 17, true);
                WriteLiteral("Continue Shopping");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_15.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_15);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(11035, 32, true);
            WriteLiteral("\r\n    </div>\r\n    <br />\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GraniteHouse.Models.ViewModel.ShoppingCartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
