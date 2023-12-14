# Holidaying Travel Cars Challange  
## using .Net 6 C#
A group of friends is going on holiday together. They have come to a meeting point (start of the journey)
Using N cars. There are P[K] people and S[K] seats in the K-th car for K in range [0...N-1].
Some of the seatd in the cars maybe free, so it is possible for some of the friends to change the car they are in. 
The friends have decided that, in order to be ecological, they will leave some cars parked at the meeting point and travel with as few cars as possible.
Write a function 
```c#
class Solution {
  public int solution(int[] P, int[] s) //Your code goes here ...
}
```
that given two arrays P and S, consisting of N integers each, returns the minimum number of cars needed to take all of the friends on holiday.
## Examples 
1. Given P = [1, 4, 1] and S = [1, 5, 1], the function should return **2**. A person from car number 0 can travel in car number 1 instead. This way, car number 0 can be left parked at the meeting point.
2. Given P = [4, 4, 2, 4] and S = [5, 5, 2, 5], the function should return **3**. One person from car number 2 can travel in car number 0 and the other person from car number 2 can travel in car number 3.
3. Given P = [2, 3, 4, 2] and S = [2, 5, 7, 2], the function should return **2**. Passangers from car number 0 can travel in car number 1 and passangers from car number 3 can travel in car number 2.

Write an efficient algorithim for the following assumptions:
- N is an integer within the range [1...100,000]
- each element of arrays P and S is an integer within the range [1...9]
- every friend had a seat in the car they came in; that is, P[K] ≤ S[K] for each K within the range [0...N-1].

# Bonus
Write a function:
```c#
class Solution {
  public int solution(int[] A) //Your code goes here ...
}
```
that, given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.

## Example
1. Given A = [1, 3, 6, 4, 1, 2], the function should return 5.
2. Given A = [1, 2, 3], the function should return 4.
3. Given A = [−1, −3], the function should return 1.

Write an efficient algorithm for the following assumptions:
- N is an integer within the range [1..100,000];
- each element of array A is an integer within the range [−1,000,000..1,000,000].
