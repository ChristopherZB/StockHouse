using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageTemplates.Templates.FormChildren.Partials
{
    public partial class IntField : FieldClass<int>
    {
        public override async Task SetValue(ChangeEventArgs args)
        {
            int val;
            if (!int.TryParse((string)args.Value, out val))
                val = -1;

            await SetValue(val);
        }

    }
}
