using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAppBlazor.Services;
using WebAppBlazor.Models;
using Microsoft.AspNetCore.Components;

namespace WebAppBlazor.Pages
{
    public partial class Delete
    {
        [Inject]
        private ICustomerService _service { get; set; }

        private CustomerAttributeModel ca = new CustomerAttributeModel();

        [Parameter]
        public int id { get; set; }

        protected override async Task OnInitializedAsync()
        {
            ca = await _service.Delete(id);
        }
    }
}
