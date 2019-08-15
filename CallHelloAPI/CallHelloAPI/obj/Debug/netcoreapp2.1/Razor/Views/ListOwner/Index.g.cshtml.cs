#pragma checksum "D:\TestBanana\CallHelloAPI\CallHelloAPI\Views\ListOwner\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee9d2762501bcf86570587c22d37e0a9e1ea0bd1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CallHelloAPI.Pages.ListOwner.Views_ListOwner_Index), @"mvc.1.0.view", @"/Views/ListOwner/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ListOwner/Index.cshtml", typeof(CallHelloAPI.Pages.ListOwner.Views_ListOwner_Index))]
namespace CallHelloAPI.Pages.ListOwner
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\TestBanana\CallHelloAPI\CallHelloAPI\Views\_ViewImports.cshtml"
using CallHelloAPI;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee9d2762501bcf86570587c22d37e0a9e1ea0bd1", @"/Views/ListOwner/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5f5ea0c4c5eab2894ff9bad86b33a4e609bc275", @"/Views/_ViewImports.cshtml")]
    public class Views_ListOwner_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CallHelloAPI.Model.Owner>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2186, true);
            WriteLiteral(@"
<script src=""https://cdn.jsdelivr.net/npm/vue@2.5.16/dist/vue.js""></script>
<h2>List Owner</h2>

<div id=""app"">

    <table class=""table table-striped"">
        <thead>
            <tr>

                <th>Operation</th>
                <th>
                    HN เจ้าของ
                </th>
                <th>
                    ชื่อเจ้าของ
                </th>
                <th>
                    เบอร์โทรติดต่อ
                </th>
                <th>
                    อีเมล์
                </th>
            </tr>
        </thead>
        <tbody>  
            <tr v-for=""item in agr1"" :key=""item.hn"">               
                <td><a v-bind:href=""'../DetailOwner/Index/'+item.hn"">Detail</a></td>               
                <td><div id=""hn"">{{ item.hn }}</div></td>
                <td>{{ item.name }}</td>
                <td>{{ item.phone }}</td>
                <td>{{ item.email }}</td>
            </tr>
        </tbody>
    </table>
</div>



<sc");
            WriteLiteral(@"ript>
    console.log($(""#hn"").val());
    new Vue({
        el: ""#app"",
        data: {           
            agr1: []
        },
            mounted() {
                this.getAll(); //DISPLAY TABLE ON PAGE LOAD
            },
            methods: {               
                getAll: function () {
                    var self = this;
                    console.log('teste');
                    $.ajax({
                        url: '../api/Owner/Transection',
                        type: ""GET"",
                        dataType: ""json"",
                        success: function (response) {
                            console.log(response); // 
                            self.agr1 = response;
                            console.log(self.agr1);
                            console.log('success!');
                        },
                        error: function () {
                            console.log('error');
                        } //end error function 
           ");
            WriteLiteral("         }); //end $.ajax() request \r\n                }, //end getAll function\r\n        }, //end methods\r\n        \r\n    });\r\n\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CallHelloAPI.Model.Owner>> Html { get; private set; }
    }
}
#pragma warning restore 1591