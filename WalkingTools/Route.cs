public class Route {

    // a field called moves that holds a dictionary
    // available within the scope of the Route class
    private Dictionary<string, int> moves = new Dictionary<string, int>() {
        {"n", 0},
        {"s", 0},
        {"e", 0},
        {"w", 0}
    };

    public Dictionary<string, int> getMoves() {
        // 'this' is the instance of Route
        return this.moves;
    }

    public bool isTenMinuteWalk()
    {
        int totalMoves = moves.Values.Sum();
        if(totalMoves != 10) {
            return false;
        } else if(startAndFinishIsSamePlace()) {
            return true;
        } else {
            return false;
        }
    }

    private bool startAndFinishIsSamePlace()
    {
        return sameDistanceEastAndWest() &&
            sameDistanceNorthAndSouth();
    }

    private bool sameDistanceNorthAndSouth()
    {
        return moves["n"] == moves["s"];
    }

    private bool sameDistanceEastAndWest()
    {
        return moves["e"] == moves["w"];
    }

    public void move(string direction) {
        // set the new value by incrementing the current value
        moves[direction] += 1;
        // check direction and then do something depending on direction
    }
}
