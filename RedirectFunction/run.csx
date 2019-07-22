using System;
using System.Net;
using System.Configuration;
using System.Text;
using System.Threading;
using System.Globalization;
using System.Collections.Generic;

public static HttpResponseMessage Run(HttpRequestMessage req)
{    
    var redirectResponse = req.CreateResponse(HttpStatusCode.MovedPermanently);
    redirectResponse.Headers.Location = new Uri("https://events.rapidcircle.com/dre");
    return redirectResponse;
}