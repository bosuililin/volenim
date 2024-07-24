public class Website
{
    // Read-only property for the URL
    public string Url { get; }

    // Constructor to initialize the URL
    public Website(string url)
    {
        Url = url;  // Set the value of the read-only property in the constructor
    }
}
