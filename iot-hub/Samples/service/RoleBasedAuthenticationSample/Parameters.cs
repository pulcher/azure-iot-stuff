// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using CommandLine;
using Microsoft.Azure.Devices;

namespace RoleBasedAuthenticationSample
{
    /// <summary>
    /// Parameters for the application.
    /// </summary>
    internal class Parameters
    {
        [Option(
            'h',
            "HostName",
            Required = true,
            HelpText = "The IoT hub host name. Ex: my-iot-hub.azure-devices.net")]

        public string HostName { get; set; }

        [Option(
           'd',
           "DeviceId",
           Required = true,
           HelpText = "The IoT hub device to send a message to.")]

        public string DeviceId { get; set; }

        [Option(
            't',
            "TransportType",
            Default = TransportType.Amqp,
            Required = false,
            HelpText = "The transport to use to communicate with the IoT Hub. Possible values include Amqp and Amqp_WebSocket_Only.")]
        
        public TransportType TransportType { get; set; }

        [Option(
            "clientId",
            Required = true,
            HelpText = "The client Id of the Azure Active Directory application.")]
        public string ClientId { get; set; }

        [Option(
            "tenantId",
            Required = true,
            HelpText = "The Azure Active Directory tenant (directory) Id ")]
        public string TenantId { get; set; }

        [Option(
            "clientSecret",
            Required = false,
            HelpText = "A client secret that was generated for the application Registration used to authenticate the client. Only applicable when using LoginMethod of AppId.")]
        public string ClientSecret { get; set; }
    }
}
