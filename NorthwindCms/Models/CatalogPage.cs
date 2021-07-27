using Piranha.AttributeBuilder;
using Piranha.Models;

namespace NorthwindCms.Models
{  
    [PageType(Title="Catalog Page",UseBlocks=false)]
    [ContentTypeRouteAttribute(Title="Deafault",Route="/catalog")]
    public class CatalogPage : Page<CatalogPage>
    {
        
    }
}