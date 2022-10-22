int count = 0;
int distanse = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
int time = 0;

int fullTime = 0;
int fullDistanseDog = 0;
int fullDistanseFirstFriend = 0;
int fullDistanseSecondFriend = 0;

while (distanse > 10)
{
    if (friend == 1)
    {
        time = distanse / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
        time = distanse / (secondFriendSpeed + dogSpeed);
        friend = 1;
    
    distanse = distanse - (firstFriendSpeed + secondFriendSpeed) * time;
    count = count + 1;
    fullTime += time;
}
fullDistanseDog = fullTime * dogSpeed;
fullDistanseFirstFriend = fullTime * firstFriendSpeed;
fullDistanseSecondFriend = fullTime * secondFriendSpeed;

Console.WriteLine("Друзья шли на встречу друг другу " + fullTime / 60 + 
" минут, за это время собака сбегала от одного друга к дпугому " + count + " раз и пробежала в сумме " + fullDistanseDog + 
" метров. Первый друг прошел за это время " + fullDistanseFirstFriend + " метров, а второй друг прошел " + fullDistanseSecondFriend + " метров.");