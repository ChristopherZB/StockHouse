using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageTemplates.Templates.FormChildren
{
    public class FieldClass<TValue> : ComponentBase
    {

        [Parameter]
        public TValue? Value { 
            get; 
            set; }
        [Parameter]
        public string Label { get; set; }
        [Parameter]
        public EventCallback<TValue> ValueChanged { get; set; }

        public virtual async Task SetValue(ChangeEventArgs args)
        {
            await SetValue((TValue)args.Value);
        }

        public virtual async Task SetValue(TValue val)
        {
            Value = val;
            await ValueChanged.InvokeAsync(Value);
            StateHasChanged();
        }
    }
}
