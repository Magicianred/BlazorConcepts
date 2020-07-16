using System;

namespace BlazorConcepts.Models.Students.Exceptions
{
    public class SearchComponentException : Exception
    {
        public SearchComponentException(Exception innerException)
            :base ("Dependency error occurred, contact support", innerException){}
    }
}
