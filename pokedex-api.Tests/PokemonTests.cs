using pokedex_api;
using pokedex_api.Controllers;

namespace pokedex_api.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
        var pokemon = new Pokemon();
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}