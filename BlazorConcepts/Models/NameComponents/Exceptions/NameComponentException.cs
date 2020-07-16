using System;

namespace BlazorConcepts.Models.NameComponents.Exceptions
{
    public class NameComponentException : Exception
    {
        public NameComponentException(Exception innerException)
            : base("Systme error occurred, contact support", innerException) { }
    }
}
