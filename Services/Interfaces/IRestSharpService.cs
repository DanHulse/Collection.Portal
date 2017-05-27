using RestSharp;
using System.Collections.Generic;
using System.Net.Http;

namespace Collection.Portal.Services.Interfaces
{
    public interface IRestSharpService
    {
        /// <summary>
        /// Gets or sets the request URL
        /// </summary>
        string Url { get; set; }

        /// <summary>
        /// Gets or sets the body.
        /// </summary>
        object Body { get; set; }

        /// <summary>
        /// Gets or sets the data format.
        /// </summary>
        DataFormat DataFormat { get; set; }

        /// <summary>
        /// Gets or sets the request method.
        /// </summary>
        HttpMethod RequestMethod { get; set; }

        /// <summary>
        /// Executes a rest request
        /// </summary>
        /// <typeparam name="T">Type to deserialize to</typeparam>
        /// <returns>A instance of <typeparamref name="T"/></returns>
        IRestResponse<T> Execute<T>() where T : new();

        /// <summary>
        /// Executes a rest request
        /// </summary>
        /// <returns>A instance of <see cref="IRestResponse"/></returns>
        IRestResponse Execute();

        /// <summary>
        /// Adds the parameter to the request.
        /// </summary>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="parameterValue">The parameter value.</param>
        /// <param name="parameterType">Type of the parameter.</param>
        void AddParameter(string parameterName, object parameterValue, ParameterType parameterType);

        /// <summary>
        /// Adds the parameter range.
        /// </summary>
        /// <param name="parameterRange">The parameter range.</param>
        /// <param name="parameterType">Type of the parameter.</param>
        void AddParameterRange(IDictionary<string, object> parameterRange, ParameterType parameterType);
    }
}
