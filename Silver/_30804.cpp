#include <iostream>

using namespace std;

int n, ans = 0;
int* fruit;
int c[10] = { 0, };

int check()
{
	int cnt = 0;
	for (int i = 1; i < 10; i++)
	{
		if (c[i] != 0)
			cnt++;
	}

	return cnt;
}

int main()
{
	cin >> n;
	fruit = new int[n]();

	for (int i = 0; i < n; i++)
		cin >> fruit[i];

	int j = 0;
	for (int i = 0; i < n; i++)
	{
		while(j < n)
		{
			c[fruit[j]]++;
			if (check() > 2)
			{
				c[fruit[j]]--;
				ans = max(ans, j - i);
				break;
			}

			ans = max(ans, j - i + 1);
			j++;
		}

		c[fruit[i]]--;
	}

	cout << ans;
}
