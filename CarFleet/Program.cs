//LeetCode 853
/*There are n cars going to the same destination along a one-lane road. The destination is target miles away.
You are given two integer array position and speed, both of length n, where position[i] is the position of the ith car and speed[i] is the speed of the ith car (in miles per hour).
A car can never pass another car ahead of it, but it can catch up to it and drive bumper to bumper at the same speed. The faster car will slow down to match the slower car's speed. The distance between these two cars is ignored (i.e., they are assumed to have the same position).
A car fleet is some non-empty set of cars driving at the same position and same speed. Note that a single car is also a car fleet.
If a car catches up to a car fleet right at the destination point, it will still be considered as one car fleet.
Return the number of car fleets that will arrive at the destination.*/

static int CarFleet(int target, int[] position, int[] speed)
{
    //sort position array and keep the order of speed array 
    Array.Sort(position, speed);
    var lastFleetTime = 0.0;
    var fleetCount = 0;

    //start from last car
    for (var i = position.Length - 1; i >= 0; i--)
    {
        //calculate reaching time to the target 
        var carTime = (double)(target - position[i]) / speed[i];
        
        //if the time is bigger than the reaching time of the ahead car, it means they don't become a fleet 
        if (carTime > lastFleetTime)
        {
            fleetCount++;
            lastFleetTime = carTime;
        }
    }

    return fleetCount;
}