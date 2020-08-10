using System.Collections.Generic;
using System.Threading.Tasks;
using ekeneEstateApp.Data.Entities;
using ekeneEstateApp.Web.Models;

namespace ekeneEstateApp.Web.Interfaces
{
    public interface IPropertyService
    {
        Task AddProperty(PropertyModel model);

        IEnumerable<Property> GetAllProperties();
    }
}