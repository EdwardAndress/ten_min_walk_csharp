namespace WalkingTools.Tests;

public class RouteTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void testNewRouteHasDefaultDict()
    {   
        Route route = new Route();

        // what the program actually returns
        Dictionary<string, int> actual = route.getMoves();

        // what we want the program to return
        Dictionary<string, int> expected = new Dictionary<string, int>() {
            {"n", 0},
            {"s", 0},
            {"e", 0},
            {"w", 0}
        };

        // compare what the program returns with what we want it to return
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void testMoveUpdatesDict() {
        Route route = new Route();
        route.move("n");
        route.move("s");
        route.move("s");
        route.move("e");
        route.move("w");

        Dictionary<string, int> actual = route.getMoves();
        
        // what we want the program to return
        Dictionary<string, int> expected = new Dictionary<string, int>() {
            {"n", 1},
            {"s", 2},
            {"e", 1},
            {"w", 1}
        };

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void testIsTenMinuteWalkWhenWalkIs9MinutesReturnsFalse() {
        Route route = new Route();
        route.move("n");
        route.move("s");
        route.move("s");
        route.move("e");
        route.move("w");
        route.move("s");
        route.move("s");
        route.move("e");
        route.move("w");

        Assert.AreEqual(false, route.isTenMinuteWalk());
    }

    [Test]
    public void testIsTenMinuteWalkWhenWalkIs11MinutesReturnsFalse() {
        Route route = new Route();
        route.move("n");
        route.move("s");
        route.move("s");
        route.move("e");
        route.move("w");
        route.move("s");
        route.move("s");
        route.move("e");
        route.move("w");
        route.move("e");
        route.move("w");

        Assert.AreEqual(false, route.isTenMinuteWalk());
    }

    [Test]
    public void testIsTenMinuteWalkWhenWalkIs10MinutesAndEndsIsNotAtStartReturnsFalse() {
        Route route = new Route();
        route.move("n");
        route.move("n");
        route.move("n");
        route.move("n");
        route.move("n");
        route.move("s");
        route.move("s");
        route.move("s");
        route.move("s");
        route.move("e");

        Assert.AreEqual(false, route.isTenMinuteWalk());
    }

    [Test]
    public void testIsTenMinuteWalkWhenWalkIs10MinutesAndEndAtTheStartReturnsTrue() {
        Route route = new Route();
        route.move("n");
        route.move("n");
        route.move("n");
        route.move("n");
        route.move("n");
        route.move("s");
        route.move("s");
        route.move("s");
        route.move("s");
        route.move("s");

        Assert.AreEqual(true, route.isTenMinuteWalk());
    }
}
