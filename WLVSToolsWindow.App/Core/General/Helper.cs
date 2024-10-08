﻿using System.Reflection;

namespace WLVSToolsWindow.App.Core.General
{
    internal static class Helper
    {
        internal static Form TryGetFormByName(string frmname)
        {
            var formType = Assembly.GetExecutingAssembly().GetTypes()
                .Where(a => a.BaseType == typeof(Form) && a.Name == frmname)
                .FirstOrDefault();

            if (formType == null) // If there is no form with the given frmname
                return null;

            return (Form)Activator.CreateInstance(formType);
        }
    }
}
