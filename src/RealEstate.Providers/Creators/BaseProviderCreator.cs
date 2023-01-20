using RealEstate.Providers.Interfaces;

namespace RealEstate.Providers.Creators;

public abstract class BaseProviderCreator
{
    public abstract IBaseProvider CreateProvider();

}