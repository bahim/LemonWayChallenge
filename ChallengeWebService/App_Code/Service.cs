using ChallengeLib;
using System;
using System.Web.Services;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class Service : WebService
{
    public Service ()
    {
    }

    [WebMethod]
    public int Fibonacci(int n)
    {
        int result;

        try
        {
            var fibo = new Fibonacci(100);
            result = fibo.Compute(n);
        }
        catch (ArgumentException exception)
        {
            Console.Error.WriteLine(exception);
            return -1;
        }

        return result;
    }

    [WebMethod]
    public string JsonToXml(string xml)
    {
        var convert = new XmlConverter();
        string json;

        try
        {
           json = convert.ConvertToJson(xml);
        }
        catch (Exception exception) // TODO: Specialiser les exceptions
        {
            Console.Error.WriteLine(exception);
            return "Bad Xml format";
        }

        return json;
    }
}