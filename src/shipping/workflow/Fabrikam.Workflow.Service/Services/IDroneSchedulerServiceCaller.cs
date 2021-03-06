// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

using System.Threading.Tasks;
using Fabrikam.Workflow.Service.Models;

namespace Fabrikam.Workflow.Service.Services
{
    public interface IDroneSchedulerServiceCaller
    {
        Task<string> GetDroneIdAsync(Delivery deliveryRequest);
    }
}
