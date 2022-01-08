using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAppBlazor.Services;
using WebAppBlazor.Models;

using Microsoft.AspNetCore.Components;

namespace WebAppBlazor.Pages
{
    public partial class CustomerAttributeView
    {
        [Inject]
        NavigationManager navigation { get; set; }

        [Inject]
        private ICustomerService services { get; set; }
        private List<CustomerAttributeModel> CustomerAttributes { set; get; }

        protected override async Task OnInitializedAsync()
        {
            CustomerAttributes = await services.getAll();
        }
<<<<<<< Updated upstream
=======

        /*public async Task Edit_ClickAsync(int id)
        {
            navigation.NavigateTo("/details/" + id);
        }*/
>>>>>>> Stashed changes
    }
}
