﻿using System;
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

        private CustomerAttributeModel CustomerAttribute { set; get; }

        [Parameter]
        public int id { get; set; }

        protected override async Task OnInitializedAsync()
        {
<<<<<<< Updated upstream
            //CustomerAttribute = await services.GetOne(1);
        }

=======
            CustomerAttribute = await services.GetOne(id);
>>>>>>> Stashed changes

        }
    }
}
