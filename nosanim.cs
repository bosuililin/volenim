public class MyClass
{
    private static Dictionary<string, object> cachedReferences;

    static MyClass()
    {
        // Initialize the cached references
        cachedReferences = new Dictionary<string, object>();

        // Set any passed in parameters
        // For example, if the class requires a configuration object to be passed in
        // during initialization, it can be set here
    }

    // Other members of the class
}
