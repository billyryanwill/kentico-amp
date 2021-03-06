﻿using CMS;
using CMS.DataEngine;
using CMS.MacroEngine;
using Kentico.AcceleratedMobilePages;

[assembly: RegisterModule(typeof(CustomMacro))]
namespace Kentico.AcceleratedMobilePages
{
    public class CustomMacro : Module
    {
        // Module class constructor, the system registers the module under the name "CustomMacros"
        public CustomMacro()
            : base("CustomMacros")
        {
        }

        // Contains initialization code that is executed when the application starts
        protected override void OnInit()
        {
            base.OnInit();

            // Registers "CustomNamespace" into the macro engine
            MacroContext.GlobalResolver.SetNamedSourceData("AmpFilter", CustomMacroNamespace.Instance);
        }
    }
}
