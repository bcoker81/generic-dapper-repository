using genericdappertest.Repository;
using Microsoft.AspNetCore.Mvc;

namespace genericdappertest.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DataController : ControllerBase
{
    private PeopleRepository peopleRepository;
    private AddressRepository addressRepository;
    public DataController()
    {
        peopleRepository = new PeopleRepository();
        addressRepository = new AddressRepository();
    }
    [HttpPost("add-person")]
    public async Task<IActionResult> AddPeople(PeopleDTO person)
    {
        var result = await peopleRepository.Add(person);
        return Ok(result);
    }

    [HttpGet("get-all-people")]
    public async Task<IActionResult> GetAllPeople()
    {
        return Ok(await peopleRepository.GetAll());
    }

    [HttpGet("get-people/{id}")]
    public async Task<IActionResult> GetPersonById(int id)
    {
        return Ok(await peopleRepository.GetById(id));
    }

    [HttpPost("delete-person")]
    public async Task<IActionResult> DeletePerson(PeopleDTO person)
    {
        return Ok(await peopleRepository.Delete(person));
    }

    [HttpPost("delete-address")]
    public async Task<IActionResult> DeleteAddress(AddressDTO address)
    {
        return Ok(await addressRepository.Delete(address));
    }

    [HttpPost("add-address")]
    public async Task<IActionResult> AddAddress(AddressDTO address)
    {
        var result = await addressRepository.Add(address);
        return Ok(result);
    }

    [HttpGet("get-all-address")]
    public async Task<IActionResult> GetAllAddress()
    {
        return Ok(await addressRepository.GetAll());
    }

    [HttpGet("get-address/{id}")]
    public async Task<IActionResult> GetAddressById(int id)
    {
        return Ok(await addressRepository.GetById(id));
    }
}