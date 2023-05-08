using System.Collections.ObjectModel;
using FluentAssertions;
using UserService.Data;
using UserService.Model;
using UserService;
using Moq;



namespace UserService.Test;

[TestFixture]
public class UserServiceTests
{
    //Service
    private IDataRepository _userService;
    private Mock<IDataRepository> _userRepositoryMock;

    [SetUp]
    public void Setup()
    {
        // initialize the UserService with a mocked repo
        _userRepositoryMock = new Mock<IDataRepository>();
    }

    [Test]
    public async Task GetAll_ReturnsCollectionOfUsers()
    {
        // Arrange
        var expectedUsers = new List<User>
        {
            new User
            {
                Id = 1,
                Name = "Henk",
            },
        };

        _userRepositoryMock.Setup(x => x.GetAll());

        // Act
        var result = _userService.GetAll();

        // Assert
        result.Should().BeEquivalentTo(expectedUsers);
    }
}