#pragma checksum "C:\Users\Joe Hendrick\Documents\SoporteContable\WebSiteASi\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61d2a1bc50e5e50f13e58a27d206d5df9d421b67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Joe Hendrick\Documents\SoporteContable\WebSiteASi\Views\_ViewImports.cshtml"
using WebSiteASi;

#line default
#line hidden
#line 2 "C:\Users\Joe Hendrick\Documents\SoporteContable\WebSiteASi\Views\_ViewImports.cshtml"
using WebSiteASi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61d2a1bc50e5e50f13e58a27d206d5df9d421b67", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b04969b363d75768f3ec4efab078f6c408ef8e4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Joe Hendrick\Documents\SoporteContable\WebSiteASi\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Gestor de Soportes Contables";

#line default
#line hidden
            BeginContext(64, 4801, true);
            WriteLiteral(@"
          <section class=""hero is-info welcome is-small"">
              <div class=""hero-body"">
                  <div class=""container"">
                      <h1 class=""title"">
                          Hola, Admin.
                      </h1>
                      <h2 class=""subtitle"">
                          Deseo que tengas un gran día!
                      </h2>
                  </div>
              </div>
          </section>
          <section class=""info-tiles"">
              <div class=""tile is-ancestor has-text-centered"">
                  <div class=""tile is-parent"">
                      <article class=""tile is-child box"">
                          <p class=""title"">439k</p>
                          <p class=""subtitle"">Clientes</p>
                      </article>
                  </div>
                  <div class=""tile is-parent"">
                      <article class=""tile is-child box"">
                          <p class=""title"">59k</p>
                          ");
            WriteLiteral(@"<p class=""subtitle"">Recibos de Caja</p>
                      </article>
                  </div>
                  <div class=""tile is-parent"">
                      <article class=""tile is-child box"">
                          <p class=""title"">3.4k</p>
                          <p class=""subtitle"">Consignaciones</p>
                      </article>
                  </div>
                  <div class=""tile is-parent"">
                      <article class=""tile is-child box"">
                          <p class=""title"">19</p>
                          <p class=""subtitle"">Exceptions</p>
                      </article>
                  </div>
              </div>
          </section>
          <div class=""columns"">
              <div class=""column is-6"">
                  <div class=""card events-card"">
                      <header class=""card-header"">
                          <p class=""card-header-title"">
                              Ultimas Transacciones
                          <");
            WriteLiteral(@"/p>
                          <a href=""#"" class=""card-header-icon"" aria-label=""more options"">
                            <span class=""icon"">
                            <i class=""fa fa-angle-down"" aria-hidden=""true""></i>
                            </span>
                        </a>
                      </header>
                      <div class=""card-table"">
                          <div class=""content"">
                              <table class=""table is-fullwidth is-striped"">
                                  <tbody>
                                      <tr>
                                          <td width=""5%""><i class=""fa fa-bell-o""></i></td>
                                          <td>Lorum ipsum dolem aire</td>
                                          <td class=""level-right""><a class=""button is-small is-primary"" href=""#"">Action</a></td>
                                      </tr>
                                  </tbody>
                              </table>
           ");
            WriteLiteral(@"               </div>
                         
                      </div>
                      <footer class=""card-footer"">
                          <a href=""#"" class=""card-footer-item"">View All</a>
                      </footer>
                  </div>
              </div>
              <div class=""column is-6"">
                  <div class=""card"">
                      <header class=""card-header"">
                          <p class=""card-header-title"">
                              Buscar Cliente
                          </p>
                          <a href=""#"" class=""card-header-icon"" aria-label=""more options"">
                            <span class=""icon"">
                            <i class=""fa fa-angle-down"" aria-hidden=""true""></i>
                            </span>
                          </a>
                        </header>
                      <div class=""card-content"">
                          <div class=""content"">
                              <div class=""co");
            WriteLiteral(@"ntrol has-icons-left has-icons-right"">
                                  <input class=""input is-large"" type=""text"" placeholder="""">
                                  <span class=""icon is-medium is-left"">
                                        <i class=""fa fa-search""></i>
                                    </span>
                                    <span class=""icon is-medium is-right"">
                                        <i class=""fa fa-check""></i>
                                    </span>
                              </div>
                          </div>
                      </div>
                  </div>
                  </div>
              </div>
          </div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591