using System;
using System.Net;
using System.Configuration;
using System.Text;
using System.Threading;
using System.Globalization;
using System.Collections.Generic;

public static HttpResponseMessage Run(HttpRequestMessage req, string subscriptionId, string resourceGroupName, string miniRpName, string action, ILogger log = null)
{    
    var redirectResponse = req.CreateResponse(HttpStatusCode.MovedPermanently);
    redirectResponse.Headers.Location = new Uri("https://events.rapidcircle.com/dre");
    return redirectResponse;
}