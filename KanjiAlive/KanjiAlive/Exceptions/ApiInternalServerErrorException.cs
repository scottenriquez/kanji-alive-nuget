﻿using System;

namespace KanjiAlive.Exceptions
{
    /// <summary>
    ///     Thrown when the API server returns a 500 error.
    /// </summary>
    public class ApiInternalServerErrorException : Exception
    {
        /// <summary>
        ///     Constructor for ApiInternalServerException.
        /// </summary>
        public ApiInternalServerErrorException() : base("The API server returned an internal server error (500) response.")
        {
        }
    }
}