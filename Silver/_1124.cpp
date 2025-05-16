#include <iostream>
#include <vector>

using namespace std;

int main()
{
	int a, b, ans = 0; cin >> a >> b;
	vector<bool> isPrime(100001, true);
	isPrime[0] = false; isPrime[1] = false;

	for (int i = 2; i * i < 100001; i++)
	{
		if (!isPrime[i]) continue;
		for (int j = i * i; j < 100001; j += i)
			isPrime[j] = false;
	}

	for (int i = a; i <= b; i++)
	{
		int cnt = 0, num = i;
		for (int j = 2; j<= num && num > 1;)
		{
			if (isPrime[j] && num % j == 0)
			{
				num /= j;
				cnt++;
			}
			else j++;
		}

		if (isPrime[cnt]) ans++;
	}

	cout << ans;
	return 0;
}
