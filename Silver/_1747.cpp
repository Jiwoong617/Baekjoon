#include <iostream>
#include <algorithm>
#define end 9999999

using namespace std;

bool isPrime[end];

bool isPalindrome(int n)
{
	int a = n, b = 0;
	while (n > 0)
	{
		b = b * 10 + n % 10;
		n /= 10;
	}

	return a == b;
}

int main()
{
	int n; cin >> n;
	fill(isPrime, isPrime + end, true);
	isPrime[0] = false; isPrime[1] = false;

	for (int i = 2; i < end; i++)
	{
		if (isPrime[i])
			for (int j = i * 2; j < end; j += i)
				isPrime[j] = false;
	}

	for (int i = n; i < end; i++)
	{
		if (isPrime[i] && isPalindrome(i))
		{
			cout << i;
			break;
		}
	}

	return 0;
}
