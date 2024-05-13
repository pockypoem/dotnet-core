using NuGet.Frameworks;

namespace GameLibrary.UnitTests;

public class TreasureChestTests
{
    // MethodName_StateUnderTest_ExpectedBehavior


    [Fact] // this turn the method into an actual unit test
    // so this fact should always be true 
    public void CanOpen_ChestIsLockedAndHasKey_ReturnsTrue() {

        // Triple A Pattern

        // 1. Arrage (Prepare test scenario)
        // sut = subject under test -> object that you're apply verifications
        var sut = new TreasureChest(true); // chest is locked

        // 2. Act (invoke that unit that you want to verify)
        var result = sut.CanOpen(true);

        // 3. Assert (verify that your expectations about the unit under the scenario that has been spesified for this test are correct)
        Assert.True(result);
    }

    [Fact]
    public void CanOpen_ChestIsLockedAndHasNoKey_ReturnsFalse() {
        // Arrange
        var sut = new TreasureChest(true);

        // Act
        var result = sut.CanOpen(false);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void CanOpen_ChestIsUnlockedAndHasKey_ReturnsTrue() {
        // Arrange
        var sut = new TreasureChest(false);

        // Act
        var result = sut.CanOpen(true);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CanOpen_ChestIsUnlockedAndHasNoKey_ReturnsTrue() {
        // Arrange
        var sut = new TreasureChest(false);

        // Act
        var result = sut.CanOpen(false);

        // Assert
        Assert.True(result);
    }
}
