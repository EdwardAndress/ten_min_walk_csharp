- We're walking around a city like New York, that is grid based.
- Each block takes 1 min to cover, when walking
- Each 'move' is one block
- route.move("w") would move you one block west, which would take 1 minute

Test 1
- Check that the new instance of route has an empty dict of the correct structure

Test 2
- `move` updates the dict

Test 3
- `isTenMinuteWalk` returns false if walk is not 10 minutes (less than or more than 10 moves)

<!-- a variable called `route` of type `Route` -->
Route myWalk = new Route()
myWalk.move("w")
myWalk.move("e")
myWalk.move("n")
myWalk.move("s")
myWalk.isTenMinuteWalk() -> true / false

# The plan

Initial state - before you walk anywhere

{
    "w": 0,
    "e": 0,
    "s": 0,
    "n": 0
}

myWalk.move("w")

Next state - after one block west

{
    "w": 1,
    "e": 0,
    "s": 0,
    "n": 0
}

If total of all numbers is 10, the walk is ten mins.

- Check that the number of e equals the number of w
- Check that the number of s equals the number of n

If e == w and s == n then we're back where we started
