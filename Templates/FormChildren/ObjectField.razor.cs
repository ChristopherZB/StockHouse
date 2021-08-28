using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockHouse.Templates.FormChildren.Partials
{
    public partial class ObjectField<T> : FieldClass<T>
    {
        [Parameter]
        public List<T> Options { get; set; }
        [Parameter]
        public EventCallback Add { get; set; }
        [Parameter]
        public Func<T, string> DisplayMethod { get; set; }
    }
}
