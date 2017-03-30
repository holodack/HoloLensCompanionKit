﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace HoloLensCommander
{
    /// <summary>
    /// The view model for the TagDeviceDialog object.
    /// </summary>
    partial class TagDeviceDialogViewModel
    {
        /// <summary>
        /// Gets the address of the device being viewed.
        /// </summary>
        public string DeviceAddress
        { get; private set; }

        /// <summary>
        /// Gets or sets the descriptive name of this device
        /// </summary>
        private string name = string.Empty;
        public string Name
        {
            get 
            {
                return this.name;
            }

            set
            {
                if (this.name != value)
                {
                    this.name = value;
                    NotifyPropertyChanged("Name");
                }
            }
        }
    }
}
