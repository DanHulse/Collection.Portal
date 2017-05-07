using Collections.Portal.Services.Interfaces;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Portal.Services
{
	public class RestSharpService : IRestSharpService
    {
        #region Private Fields

        /// <summary>
        /// The request parameters
        /// </summary>
        private List<Parameter> requestParameters;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the request URL
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the body.
        /// </summary>
        public object Body { get; set; }

        /// <summary>
        /// Gets or sets the data format.
        /// </summary>
        public DataFormat DataFormat { get; set; } = DataFormat.Json;

        /// <summary>
        /// Gets or sets the request method.
        /// </summary>
        public HttpMethod RequestMethod { get; set; } = HttpMethod.Get;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="RestSharpService"/> class.
        /// </summary>
        public RestSharpService()
        {
            this.requestParameters = new List<Parameter>();
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Executes a rest request
        /// </summary>
        /// <typeparam name="T">Type to deserialize to</typeparam>
        /// <returns>A instance of <typeparamref name="T"/></returns>
        public IRestResponse<T> Execute<T>() where T : new()
        {
            var client = this.GetClient(this.Url);

            var request = this.BuildRequest();

            return client.Execute<T>(request);
        }

        /// <summary>
        /// Executes a rest request
        /// </summary>
        /// <returns>A instance of <see cref="IRestResponse"/></returns>
        public IRestResponse Execute()
        {
            var client = this.GetClient(this.Url);

            var request = this.BuildRequest();

            return client.Execute(request);
        }

        /// <summary>
        /// Adds the parameter to the request.
        /// </summary>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="parameterValue">The parameter value.</param>
        /// <param name="parameterType">Type of the parameter.</param>
        public void AddParameter(string parameterName, object parameterValue, ParameterType parameterType)
        {
            this.requestParameters.Add(new Parameter { Name = parameterName, Value = parameterValue, Type = parameterType });
        }

        /// <summary>
        /// Adds the parameter range.
        /// </summary>
        /// <param name="parameterRange">The parameter range.</param>
        /// <param name="parameterType">Type of the parameter.</param>
        public void AddParameterRange(IDictionary<string, object> parameterRange, ParameterType parameterType)
        {
            foreach (var parameter in parameterRange)
            {
                this.requestParameters.Add(new Parameter { Name = parameter.Key, Value = parameter.Value, Type = parameterType });
            }
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Gets the HttpClient
        /// </summary>
        /// <param name="url">Url for the request</param>
        /// <returns><see cref="IRestClient"/>Http Client</returns>
        private IRestClient GetClient(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentNullException("Url");
            }

            return new RestClient(url);
        }

        /// <summary>
        /// Builds the request
        /// </summary>
        /// <returns><see cref="IRestRequest"/>A HTTP request</returns>
        private IRestRequest BuildRequest()
        {
            if (this.RequestMethod == null)
            {
                throw new ArgumentNullException("method");
            }

            var request = new RestRequest((Method)Enum.Parse(typeof(Method), this.RequestMethod.Method))
            {
                RequestFormat = this.DataFormat
            };

            if (this.Body != null)
            {
                request.AddBody(this.Body);
            }

            foreach (var parameter in this.requestParameters)
            {
                request.AddParameter(parameter);
            }

            return request;
        }

        #endregion
    }
}
