using genericdappertest.Repository;

namespace genericdappertest.Services;

public class AddressService
{
    bool isAdded = false;
    public async Task<bool> Add(AddressDTO address)
    {
        AddressRepository addressRepository = new AddressRepository();
        isAdded = await addressRepository.Add(address);

        return isAdded;
    }

    public async Task<IEnumerable<AddressDTO>> GetAll()
    {
        AddressRepository addressRepository = new AddressRepository();
        return await addressRepository.GetAll();
    }
}