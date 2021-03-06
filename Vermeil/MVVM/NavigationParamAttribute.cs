#region

using System;

#endregion

namespace Vermeil.MVVM
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class NavigationParamAttribute : Attribute
    {
        public NavigationParamAttribute(string name, bool isMandatory = true)
        {
            Name = name;
            IsMandatory = isMandatory;
        }

        public bool IsMandatory { get; set; }
        public string Name { get; private set; }
    }
}
