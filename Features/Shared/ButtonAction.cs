using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_2_Gestor.Features.Shared
{
    internal class ButtonAction
    {
        public Func<DataGridViewRow, int> GetId { get; init; }
        public Action<int> OnClick { get; init; }
    }
}
