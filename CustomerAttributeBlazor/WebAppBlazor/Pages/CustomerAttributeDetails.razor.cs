using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAppBlazor.Services;
using WebAppBlazor.Models;
using Microsoft.AspNetCore.Components;

namespace WebAppBlazor.Pages
{
    public partial class CustomerAttributeDetails
    {



        [Inject]
        private ICustomerService services { get; set; }

        private CustomerAttributeModel CustomerAttribute;

        [Parameter]
        public int custid { get; set; }

        protected override async Task OnInitializedAsync()
        {
            CustomerAttribute = await services.GetOne(1);
        }


    }
}
