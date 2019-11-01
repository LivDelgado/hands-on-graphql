using GraphQL;

namespace ExampleData.Schema
{
    public class DtiSchema : GraphQL.Types.Schema
    {
        public DtiSchema(DtiQuery query, IDependencyResolver resolver)
        {
            Query = query;
            DependencyResolver = resolver;
        }
    }
}

